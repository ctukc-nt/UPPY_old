using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.DIE.Export
{
    public interface IDataExportToFile
    {
        void CreatePassportProjectToFile(HierarchyNumberDrawing masterDrawing, List<HierarchyNumberDrawing> list, string fileName);
        void CreatePassportProjectToFile(HierarchyNumberDrawing masterDrawing, List<HierarchyNumberDrawing> list, List<TechOperation> techOperations, List<TechRoute> techRoutes, string fileName);
        void CreateReportClearWeights(Standart standart, string fileName);
    }
}