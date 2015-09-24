using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.DIE.Export;

namespace UPPY.Desktop.Concrete.Controllers.Drawings
{
    public class PrintDrawingsController : IPrintDrawingsController
    {

        private class HierarchyNumberDrawingComparer : IComparer<string>
        {
            public int Compare(HierarchyNumberDrawing doc1, HierarchyNumberDrawing doc2)
            {
                if (doc1 == null && doc2 == null)
                    return 0;

                if (doc1 == null)
                    return 1;

                if (doc2 == null)
                    return 1;

                var levels1 = doc1.HierarchyNumber.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                var levels2 = doc2.HierarchyNumber.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                var minLevels = Math.Min(levels1.Length, levels2.Length);

                for (var i = 0; i < minLevels; i++)
                {
                    if (Convert.ToInt32(levels1[i]) > Convert.ToInt32(levels2[i]))
                        return 1;

                    if (Convert.ToInt32(levels1[i]) < Convert.ToInt32(levels2[i]))
                        return -1;
                }

                if (levels1.Length > levels2.Length)
                    return 1;

                if (levels1.Length < levels2.Length)
                    return -1;

                return 0;
            }

            public int Compare(string doc1, string doc2)
            {
                if (doc1 == null && doc2 == null)
                    return 0;


                if (doc1 == null)
                    return 1;

                if (doc2 == null)
                    return 1;

                var levels1 = doc1.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                var levels2 = doc2.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                var minLevels = Math.Min(levels1.Length, levels2.Length);

                for (var i = 0; i < minLevels; i++)
                {
                    if (Convert.ToInt32(levels1[i]) > Convert.ToInt32(levels2[i]))
                        return 1;

                    if (Convert.ToInt32(levels1[i]) < Convert.ToInt32(levels2[i]))
                        return -1;
                }

                if (levels1.Length > levels2.Length)
                    return 1;

                if (levels1.Length < levels2.Length)
                    return -1;

                return 0;
            }
        }

        private readonly IUppyControllersFactory _controllersFactory;
        private readonly IUppyDataManagersFactory _dataManagersFactory;
        private readonly IDataExportToFile _dataExport;

        public PrintDrawingsController(IUppyControllersFactory controllersFactory, IUppyDataManagersFactory dataManagersFactory, IDataExportToFile dataExport)
        {
            _controllersFactory = controllersFactory;
            _dataManagersFactory = dataManagersFactory;
            _dataExport = dataExport;
        }

        private static int? GetTopParentId(int? id, IClassDataManager<Drawing> classDataManager)
        {
            while (true)
            {
                var copyId = id;
                var drawing = classDataManager.GetDocument(copyId);
                if (drawing != null)
                {
                    if (drawing.ParentId != null)
                    {
                        id = drawing.ParentId;
                        continue;
                    }

                    return id;
                }

                return id;
            }
        }

        private Order GetOrder(int? drawingId, IClassDataManager<Order> ordersDataManager)
        {
            return ordersDataManager.GetListCollection(x => x.DrawingId == drawingId).FirstOrDefault();
        }

        public void PrintPassportWithTechOeprs(int? headDrawingId)
        {
            var topParentId = GetTopParentId(headDrawingId, _dataManagersFactory.GetDataManager<Drawing>());
            var order = GetOrder(topParentId, _dataManagersFactory.GetDataManager<Order>());
            var dm = _dataManagersFactory.GetFilteredDrawingsByParent(topParentId);
            var header = _dataManagersFactory.GetDataManager<Drawing>().GetDocument(topParentId);
            var hierarchy = CreateHierarchyNumbers(dm.GetListCollection(), header);
            var fileName = GetFileName();
            hierarchy = hierarchy.OrderBy(x => x.HierarchyNumber, new HierarchyNumberDrawingComparer()).ToList();
            var tos = _dataManagersFactory.GetDataManager<TechOperation>().GetListCollection();
            var trs = _dataManagersFactory.GetDataManager<TechRoute>().GetListCollection();

            _dataExport.CreatePassportProjectToFile(order, hierarchy, tos, trs, fileName);
        }

        private string GetFileName()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                return sfd.FileName;
            return null;
        }

        public void PrintPassportWithoutTechOeprs(int? headDrawingId)
        {
            var topParentId = GetTopParentId(headDrawingId, _dataManagersFactory.GetDataManager<Drawing>());
            var order = GetOrder(topParentId, _dataManagersFactory.GetDataManager<Order>());
            var dm = _dataManagersFactory.GetFilteredDrawingsByParent(topParentId);
            var header = _dataManagersFactory.GetDataManager<Drawing>().GetDocument(topParentId);
            var hierarchy = CreateHierarchyNumbers(dm.GetListCollection(), header);
            var fileName = GetFileName();
            hierarchy = hierarchy.OrderBy(x => x.HierarchyNumber, new HierarchyNumberDrawingComparer()).ToList();

            _dataExport.CreatePassportProjectToFile(order, hierarchy, fileName);
        }

        public void PrintSomeDrawings(List<Drawing> drawings)
        {
            throw new System.NotImplementedException();
        }

        public void PrintSomeDrawingsWithTechOpers(List<Drawing> drawings)
        {
            throw new System.NotImplementedException();
        }

        public void PrintSomeDrawings(List<HierarchyNumberDrawing> drawings)
        {
            throw new System.NotImplementedException();
        }

        public void PrintSomeDrawingsWithTechOpers(List<HierarchyNumberDrawing> drawings)
        {
            throw new System.NotImplementedException();
        }

        public void PrintClearWeigths(int? headDrawingId)
        {
            throw new System.NotImplementedException();
        }

        private List<HierarchyNumberDrawing> CreateHierarchyNumbers(List<Drawing> drawings, Drawing header)
        {
            var res = drawings
                   .OrderBy(x => x.Id)
                   .ToList()
                   .ConvertAll(Mapper.Map<HierarchyNumberDrawing>);

            var dctChildrens = new Dictionary<int?, int>();

            res.ForEach(drawing =>
            {
                int? id = int.MaxValue;

                id = drawing.ParentId ?? id;

                if (dctChildrens.ContainsKey(id))
                {
                    dctChildrens[id]++;
                }
                else
                {
                    dctChildrens.Add(id, 1);
                }

                drawing.Order = dctChildrens[id];
            });

            res.ForEach(x => x.HierarchyNumber = GetHierarchyNumber(res, x, header));

            return res;
        }

        private string GetHierarchyNumber(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing, Drawing headerDrawing)
        {
            if (drawing.ParentId != headerDrawing.Id)
            {
                return GetHierarchyNumber(data, data.FirstOrDefault(x => x.Id == drawing.ParentId), headerDrawing) + drawing.Order +
                       ".";
            }

            return drawing.Order + ".";
        }




    }
}