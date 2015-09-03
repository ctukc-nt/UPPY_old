using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IUppyControllersFactory : IControllersFactory
    {
        IDrawingListController GetDrawingsListController(int? parentId);
        IDrawingListController GetDrawingsListController();
        IListDocumentController GetDrawingsViewController(int? parentId);
        IListDocumentController GetDrawingsViewController();
        IOrderListController GetOrdersListController();
        IDrawingBulkChangesHelper GetDrawingBulkChangesHelper();
        IDrawingsToStandartShower GetDrawingsToStandartController();
    }
}