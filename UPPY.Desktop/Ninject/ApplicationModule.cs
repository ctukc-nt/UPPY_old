using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Controllers;
using DesktopApp.Infrastructure;
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
            var connection = new MongoDbConnection();
            Bind(typeof(IMongoDatabase)).ToConstant(connection.Database);
            Bind(typeof(IDataManagersFactory)).To(typeof(UppyFakeDataManagersFactory));

            //Bind(typeof(IClassDataManager<Drawing>)).To(typeof(DrawingListClassFakeDataManager));
            //Bind(typeof(IClassDataManager<TechRoute>)).To(typeof(TechRoutesClassFakeDataManager));
            //Bind(typeof(IClassDataManager<Standart>)).To(typeof(StandartClassFakeDataManager));

            Bind(typeof(IControllerFactory)).To(typeof(ControllersFactory));

            //Bind(typeof(IController<Drawing>)).To(typeof(DrawingController));
            //Bind(typeof(IController<HierarchyNumberDrawing>)).To(typeof(HierarchyNumberDrawingController));
            //Bind(typeof(IController<Standart>)).To(typeof(StandartController));

            Bind(typeof(IFormsBuilder)).To(typeof(FormsBuilder));

            Bind(typeof (IController<TechOperation>)).To(typeof (Controller<TechOperation>));
            Bind(typeof (IController<TechRoute>)).To(typeof (Controller<TechRoute>));



        }
    }
}