using System;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;

namespace DesktopApp.Forms
{
    public partial class DrawingsListForm : Form, IDocForm<Drawing>
    {
        private readonly IController<Drawing> _controller;

        public DrawingsListForm(IController<Drawing> controller)
        {
            InitializeComponent();
            AddDocument += controller.AddDocument;
            DeleteDocument += controller.DeleteDocument;
            UpdateDocument += controller.UpdateDocument;

            _controller = controller;
            _controller.SourceRefreshed += RefreshSource;
        }

        public IController<Drawing> Controller
        {
            get { return _controller; }
        }

        public event DocumentEventHandler<Drawing> UpdateDocument;
        public event DocumentEventHandler<Drawing> DeleteDocument;
        public event DocumentEventHandler<Drawing> AddDocument;

        public void RefreshSource(object sender, EventArgs e)
        {
        }

        private void DrawingsListForm_Load(object sender, EventArgs e)
        {
            var data = Controller.GetData();
        }
    }
}