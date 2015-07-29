using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces;

namespace UPPY.Desktop.Views
{
    public partial class TechRouteForm : Form, IView<TechRoute>
    {
        private readonly IControllerDocument<TechRoute> _techRouteDocumentController;

        public TechRouteForm(IControllerDocument<TechRoute> techRouteDocumentController)
        {
            _techRouteDocumentController = techRouteDocumentController;
            InitializeComponent();
        }

        public TechRoute Document { get; set; }
    }
}