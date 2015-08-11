using System;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraGrid.Views.Base;
using UPPY.Desktop.Controllers;
using UPPY.Desktop.Controllers.Drawings;

namespace UPPY.Desktop.Views
{
    public partial class DrawingsListForm : Form
    {
        private readonly IHierarchyNumberDrawingController _controller;

        public DrawingsListForm(IHierarchyNumberDrawingController controller)
        {
            _controller = controller;
            InitializeComponent();

            _controller = controller;
            _controller.DataRefreshed += RefreshData;

            repositoryItemLookUpEdit1.DataSource = controller.GetTechRoutes();
        }

       

        public void RefreshData(object sender, EventArgs e)
        {
            gridControl1.DataSource = _controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            _controller.SaveDocument(_controller.CreateDocument());
            gridControl1.Focus();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = gridView1.GetFocusedRow();
            var ind = gridView1.GetSelectedRows().FirstOrDefault();
            if (data != null)
            {
                var parentDrw = (Drawing) data;
                var newDoc = _controller.CreateDocument();
                newDoc.ParentId = parentDrw.Id;
                _controller.SaveDocument(newDoc);

                gridView1.FocusedRowHandle = ind;
                gridControl1.RefreshDataSource();
            }
        }

        private void btnDelDrawing_Click(object sender, EventArgs e)
        {
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_CustomColumnSort(object sender, CustomColumnSortEventArgs e)
        {
            e.Handled = true;
            //e.Result = _controller.CompareTwoDocuments((HierarchyNumberDrawing)e.RowObject1,
            //    (HierarchyNumberDrawing) e.RowObject2);
        }
    }
}