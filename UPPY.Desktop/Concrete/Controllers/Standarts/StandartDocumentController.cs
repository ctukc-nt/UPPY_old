using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Standarts;
using UPPY.Desktop.Views.Standarts;

namespace UPPY.Desktop.Concrete.Controllers.Standarts
{
    public class StandartDocumentController : IStandartController, IDocumentController<Standart>
    {
        public bool ShowViewDialog()
        {
            var form = new StandartForm(this);
            return form.ShowDialog() == DialogResult.OK;
        }

        public Standart Document { get; set; }
    }
}