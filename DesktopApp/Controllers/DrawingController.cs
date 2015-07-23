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

        public IClassDataManager<Drawing> DataManager { get; private set; }

        public DrawingController(IClassDataManager<Drawing> dataManager)
        {
            DataManager = dataManager;
        }

        public List<Drawing> GetData()
        {
            return DataManager.GetListCollection();
        }

        public event EventHandler SourceRefreshed;
        public void AddDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            DataManager.InsertOrUpdate(args.Document);
        }

        public void UpdateDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            DataManager.Update(args.Document);
        }

        public void DeleteDocument(object sender, DocumentEventArgs<Drawing> args)
        {
            DataManager.Delete(args.Document);
        }
    }
}