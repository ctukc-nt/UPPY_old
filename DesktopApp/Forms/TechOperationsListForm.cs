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
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;

namespace DesktopApp.Forms
{
    public partial class TechOperationsListForm : Form, IDocsListForm<TechOperation>
    {

        private IController<TechOperation> _controller;

        public TechOperationsListForm(IController<TechOperation> controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public IController<TechOperation> Controller
        {
            get { return _controller; }
        }

        public event DocumentEventHandler<TechOperation> UpdateDocument;
        public event DocumentEventHandler<TechOperation> DeleteDocument;
        public event DocumentEventHandler<TechOperation> AddDocument;
        public void RefreshSource(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
