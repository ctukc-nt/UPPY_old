using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;

namespace DesktopApp.Forms
{
    public partial class StandartEditForm : Form, IDocEditForm<Standart>
    {
        private Standart _document;
        private IController<Standart> _controller;

        public StandartEditForm(IController<Standart> controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public Standart Document
        {
            get { return _document; }
            set
            {
                _document = value;
            }
        }

        public event DocumentEventHandler<Standart> UpdateDocument;

        private void btnAddPosition_Click(object sender, System.EventArgs e)
        {
            _document.Positions.Add(new PostitionStandart());
            gcPositions.RefreshDataSource();
        }

        private void btnDelPosition_Click(object sender, System.EventArgs e)
        {
            _document.Positions.Remove((PostitionStandart)gridView1.GetFocusedRow());
            gcPositions.RefreshDataSource();
        }

        private void StandartEditForm_Load(object sender, System.EventArgs e)
        {
            LoadDataFromDocument();
        }

        private void LoadDataFromDocument()
        {
            teName.Text = Document.Name;
            leDrawing.Properties.DataSource = _controller.GetListRelatedDocument<Drawing>().ConvertAll<Drawing>(x => (Drawing)x);
            leDrawing.EditValue = Document.Drawing;
            gcPositions.DataSource = _document.Positions;
        }
    }
}