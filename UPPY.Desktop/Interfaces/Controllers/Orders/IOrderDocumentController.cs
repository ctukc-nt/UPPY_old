

using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Interfaces.Controllers.Orders
{
    public interface IOrderDocumentController
    {
        IDrawingListController DrawingListController { get; set; }

    }
}