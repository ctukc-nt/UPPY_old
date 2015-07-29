using System;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Interfaces;
using DesktopApp.View;
using DevExpress.XtraGrid.Views.Base;

namespace DesktopApp.Forms
{
    public partial class DrawingsListForm : Form, IDocsListForm<HierarchyNumberDrawing>
    {
        public DrawingsListForm(IController<HierarchyNumberDrawing> controller)
        {
            InitializeComponent();

            Controller = controller;
            Controller.DataRefreshed += RefreshData;


            repositoryItemLookUpEdit1.DataSource =
                controller.GetListRelatedDocument<TechRoute>().ConvertAll(x => (TechRoute) x);
        }

        public IController<HierarchyNumberDrawing> Controller { get; private set; }

        public void RefreshData(object sender, EventArgs e)
        {
            gridControl1.DataSource = Controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            Controller.SaveDocument(Controller.CreateDocument());
            gridControl1.Focus();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = gridView1.GetFocusedRow();
            var ind = gridView1.GetSelectedRows().FirstOrDefault();
            if (data != null)
            {
                var parentDrw = (Drawing) data;
                var newDoc = Controller.CreateDocument();
                newDoc.ParentId = parentDrw.Id;
                Controller.SaveDocument(newDoc);

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
            e.Result = Controller.CompareTwoDocuments((HierarchyNumberDrawing) e.RowObject1,
                (HierarchyNumberDrawing) e.RowObject2);
        }
    }
}