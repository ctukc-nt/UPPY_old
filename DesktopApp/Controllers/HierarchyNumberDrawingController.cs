using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;
using DesktopApp.View;
using DevExpress.XtraPrinting.Native;

namespace DesktopApp.Controllers
{
    public class HierarchyNumberDrawingController : IController<HierarchyNumberDrawing>
    {
        private Dictionary<int?, int> _dctChildrens;
        private Dictionary<int?, string> _dctNumbers; 

        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public HierarchyNumberDrawingController(IClassDataManager<Drawing> drawingsDataManager,
            IClassDataManager<TechRoute> techRouteManager)
        {
            _drawingsDataManager = drawingsDataManager;
            _techRouteDataManager = techRouteManager;
        }

        public List<HierarchyNumberDrawing> GetData()
        {
            _dctChildrens = new Dictionary<int?, int>();
            _dctNumbers = new Dictionary<int?, string>();
            var drawings = _drawingsDataManager.GetListCollection().ConvertAll(AutoMapper.Mapper.Map<HierarchyNumberDrawing>);

            foreach (var cat in drawings)
            {
                AddFirstParent(drawings, cat);

                cat.HierarchyNumber = _dctNumbers.ContainsKey(cat.ParentId) ? _dctNumbers[cat.ParentId] : "";
                    = GetHierNumber(drawings, cat);

            }

            return drawings;
        }

        private void AddFirstParent(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing)
        {
            int? num = drawing.ParentId ?? int.MaxValue;

            if (_dctChildrens.ContainsKey(num))
                _dctChildrens[num] += 1;
            else
            {
                _dctChildrens.Add(num, 1);
            }
        }

        private string GetHierarchyNumber(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing)
        {
            if (drawing != null)
            {
                var num = 1;
                if (_dctChildrens.ContainsKey(drawing.ParentId))
                    _dctChildrens[drawing.ParentId] += 1;
                else
                {
                    _dctChildrens.Add(drawing.ParentId, 1);
                }

                return GetHierarchyNumber(data, data.FirstOrDefault(x => x.Id == drawing.ParentId)) + _dctChildrens[drawing.ParentId];
            }

            return "1.";
        }

        private string GetHierNumber(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing)
        {
            if (drawing.ParentId != null)
            {
                if (!_dctChildrens.ContainsKey(drawing.ParentId))
                {
                    _dctChildrens.Add(drawing.ParentId, 1);
                }

                return GetHierNumber(data, data.FirstOrDefault(x => x.Id == drawing.ParentId)) + _dctChildrens[drawing.ParentId].ToString() + ".";
            }

            if (!_dctChildrens.ContainsKey(int.MaxValue))
            {
                _dctChildrens.Add(int.MaxValue, 1);
            }

            return _dctChildrens[int.MaxValue].ToString() + ".";
        }

        private static int GetLevel(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing)
        {
            if (drawing.ParentId != null)
                return 1 + GetLevel(data, data.FirstOrDefault(x => x.Id == drawing.ParentId));

            return 0;
        }

        public event EventHandler SourceRefreshed;

        public void AddDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            _drawingsDataManager.InsertOrUpdate(args.Document);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public void UpdateDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            _drawingsDataManager.Update(args.Document);
        }

        public void DeleteDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            _drawingsDataManager.Delete(args.Document);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public List<IEntity> GetListRelatedDocument<TO>()
        {
            if (typeof(TO) == typeof(TechRoute))
            {
                return _techRouteDataManager.GetListCollection().ConvertAll(input => (IEntity)input);
            }

            return null;
        }
    }
}