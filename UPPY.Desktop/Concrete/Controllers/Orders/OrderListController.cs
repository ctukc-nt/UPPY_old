using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Views.Orders;

namespace UPPY.Desktop.Concrete.Controllers.Orders
{
    public class OrderListController : IOrderListController, IListViewController
    {
        private readonly IClassDataManager<Order> _orderDataManager;
        private readonly IClassDataManager<Drawing> _drawingDataManager;
        private readonly IUppyControllersFactory _factory;

        public OrderListController(IUppyControllersFactory factory, IClassDataManager<Order> orderDataManager,  IClassDataManager<Drawing> drawingDataManager)
        {
            _orderDataManager = orderDataManager;
            _drawingDataManager = drawingDataManager;
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
            if (order.DrawingId == null)
            {
                var drawing = new Drawing();
                _drawingDataManager.Insert(drawing);
                order.DrawingId = drawing.Id;
            }

            _orderDataManager.InsertOrUpdate(order);
        }

        public Order CreateDocument()
        {
            return new Order() {DateStart = DateTime.Now, DeadlineDate = DateTime.Now, IsClosed = false};
        }

        public void Delete(Order order)
        {
           _orderDataManager.Delete(order);
        }

        public void ShowViewDialog()
        {
            OrdersListForm form = new OrdersListForm(this);
            form.ShowDialog();
        }
    }
}