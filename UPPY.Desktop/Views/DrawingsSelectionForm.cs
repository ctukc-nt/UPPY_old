using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList.Nodes;
using UPPY.Desktop.Controllers;
using UPPY.Desktop.Factorys;
using UPPY.Desktop.Interfaces;

namespace UPPY.Desktop.Views
{
    public partial class DrawingsSelectionForm : Form
    {
        private List<Drawing> _selectedDocuments;
        private readonly IDrawingsSelectionController _controller;

        public DrawingsSelectionForm(IDrawingsSelectionController controller)
        {
            InitializeComponent();

            _controller = controller;
            _controller.DataRefreshed += RefreshData;

            repoTechRoutes.DataSource = controller.GetTechRoutes();
        }

        public DrawingsSelectionForm(IDrawingsSelectionController controller, bool multipleSelect)
            : this(controller)
        {

            tlDarwings.OptionsSelection.MultiSelect = multipleSelect;
        }

        public List<Drawing> SelectedDocuments
        {
            get { return _selectedDocuments; }
            set
            {
                _selectedDocuments = value;
                if (value != null)
                {
                    value.ForEach(y =>
                    {
                        var node = tlDarwings.FindNode(x => ((Drawing)tlDarwings.GetDataRecordByNode(x)).Id == y.Id);
                        ExpandToParentNode(node);
                    });

                }
            }
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
        }

        #region работа с операциями с чертежами

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            var listId = SaveNodeStates(tlDarwings.Nodes).ToList();
            RefreshData(this, null);
            LoadNodesState(listId);
        }

        #endregion

        private void repoTechRoutes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
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
    }
}