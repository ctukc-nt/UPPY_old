using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.TechRoutes;
using UPPY.Desktop.Views.TechRoutes;

namespace UPPY.Desktop.Concrete.Controllers.TechRoutes
{
    internal class TechRouteDocumentController : ITechRouteDocumentController, IDocumentController<TechRoute>
    {
        private readonly IDataManagersFactory _dataManagersFactory;
        private IControllersFactory _factory;

        public TechRouteDocumentController(IControllersFactory controllersFactory,
            IDataManagersFactory dataManagersFactory)
        {
            _factory = controllersFactory;
            _dataManagersFactory = dataManagersFactory;
        }

        public TechRoute Document { get; set; }

        public bool ShowViewDialog()
        {
            var view = new TechRouteDocumentForm(this);
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