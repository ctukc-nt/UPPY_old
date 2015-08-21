using System;
using System.Collections.Generic;
using Core.DomainModel;
using UPPY.Desktop.Classes;

namespace UPPY.Desktop.Interfaces.Controllers.Drawings
{
    public interface IHierarchyNumberDrawingController
    {
        List<HierarchyNumberDrawing> GetData();

        event EventHandler DataRefreshed;
        HierarchyNumberDrawing CreateDocument();
        void Save(HierarchyNumberDrawing document);
        void Delete(HierarchyNumberDrawing document);
        void EditDocument(HierarchyNumberDrawing document);
        List<TechRoute> GetTechRoutes();
    }
}