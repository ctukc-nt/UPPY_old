using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;

namespace DesktopApp.Forms
{
    public partial class DrawingsListForm : Form, IDocForm<Drawing>
    {
        private readonly IController<Drawing> _controller;

        public DrawingsListForm(IController<Drawing> controller)
        {
            InitializeComponent();
            AddDocument += controller.AddDocument;
            DeleteDocument += controller.DeleteDocument;
            UpdateDocument += controller.UpdateDocument;

            _controller = controller;
            _controller.SourceRefreshed += RefreshSource;
        }

        public IController<Drawing> Controller
        {
            get { return _controller; }
        }

        public event DocumentEventHandler<Drawing> UpdateDocument;
        public event DocumentEventHandler<Drawing> DeleteDocument;
        public event DocumentEventHandler<Drawing> AddDocument;

        public void RefreshSource(object sender, EventArgs e)
        {
        }

        private void DrawingsListForm_Load(object sender, EventArgs e)
        {
            //var data = Controller.GetData();
            treeList1.DataSource = Controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            Controller.AddDocument(this, new DocumentEventArgs<Drawing>() { Document = new Drawing() { Name = "Test" } });
            treeList1.RefreshDataSource();
        }

        private void treeList1_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            var data = treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            Controller.UpdateDocument(this, new DocumentEventArgs<Drawing>() { Document = (Drawing)data });
        }

        private void btnDelDrawing_Click(object sender, EventArgs e)
        {
            var data = treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            Controller.DeleteDocument(this, new DocumentEventArgs<Drawing>() { Document = (Drawing)data });
            treeList1.RefreshDataSource();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            var selectedNode = treeList1.Selection[0];
            if (data != null)
            {
                var parentDrw = (Drawing)data;
                Controller.AddDocument(this, new DocumentEventArgs<Drawing>() { Document = new Drawing() { ParentId = parentDrw.Id } });
                treeList1.RefreshDataSource();
            }
        }
    }
}