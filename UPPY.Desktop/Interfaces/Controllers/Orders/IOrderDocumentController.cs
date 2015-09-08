
using System;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Interfaces.Controllers.Orders
{
    /// <summary>
    /// Интерфейс контроллера редактора заказа
    /// </summary>
    public interface IOrderDocumentController
    {
        Order Document { get; set; }

        void Save(Order order);

        event EventHandler<EventArgs> DataRefreshed;
        IDrawingListController GetDrawingsController(int? drawingId);
        IDrawingListController InitNewDrawingAndGetController();
        bool LoadDataFromSiemens();
    }
}