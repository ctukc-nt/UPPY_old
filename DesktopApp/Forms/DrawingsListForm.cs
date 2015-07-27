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
    public partial class DrawingsListForm : Form, IDocForm<HierarchyNumberDrawing>
    {
        private IController<HierarchyNumberDrawing> _controller;

        public DrawingsListForm(IController<HierarchyNumberDrawing> controller)
        {
            InitializeComponent();
            AddDocument += controller.AddDocument;
            DeleteDocument += controller.DeleteDocument;
            UpdateDocument += controller.UpdateDocument;

            _controller = controller;
            _controller.SourceRefreshed += RefreshSource;


            repositoryItemLookUpEdit1.DataSource =
                controller.GetListRelatedDocument<TechRoute>().ConvertAll(x => (TechRoute)x);
        }

        public IController<HierarchyNumberDrawing> Controller
        {
            get { return _controller; }
        }

        public event DocumentEventHandler<HierarchyNumberDrawing> UpdateDocument;
        public event DocumentEventHandler<HierarchyNumberDrawing> DeleteDocument;
        public event DocumentEventHandler<HierarchyNumberDrawing> AddDocument;

        public void RefreshSource(object sender, EventArgs e)
        {
            gridControl1.DataSource = _controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            Controller.AddDocument(this,
               new DocumentEventArgs<HierarchyNumberDrawing> { Document = new HierarchyNumberDrawing() { Name = "Test", TechRouteId = 2 } });
            gridControl1.Focus();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = gridView1.GetFocusedRow();
            var ind = gridView1.GetSelectedRows().FirstOrDefault();
            if (data != null)
            {
                var parentDrw = (Drawing)data;
                Controller.AddDocument(this,
                    new DocumentEventArgs<HierarchyNumberDrawing> { Document = new HierarchyNumberDrawing() { ParentId = parentDrw.Id } });

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
