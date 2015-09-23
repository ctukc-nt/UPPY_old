using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Gosts;
using UPPY.Desktop.Views.Gosts;

namespace UPPY.Desktop.Concrete.Controllers.Gosts
{
    public class GostListController : IGostListController, IListViewController
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

        public void EditDocumentInAnotherView(Gost gost)
        {
            var docController = _factory.GetDocumentController<Gost>();
            var copyDoc = _gostDataManager.GetDocument(gost.Id);
            docController.Document = copyDoc;
            if (docController.ShowViewDialog())
            {
                copyDoc = docController.Document;
                Save(copyDoc);
                DataRefreshed?.Invoke(this, EventArgs.Empty);
            }
        }

        public void ShowViewDialog()
        {
            GostsListViewForm form = new GostsListViewForm(this);
            form.ShowDialog();
        }
    }
}