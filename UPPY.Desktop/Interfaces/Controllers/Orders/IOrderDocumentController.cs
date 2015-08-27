
using System;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Orders
{
    /// <summary>
    /// Интерфейс контроллера редактора заказа
    /// </summary>
    public interface IOrderDocumentController
    {
        Order Order { get; set; }

        void Save(Order order);

        event EventHandler<EventArgs> DataRefreshed;
    }
}