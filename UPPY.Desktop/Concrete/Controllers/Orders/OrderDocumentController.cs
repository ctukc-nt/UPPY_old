using System;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Interfaces.DataManagers;
using UPPY.Desktop.Views.Orders;

namespace UPPY.Desktop.Concrete.Controllers.Orders
{
    class OrderDocumentController : IOrderDocumentController, IDocumentController<Order>
    {
        private readonly IUppyControllersFactory _factory;
        private readonly IUppyDataManagersFactory _dataManagersFactory;

        public OrderDocumentController(IUppyControllersFactory factory, IUppyDataManagersFactory dataManagersFactory)
        {
            _factory = factory;
            _dataManagersFactory = dataManagersFactory;
        }

        public void Save(Order order)
        {

        }

        public event EventHandler<EventArgs> DataRefreshed;


        public IDrawingListController GetDrawingsController(int? drawingId)
        {
            return _factory.GetDrawingsListController(drawingId);
        }

        public IDrawingListController InitNewDrawingAndGetController()
        {
            var drawing = new Drawing();
            var drawingDataManager = _dataManagersFactory.GetDataManager<Drawing>();
            drawingDataManager.Insert(drawing);
            var drawingsController = _factory.GetDrawingsListController(drawing.Id);
            Document.DrawingId = drawing.Id;
            return drawingsController;
        }

        public Order Document { get; set; }

        public bool ShowViewDialog()
        {
            var orderForm = new OrderForm(this);
            orderForm.Document = Document;
            orderForm.ShowDialog();
            return true;
        }
    }
}
