using System;
using System.Drawing;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Ninject;
using UPPY.Desktop.Views.Drawings;

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
            var controllersFactory = CompositionRoot.Resolve<IControllersFactory>();
            var contr = CompositionRoot.Resolve<IUppyControllersFactory>();
            var drawContr = CompositionRoot.Resolve<IUppyControllersFactory>().GetDrawingsListController(null);
            //contr.GetListController<Drawing>().ShowViewDialog();
            var form = new DrawingForm(drawContr);
            form.Drawing = new Drawing
            {
                Length = 1,
                Color = Color.Azure,
                Count = 2,
                CountAll = 3,
                Designation = "4",
                NumberOnSpec = 5,
                Weight = 6,
                PartOfDrawingId = 7,
                Width = 8,
                WeightAll = 9,
                Name = "10",
                GostOnSort = "11",
                StandartSize = "12",
                GostOnMaterial = "13",
                TechRouteId = 14,
                OP = "15",
                Profile = "16",
                MarkSteal = "17",
                Id = 18,
                ParentId = 19
            };

            Application.Run(form);
        }
    }
}