using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    public class DrawingController : IController<Drawing>
    {
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public DrawingController(IDataManagersFactory dataManagersFactory)
        {
            var dataManagerFactory1 = dataManagersFactory;
            _drawingsDataManager = dataManagerFactory1.GetDataManager<Drawing>();
            _techRouteDataManager = dataManagerFactory1.GetDataManager<TechRoute>();
        }

        public List<Drawing> GetData()
        {
            return new List<Drawing>(_drawingsDataManager.GetListCollection());
        }

        public event EventHandler DataRefreshed;

        public Drawing CreateDocument()
        {
           return new Drawing();
        }

        public void SaveDocument(Drawing doc)
        {
            _drawingsDataManager.InsertOrUpdate(doc);
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public void DeleteDocument(Drawing doc)
        {
            _drawingsDataManager.Delete(doc);
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO:IEntity
        {
            if (typeof (TO) == typeof (TechRoute))
            {
                return _techRouteDataManager.GetListCollection().ConvertAll(input => (IEntity) input);
            }

            return null;
        }

        public int CompareTwoDocuments(Drawing doc1, Drawing doc2)
        {
            throw new NotImplementedException();
        }
    }
}