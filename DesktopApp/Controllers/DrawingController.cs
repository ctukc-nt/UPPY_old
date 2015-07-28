using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    public class DrawingController : IController<Drawing>
    {

        private IClassDataManager<Drawing> _drawingsDataManager;
        private IClassDataManager<TechRoute> _techRouteDataManager;

        public DrawingController(IDataManagerFactory dataManagerFactory)
        {
            _drawingsDataManager = dataManagerFactory.GetDataManager<Drawing>();
            _techRouteDataManager = dataManagerFactory.GetDataManager<TechRoute>();
        }

        public List<Drawing> GetData()
        {
            return new List<Drawing>(_drawingsDataManager.GetListCollection());
        }

        public event EventHandler SourceRefreshed;
        public Drawing CreateDocument()
        {
           return new Drawing();
        }

        public void AddDocument(Drawing doc)
        {
            _drawingsDataManager.InsertOrUpdate(doc);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public void UpdateDocument(Drawing doc)
        {
            _drawingsDataManager.Update(doc);
        }

        public void DeleteDocument(Drawing doc)
        {
            _drawingsDataManager.Delete(doc);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }


        public List<IEntity> GetListRelatedDocument<TO>() where TO:IEntity
        {
            if (typeof(TO) == typeof(TechRoute))
            {
                return _techRouteDataManager.GetListCollection().ConvertAll(input => (IEntity)input);
            }

            return null;
        }

        public int CompareTwoDocuments(Drawing doc1, Drawing doc2)
        {
            throw new NotImplementedException();
        }
    }
}