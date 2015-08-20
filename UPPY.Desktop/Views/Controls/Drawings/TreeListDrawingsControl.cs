using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.Skins;
using DevExpress.XtraTreeList.Nodes;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Controls.Drawings
{
    public partial class TreeListDrawingsControl : UserControl
    {
        private readonly IDrawingListController _controller;

        public TreeListDrawingsControl()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);

            if (DesignMode || designMode)
            {
                InitializeComponent();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public TreeListDrawingsControl(IDrawingListController controller)
        {
            _controller = controller;
            _controller.DataRefreshed += RefreshData;
            InitializeComponent();

            SetVisibleLevelsLine();
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
                data = (Drawing) tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            }

            tlDarwings.DataSource = _controller.GetDrawingsList();
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

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var listId = SaveNodeStates(tlDarwings.Nodes).ToList();
            RefreshData(this, null);
            LoadNodesState(listId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.Save(_controller.CreateDocument());
            tlDarwings.Focus();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
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

        private void btnShowAnotherView_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            var drawing = data as Drawing;
            if (drawing != null)
                _controller.ShowDrawingInAnotherView(drawing);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = tlDarwings.GetDataRecordByNode(tlDarwings.Selection[0]);
            _controller.Delete((Drawing)data);
            tlDarwings.RefreshDataSource();
        }
    }
}