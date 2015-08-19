using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Drawings
{
    public interface IDrawingsSelectionController
    {
        List<Drawing> GetDrawingsList();
        List<TechRoute> GetTechRoutes();
        event EventHandler<EventArgs> DataRefreshed;
    }
}