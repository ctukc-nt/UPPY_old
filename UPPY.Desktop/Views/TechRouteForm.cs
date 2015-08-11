using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Controllers.TechRoutes;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Views
{
    public partial class TechRouteForm : Form, IDocumentView<TechRoute>
    {
        private TechRoute _document;
        private readonly ITechRouteDocumentController _techRouteDocumentController;

        public TechRouteForm(ITechRouteDocumentController techRouteDocumentController)
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
                _document.TechOperations =
                    ((List<OrdersOperations>) gridControlTechOperations.DataSource).ConvertAll(
                        x => _techRouteDocumentController.GetDataTechOperations().Find(y => y.Id == x.TechOperationId));
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
                    _document.TechOperations.ConvertAll(
                        x => new OrdersOperations {Order = order++, TechOperationId = x.Id});

                gridControlTechOperations.DataSource = sourdeDataGrid;
            }
        }

        private void TechRouteForm_Load(object sender, EventArgs e)
        {
            repoTechOperations.DataSource =
                _techRouteDocumentController.GetDataTechOperations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((List<OrdersOperations>) gridControlTechOperations.DataSource).Add(new OrdersOperations
            {
                Order = ((List<OrdersOperations>) gridControlTechOperations.DataSource).Count + 1,
                TechOperationId = null
            });
            gridControlTechOperations.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ((List<OrdersOperations>) gridControlTechOperations.DataSource).Remove(
                (OrdersOperations) gridView1.GetFocusedRow());
            gridControlTechOperations.RefreshDataSource();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private class OrdersOperations
        {
            public int? TechOperationId { get; set; }
            public int Order { get; set; }
        }
    }
}