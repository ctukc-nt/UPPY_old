
using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using Ninject.Infrastructure.Language;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Controllers.Drawings
{
    public class HierarchyNumberDrawingController : IHierarchyNumberDrawingController
    {
        private readonly IDataManagersFactory _dataManagersFactory;
        private Dictionary<int?, int> _dctChildrens;

        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public HierarchyNumberDrawingController(IDataManagersFactory dataManagersFactory, IControllersFactory controllersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
            _drawingsDataManager = dataManagersFactory.GetDataManager<Drawing>();
            _techRouteDataManager = dataManagersFactory.GetDataManager<TechRoute>();
        }


        public List<HierarchyNumberDrawing> GetData()
        {
            _dctChildrens = new Dictionary<int?, int>();

            var drawings = _drawingsDataManager.GetListCollection().OrderBy(x => x.Id).ToList().ConvertAll(AutoMapper.Mapper.Map<HierarchyNumberDrawing>);

            drawings.AsParallel().Map(drawing =>
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

        public event EventHandler DataRefreshed;
        public HierarchyNumberDrawing CreateDocument()
        {
            return new HierarchyNumberDrawing();
        }

        public void Save(HierarchyNumberDrawing document)
        {
            
        }

        public void Delete(HierarchyNumberDrawing document)
        {
            throw new NotImplementedException();
        }

        public void EditDocument(HierarchyNumberDrawing document)
        {
            throw new NotImplementedException();
        }

        public void SaveDocument(HierarchyNumberDrawing doc)
        {
            _drawingsDataManager.InsertOrUpdate(doc);
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public void DeleteDocument(HierarchyNumberDrawing doc)
        {
            _drawingsDataManager.Delete(doc);
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public List<TechRoute> GetTechRoutes()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
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

        public List<TO> GetData<TO>() where TO : IEntity
        {
            throw new NotImplementedException();
        }

        public bool ShowView()
        {
            throw new NotImplementedException();
        }
    }
}