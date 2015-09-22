using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.Skins;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList.Nodes;
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
                var logger = new Logger();
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

                foreach (var mess in logger.Messages)
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

                var logger = new Logger();
                var task = new Task(() => { _storage = Controller.ConvertSiemensToDrawings(_project, logger); });

                task.Start();
                await task;

                waitPanelConversion.Visible = false;
                if (_storage != null)
                {
                    tlDarwings.DataSource = _storage.Drawings;
                }

                lbMessages.DataSource = logger.Messages.Select(mess => new MessageListBox() { Tag = mess.Tag, Message = mess.Message }).ToList();

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

        private void lbMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lbMessages.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var itemByIndex = (MessageListBox)lbMessages.Items[index];
                var node = tlDarwings.FindNode(x => ((Drawing)tlDarwings.GetDataRecordByNode(x)).Id == ((Drawing)itemByIndex.Tag).Id);

                tlDarwings.Selection.Clear();
                if (node != null)
                {
                    tlDarwings.Selection.Add(node);
                    tlDarwings.FocusedNode = node;
                    ExpandToParentNode(node);
                }
            }
        }

        private static void ExpandToParentNode(TreeListNode node)
        {
            if (node.ParentNode != null)
            {
                node.ParentNode.Expanded = true;
                ExpandToParentNode(node.ParentNode);
            }
        }

        private class MessageListBox
        {
            public string Message { get; set; }

            public object Tag { get; set; }

            public override string ToString()
            {
                return Message;
            }
        }
    }
}