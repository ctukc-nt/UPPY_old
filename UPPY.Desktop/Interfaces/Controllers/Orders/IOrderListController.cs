using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Orders
{
    public interface IOrderListController
    {
        event EventHandler<EventArgs> DataRefreshed;
        List<Order> GetOrdersList();
        void EditDocument(Order order);
        void Save(Order order);
        Order CreateDocument();
        void Delete(Order order);
    }
}