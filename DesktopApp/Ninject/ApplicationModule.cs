using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Controllers;
using DesktopApp.Interfaces;
using DesktopApp.Temp;
using DesktopApp.View;
using MongoDB.Driver;
using MongoWork;
using Ninject.Modules;

namespace DesktopApp.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IController<Drawing>)).To(typeof(DrawingController));
            Bind(typeof(IController<HierarchyNumberDrawing>)).To(typeof(HierarchyNumberDrawingController));
            Bind(typeof(IClassDataManager<Drawing>)).To(typeof(ListClassDataManager));
            Bind(typeof(IClassDataManager<TechRoute>)).To(typeof(TechRoutesClassDataManager));
        }
    }
}
