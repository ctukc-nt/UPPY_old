﻿using System;
using Core.DomainModel;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Concrete.Controllers.Common;
using UPPY.Desktop.Concrete.Controllers.Drawings;
using UPPY.Desktop.Concrete.Controllers.Gosts;
using UPPY.Desktop.Concrete.Controllers.Orders;
using UPPY.Desktop.Concrete.Controllers.Standarts;
using UPPY.Desktop.Concrete.Controllers.TechOpers;
using UPPY.Desktop.Concrete.Controllers.TechRoutes;
using UPPY.Desktop.Interfaces.Common;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Interfaces.DataManagers;
using UPPY.DIE.Export;
using UPPY.Files;

namespace UPPY.Desktop.Factorys
{
    internal class UppyControllersFactory : IUppyControllersFactory
    {
        private readonly IUppyDataManagersFactory _dataManagersFactory;

        public UppyControllersFactory(IUppyDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }

        public IListViewController GetListController<T>()
        {
            if (typeof(T) == typeof(Drawing))
                return new DrawingsListViewController(_dataManagersFactory.GetDataManager<Drawing>(), _dataManagersFactory.GetDataManager<TechRoute>(), this);

            if (typeof(T) == typeof(TechRoute))
                return new TechRouteListController(this, _dataManagersFactory.GetDataManager<TechRoute>());

            if (typeof(T) == typeof(Order))
                return new OrderListController(this, _dataManagersFactory.GetDataManager<Order>(), _dataManagersFactory.GetDataManager<Drawing>());

            if (typeof(T) == typeof(Standart))
                return new StandartsListController(this, _dataManagersFactory.GetDataManager<Standart>());

            if (typeof(T) == typeof(TechOperation))
                return new TechOpersListController(_dataManagersFactory.GetDataManager<TechOperation>());

            if (typeof (T) == typeof (Gost))
                return new GostListController(this, _dataManagersFactory.GetDataManager<Gost>());

            return null;
        }

        public IDocumentController<T> GetDocumentController<T>()
        {
            if (typeof(T) == typeof(Order))
                return (IDocumentController<T>)new OrderDocumentController(this, _dataManagersFactory.GetDataManager<Drawing>());

            if (typeof(T) == typeof(Drawing))
                return (IDocumentController<T>)new DrawingDocumentController(this);

            if (typeof(T) == typeof(Standart))
                return (IDocumentController<T>)new StandartDocumentController();

            if (typeof(T) == typeof(TechRoute))
                return (IDocumentController<T>)new TechRouteDocumentController(this, _dataManagersFactory);

            return null;
        }

        public ISelectionController<T> GetDocumentSelectionController<T>()
        {
            if (typeof(T) == typeof(Drawing))
                return (ISelectionController<T>)new DrawingsSelectionController(this, _dataManagersFactory);

            throw new NotImplementedException();
        }

        public IListViewController GetStartController()
        {
            return new DrawingsListViewController(_dataManagersFactory.GetDataManager<Drawing>(), _dataManagersFactory.GetDataManager<TechRoute>(), this);
        }

        public IListViewController GetViewListController<T>(int? id)
        {
            throw new NotImplementedException();
        }

        public IDrawingListController GetDrawingsListController(int? parentId)
        {
            return new DrawingsListViewController(_dataManagersFactory.GetFilteredDrawingsByParent(parentId), _dataManagersFactory.GetDataManager<TechRoute>(), this);
        }

        public IDrawingListController GetDrawingsListController()
        {
            throw new NotImplementedException();
        }

        public IOrderListController GetOrdersListController()
        {
            return new OrderListController(this, _dataManagersFactory.GetDataManager<Order>(), _dataManagersFactory.GetDataManager<Drawing>());
        }

        public IDrawingBulkChangesHelper GetDrawingBulkChangesHelper()
        {
            return new DrawingBulkChangesHelper(_dataManagersFactory);
        }

        public IDrawingsToStandartShower GetDrawingsToStandartController()
        {
            return new DrawingsToStandartController(_dataManagersFactory);
        }

        public IListViewController GetDrawingsGridViewController(int? parentId)
        {
            return new HierarchyNumberDrawingController(_dataManagersFactory.GetFilteredDrawingsByParent(parentId),
                _dataManagersFactory.GetDataManager<TechRoute>(), _dataManagersFactory.GetDataManager<TechOperation>())
            { ParentId = parentId };
        }

        public IUppyDataImport GetSiemensLoaderController(int? parentId)
        {
            return new SiemensDataAndFilesImportController(_dataManagersFactory.GetDataManager<Drawing>(), new SimpleFilesLoaderToRepository(new FilesRepository()) ,parentId);
        }

        public IPrintDrawingsController GetPrinDrawingsController()
        {
            return new PrintDrawingsController(this, _dataManagersFactory, new ExportExcelFile());
        }
    }
}