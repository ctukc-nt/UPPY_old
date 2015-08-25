﻿using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Drawings
{
    public interface IDrawingListController
    {
        List<Drawing> GetDrawingsList();
        Drawing CreateDocument();
        void Save(Drawing document);
        void Delete(Drawing document);
        List<TechRoute> GetTechRoutes();
        void ShowTechRoutesList();
        void CreateStandartByDrawing();

        event EventHandler<EventArgs> DataRefreshed;
        void ShowDrawingInAnotherView(Drawing drawing);
    }
}