using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Controllers.Common;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class DrawingToStandartForm : Form
    {
        private IDrawingsToStandartController _controller;

        public DrawingToStandartForm(IDrawingsToStandartController controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}
