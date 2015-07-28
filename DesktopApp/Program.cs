using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Forms;
using DesktopApp.Interfaces;
using DesktopApp.Ninject;
using DesktopApp.View;

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
            AutoMapper.Mapper.CreateMap<Drawing, HierarchyNumberDrawing>();
            CompositionRoot.Wire(new ApplicationModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<TechOperationsListForm>());
        }
    }
}
