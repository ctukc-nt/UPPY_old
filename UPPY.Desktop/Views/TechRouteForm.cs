using System;
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
        private TechRoute _document;

        public TechRouteForm(IControllerDocument<TechRoute> techRouteDocumentController)
        {
            _techRouteDocumentController = techRouteDocumentController;
            InitializeComponent();

        }

        public TechRoute Document
        {
            get
            {
                _document.Name = textEdit1.Text;
                _document.Note = textEdit2.Text;
                _document.TechOperations = ((List<OrdersOperations>)gridControlTechOperations.DataSource).ConvertAll(x => _techRouteDocumentController.GetData<TechOperation>().Find(y => y.Id == x.TechOperationId));
                return _document;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                _document = value;

                textEdit1.Text = _document.Name;
                textEdit2.Text = _document.Note;
                var order = 1;
                var sourdeDataGrid =
               _document.TechOperations.ConvertAll(x => new OrdersOperations() { Order = order++, TechOperationId = x.Id });

                gridControlTechOperations.DataSource = sourdeDataGrid;
            }
        }

        public IControllerDocument<TechRoute> Controller
        {
            get;
            set;
        }

        private void TechRouteForm_Load(object sender, System.EventArgs e)
        {
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
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}