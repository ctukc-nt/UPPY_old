using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Common;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class DrawingToStandartForm : Form
    {
        private IDrawingsToStandartController _controller;
        private Standart _standart = null;

        public DrawingToStandartForm(IDrawingsToStandartController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wpUngrouppedPositions)
            {
                _standart = _controller.CreateStandartByDrawing();
                gcUngPositions.DataSource = _standart.Positions;
            }

            if (e.Page == wpGrouppedPositions)
            {
                _standart = _controller.GroupPositionsStandart(_standart);
                gcUngPositions.DataSource = _standart.Positions;
            }
        }
    }
}
