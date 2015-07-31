using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Views
{
    public partial class TechRouteForm : Form, IView<TechRoute>
    {
        private class OrdersOperations
        {
            public int? TechOperationId { get; set; }
            public int Order { get; set; }
        }

        private readonly IControllerDocument<TechRoute> _techRouteDocumentController;

        public TechRouteForm(IControllerDocument<TechRoute> techRouteDocumentController)
        {
            _techRouteDocumentController = techRouteDocumentController;
            InitializeComponent();

        }

        public TechRoute Document { get; set; }

        public IControllerDocument<TechRoute> Controller
        {
            get;
            set;
        }

        private void TechRouteForm_Load(object sender, System.EventArgs e)
        {
            var order = 1;
            var sourdeDataGrid =
                Document.TechOperations.ConvertAll(x => new OrdersOperations() { Order = order++, TechOperationId = x.Id });

            gridControlTechOperations.DataSource = sourdeDataGrid;

            repoTechOperations.DataSource =
                _techRouteDocumentController.GetData<TechOperation>();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            ((List<OrdersOperations>)gridControlTechOperations.DataSource).Add(new OrdersOperations() { Order = ((List<OrdersOperations>)gridControlTechOperations.DataSource).Count + 1, TechOperationId = null });
            gridControlTechOperations.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            ((List<OrdersOperations>)gridControlTechOperations.DataSource).Remove((OrdersOperations)gridView1.GetFocusedRow());
            gridControlTechOperations.RefreshDataSource();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Document.TechOperations = ((List<OrdersOperations>)gridControlTechOperations.DataSource).ConvertAll(x => _techRouteDocumentController.GetData<TechOperation>().Find(y => y.Id == x.TechOperationId));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}