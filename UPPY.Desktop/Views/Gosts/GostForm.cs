using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Gosts;
using UPPY.Desktop.Interfaces.Views;

namespace UPPY.Desktop.Views.Gosts
{
    public partial class GostForm : Form, IView<Gost>
    {
        private IGostDocumentController _controller;

        public GostForm(IGostDocumentController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        public Gost Document { get; set; }

        private void LoadDataFields()
        {
            if (Document != null)
            {
                teName.Text = Document.Name;
                teProfile.Text = Document.Profile;
                teNote.Text = Document.Note;

                switch (Document.TypeExtraDimension)
                {
                    case ExtraDimensions.Meters:
                        rbDopMetrPog.Checked = true;
                        break;
                    case ExtraDimensions.Piece:
                        rbDopPieces.Checked = true;
                        break;
                    case ExtraDimensions.SquareMeter:
                        rbDopMetrSquare.Checked = true;
                        break;
                }

                switch (Document.WeightMethodCalculate)
                {
                    case WeightMethodCalculate.ByTable:
                        rbTable.Checked = true;
                        break;
                    case WeightMethodCalculate.Length:
                        rbLengthCircle.Checked = true;
                        break;
                    case WeightMethodCalculate.LengthAndDoubleThikness:
                        rbSquare.Checked = true;
                        break;
                    case WeightMethodCalculate.LengthAndThikness:
                        rbLengthThik.Checked = true;
                        break;
                    case WeightMethodCalculate.LengthAndWidth:
                        rbLengthWidth.Checked = true;
                        break;
                }
            }
        }

        private void SaveDataFields()
        {
            if (Document != null)
            {
                Document.Name = teName.Text;
                Document.Profile = teProfile.Text;
                Document.Note = teNote.Text;

                if (rbDopMetrPog.Checked)
                    Document.TypeExtraDimension = ExtraDimensions.Meters;

                if (rbDopPieces.Checked)
                    Document.TypeExtraDimension = ExtraDimensions.Piece;

                if (rbDopMetrSquare.Checked)
                    Document.TypeExtraDimension = ExtraDimensions.SquareMeter;

                if (rbTable.Checked)
                    Document.WeightMethodCalculate = WeightMethodCalculate.ByTable;

                if (rbLengthCircle.Checked)
                    Document.WeightMethodCalculate = WeightMethodCalculate.Length;

                if (rbSquare.Checked)
                    Document.WeightMethodCalculate = WeightMethodCalculate.LengthAndDoubleThikness;

                if (rbLengthThik.Checked)
                    Document.WeightMethodCalculate = WeightMethodCalculate.LengthAndThikness;

                if (rbLengthWidth.Checked)
                    Document.WeightMethodCalculate = WeightMethodCalculate.LengthAndWidth;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDataFields();
        }

        private void GostForm_Load(object sender, EventArgs e)
        {
            LoadDataFields();
        }
    }
}