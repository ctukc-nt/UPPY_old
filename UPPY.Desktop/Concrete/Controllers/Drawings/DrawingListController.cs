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
    public class DrawingsListDocumentController : IDrawingListController, IListDocumentController
    {
        private readonly IUppyControllersFactory _controllersFactory;
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public DrawingsListDocumentController(IClassDataManager<Drawing> drawingDataManager,
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

        public void CreateStandartByDrawing()
        {
            var converterController = _controllersFactory.GetDrawingsToStandartController();
           // converterController.CreateStandartByDrawing();
        }

        public event EventHandler<EventArgs> DataRefreshed;

        public void ShowDrawingInAnotherView(Drawing drawing)
        {
            var controller = _controllersFactory.GetDrawingsViewController(drawing.Id);
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

        public Drawing CreateDocument(int? parentId)
        {
            return new Drawing() { ParentId = parentId, Count = 1, CountAll = 1};
        }

        public void Save(Drawing document)
        {
            _drawingsDataManager.InsertOrUpdate(document);
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
            var view = new DrawingsListTreeForm(this);
            view.ShowDialog();
        }
    }
}