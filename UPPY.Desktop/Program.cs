using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Ninject;
using UPPY.Desktop.Views.Orders;

namespace UPPY.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var uppyFactory = CompositionRoot.Resolve<IUppyControllersFactory>();
            var controller = uppyFactory.GetOrdersListController();

            var formOrders = new OrdersListForm(controller);

            Application.Run(formOrders);
        }
    }
}