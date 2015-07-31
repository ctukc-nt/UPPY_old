using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Views
{
    public partial class DrawingsListTreeForm : Form, IListView<Drawing>
    {
        private readonly IControllerList<Drawing> _controller;

        public DrawingsListTreeForm(IControllerList<Drawing> controller)
        {
            InitializeComponent();

            _controller = controller;
            _controller.DataRefreshed += RefreshData;

            repoTechRoutes.DataSource = controller.GetData<TechRoute>();
        }

        public IControllerList<Drawing> Controller
        {
            get { return _controller; }
        }

        public void RefreshData(object sender, EventArgs e)
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
            Controller.Save(Controller.CreateDocument());
            tlDarwings.Focus();
        }

        private void tlDrawings_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            Controller.Save((Drawing) data);
        }

        private void btnDelDrawing_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            Controller.Delete((Drawing) data);
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
                Controller.Save(newDoc);
                tlDarwings.RefreshDataSource();
            }
            tlDarwings.Selection[0].Expanded = true;
            tlDarwings.Focus();
        }

        private void repoTechRoutes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
           
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            var listId = SaveNodeStates(tlDarwings.Nodes).ToList();
            RefreshData(this, null);
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

        public Drawing SelectedDocument
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}