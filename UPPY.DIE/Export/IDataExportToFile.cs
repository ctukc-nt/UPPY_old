using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.DIE.Export
{
    public interface IDataExportToFile
    {
        void CreatePassportProjectToFile(Order order, List<HierarchyNumberDrawing> list, string fileName);
        void CreatePassportProjectToFile(Order order, List<HierarchyNumberDrawing> list, List<TechOperation> techOperations, List<TechRoute> techRoutes, string fileName);
        void CreateReportClearWeights(Standart standart, string fileName);
    }
}