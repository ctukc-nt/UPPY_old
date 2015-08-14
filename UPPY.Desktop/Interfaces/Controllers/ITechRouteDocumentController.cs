using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface ITechRouteDocumentController
    {
        List<TechOperation> GetDataTechOperations();
    }
}