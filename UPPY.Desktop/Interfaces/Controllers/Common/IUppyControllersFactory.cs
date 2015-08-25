using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Drawings;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IUppyControllersFactory : IControllersFactory
    {
        IDrawingListController GetDrawingsListController(int? parentId);

        IListDocumentController GetDrawingsViewController(int? parentId);

    }
}