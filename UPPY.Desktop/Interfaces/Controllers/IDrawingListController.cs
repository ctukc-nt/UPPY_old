using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IDrawingListController
    {
        List<Drawing> GetData();
        Drawing CreateDocument();
        void Save(Drawing document);
        void Delete(Drawing document);
        List<TechRoute> GetTechRoutes();
        bool ShowView();
        void ShowTechRoutesListToSelect();
        event EventHandler<EventArgs> DataRefreshed;
    }
}