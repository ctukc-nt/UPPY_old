using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DesktopApp.Forms
{
    public partial class DrawingsListTreeForm : Form, IDocsListForm<Drawing>
    {
        private readonly IController<Drawing> _controller;

        public DrawingsListTreeForm(IController<Drawing> controller)
        {
            InitializeComponent();

            _controller = controller;
            _controller.SourceRefreshed += RefreshSource;

            repositoryItemLookUpEdit1.DataSource =
                controller.GetListRelatedDocument<TechRoute>().ConvertAll(x => (TechRoute) x);
        }

        public IController<Drawing> Controller
        {
            get { return _controller; }
        }

        public void RefreshSource(object sender, EventArgs e)
        {
            tlDarwings.BeginUpdate();
            var state = SaveNodeStates(tlDarwings.Nodes).ToList();
            var slctdNode = tlDarwings.Selection[0];
            Drawing data = null;
            if (slctdNode != null)
            {
                data = (Drawing) tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            }

            tlDarwings.DataSource = _controller.GetData();
            tlDarwings.RefreshDataSource();
            if (data != null)
            {
                var newNode = tlDarwings.FindNode(x => ((Drawing) tlDarwings.GetDataRecordByNode(x)).Id == data.Id);

                tlDarwings.Selection.Clear();
                if (newNode != null)
                {
                    tlDarwings.Selection.Add(newNode);
                    tlDarwings.FocusedNode = newNode;
                    ExpandToParentNode(newNode);
                }
            }

            tlDarwings.Focus();
            LoadNodesState(state);
            tlDarwings.EndUpdate();
        }

        private void ExpandToParentNode(TreeListNode node)
        {
            if (node.ParentNode != null)
            {
                node.ParentNode.Expanded = true;
                ExpandToParentNode(node.ParentNode);
            }
        }

        private void DrawingsListForm_Load(object sender, EventArgs e)
        {
            tlDarwings.DataSource = Controller.GetData();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            Controller.SaveDocument(Controller.CreateDocument());
            tlDarwings.Focus();
        }

        private void tlDrawings_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            Controller.SaveDocument((Drawing) data);
        }

        private void btnDelDrawing_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            Controller.DeleteDocument((Drawing) data);
            tlDarwings.RefreshDataSource();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            if (data != null)
            {
                var parentDrw = (Drawing) data;
                var newDoc = Controller.CreateDocument();
                newDoc.ParentId = parentDrw.Id;
                Controller.SaveDocument(newDoc);
                tlDarwings.RefreshDataSource();
            }
            tlDarwings.Selection[0].Expanded = true;
            tlDarwings.Focus();
        }

        private void repositoryItemLookUpEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            var listId = SaveNodeStates(tlDarwings.Nodes).ToList();
            RefreshSource(this, null);
            LoadNodesState(listId);
        }

        private void LoadNodesState(List<int?> listId)
        {
            foreach (var id in listId.AsParallel())
            {
                var id1 = id;
                var node = tlDarwings.FindNode(x => ((Drawing) tlDarwings.GetDataRecordByNode(x)).Id == id1);
                if (node != null)
                    node.Expanded = true;
            }
        }

        private IEnumerable<int?> SaveNodeStates(TreeListNodes nodes)
        {
            foreach (TreeListNode treeListNode in nodes)
            {
                if (treeListNode.Expanded)
                {
                    var data = (Drawing) tlDarwings.GetDataRecordByNode(treeListNode);
                    yield return data.Id;

                    foreach (var id in SaveNodeStates(treeListNode.Nodes))
                    {
                        yield return id;
                    }
                }
            }
        }
    }
}