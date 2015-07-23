using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.Interfaces;
using Ninject;
using _1CToMongoTransfer.Ninject;

namespace _1CToMongoTransfer
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
            Application.Run(new Form1(CompositionRoot.Resolve<IDataManagerFactory>()));
        }
    }
}
