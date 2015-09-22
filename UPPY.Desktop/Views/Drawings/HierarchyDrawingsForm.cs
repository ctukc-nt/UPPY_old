using System;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class HierarchyDrawingsForm : Form
    {
        public HierarchyDrawingsForm(IHierarchyNumberDrawingController controller)
        {
            InitializeComponent();
            hierarListDrawingsControl.Controller = controller;
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