

using System;
using System.Windows.Forms;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Ninject;
using UPPY.Desktop.Views.Orders;

namespace UPPY.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var controllersFactory = CompositionRoot.Resolve<IControllersFactory>();
            Application.Run(new OrderForm(CompositionRoot.Resolve<IOrderDocumentController>()));
        }
    }
}
