using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Views
{
    public partial class DrawingsListTreeForm : Form
    {
        private readonly IDrawingListController _controller;
        private Drawing _selectedDocument;

        public DrawingsListTreeForm(IDrawingListController controller)
        {
            InitializeComponent();

            _controller = controller;
            _controller.DataRefreshed += RefreshData;

            repoTechRoutes.DataSource = controller.GetTechRoutes();
        }


        public void RefreshData(object sender, EventArgs e)
        {
            tlDarwings.BeginUpdate();
            var state = SaveNodeStates(tlDarwings.Nodes).ToList();
            var slctdNode = tlDarwings.Selection[0];
            Drawing data = null;
            if (slctdNode != null)
            {
                data = (Drawing)tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            }

            tlDarwings.DataSource = _controller.GetDrawingsList();
            tlDarwings.RefreshDataSource();
            if (data != null)
            {
                var newNode = tlDarwings.FindNode(x => ((Drawing)tlDarwings.GetDataRecordByNode(x)).Id == data.Id);

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
            tlDarwings.DataSource = _controller.GetDrawingsList();
            if (SelectedDocument != null)
            {
                var node = tlDarwings.FindNode(x => ((Drawing)tlDarwings.GetDataRecordByNode(x)).Id == SelectedDocument.Id);
                ExpandToParentNode(node);
            }
        }

        #region работа с операциями с чертежами

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            _controller.Save(_controller.CreateDocument());
            tlDarwings.Focus();
        }

        private void btnAddSubDrawing_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            if (data != null)
            {
                var parentDrw = (Drawing)data;
                var newDoc = _controller.CreateDocument();
                newDoc.ParentId = parentDrw.Id;
                _controller.Save(newDoc);
                tlDarwings.RefreshDataSource();
            }
            tlDarwings.Selection[0].Expanded = true;
            tlDarwings.Focus();
        }

        private void tlDrawings_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            _controller.Save((Drawing)data);
        }

        private void btnDelDrawing_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            _controller.Delete((Drawing)data);
            tlDarwings.RefreshDataSource();
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            var listId = SaveNodeStates(tlDarwings.Nodes).ToList();
            RefreshData(this, null);
            LoadNodesState(listId);
        }

        #endregion


        private void repoTechRoutes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if ((string)e.Button.Tag == "showlist")
                _controller.ShowTechRoutesList();
        }

        #region Работа с состоянием нод tlDrawings

        private void LoadNodesState(List<int?> listId)
        {
            foreach (var id in listId.AsParallel())
            {
                var id1 = id;
                var node = tlDarwings.FindNode(x => ((Drawing)tlDarwings.GetDataRecordByNode(x)).Id == id1);
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
                    var data = (Drawing)tlDarwings.GetDataRecordByNode(treeListNode);
                    yield return data.Id;

                    foreach (var id in SaveNodeStates(treeListNode.Nodes))
                    {
                        yield return id;
                    }
                }
            }
        }

        #endregion


        public Drawing SelectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                _selectedDocument = value;
                if (value != null)
                {
                    var node =
                        tlDarwings.FindNode(x => ((Drawing)tlDarwings.GetDataRecordByNode(x)).Id == value.Id);
                    ExpandToParentNode(node);
                }
            }
        }
    }
}