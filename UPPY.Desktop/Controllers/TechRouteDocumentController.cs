using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    public interface ITechRouteDocumentController
    {
        TechRoute Document { get; set; }
        bool ShowEditor();
        List<TechOperation> GetDataTechOperations();
    }

    internal class TechRouteDocumentController : ITechRouteDocumentController
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
                Document = view.Document;
                return true;
            }

            return false;
        }

        public IClassDataManager<TechRoute> DataManager { get; set; }

        public List<TechOperation> GetDataTechOperations()
        {
            return _dataManagersFactory.GetDataManager<TechOperation>().GetListCollection();
        }
    }
}