using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;
using DesktopApp.View;

namespace DesktopApp.Forms
{
    public partial class DrawingsListForm : Form, IDocsListForm<HierarchyNumberDrawing>
    {
        private IController<HierarchyNumberDrawing> _controller;

        public DrawingsListForm(IController<HierarchyNumberDrawing> controller)
        {
            InitializeComponent();
          
            _controller = controller;
            _controller.SourceRefreshed += RefreshSource;


            repositoryItemLookUpEdit1.DataSource =
                controller.GetListRelatedDocument<TechRoute>().ConvertAll(x => (TechRoute)x);
        }

        public IController<HierarchyNumberDrawing> Controller
        {
            get { return _controller; }
        }

        public void RefreshSource(object sender, EventArgs e)
        {
            gridControl1.DataSource = _controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            Controller.AddDocument(Controller.CreateDocument());
            gridControl1.Focus();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = gridView1.GetFocusedRow();
            var ind = gridView1.GetSelectedRows().FirstOrDefault();
            if (data != null)
            {
                var parentDrw = (Drawing)data;
                var newDoc = Controller.CreateDocument();
                newDoc.ParentId = parentDrw.Id;
                Controller.AddDocument(newDoc);

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

        private void gridView1_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            e.Handled = true;
            e.Result = _controller.CompareTwoDocuments((HierarchyNumberDrawing)e.RowObject1, (HierarchyNumberDrawing)e.RowObject2);
        }

    }
}
