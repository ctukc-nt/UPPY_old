using System;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Concrete.Controllers.Orders
{
    class OrderDocumentController : IOrderDocumentController
    {
        public Order Order { get; set; }

        public void Save(Order order)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> DataRefreshed;
    }
}
