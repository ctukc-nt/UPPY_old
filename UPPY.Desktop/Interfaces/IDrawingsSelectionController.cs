using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces
{
    public interface IDrawingsSelectionController
    {
        List<Drawing> GetDrawingsList();
        List<TechRoute> GetTechRoutes();
        event EventHandler<EventArgs> DataRefreshed;
    }
}