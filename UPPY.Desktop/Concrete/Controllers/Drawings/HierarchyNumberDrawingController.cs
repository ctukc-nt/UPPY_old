using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.DomainModel;
using Core.Interfaces;
using Ninject.Infrastructure.Language;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Views.Drawings;

namespace UPPY.Desktop.Concrete.Controllers.Drawings
{
    public class HierarchyNumberDrawingController : IHierarchyNumberDrawingController, IListViewController
    {
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechOperation> _techOperDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;
        private Dictionary<int?, int> _dctChildrens;

        public int? ParentId { get; set; } = null;

        public HierarchyNumberDrawingController(IClassDataManager<Drawing> drawingDataManager,
            IClassDataManager<TechRoute> techRouteDataManager, IClassDataManager<TechOperation> techOperDataManager)
        {
            _drawingsDataManager = drawingDataManager;
            _techRouteDataManager = techRouteDataManager;
            _techOperDataManager = techOperDataManager;
        }

        public List<HierarchyNumberDrawing> GetData()
        {
            _dctChildrens = new Dictionary<int?, int>();

            var drawings =
                _drawingsDataManager.GetListCollection()
                    .OrderBy(x => x.Id)
                    .ToList()
                    .ConvertAll(Mapper.Map<HierarchyNumberDrawing>);

            drawings.AsParallel<HierarchyNumberDrawing>().Map(drawing =>
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

            drawings.AsParallel<HierarchyNumberDrawing>().Map(x => x.HierarchyNumber = GetHierarchyNumber(drawings, x));

            return drawings;
        }

        public event EventHandler DataRefreshed;

        public HierarchyNumberDrawing CreateDocument()
        {
            return new HierarchyNumberDrawing();
        }

        public void Save(HierarchyNumberDrawing document)
        {
            _drawingsDataManager.InsertOrUpdate(document);
        }

        public void Delete(HierarchyNumberDrawing document)
        {
            throw new NotImplementedException();
        }

        public void EditDocument(HierarchyNumberDrawing document)
        {
            throw new NotImplementedException();
        }

        public List<TechRoute> GetTechRoutes()
        {
            return _techRouteDataManager.GetListCollection();
        }

        public List<TechOperation> GetTechOperations()
        {
            return _techOperDataManager.GetListCollection();
        }

        public int? CreateTechToute(List<TechOperation> techOpers)
        {
            var techRoute = new TechRoute();
            techRoute.TechOperations.AddRange(techOpers);
            _techRouteDataManager.InsertOrUpdate(techRoute);

            return techRoute.Id;
        }

        public void ShowViewDialog()
        {
            var form = new HierarchyDrawingsForm(this);
            form.ShowDialog();
        }

        private string GetHierarchyNumber(List<HierarchyNumberDrawing> data, HierarchyNumberDrawing drawing)
        {
            if (drawing.ParentId != ParentId)
            {
                return GetHierarchyNumber(data, data.FirstOrDefault(x => x.Id == drawing.ParentId)) + drawing.Order +
                       ".";
            }

            return drawing.Order + ".";
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

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
        {
            if (typeof (TO) == typeof (TechRoute))
            {
                return _techRouteDataManager.GetListCollection().ConvertAll(input => (IEntity) input);
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

            var levels1 = doc1.HierarchyNumber.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            var levels2 = doc2.HierarchyNumber.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

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
}