

using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Ninject;
using UPPY.Desktop.Views.Drawings;
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
            var contr = CompositionRoot.Resolve<IUppyControllersFactory>();
            contr.GetListController<Drawing>().ShowViewDialog();
            //Application.Run(new DrawingsListTreeForm();
        }
    }
}
