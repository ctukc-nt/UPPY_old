using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.TechRoutes;

namespace UPPY.Desktop.Views.TechRoutes
{
    public partial class TechRoutesListForm : Form
    {
        private readonly ITechRouteListController _controller;

        public TechRoutesListForm(ITechRouteListController controller)
        {
            _controller = controller;
            InitializeComponent();

            gcTechRoutes.DataSource = _controller.GetData();
            _controller.DataRefreshed += _techRouteController_DataRefreshed;
        }

        private void _techRouteController_DataRefreshed(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gcTechRoutes.DataSource = _controller.GetData();
            gcTechRoutes.RefreshDataSource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newDoc = _controller.CreateDocument();
            _controller.Save(newDoc);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var doc = (TechRoute) gvTechRoutes.GetFocusedRow();
            _controller.EditDocument(doc);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var doc = (TechRoute) gvTechRoutes.GetFocusedRow();
            _controller.Delete(doc);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TechRoutesListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvTechRoutes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }
    }
}