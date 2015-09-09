using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraWizard;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class ImportDrawingsForm : Form
    {
        private string _pathFolder = string.Empty;
        private SiemensProject _project;

        public ImportDrawingsForm()
        {
            InitializeComponent();
        }

        public ImportDrawingsForm(ISiemensDataImportController controller)
        {
            Controller = controller;
            InitializeComponent();
        }

        public ISiemensDataImportController Controller { get; set; }

        private async void wizardControl1_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == welcomeWizardPage)
            {
                wpPreviewPackSiemens.Enabled = false;
                var logger = new LoggerLoad();
                var filesNameGetter = new SiemensXmlDataFilesNameGetter {LocationDirectory = _pathFolder};

                var docFilesGetter = new SiemensDocsFilesNameGetter {LocationDirectory = _pathFolder};
                SiemensProject project = null;
                var filesArticlesFactory = new FilesArticlesFactory(filesNameGetter);
                var siemensProjectLoader = new SiemensProjectLoader(filesArticlesFactory, logger, docFilesGetter);
                var task = new Task(() => { project = siemensProjectLoader.LoadStructureProject(); });

                project = siemensProjectLoader.LoadStructureProject();
                waitPanel.Visible = true;
                wpPreviewPackSiemens.AllowNext = false;
                wpPreviewPackSiemens.AllowBack = false;
                wpPreviewPackSiemens.AllowCancel = false;

                //task.Start();

//                await task;

                waitPanel.Visible = false;
                wpPreviewPackSiemens.AllowBack = true;
                wpPreviewPackSiemens.AllowCancel = true;

                wpPreviewPackSiemens.Enabled = true;
                ;
                if (siemensProjectLoader.ErrorDuringLoad)
                {
                    foreach (var mess in logger)
                    {
                        rtbPreviewLoad.AppendText(string.Format("{0}\n\r", mess));
                    }
                }
                else
                {
                    _project = project;
                    wpPreviewPackSiemens.AllowNext = true;
                    rtbPreviewLoad.Text = "Загрузка прошла успешно, ошибок нет!\n Можно переходить к следующему этапу.";
                }
            }

            if (e.Page == wpPreviewPackSiemens)
            {
                var converter = new ConverterSiemensProject();

            }
        }

        

        private void btnPath_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            folderBrowser.SelectedPath = btnPath.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                _pathFolder = btnPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void wizardControl1_CustomizeCommandButtons(object sender, CustomizeCommandButtonsEventArgs e)
        {
        }

        private class LoggerLoad : List<string>, ILogging
        {
            public void AppendMessage(string message)
            {
                Add(message);
            }

            public new void Clear()
            {
                base.Clear();
            }
        }
    }
}