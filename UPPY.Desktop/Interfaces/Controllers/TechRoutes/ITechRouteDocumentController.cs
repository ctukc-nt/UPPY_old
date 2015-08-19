using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.TechRoutes
{
    public interface ITechRouteDocumentController
    {
        List<TechOperation> GetDataTechOperations();
    }
}