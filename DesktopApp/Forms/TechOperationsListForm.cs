using System;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Interfaces;

namespace DesktopApp.Forms
{
    public partial class TechOperationsListForm : Form, IDocsListForm<TechOperation>
    {
        private readonly IController<TechOperation> _controller;

        public TechOperationsListForm(IController<TechOperation> controller)
        {
            InitializeComponent();
            _controller = controller;
            gridControl.DataSource = _controller.GetData();
        }

        public IController<TechOperation> Controller
        {
            get { return _controller; }
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            gridControl.DataSource = _controller.GetData();
            gridControl.RefreshDataSource();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controller.AddDocument(Controller.CreateDocument());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var data = gvOperations.GetFocusedRow();
            Controller.DeleteDocument((TechOperation) data);
        }
    }
}