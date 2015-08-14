using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IOrderDocumentController
    {
        IDrawingListController DrawingListController { get; set; }

    }
}