using System;
using System.Collections.Generic;
using System.Reflection;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    public class Controller<T> : IController<T> where T : IEntity
    {
        private readonly IDataManagerFactory _dataManagerFactory;

        public Controller(IDataManagerFactory dataManagerFactory)
        {
            _dataManagerFactory = dataManagerFactory;
        }
        public List<T> GetData()
        {
            var dataManager = _dataManagerFactory.GetDataManager<T>();
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

        public void AddDocument(T doc)
        {
            var dataManager = _dataManagerFactory.GetDataManager<T>();
            dataManager.Insert(doc);
        }

        public void UpdateDocument(T doc)
        {
            var dataManager = _dataManagerFactory.GetDataManager<T>();
            dataManager.Update(doc);
        }

        public void DeleteDocument(T doc)
        {
            var dataManager = _dataManagerFactory.GetDataManager<T>();
            dataManager.Delete(doc);
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
        {
            var dataManager = _dataManagerFactory.GetDataManager<TO>();
            return dataManager.GetListCollection().ConvertAll(x => (IEntity) x);
        }

        public int CompareTwoDocuments(T doc1, T doc2)
        {
            throw new NotImplementedException();
        }
    }
}