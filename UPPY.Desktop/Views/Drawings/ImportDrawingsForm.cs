using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraWizard;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.DIE.Import.Siemens;
using Utils.Common;

namespace UPPY.Desktop.Views.Drawings
{
    public partial class ImportDrawingsForm : Form
    {
        private string _pathFolder = string.Empty;
        private SiemensProject _project;
        private TempDrawingsStorage _storage;

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
                rtbPreviewLoad.Text = string.Empty;
                var logger = new LoggerLoad();
                SiemensProject project = null;

                var task = new Task(() => { project = Controller.LoadStructureSiemens(btnPath.Text, logger); });

                waitPanel.Visible = true;
                wpPreviewPackSiemens.AllowNext = false;
                wpPreviewPackSiemens.AllowBack = false;
                wpPreviewPackSiemens.AllowCancel = false;

                task.Start();
                await task;

                waitPanel.Visible = false;
                wpPreviewPackSiemens.AllowBack = true;
                wpPreviewPackSiemens.AllowCancel = true;

                wpPreviewPackSiemens.Enabled = true;

                foreach (var mess in logger)
                {
                    rtbPreviewLoad.AppendText(string.Format("{0}\n\r", mess));
                }

                if (!logger.ErrorHappens)
                {
                    _project = project;
                    wpPreviewPackSiemens.AllowNext = true;
                    rtbPreviewLoad.Text += rtbPreviewLoad.Text.Length == 0 ? "Загрузка прошла успешно, ошибок нет!\nМожно переходить к следующему этапу." : "Есть предупреждения. Переходите к следующему этапу, если вы игнорируете их.";
                }
            }

            if (e.Page == wpPreviewPackSiemens)
            {

                wpConvertedDataView.AllowNext = false;
                wpConvertedDataView.AllowBack = false;
                wpConvertedDataView.AllowCancel = false;
                waitPanelConversion.Visible = true;

                LoggerLoad logger = new LoggerLoad();
                var task = new Task(() => { _storage = Controller.ConvertSiemensToDrawings(_project, logger); });

                task.Start();
                await task;

                waitPanelConversion.Visible = false;
                if (_storage != null)
                {
                    tlDarwings.DataSource = _storage.Drawings;
                }

                foreach (var mess in logger)
                {
                    rtbConvertLog.AppendText(string.Format("{0}\n\r", mess));
                }

                waitPanelConversion.Visible = false;
                wpConvertedDataView.AllowNext = true;
                wpConvertedDataView.AllowBack = true;
                wpConvertedDataView.AllowCancel = true;
                SetVisibleLevelsLine();
            }
        }
        private void SetVisibleLevelsLine()
        {
            var skin = GridSkins.GetSkin(tlDarwings.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            tlDarwings.LookAndFeel.UpdateStyleSettings();
        }

        private void btnPath_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            folderBrowser.SelectedPath = btnPath.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                _pathFolder = btnPath.Text = folderBrowser.SelectedPath;
            }
        }

        private class LoggerLoad : List<LogMessage>, ILogging
        {
            public bool ErrorHappens {
                get { return this.Any(x => x.Type == TypeMessage.Error); }
            }
            public IEnumerable<LogMessage> Messages { get { return this.AsEnumerable(); } }

            public void AppendMessage(string message)
            {
                Add(new LogMessage(message));
            }

            public void AppendMessage(string message, TypeMessage typeMessage)
            {
                throw new System.NotImplementedException();
            }

            public void AppendMessage(string message, object obj)
            {
                throw new System.NotImplementedException();
            }

            public void AppendMessage(string message, object obj, TypeMessage typeMessage)
            {
                throw new System.NotImplementedException();
            }

            public new void Clear()
            {
                base.Clear();
            }
        }

        private async void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            completionWizardPage.AllowCancel = false;
            completionWizardPage.AllowBack = false;
            completionWizardPage.AllowFinish = false;
            completionWizardPage.AllowDrop = false;
            completionWizardPage.AllowNext = false;

            e.Cancel = true;
            ppFinishLoad.Visible = true;
            var task = new Task(() => Controller.SaveDrawingsToDataBase(_storage));
            task.Start();
            await task;
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}