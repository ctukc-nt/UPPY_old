﻿using Core.DomainModel;
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
            Bind(typeof (IMongoDatabase)).ToConstant(connection.Database);
            Bind(typeof(IDataManagerFactory)).To(typeof(UppyDataManagerFactory));

            //Bind(typeof(IClassDataManager<Drawing>)).To(typeof(DrawingListClassDataManager));
            //Bind(typeof(IClassDataManager<TechRoute>)).To(typeof(TechRoutesClassDataManager));
            //Bind(typeof(IClassDataManager<Standart>)).To(typeof(StandartClassDataManager));

            Bind(typeof (IControllerFactory)).To(typeof (ControllersFactory));

            //Bind(typeof(IController<Drawing>)).To(typeof(DrawingController));
            //Bind(typeof(IController<HierarchyNumberDrawing>)).To(typeof(HierarchyNumberDrawingController));
            //Bind(typeof(IController<Standart>)).To(typeof(StandartController));

            Bind(typeof (IFormsBuilder)).To(typeof (ControllersFactory));



        }
    }
}