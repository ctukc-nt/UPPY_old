using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IUppyControllersFactory : IControllersFactory
    {
        IDrawingListController GetDrawingsListController(int? parentId);

        IListDocumentController GetDrawingsViewController(int? parentId);

        IOrderListController GetOrdersListController();
    }
}