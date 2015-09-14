using System;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraGrid.Views.Base;
using UPPY.Desktop.Interfaces.Controllers.TechOpers;

namespace UPPY.Desktop.Views.TechOpers
{
    public partial class TechOpersListForm : Form
    {
        private readonly ITechOpersListController _controller;

        public TechOpersListForm(ITechOpersListController controller)
        {
            _controller = controller;
            _controller.DataRefreshed += _controller_DataRefreshed;
            InitializeComponent();
        }

        private void _controller_DataRefreshed(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmCommands_ButtonAddClick(object sender, EventArgs e)
        {
            _controller.Save(_controller.CreateDocument());
        }

        private void cmCommands_ButtonDeleteClick(object sender, EventArgs e)
        {
            var doc = (TechOperation) gvTechOpers.GetFocusedRow();
            _controller.Delete(doc);
        }

        private void cmCommands_ButtonEditClick(object sender, EventArgs e)
        {
        }

        private void cmCommands_ButtonRefreshClick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gcTechOpers.DataSource = _controller.GetTechOperationsList();
            gcTechOpers.RefreshDataSource();
        }

        private void TechOpersListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvTechOpers_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var data = gvTechOpers.GetRow(e.RowHandle);
            _controller.Save((TechOperation) data);
        }
    }
}