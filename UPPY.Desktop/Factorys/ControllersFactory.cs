using System;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Controllers;
using UPPY.Desktop.Controllers.Drawings;
using UPPY.Desktop.Controllers.TechRoutes;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Ninject;

namespace UPPY.Desktop.Factorys
{
    internal class ControllersFactory : IControllersFactory
    {

        private static ControllersFactory _instance;

        private ControllersFactory()
        {
            
        }

        public static ControllersFactory Instance
        {
            get
            {
                return _instance ?? (_instance = new ControllersFactory());
            }
        }


        public IListDocumentController GetListController<T>()
        {
            if (typeof (T) == typeof (Drawing))
                return new DrawingsListDocumentController(CompositionRoot.Resolve<IDataManagersFactory>(), this);

            if (typeof(T) == typeof(TechRoute))
                return new TechRouteListController(CompositionRoot.Resolve<IDataManagersFactory>(), this);

            if (typeof(T) == typeof(TechRoute))
                return new TechRouteListController(CompositionRoot.Resolve<IDataManagersFactory>(), this);

            return null;
        }

        public IDocumentController<T> GetDocumentController<T>()
        {
            throw new NotImplementedException();
        }

        public ISelectionController<T> GetDocumentSelectionController<T>()
        {
            if (typeof (T) == typeof (Drawing))
                return (ISelectionController<T>) new DrawingsSelectionController(CompositionRoot.Resolve<IDataManagersFactory>(), this);

            throw new NotImplementedException();
        }

        public IListDocumentController GetStartController()
        {
            return new DrawingsListDocumentController(CompositionRoot.Resolve<IDataManagersFactory>(), this);
        }
    }
}