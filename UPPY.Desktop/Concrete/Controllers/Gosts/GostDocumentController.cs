using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Gosts;
using UPPY.Desktop.Views.Gosts;

namespace UPPY.Desktop.Concrete.Controllers.Gosts
{
    public class GostDocumentController : IGostDocumentController, IDocumentController<Gost>
    {
        public bool ShowViewDialog()
        {
            var form = new GostForm(this);
            form.Document = Document;
            return form.ShowDialog() == DialogResult.OK;
        }

        public Gost Document { get; set; }
    }
}