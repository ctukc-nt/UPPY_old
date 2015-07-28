using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    public class StandartController : IController<Standart>
    {
        private IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IDataManagersFactory _dataManagersFactory;
        private readonly IClassDataManager<Standart> _standartsDataManager;

        public StandartController(IDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
            _standartsDataManager = _dataManagersFactory.GetDataManager<Standart>();
        }

        public List<Standart> GetData()
        {
            return _standartsDataManager.GetListCollection();
        }

        public event EventHandler SourceRefreshed;

        public Standart CreateDocument()
        {
            return new Standart();
        }

        public void AddDocument(Standart doc)
        {
            _standartsDataManager.InsertOrUpdate(doc);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public void UpdateDocument(Standart doc)
        {
            _standartsDataManager.Update(doc);
        }

        public void DeleteDocument(Standart doc)
        {
            _standartsDataManager.Delete(doc);
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
        {
            if (_drawingsDataManager == null)
                _drawingsDataManager = _dataManagersFactory.GetDataManager<Drawing>();

            if (typeof(TO) == typeof(Drawing))
            {
                return _drawingsDataManager.GetListCollection().ConvertAll(x => (IEntity)x);
            }

            return null;
        }

        public int CompareTwoDocuments(Standart doc1, Standart doc2)
        {
            throw new NotImplementedException();
        }
    }
}