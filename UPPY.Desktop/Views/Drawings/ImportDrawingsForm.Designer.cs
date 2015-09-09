namespace UPPY.Desktop.Views.Drawings
{
    partial class ImportDrawingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDrawingsForm));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPath = new DevExpress.XtraEditors.ButtonEdit();
            this.wpPreviewPackSiemens = new DevExpress.XtraWizard.WizardPage();
            this.rtbPreviewLoad = new System.Windows.Forms.RichTextBox();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.waitPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).BeginInit();
            this.wpPreviewPackSiemens.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage);
            this.wizardControl1.Controls.Add(this.wpPreviewPackSiemens);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wpPreviewPackSiemens,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(731, 455);
            this.wizardControl1.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            this.wizardControl1.CustomizeCommandButtons += new DevExpress.XtraWizard.WizardCustomizeCommandButtonsEventHandler(this.wizardControl1_CustomizeCommandButtons);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.AllowBack = false;
            this.welcomeWizardPage.Controls.Add(this.labelControl1);
            this.welcomeWizardPage.Controls.Add(this.btnPath);
            this.welcomeWizardPage.IntroductionText = resources.GetString("welcomeWizardPage.IntroductionText");
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.ProceedText = "Для продолжения нажмите \"Далее\"";
            this.welcomeWizardPage.Size = new System.Drawing.Size(514, 322);
            this.welcomeWizardPage.Text = "Мастер импорта данных от компании Siemens";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(4, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Путь к папке данных";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(3, 109);
            this.btnPath.Name = "btnPath";
            this.btnPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnPath.Size = new System.Drawing.Size(498, 20);
            this.btnPath.TabIndex = 0;
            this.btnPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnPath_ButtonClick);
            // 
            // wpPreviewPackSiemens
            // 
            this.wpPreviewPackSiemens.Controls.Add(this.waitPanel);
            this.wpPreviewPackSiemens.Controls.Add(this.rtbPreviewLoad);
            this.wpPreviewPackSiemens.DescriptionText = "В окне расположены сообщения, возникшие в результате анализа пакета данных";
            this.wpPreviewPackSiemens.Name = "wpPreviewPackSiemens";
            this.wpPreviewPackSiemens.Size = new System.Drawing.Size(699, 310);
            this.wpPreviewPackSiemens.Text = "Отчет по проверке корректности пакета";
            // 
            // rtbPreviewLoad
            // 
            this.rtbPreviewLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPreviewLoad.Location = new System.Drawing.Point(0, 0);
            this.rtbPreviewLoad.Name = "rtbPreviewLoad";
            this.rtbPreviewLoad.Size = new System.Drawing.Size(699, 310);
            this.rtbPreviewLoad.TabIndex = 0;
            this.rtbPreviewLoad.Text = "";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(514, 322);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(699, 310);
            this.wizardPage1.Text = "Преобразование данных";
            // 
            // waitPanel
            // 
            this.waitPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waitPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.waitPanel.Appearance.Options.UseBackColor = true;
            this.waitPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.waitPanel.AppearanceCaption.Options.UseFont = true;
            this.waitPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waitPanel.AppearanceDescription.Options.UseFont = true;
            this.waitPanel.Caption = "Пожалуйста, подождите";
            this.waitPanel.Description = "Загрузка и обработка данных  от Siemens...";
            this.waitPanel.Location = new System.Drawing.Point(216, 105);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(278, 66);
            this.waitPanel.TabIndex = 1;
            this.waitPanel.Text = "progressPanel1";
            this.waitPanel.Visible = false;
            // 
            // ImportDrawingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 455);
            this.Controls.Add(this.wizardControl1);
            this.Name = "ImportDrawingsForm";
            this.Text = "ImportDrawingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage.ResumeLayout(false);
            this.welcomeWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).EndInit();
            this.wpPreviewPackSiemens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraWizard.WizardPage wpPreviewPackSiemens;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.ButtonEdit btnPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox rtbPreviewLoad;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWaitForm.ProgressPanel waitPanel;
    }
}