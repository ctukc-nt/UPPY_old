using System;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Drawings;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Views.Orders;

namespace UPPY.Desktop.Concrete.Controllers.Orders
{
    class OrderDocumentController : IOrderDocumentController, IDocumentController<Order>
    {
        private readonly IUppyControllersFactory _controllersFactory;
        private readonly IClassDataManager<Drawing> _drawingDataManager;

        public OrderDocumentController(IUppyControllersFactory controllersFactory, IClassDataManager<Drawing> drawingDataManager)
        {
            _controllersFactory = controllersFactory;
            _drawingDataManager = drawingDataManager;
        }

        public void Save(Order order)
        {

        }

        public event EventHandler<EventArgs> DataRefreshed;


        public IDrawingListController GetDrawingsController(int? drawingId)
        {
            return _controllersFactory.GetDrawingsListController(drawingId);
        }

        public IDrawingListController InitNewDrawingAndGetController()
        {
            var drawing = new Drawing();
            _drawingDataManager.Insert(drawing);
            var drawingsController = _controllersFactory.GetDrawingsListController(drawing.Id);
            Document.DrawingId = drawing.Id;
            return drawingsController;
        }

        public bool LoadDataFromSiemens()
        {
            var doc = _drawingDataManager.GetDocument(Document.DrawingId);
            _drawingDataManager.Delete(doc);

            var drawing = new Drawing();
            _drawingDataManager.Insert(drawing);
            Document.DrawingId = drawing.Id;

            var loader = _controllersFactory.GetSiemensLoaderController(Document.DrawingId);
            return loader.ImportData();
        }

        public Order Document { get; set; }

        public bool ShowViewDialog()
        {
            var orderForm = new OrderForm(this) {Document = Document};
            orderForm.ShowDialog();
            return true;
        }
    }
}
