using System;
using System.Globalization;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Standarts;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class StandartForm : Form
    {
        private readonly IStandartController _controller;

        public StandartForm(IStandartController controller)
        {
            _controller = controller;
            InitializeComponent();
            Standart = _controller.Document;
        }

        public Standart Standart { get; set; }

        private void StandartForm_Load(object sender, EventArgs e)
        {
            LoadDataField();
        }

        private void LoadDataField()
        {
            if (Standart != null)
            {
                teName.Text = Standart.Name;
                teDrawing.Text = Standart.Drawing != null
                    ? $"({Standart.Drawing.Designation}) {Standart.Drawing.Name}"
                    : string.Empty;
                teUtilRation.Text = Standart.UtilizationRatio.ToString(CultureInfo.InvariantCulture);
                gcPositions.DataSource = Standart.Positions;
            }
        }

        private void SaveDataField()
        {
            if (Standart != null)
            {
                Standart.Name = teName.Text;
                teUtilRation.Text = Standart.UtilizationRatio.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void StandartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataField();
        }
    }
}