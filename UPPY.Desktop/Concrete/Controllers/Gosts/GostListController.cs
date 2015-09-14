using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Gosts;

namespace UPPY.Desktop.Concrete.Controllers.Gosts
{
    public class GostListController : IGostListController
    {
        private readonly IUppyControllersFactory _factory;
        private readonly IClassDataManager<Gost> _gostDataManager;

        public GostListController(IUppyControllersFactory factory, IClassDataManager<Gost> gostDataManager)
        {
            _factory = factory;
            _gostDataManager = gostDataManager;
        }

        public List<Gost> GetGostsList()
        {
            return _gostDataManager.GetListCollection();
        }

        public Gost CreateDocument()
        {
            return new Gost();
        }

        public void Save(Gost document)
        {
            _gostDataManager.InsertOrUpdate(document);
        }

        public void Delete(Gost document)
        {
            _gostDataManager.Delete(document);
        }

        public event EventHandler<EventArgs> DataRefreshed;

        public void ShowGostInAnotherView(Gost gost)
        {
            var docController = _factory.GetDocumentController<Gost>();
            docController.Document = gost;
            if (docController.ShowViewDialog())
            {
                Save(gost);
            }
        }
    }
}