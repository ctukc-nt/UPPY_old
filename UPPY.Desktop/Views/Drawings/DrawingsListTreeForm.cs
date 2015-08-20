using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.Skins;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class DrawingsListTreeForm : Form
    {
        private readonly IDrawingListController _controller = null;

        public DrawingsListTreeForm(IDrawingListController controller)
        {
            _controller = controller;
            InitializeComponent();
            treeListDrawingsControl1.Controller = _controller;


        }

       
    }
}