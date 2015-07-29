using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Ninject;
using UPPY.Desktop.Views;

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
            var form = new TechRoutesListForm(CompositionRoot.Resolve<IControllerList<TechRoute>>());
            Application.Run(form);
        }
    }
}
