using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Forms;
using DesktopApp.Interfaces;
using DesktopApp.Ninject;

namespace DesktopApp
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
            Application.Run(new DrawingsListForm(CompositionRoot.Resolve<IController<Drawing>>()));
        }
    }
}
