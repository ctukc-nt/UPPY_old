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

        public DrawingController(IClassDataManager<Drawing> drawingsDataManager, IClassDataManager<TechRoute> techRouteManager)
        {
            _drawingsDataManager = drawingsDataManager;
            _techRouteDataManager = techRouteManager;
        }

        public List<Drawing> GetData()
        {
            return new List<Drawing>(_drawingsDataManager.GetListCollection());
        }

        public event EventHandler SourceRefreshed;
        public void AddDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            _drawingsDataManager.InsertOrUpdate(args.Document);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public void UpdateDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            _drawingsDataManager.Update(args.Document);
        }

        public void DeleteDocument(object sender, DocumentEventArgs<Drawing> args)
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

        public int CompareTwoDocuments(Drawing doc1, Drawing doc2)
        {
            throw new NotImplementedException();
        }
    }
}