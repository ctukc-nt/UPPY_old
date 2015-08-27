using System;
using Core.DomainModel;
using UPPY.Desktop.Concrete.Controllers.Drawings;
using UPPY.Desktop.Concrete.Controllers.Orders;
using UPPY.Desktop.Concrete.Controllers.TechRoutes;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Interfaces.DataManagers;

namespace UPPY.Desktop.Factorys
{
    internal class UppyControllersFactory : IUppyControllersFactory
    {
        private readonly IUppyDataManagersFactory _dataManagersFactory;

        public UppyControllersFactory(IUppyDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }

        public IListDocumentController GetListController<T>()
        {
            if (typeof (T) == typeof (Drawing))
                return new DrawingsListDocumentController(_dataManagersFactory.GetDataManager<Drawing>(), _dataManagersFactory.GetDataManager<TechRoute>(), this);

            if (typeof(T) == typeof(TechRoute))
                return new TechRouteListController(_dataManagersFactory, this);

            if (typeof(T) == typeof(TechRoute))
                return new TechRouteListController(_dataManagersFactory, this);

            return null;
        }

        public IDocumentController<T> GetDocumentController<T>()
        {
            throw new NotImplementedException();
        }

        public ISelectionController<T> GetDocumentSelectionController<T>()
        {
            if (typeof (T) == typeof (Drawing))
                return (ISelectionController<T>)new DrawingsSelectionController(_dataManagersFactory, this);

            throw new NotImplementedException();
        }

        public IListDocumentController GetStartController()
        {
            return new DrawingsListDocumentController(_dataManagersFactory.GetDataManager<Drawing>(), _dataManagersFactory.GetDataManager<TechRoute>(), this);
        }

        public IDrawingListController GetDrawingsListController(int? parentId)
        {
            return new DrawingsListDocumentController(_dataManagersFactory.GetFilteredDrawingsByParent(parentId), _dataManagersFactory.GetDataManager<TechRoute>(), this);
        }

        public IListDocumentController GetDrawingsViewController(int? parentId)
        {
            return new DrawingsListDocumentController(_dataManagersFactory.GetFilteredDrawingsByParent(parentId), _dataManagersFactory.GetDataManager<TechRoute>(), this);
        }

        public IOrderListController GetOrdersListController()
        {
            return new OrderListController(_dataManagersFactory.GetDataManager<Order>(), this);
        }
    }
}