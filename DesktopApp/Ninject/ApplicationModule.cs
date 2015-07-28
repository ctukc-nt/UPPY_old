using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Controllers;
using DesktopApp.Interfaces;
using DesktopApp.Temp;
using DesktopApp.View;
using Ninject.Modules;

namespace DesktopApp.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IController<Drawing>)).To(typeof(DrawingController));
            Bind(typeof(IController<HierarchyNumberDrawing>)).To(typeof(HierarchyNumberDrawingController));
            Bind(typeof(IController<Standart>)).To(typeof(StandartController));
            Bind(typeof(IClassDataManager<Drawing>)).To(typeof(DrawingClassDataManager));
            Bind(typeof(IClassDataManager<TechRoute>)).To(typeof(TechRoutesClassDataManager));
            Bind(typeof(IClassDataManager<Standart>)).To(typeof(StandartClassDataManager));
        }
    }
}
