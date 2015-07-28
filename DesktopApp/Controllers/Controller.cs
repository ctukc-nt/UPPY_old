using System;
using System.Collections.Generic;
using System.Reflection;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    public class Controller<T> : IController<T> where T : IEntity
    {
        private readonly IDataManagersFactory _dataManagersFactory;

        public Controller(IDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }
        public List<T> GetData()
        {
            var dataManager = _dataManagersFactory.GetDataManager<T>();
            return dataManager.GetListCollection();
        }

        public event EventHandler SourceRefreshed;

        public T CreateDocument()
        {
            var constructorInfo = typeof (T).GetConstructors();
            if (constructorInfo.Length > 0)
                return (T) constructorInfo[0].Invoke(null);
            
            throw new TypeInitializationException(typeof(T).FullName, new Exception());
        }

        public void SaveDocument(T doc)
        {
            var dataManager = _dataManagersFactory.GetDataManager<T>();
            dataManager.InsertOrUpdate(doc);
        }

        public void DeleteDocument(T doc)
        {
            var dataManager = _dataManagersFactory.GetDataManager<T>();
            dataManager.Delete(doc);
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
        {
            var dataManager = _dataManagersFactory.GetDataManager<TO>();
            return dataManager.GetListCollection().ConvertAll(x => (IEntity) x);
        }

        public int CompareTwoDocuments(T doc1, T doc2)
        {
            throw new NotImplementedException();
        }
    }
}