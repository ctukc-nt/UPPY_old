using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraWizard;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Common;
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
                var filesNameGetter = new SiemensXmlDataFilesNameGetter { LocationDirectory = _pathFolder };

                var docFilesGetter = new SiemensDocsFilesNameGetter { LocationDirectory = _pathFolder };
                SiemensProject project = null;
                var filesArticlesFactory = new FilesArticlesFactory(filesNameGetter);
                var siemensProjectLoader = new SiemensProjectLoader(filesArticlesFactory, logger, docFilesGetter);
                var task = new Task(() => { project = siemensProjectLoader.LoadStructureProject(); });

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

                wpConvertedDataView.AllowNext = false;
                wpConvertedDataView.AllowBack = false;
                wpConvertedDataView.AllowCancel = false;
                waitPanelConversion.Visible = true;

                LoggerLoad logger = new LoggerLoad();
                var converter = new ConverterSiemensProject(logger);
                MaterialParser parser = new MaterialParser();
                ProjectExcluder excluder = new ProjectExcluder();
                NameMatSearcherStubber searcher = new NameMatSearcherStubber();
                FieldsNormalizer normalizer = new FieldsNormalizer();
                converter.ExcluderProject = excluder;
                converter.Log = logger;
                converter.MaterialParser = parser;
                converter.NameMaterialSearch = searcher;
                converter.Normalizer = normalizer;
                TempDrawingsStorage storage = null;

                wpConvertedDataView.AllowNext = false;
                wpConvertedDataView.AllowBack = false;
                wpConvertedDataView.AllowCancel = false;

                var task = new Task(() => { storage = converter.ConvertSiemensProjectToDomainModel(_project); });
               
                task.Start();
                await task;

                waitPanelConversion.Visible = false;
                if (storage != null)
                {
                    tlDarwings.DataSource = storage.Drawings;
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

        private void wizardControl1_CustomizeCommandButtons(object sender, CustomizeCommandButtonsEventArgs e)
        {
        }

        private class NameMatSearcherStubber : INameMaterialSearch
        {
            public string GetNameMaterialByGost(string gost)
            {
                return String.Empty;
            }
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