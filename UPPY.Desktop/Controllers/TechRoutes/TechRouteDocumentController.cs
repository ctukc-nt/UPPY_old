using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers.TechRoutes
{
    public interface ITechRouteDocumentController
    {
        List<TechOperation> GetDataTechOperations();
    }

    internal class TechRouteDocumentController : ITechRouteDocumentController, IDocumentController<TechRoute>
    {
        private IControllersFactory _factory;
        private readonly IDataManagersFactory _dataManagersFactory;

        public TechRouteDocumentController(IControllersFactory controllersFactory, IDataManagersFactory dataManagersFactory)
        {
            _factory = controllersFactory;
            _dataManagersFactory = dataManagersFactory;
        }

        public TechRoute Document { get; set; }
        public bool ShowViewDialog()
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

        public List<TechOperation> GetDataTechOperations()
        {
            return _dataManagersFactory.GetDataManager<TechOperation>().GetListCollection();
        }
    }
}