using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Drawings
{
    public interface IDrawingListController
    {
        List<Drawing> GetDrawingsList();
        Drawing CreateDocument(int? parentId);
        void Save(Drawing document);
        void Delete(Drawing document);
        List<TechRoute> GetTechRoutes();
        void ShowTechRoutesList();
        void CreateStandartByDrawing(Drawing drawing);
        event EventHandler<EventArgs> DataRefreshed;
        void ShowDrawingInAnotherView(Drawing drawing);
        void ChangeDrawingCount(Drawing drawing);
        void ChangeDrawingWeight(Drawing drawing);
        void ShowDrawingInGridView(int? drawingId);
        string GetCopy(int drawingId);
        void InsertIntoDrawing(int? drawingId, string base64Xml);
        void ShowFilesViewer(Drawing drawing);
    }
}