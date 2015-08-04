using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    public class TechRouteListController : ITechRouteListController
    {
        private readonly IDataManagersFactory _dataMangersfactory;
        private IControllersFactory _controllersFactory;

        public TechRouteListController(IControllersFactory controllersControllersFactory, IDataManagersFactory dataMangersfactory)
        {
            _controllersFactory = controllersControllersFactory;
            _dataMangersfactory = dataMangersfactory;
        }

        public event EventHandler<EventArgs> DataRefreshed;

        public IClassDataManager<TechRoute> DataManager { get; set; }


        public List<TechRoute> GetData()
        {
            return _dataMangersfactory.GetDataManager<TechRoute>().GetListCollection();
        }

        public TechRoute CreateDocument()
        {
            return new TechRoute();
        }

        public void Save(TechRoute document)
        {
            _dataMangersfactory.GetDataManager<TechRoute>().InsertOrUpdate(document);
        }

        public void Delete(TechRoute document)
        {
            _dataMangersfactory.GetDataManager<TechRoute>().Delete(document);
        }

        public void EditDocument(TechRoute document)
        {
            var controller = _controllersFactory.GetDocumentController<TechRoute>();
            controller.Document = document;
            controller.ShowViewDialog();
            //if ()
            //{
            //    document = controller.Document;
            //    Save(document);
            //    if (DataRefreshed != null)
            //        DataRefreshed(this, new EventArgs());
            //}
        }

        public bool ShowView()
        {
            var view = new TechRoutesListForm(this);
            if (view.ShowDialog() == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
    }
}