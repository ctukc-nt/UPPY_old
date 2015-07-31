using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    internal class TechRouteDocumentController : IControllerDocument<TechRoute>
    {
        private IControllersFactory _factory;
        private readonly IDataManagersFactory _dataManagersFactory;

        public TechRouteDocumentController(IControllersFactory controllersFactory, IDataManagersFactory dataManagersFactory)
        {
            _factory = controllersFactory;
            _dataManagersFactory = dataManagersFactory;
        }

        public TechRoute Document { get; set; }

        public bool ShowEditor()
        {
            var view = new TechRouteForm(this);
            view.Document = Document;
            if (view.ShowDialog() == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        public IClassDataManager<TechRoute> DataManager { get; set; }

        public List<TO> GetData<TO>() where TO : IEntity
        {
            return _dataManagersFactory.GetDataManager<TO>().GetListCollection();
        }

        public void ShowAnotherListDocument<T>() where T : IEntity
        {
            _factory.GetControllerListView<T>().ShowView();
        }
    }
}