using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IDrawingListController
    {
        List<Drawing> GetDrawingsList();
        Drawing CreateDocument();
        void Save(Drawing document);
        void Delete(Drawing document);
        List<TechRoute> GetTechRoutes();
        void ShowTechRoutesList();

        event EventHandler<EventArgs> DataRefreshed;
    }
}