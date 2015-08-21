using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.TechRoutes
{
    public interface ITechRouteListController
    {
        event EventHandler<EventArgs> DataRefreshed;
        List<TechRoute> GetData();
        TechRoute CreateDocument();
        void Save(TechRoute document);
        void Delete(TechRoute document);
        void EditDocument(TechRoute document);
    }
}