using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IUppyControllersFactory : IControllersFactory
    {
        IListViewController GetViewListController<T>(int? id);
        IDrawingListController GetDrawingsListController(int? parentId);
        IDrawingListController GetDrawingsListController();
        IOrderListController GetOrdersListController();
        IDrawingBulkChangesHelper GetDrawingBulkChangesHelper();
        IDrawingsToStandartShower GetDrawingsToStandartController();
        IListViewController GetDrawingsGridViewController(int? parentId);
        IUppyDataImport GetSiemensLoaderController(int? parentId);
    }
}