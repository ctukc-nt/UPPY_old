using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.TechOpers
{
    public interface ITechOpersListController
    {
        List<TechOperation> GetTechOperationsList();
        TechOperation CreateDocument();
        void Save(TechOperation document);
        void Delete(TechOperation doc);
    }
}