using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.Skins;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Controls.Drawings
{
    public partial class TreeListDrawingsControl : UserControl
    {
        private IDrawingListController _controller;
        private int? _parentId;

        public event DrawingChangeEventHandler DrawingWeightChanged;

        public event DrawingChangeEventHandler DrawingCountChanged;

        public List<Drawing> SelectedDrawings
        {
            get
            {
                var selection = tlDarwings.Selection;
                return (from TreeListNode slc in selection select (Drawing)tlDarwings.GetDataRecordByNode(slc)).ToList();
            }
        }

        public IDrawingListController Controller
        {
            get
            {
                return _controller;
            }
            set
            {
                _controller = value;
                btnRefresh.Enabled = _controller != null;
                btnAdd.Enabled = _controller != null;
                btnAddChild.Enabled = _controller != null;
                btnDelete.Enabled = _controller != null;

                //btnCopy.Enabled = _controller != null;
                //btnPaste.Enabled = _controller != null;
                //btnPaste.Enabled = _controller != null;
                btnShowAnotherView.Enabled = _controller != null;

                if (_controller != null)
                {
                    DrawingCountChanged += _controller.ChangeDrawingCount;
                    DrawingWeightChanged += _controller.ChangeDrawingWeight;
                }

            }
        }

        public int? ParentId
        {
            get { return _parentId; }
            set
            {
                _parentId = value;
                tlDarwings.RootValue = _parentId;
            }
        }

        public TreeListDrawingsControl()
        {
            InitializeComponent();
        }

        public TreeListDrawingsControl(IDrawingListController controller)
        {
            Controller = controller;
            Controller.DataRefreshed += RefreshData;
            InitializeComponent();

            SetVisibleLevelsLine();
        }

        public override void Refresh()
        {
            RefreshData(this, new EventArgs());
            base.Refresh();
        }

        private void SetVisibleLevelsLine()
        {
            var skin = GridSkins.GetSkin(tlDarwings.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            tlDarwings.LookAndFeel.UpdateStyleSettings();
        }

        private void RefreshData(object sender, EventArgs e)
        {
            tlDarwings.BeginUpdate();
            var state = SaveNodeStates(tlDarwings.Nodes).ToList();
            var slctdNode = tlDarwings.Selection[0];
            Drawing data = null;
            if (slctdNode != null)
            {
                data = (Drawing)tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            }

            tlDarwings.DataSource = Controller.GetDrawingsList();
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

        #region Работа с состоянием нод tlDrawings

        private void ExpandToParentNode(TreeListNode node)
        {
            if (node.ParentNode != null)
            {
                node.ParentNode.Expanded = true;
                ExpandToParentNode(node.ParentNode);
            }
        }

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var listId = SaveNodeStates(tlDarwings.Nodes).ToList();
            RefreshData(this, null);
            LoadNodesState(listId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            if (data is Drawing)
            {
                var draw = data as Drawing;
                Controller.Save(Controller.CreateDocument(draw.ParentId));
            }
            else
            {
                Controller.Save(Controller.CreateDocument(_parentId));
            }
            tlDarwings.Focus();
            tlDarwings.RefreshDataSource();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            if (data != null)
            {
                var parentDrw = (Drawing)data;
                var newDoc = Controller.CreateDocument(parentDrw.Id);
                Controller.Save(newDoc);
                tlDarwings.RefreshDataSource();
            }

            tlDarwings.Selection[0].Expanded = true;
            tlDarwings.Focus();
        }

        private void btnShowAnotherView_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            var drawing = data as Drawing;
            if (drawing != null)
                Controller.ShowDrawingInAnotherView(drawing);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            Controller.Delete((Drawing)data);
            tlDarwings.RefreshDataSource();
        }

        private void tlDarwings_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(e.Node);

            if (!(data is Drawing))
                return;

            if (e.Column.FieldName == "Count")
            {
                OnDrawingCountChanged((Drawing)data);
                return;
            }

            if (e.Column.FieldName == "Weight")
            {
                OnDrawingWeightChanged((Drawing)data);
                return;
            }

            Controller.Save((Drawing)data);
        }

        public delegate void DrawingChangeEventHandler(Drawing drawing);

        protected virtual void OnDrawingWeightChanged(Drawing arg)
        {
            DrawingWeightChanged?.Invoke(arg);
        }

        protected virtual void OnDrawingCountChanged(Drawing drawing)
        {
            DrawingCountChanged?.Invoke(drawing);
        }

        private void sbCreateStandart_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            var drawing = data as Drawing;
            if (drawing != null)
                _controller.CreateStandartByDrawing(drawing);
        }

        private void sbShowInTable_Click(object sender, EventArgs e)
        {
            _controller.ShowDrawingInGridView(_parentId);
        }
    }

}