using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;
using DesktopApp.View;
using DevExpress.XtraPrinting.Native;
using Ninject.Infrastructure.Language;

namespace DesktopApp.Controllers
{
    public class HierarchyNumberDrawingController : IController<HierarchyNumberDrawing>
    {
        private Dictionary<int?, int> _dctChildrens;

        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public HierarchyNumberDrawingController(IDataManagerFactory dataManagerFactory)
        {
            _drawingsDataManager = dataManagerFactory.GetDataManager<Drawing>();
            _techRouteDataManager = dataManagerFactory.GetDataManager<TechRoute>();
        }

        public List<HierarchyNumberDrawing> GetData()
        {
            _dctChildrens = new Dictionary<int?, int>();

            var drawings = _drawingsDataManager.GetListCollection().OrderBy(x => x.Id).ToList().ConvertAll(AutoMapper.Mapper.Map<HierarchyNumberDrawing>);

            drawings.AsParallel().ForEach(drawing =>
            {
                int? id = int.MaxValue;

                id = drawing.ParentId ?? id;

                if (_dctChildrens.ContainsKey(id))
                {
                    _dctChildrens[id]++;
                }
                else
                {
                    _dctChildrens.Add(id, 1);
                }

                drawing.Order = _dctChildrens[id];
            });

            drawings.AsParallel().Map(x => x.HierarchyNumber = GetHierarchyNumber(drawings, x));

            return drawings;
        }

        private string GetHierarchyNumber(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing)
        {
            if (drawing.ParentId != null)
            {
                return GetHierarchyNumber(data, data.FirstOrDefault(x => x.Id == drawing.ParentId)) + drawing.Order + ".";
            }

            return drawing.Order + ".";
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