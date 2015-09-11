using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Common;

namespace UPPY.Desktop.Views
{
    public partial class MainForm : Form
    {
        private readonly IUppyControllersFactory _factory;

        public MainForm(IUppyControllersFactory factory)
        {
            _factory = factory;
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var ordersController = _factory.GetListController<Order>();
            ordersController.ShowViewDialog();
        }

        private void btnStandarts_Click(object sender, EventArgs e)
        {
            var ordersController = _factory.GetListController<Standart>();
            ordersController.ShowViewDialog();
        }
    }
}
