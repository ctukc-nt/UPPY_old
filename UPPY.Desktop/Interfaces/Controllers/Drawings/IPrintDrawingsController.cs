using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Drawings
{
    public interface IPrintDrawingsController
    {
        void PrintPassportWithTechOeprs(int? headDrawingId);

        void PrintPassportWithoutTechOeprs(int? headDrawingId);

        void PrintSomeDrawings(List<Drawing> drawings);

        void PrintSomeDrawingsWithTechOpers(List<Drawing> drawings);

        void PrintSomeDrawings(List<HierarchyNumberDrawing> drawings);

        void PrintSomeDrawingsWithTechOpers(List<HierarchyNumberDrawing> drawings);

        void PrintClearWeigths(int? headDrawingId);
    }
}