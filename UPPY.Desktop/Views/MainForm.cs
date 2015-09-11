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
            var controller = _factory.GetListController<Order>();
            controller.ShowViewDialog();
        }

        private void btnStandarts_Click(object sender, EventArgs e)
        {
            var controller = _factory.GetListController<Standart>();
            controller.ShowViewDialog();
        }

        private void btnGosts_Click(object sender, EventArgs e)
        {
            var controller = _factory.GetListController<Gost>();
            controller.ShowViewDialog();
        }

        private void btnTechOpers_Click(object sender, EventArgs e)
        {
            var controller = _factory.GetListController<TechOperation>();
            controller.ShowViewDialog();
        }

        private void btnTechRoutes_Click(object sender, EventArgs e)
        {
            var controller = _factory.GetListController<TechRoute>();
            controller.ShowViewDialog();
        }
    }
}
