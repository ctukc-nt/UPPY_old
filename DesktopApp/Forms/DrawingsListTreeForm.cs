using System;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DesktopApp.Forms
{
    public partial class DrawingsListTreeForm : Form, IDocForm<Drawing>
    {
        private readonly IController<Drawing> _controller;

        public DrawingsListTreeForm(IController<Drawing> controller)
        {
            InitializeComponent();
            AddDocument += controller.AddDocument;
            DeleteDocument += controller.DeleteDocument;
            UpdateDocument += controller.UpdateDocument;

            _controller = controller;
            _controller.SourceRefreshed += RefreshSource;

            repositoryItemLookUpEdit1.DataSource =
                controller.GetListRelatedDocument<TechRoute>().ConvertAll(x => (TechRoute) x);
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
            var slctdNode = treeList1.Selection[0];
            Drawing data = null;
            if (slctdNode != null)
            {
                data = (Drawing) treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            }

            treeList1.DataSource = _controller.GetData();
            treeList1.RefreshDataSource();
            if (data != null)
            {
                var newNode =
                    GetNodeWithData(treeList1.Nodes, data);

                treeList1.Selection.Clear();
                if (newNode != null)
                {
                    treeList1.Selection.Add(newNode);
                    treeList1.FocusedNode = newNode;
                    ExpandToParentNode(newNode);
                }
            }

            treeList1.Focus();
        }

        private void ExpandToParentNode(TreeListNode node)
        {
            if (node.ParentNode != null)
            {
                node.ParentNode.Expanded = true;
                ExpandToParentNode(node.ParentNode);
            }
        }

        private TreeListNode GetNodeWithData(TreeListNodes nodes, Drawing search)
        {
            foreach (TreeListNode treeListNode in nodes)
            {
                var data = (Drawing) treeList1.GetDataRecordByNode(treeListNode);
                if (data != null)
                {
                    if (search.Id == data.Id)
                        return treeListNode;
                    var finded = GetNodeWithData(treeListNode.Nodes, search);
                    if (finded != null)
                        return finded;
                }
            }

            return null;
        }

        private void DrawingsListForm_Load(object sender, EventArgs e)
        {
            treeList1.DataSource = Controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            Controller.AddDocument(this,
                new DocumentEventArgs<Drawing> {Document = new Drawing {Name = "Test", TechRouteId = 2}});
            treeList1.Focus();
        }

        private void treeList1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var data = treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            Controller.UpdateDocument(this, new DocumentEventArgs<Drawing> {Document = (Drawing) data});
        }

        private void btnDelDrawing_Click(object sender, EventArgs e)
        {
            var data = treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            Controller.DeleteDocument(this, new DocumentEventArgs<Drawing> {Document = (Drawing) data});
            treeList1.RefreshDataSource();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = treeList1.GetDataRecordByNode(treeList1.Selection[0]);
            var selectedNode = treeList1.Selection[0];
            if (data != null)
            {
                var parentDrw = (Drawing) data;
                Controller.AddDocument(this,
                    new DocumentEventArgs<Drawing> {Document = new Drawing {ParentId = parentDrw.Id}});
                treeList1.RefreshDataSource();
            }
            treeList1.Selection[0].Expanded = true;
            treeList1.Focus();
        }

        private void repositoryItemLookUpEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            RefreshSource(this, null);
        }
    }
}