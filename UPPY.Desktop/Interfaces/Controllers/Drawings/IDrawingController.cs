using System;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Drawings
{
    /// <summary>
    /// Интерфейс контроллера редактора чертежа
    /// </summary>
    public interface IDrawingController
    {
        Drawing Document { get; set; }

        void Save();

        event EventHandler<EventArgs> DataRefreshed;
    }
}