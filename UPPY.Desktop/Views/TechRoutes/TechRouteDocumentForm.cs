using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.TechRoutes;

namespace UPPY.Desktop.Views.TechRoutes
{
    public partial class TechRouteDocumentForm : Form
    {
        private TechRoute _document;
        private readonly ITechRouteDocumentController _techRouteDocumentController;

        public TechRouteDocumentForm(ITechRouteDocumentController techRouteDocumentController)
        {
            _techRouteDocumentController = techRouteDocumentController;
            InitializeComponent();
        }

        public TechRoute Document
        {
            get
            {
                _document.Name = teName.Text;
                _document.Note = teNote.Text;
                _document.TechOperations =
                    ((List<OrdersOperations>) gcTechOperations.DataSource).ConvertAll(
                        x => _techRouteDocumentController.GetDataTechOperations().Find(y => y.Id == x.TechOperationId));
                return _document;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                _document = value;

                teName.Text = _document.Name;
                teNote.Text = _document.Note;
                var order = 1;
                var sourdeDataGrid =
                    _document.TechOperations.ConvertAll(
                        x => new OrdersOperations {Order = order++, TechOperationId = x.Id});

                gcTechOperations.DataSource = sourdeDataGrid;
            }
        }

        private void TechRouteForm_Load(object sender, EventArgs e)
        {
            repoTechOperations.DataSource =
                _techRouteDocumentController.GetDataTechOperations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((List<OrdersOperations>) gcTechOperations.DataSource).Add(new OrdersOperations
            {
                Order = ((List<OrdersOperations>) gcTechOperations.DataSource).Count + 1,
                TechOperationId = null
            });
            gcTechOperations.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ((List<OrdersOperations>) gcTechOperations.DataSource).Remove(
                (OrdersOperations) gridView1.GetFocusedRow());
            gcTechOperations.RefreshDataSource();
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