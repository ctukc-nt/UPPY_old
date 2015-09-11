using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Views.Drawings;

namespace UPPY.Desktop.Concrete.Controllers.Drawings
{
    public class DrawingsListViewController : IDrawingListController, IListViewController
    {
        private readonly IUppyControllersFactory _controllersFactory;
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public DrawingsListViewController(IClassDataManager<Drawing> drawingDataManager,
            IClassDataManager<TechRoute> techRouteDataManager, IUppyControllersFactory controllersFactory)
        {
            _controllersFactory = controllersFactory;
            _drawingsDataManager = drawingDataManager;
            _techRouteDataManager = techRouteDataManager;
        }

        public List<Drawing> GetDrawingsList()
        {
            return _drawingsDataManager.GetListCollection();
        }

        public void ShowTechRoutesList()
        {
            var c = _controllersFactory.GetListController<TechRoute>();
            c.ShowViewDialog();
        }

        public void CreateStandartByDrawing(Drawing drawing)
        {
            var converterController = _controllersFactory.GetDrawingsToStandartController();
            converterController.ShowView(drawing);
        }

        public event EventHandler<EventArgs> DataRefreshed;

        public void ShowDrawingInAnotherView(Drawing drawing)
        {
            var controller = _controllersFactory.GetDocumentController<Drawing>();
            controller.Document = drawing;
            controller.ShowViewDialog();
        }

        public void ChangeDrawingCount(Drawing drawing)
        {
            var quantHelper = _controllersFactory.GetDrawingBulkChangesHelper();
            quantHelper.RecalculateProjectByCount(drawing);
            OnDataRefreshed();
        }

        public void ChangeDrawingWeight(Drawing drawing)
        {
            var quantHelper = _controllersFactory.GetDrawingBulkChangesHelper();
            quantHelper.RecalculateProjectByWeight(drawing);
            OnDataRefreshed();
        }

        public void ShowDrawingInGridView(int? drawingId)
        {
            var controller = _controllersFactory.GetDrawingsGridViewController(drawingId);
            controller.ShowViewDialog();

        }

        public string GetCopy(int drawingId)
        {
            return string.Format("DrawingCopyID:{0}", drawingId);
        }


        public void InsertIntoDrawing(int? drawingId, string base64Xml)
        {
            var strId = base64Xml.Replace("DrawingCopyID:", string.Empty);
            try
            {
                var idToCopy = Convert.ToInt32(strId);
                if (idToCopy > 0)
                {
                    var newParentId = CopyDrawingToAnotherParent(idToCopy, drawingId);
                    if (newParentId != null)
                    {
                        CopyChildrens(idToCopy, newParentId);
                        OnDataRefreshed();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void CopyChildrens(int? parentIdOld, int? parentIdNew)
        {
            var childrensToCopy = _drawingsDataManager.GetListCollection(x => x.ParentId == parentIdOld);
            foreach (var drawing in childrensToCopy)
            {
                var newId = CopyDrawingToAnotherParent(drawing.Id, parentIdNew);
                if (newId != null)
                {
                    CopyChildrens(drawing.Id, newId);
                }
            }
        }

        private int? CopyDrawingToAnotherParent(int? idSource, int? idNewParent)
        {
            var sourceDrawing = _drawingsDataManager.GetDocument(idSource);
            var copySource = ObjectExtensions.Copy.CopyExtensions.Copy(sourceDrawing);
            if (copySource != null)
            {
                copySource.ParentId = idNewParent;
                _drawingsDataManager.Insert(copySource);
                return copySource.Id;
            }

            return null;
        }

        public Drawing CreateDocument(int? parentId)
        {
            return new Drawing() { ParentId = parentId, Count = 1, CountAll = 1 };
        }

        public void Save(Drawing document)
        {
            _drawingsDataManager.InsertOrUpdate(document);
            document.Designation = document.Id.ToString();
            _drawingsDataManager.Update(document);
            OnDataRefreshed();
        }

        public void Delete(Drawing document)
        {
            _drawingsDataManager.Delete(document);
            OnDataRefreshed();
        }

        private void OnDataRefreshed()
        {
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public List<TechRoute> GetTechRoutes()
        {
            return _techRouteDataManager.GetListCollection();
        }

        public void ShowViewDialog()
        {
            //var view = new DrawingsListTreeForm(this);
            //view.ShowDialog();
        }
    }
}