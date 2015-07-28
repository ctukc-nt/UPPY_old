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
    public partial class TechOperationsListForm : Form, IDocsListForm<Drawing>
    {
        public TechOperationsListForm()
        {
            InitializeComponent();
        }

        public IController<Drawing> Controller
        {
            get { throw new NotImplementedException(); }
        }

        public event DocumentEventHandler<Drawing> UpdateDocument;
        public event DocumentEventHandler<Drawing> DeleteDocument;
        public event DocumentEventHandler<Drawing> AddDocument;
        public void RefreshSource(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
