using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Standarts;

namespace UPPY.Desktop.Views.Standarts
{
    public partial class StandartForm : Form
    {
        private IStandartController _controller;

        public StandartForm(IStandartController controller)
        {
            _controller = controller;
            InitializeComponent();
            Standart = _controller.Standart;
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
                    ? string.Format("({0}) {1}", Standart.Drawing.Designation, Standart.Drawing.Name)
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
    }
}
