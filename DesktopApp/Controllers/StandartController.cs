using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    public class StandartController : IController<Standart> 
    {
        private IClassDataManager<Drawing> _drawingsDataManager;
        private IClassDataManager<Standart> _standartsDataManager;

        public StandartController(IClassDataManager<Standart> standartsDataManager,
            IClassDataManager<Drawing> drawingsDataManager)
        {
            _standartsDataManager = standartsDataManager;
            _drawingsDataManager = drawingsDataManager;
        }

        public List<Standart> GetData()
        {
            return _standartsDataManager.GetListCollection();
        }

        public event EventHandler SourceRefreshed;
        public void AddDocument(object sender, DocumentEventArgs<Standart> args)
        {
            _standartsDataManager.InsertOrUpdate(args.Document);
            if (SourceRefreshed != null)
                SourceRefreshed(this, new EventArgs());
        }

        public void UpdateDocument(object sender, DocumentEventArgs<Standart> args)
        {
            _standartsDataManager.Update(args.Document);
        }

        public void DeleteDocument(object sender, DocumentEventArgs<Standart> args)
        {
            _standartsDataManager.Delete(args.Document);
        }

        public List<IEntity> GetListRelatedDocument<TO>()
        {
            if (typeof(TO) == typeof(Drawing))
            {
                return _drawingsDataManager.GetListCollection().ConvertAll(input => (IEntity)input);
            }

            return null;
        }

        public int CompareTwoDocuments(Standart doc1, Standart doc2)
        {
            throw new NotImplementedException();
        }
    }
}