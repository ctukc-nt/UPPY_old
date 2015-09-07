using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
