using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using UPPY.DIE.Import.Siemens;

namespace UPPY.DIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!string.IsNullOrEmpty(buttonEdit1.Text) && Directory.Exists(buttonEdit1.Text))
            {
                fbdSlctFolderSiemens.SelectedPath = buttonEdit1.Text;
            }

            if (fbdSlctFolderSiemens.ShowDialog(this) == DialogResult.OK)
            {
                buttonEdit1.Text = fbdSlctFolderSiemens.SelectedPath;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(buttonEdit1.Text) && Directory.Exists(buttonEdit1.Text))
            {
                var filesNameGetter = new SiemensXmlDataFilesNameGetter();
                filesNameGetter.LocationDirectory = buttonEdit1.Text;
                var filesArticlesFactory = new FilesArticlesFactory(filesNameGetter);
                var siemensProjectLoader = new SiemensProjectLoader(filesArticlesFactory);

                var project = siemensProjectLoader.LoadStructureProject();
            }
        }
    }
}