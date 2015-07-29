using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    internal class TechOperationController : IController<TechOperation>
    {
        private readonly IDataManagersFactory _factory;

        public TechOperationController(IDataManagersFactory factory)
        {
            _factory = factory;
        }

        public List<TechOperation> GetData()
        {
            return _factory.GetDataManager<TechOperation>().GetListCollection();
        }

        public event EventHandler DataRefreshed;

        public TechOperation CreateDocument()
        {
            return new TechOperation();
        }

        public void SaveDocument(TechOperation doc)
        {
            //TODO: делать ли апдейт всех маршрутов ???
            //TODO: делать, но апдейт только в списке операций
            _factory.GetDataManager<TechOperation>().InsertOrUpdate(doc);
        }

        public void DeleteDocument(TechOperation doc)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
        {
            throw new NotImplementedException();
        }

        public int CompareTwoDocuments(TechOperation doc1, TechOperation doc2)
        {
            throw new NotImplementedException();
        }

        public void AddDocument(TechOperation doc)
        {
            _factory.GetDataManager<TechOperation>().InsertOrUpdate(doc);
        }

        public void UpdateDocument(TechOperation doc)
        {
        }
    }
}