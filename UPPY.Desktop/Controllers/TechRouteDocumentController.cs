using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    class TechRouteDocumentController : AbstractController, IControllerDocument<TechRoute>
    {
        public TechRoute Document { get; set; }

        public void ShowEditor()
        {
            var view = new TechRouteForm(this);
            view.Document = Document;
            view.ShowDialog();
        }

        public TechRouteDocumentController(IControllersFactory controllersFactory, IDataManagersFactory dataManagersFactory) : base(controllersFactory, dataManagersFactory)
        {
        }
    }
}
