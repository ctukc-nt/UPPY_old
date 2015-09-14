using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.TechOpers;

namespace UPPY.Desktop.Views.TechOpers
{
    public partial class TechOpersListForm : Form
    {
        private ITechOpersListController _controller;

        public TechOpersListForm(ITechOpersListController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void cmCommands_ButtonAddClick(object sender, EventArgs e)
        {
            _controller.Save(_controller.CreateDocument());
        }

        private void cmCommands_ButtonDeleteClick(object sender, EventArgs e)
        {
            var doc = (TechOperation)gvTechOpers.GetFocusedRow();
            _controller.Delete(doc);
        }

        private void cmCommands_ButtonEditClick(object sender, EventArgs e)
        {

        }

        private void cmCommands_ButtonRefreshClick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gcTechOpers.DataSource = _controller.GetTechOperationsList();
        }

        private void TechOpersListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
