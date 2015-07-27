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
            var drawings = _drawingsDataManager.GetListCollection().OrderBy(x => x.Id).ToList().ConvertAll(AutoMapper.Mapper.Map<HierarchyNumberDrawing>);

            foreach (var cat in drawings.AsParallel())
            {
                int? id = int.MaxValue;

                id = cat.ParentId ?? id;

                if (_dctChildrens.ContainsKey(id))
                {
                    _dctChildrens[id]++;
                }
                else
                {
                    _dctChildrens.Add(id, 1);
                }

                cat.Order = _dctChildrens[id];
            }

            foreach (var cat in drawings.AsParallel())
            {
                cat.HierarchyNumber = GetHierarchyNumber(drawings, cat);
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
            if (drawing.ParentId != null)
            {
                return GetHierarchyNumber(data, data.FirstOrDefault(x => x.Id == drawing.ParentId)) + drawing.Order + ".";
            }

            return drawing.Order + ".";
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

        public void AddDocument(object sender, DocumentEventArgs<HierarchyNumberDrawing> args)
        {
            _drawingsDataManager.InsertOrUpdate(args.Document);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public void UpdateDocument(object sender, DocumentEventArgs<HierarchyNumberDrawing> args)
        {
            _drawingsDataManager.Update(args.Document);
        }

        public void DeleteDocument(object sender, DocumentEventArgs<HierarchyNumberDrawing> args)
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

        public int CompareTwoDocuments(HierarchyNumberDrawing doc1, HierarchyNumberDrawing doc2)
        {
            if (doc1 == null && doc2 == null)
                return 0;

            if (doc1 == null)
                return 1;

            if (doc2 == null)
                return 1;

            var levels1 = doc1.HierarchyNumber.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var levels2 = doc2.HierarchyNumber.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            var minLevels = Math.Min(levels1.Length, levels2.Length);

            for (int i = 0; i < minLevels; i++)
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
}