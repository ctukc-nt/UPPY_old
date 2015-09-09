using System;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class HierarchyDrawingsForm : Form
    {
        private readonly IHierarchyNumberDrawingController _controller;

        public HierarchyDrawingsForm(IHierarchyNumberDrawingController controller)
        {
            _controller = controller;
            InitializeComponent();
            hierarListDrawingsControl.Controller = _controller;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HierarchyDrawingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            hierarListDrawingsControl.SaveAllTechRoutes();
        }

        private void HierarchyDrawingsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}