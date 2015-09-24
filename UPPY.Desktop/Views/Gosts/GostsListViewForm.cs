using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Gosts;

namespace UPPY.Desktop.Views.Gosts
{
    public partial class GostsListViewForm : Form
    {
        private readonly IGostListController _controller;

        public GostsListViewForm(IGostListController controller)
        {
            _controller = controller;
            _controller.DataRefreshed += _controller_DataRefreshed;
            InitializeComponent();
        }

        private void _controller_DataRefreshed(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmCommands_ButtonAddClick(object sender, EventArgs e)
        {
            _controller.Save(_controller.CreateDocument());
            RefreshData();
        }

        private void cmCommands_ButtonDeleteClick(object sender, EventArgs e)
        {
            var doc = (Gost) gvGosts.GetFocusedRow();
            _controller.Delete(doc);
        }

        private void cmCommands_ButtonEditClick(object sender, EventArgs e)
        {
            var doc = (Gost) gvGosts.GetFocusedRow();
            _controller.EditDocumentInAnotherView(doc);
        }

        private void cmCommands_ButtonRefreshClick(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            gcGosts.DataSource = _controller.GetGostsList();
            gcGosts.RefreshDataSource();
        }

        private void GostsListViewForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void gvGosts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var data = (Gost)gvGosts.GetRow(e.RowHandle);
            if (data != null)
            {
                _controller.Save(data);
            }
        }
    }
}