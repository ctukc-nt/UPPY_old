using System;
using System.Windows.Forms;
using Core.DomainModel;
using DesktopApp.Interfaces;
using DesktopApp.Ninject;

namespace DesktopApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bDrawings_Click(object sender, EventArgs e)
        {
            var form = CompositionRoot.Resolve<IFormsBuilder>().GetForm<Drawing>();
            form.Show(this);
        }
    }
}
