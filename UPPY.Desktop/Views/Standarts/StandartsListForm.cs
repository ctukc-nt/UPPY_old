using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Controllers.Standarts;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class StandartsListForm : Form
    {
        private readonly IStandartsListController _controller;

        public StandartsListForm(IStandartsListController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void StandartsListForm_Load(object sender, EventArgs e)
        {
            gcStandarts.DataSource = _controller.GetStandartsList();
        }
    }
}
