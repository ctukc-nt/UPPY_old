using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IUppyControllersFactory : IControllersFactory
    {
        IListDocumentController GetDrawingController(int? parentId);

    }
}