using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    public class TechRouteListController : ITechRouteListController
    {
        private readonly IControllersFactory _controllersFactory;
        private readonly IDataManagersFactory _dataMangersfactory;

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
            var controller = _controllersFactory.GetControllerDocument<TechRoute>();
            controller.Document = document;

            if (controller.ShowEditor())
            {
                document = controller.Document;
                Save(document);
                if (DataRefreshed != null)
                    DataRefreshed(this, new EventArgs());
            }
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