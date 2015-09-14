using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Gosts;

namespace UPPY.Desktop.Concrete.Controllers.Gosts
{
    public class GostDocumentController : IGostDocumentController, IDocumentController<Gost>
    {
        public Gost Document { get; set; }
        public bool ShowViewDialog()
        {
            throw new System.NotImplementedException();
        }
    }
}