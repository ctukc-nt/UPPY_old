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

            gridControl1.DataSource = sourdeDataGrid;

            repositoryItemGridLookUpEdit1.DataSource =
                _techRouteDocumentController.GetListRelatedDocument<TechOperation>();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            ((List<OrdersOperations>)gridControl1.DataSource).Add(new OrdersOperations() { Order = ((List<OrdersOperations>)gridControl1.DataSource).Count + 1, TechOperationId = null });
            gridControl1.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            ((List<OrdersOperations>) gridControl1.DataSource).Remove((OrdersOperations) gridView1.GetFocusedRow());
            gridControl1.RefreshDataSource();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Document.TechOperations = ((List<OrdersOperations>)gridControl1.DataSource).ConvertAll(x => _techRouteDocumentController.GetListRelatedDocument<TechOperation>().Find(y=>y.Id == x.TechOperationId));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}