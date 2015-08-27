using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Concrete.Controllers.Orders
{
    public class OrderListController : IOrderListController
    {
        private readonly IClassDataManager<Order> _orderDataManager;
        private readonly IUppyControllersFactory _factory;

        public OrderListController(IClassDataManager<Order> orderDataManager, IUppyControllersFactory factory)
        {
            _orderDataManager = orderDataManager;
            _factory = factory;
        }

        public List<Order> GetOrdersList()
        {
            return _orderDataManager.GetListCollection();
        }

        public void EditDocument(Order order)
        {
            if (order != null)
            {
                var docOrderController = _factory.GetDocumentController<Order>();
                docOrderController.Document = order;
                docOrderController.ShowViewDialog();
            }
        }

        public void Save(Order order)
        {
            _orderDataManager.InsertOrUpdate(order);
        }

        public Order CreateDocument()
        {
            return new Order();
        }

        public void Delete(Order order)
        {
           _orderDataManager.Delete(order);
        }
    }
}