using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Infrastructure;
using DesktopApp.Interfaces;
using DesktopApp.View;

namespace DesktopApp.Forms
{
    public partial class DrawingsListForm : Form, IDocForm<HierarchyNumberDrawing>
    {
        public DrawingsListForm()
        {
            InitializeComponent();
        }

        public IController<HierarchyNumberDrawing> Controller
        {
            get { throw new NotImplementedException(); }
        }

        public event DocumentEventHandler<HierarchyNumberDrawing> UpdateDocument;
        public event DocumentEventHandler<HierarchyNumberDrawing> DeleteDocument;
        public event DocumentEventHandler<HierarchyNumberDrawing> AddDocument;
        public void RefreshSource(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
