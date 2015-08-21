using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Concrete.Controllers.Orders
{
    class OrderDocumentController : IOrderDocumentController
    {



        public IDrawingListController DrawingListController
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}
