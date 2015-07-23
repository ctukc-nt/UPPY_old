using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Controllers;
using DesktopApp.Interfaces;
using DesktopApp.Temp;
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
            Bind(typeof(IClassDataManager<Drawing>)).To(typeof(ListClassDataManager));
        }
    }
}
