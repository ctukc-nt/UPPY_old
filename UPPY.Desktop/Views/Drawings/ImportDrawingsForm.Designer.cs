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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.wcSiemensDataImport = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPath = new DevExpress.XtraEditors.ButtonEdit();
            this.wpPreviewPackSiemens = new DevExpress.XtraWizard.WizardPage();
            this.waitPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.rtbPreviewLoad = new System.Windows.Forms.RichTextBox();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.ppFinishLoad = new DevExpress.XtraWaitForm.ProgressPanel();
            this.wpConvertedDataView = new DevExpress.XtraWizard.WizardPage();
            this.waitPanelConversion = new DevExpress.XtraWaitForm.ProgressPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlDarwings = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcDesignation = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcNumberOnSpec = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcProfile = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcStandartSize = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcGostOnSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcMarkSteal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcGostOnMaterial = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcLength = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcWidth = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCountAll = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcWeigth = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcWeightAll = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCountFiles = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repoTechRoutes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rtbConvertLog = new System.Windows.Forms.RichTextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wcSiemensDataImport)).BeginInit();
            this.wcSiemensDataImport.SuspendLayout();
            this.welcomeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).BeginInit();
            this.wpPreviewPackSiemens.SuspendLayout();
            this.completionWizardPage.SuspendLayout();
            this.wpConvertedDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDarwings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // wcSiemensDataImport
            // 
            this.wcSiemensDataImport.Controls.Add(this.welcomeWizardPage);
            this.wcSiemensDataImport.Controls.Add(this.wpPreviewPackSiemens);
            this.wcSiemensDataImport.Controls.Add(this.completionWizardPage);
            this.wcSiemensDataImport.Controls.Add(this.wpConvertedDataView);
            this.wcSiemensDataImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wcSiemensDataImport.Location = new System.Drawing.Point(0, 0);
            this.wcSiemensDataImport.Name = "wcSiemensDataImport";
            this.wcSiemensDataImport.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wpPreviewPackSiemens,
            this.wpConvertedDataView,
            this.completionWizardPage});
            this.wcSiemensDataImport.Size = new System.Drawing.Size(965, 550);
            this.wcSiemensDataImport.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wcSiemensDataImport.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.AllowBack = false;
            this.welcomeWizardPage.Controls.Add(this.labelControl1);
            this.welcomeWizardPage.Controls.Add(this.btnPath);
            this.welcomeWizardPage.IntroductionText = resources.GetString("welcomeWizardPage.IntroductionText");
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.ProceedText = "Для продолжения нажмите \"Далее\"";
            this.welcomeWizardPage.Size = new System.Drawing.Size(748, 417);
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
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Location = new System.Drawing.Point(4, 109);
            this.btnPath.Name = "btnPath";
            this.btnPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnPath.Size = new System.Drawing.Size(741, 20);
            this.btnPath.TabIndex = 0;
            this.btnPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnPath_ButtonClick);
            // 
            // wpPreviewPackSiemens
            // 
            this.wpPreviewPackSiemens.Controls.Add(this.waitPanel);
            this.wpPreviewPackSiemens.Controls.Add(this.rtbPreviewLoad);
            this.wpPreviewPackSiemens.DescriptionText = "В окне расположены сообщения, возникшие в результате анализа пакета данных";
            this.wpPreviewPackSiemens.Name = "wpPreviewPackSiemens";
            this.wpPreviewPackSiemens.Size = new System.Drawing.Size(933, 405);
            this.wpPreviewPackSiemens.Text = "Отчет по проверке корректности пакета";
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
            this.waitPanel.Location = new System.Drawing.Point(333, 152);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(278, 66);
            this.waitPanel.TabIndex = 1;
            this.waitPanel.Text = "progressPanel1";
            this.waitPanel.Visible = false;
            // 
            // rtbPreviewLoad
            // 
            this.rtbPreviewLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPreviewLoad.Location = new System.Drawing.Point(0, 0);
            this.rtbPreviewLoad.Name = "rtbPreviewLoad";
            this.rtbPreviewLoad.Size = new System.Drawing.Size(933, 405);
            this.rtbPreviewLoad.TabIndex = 0;
            this.rtbPreviewLoad.Text = "";
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Controls.Add(this.ppFinishLoad);
            this.completionWizardPage.FinishText = resources.GetString("completionWizardPage.FinishText");
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.ProceedText = "";
            this.completionWizardPage.Size = new System.Drawing.Size(748, 417);
            this.completionWizardPage.Text = "Завершение работы мастера";
            // 
            // ppFinishLoad
            // 
            this.ppFinishLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ppFinishLoad.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.ppFinishLoad.Appearance.Options.UseBackColor = true;
            this.ppFinishLoad.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ppFinishLoad.AppearanceCaption.Options.UseFont = true;
            this.ppFinishLoad.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ppFinishLoad.AppearanceDescription.Options.UseFont = true;
            this.ppFinishLoad.Caption = "Пожалуйста, подождите";
            this.ppFinishLoad.Description = "Сохранение данных в базу...";
            this.ppFinishLoad.Location = new System.Drawing.Point(220, 178);
            this.ppFinishLoad.Name = "ppFinishLoad";
            this.ppFinishLoad.Size = new System.Drawing.Size(278, 66);
            this.ppFinishLoad.TabIndex = 3;
            this.ppFinishLoad.Visible = false;
            // 
            // wpConvertedDataView
            // 
            this.wpConvertedDataView.Controls.Add(this.waitPanelConversion);
            this.wpConvertedDataView.Controls.Add(this.splitContainer1);
            this.wpConvertedDataView.DescriptionText = "После обработки данных в окне отобразится результат";
            this.wpConvertedDataView.Name = "wpConvertedDataView";
            this.wpConvertedDataView.Size = new System.Drawing.Size(933, 405);
            this.wpConvertedDataView.Text = "Преобразование данных";
            // 
            // waitPanelConversion
            // 
            this.waitPanelConversion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waitPanelConversion.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.waitPanelConversion.Appearance.Options.UseBackColor = true;
            this.waitPanelConversion.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.waitPanelConversion.AppearanceCaption.Options.UseFont = true;
            this.waitPanelConversion.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.waitPanelConversion.AppearanceDescription.Options.UseFont = true;
            this.waitPanelConversion.Caption = "Пожалуйста, подождите";
            this.waitPanelConversion.Description = "Загрузка и обработка данных  от Siemens...";
            this.waitPanelConversion.Location = new System.Drawing.Point(327, 169);
            this.waitPanelConversion.Name = "waitPanelConversion";
            this.waitPanelConversion.Size = new System.Drawing.Size(278, 66);
            this.waitPanelConversion.TabIndex = 2;
            this.waitPanelConversion.Text = "progressPanel1";
            this.waitPanelConversion.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tlDarwings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbConvertLog);
            this.splitContainer1.Size = new System.Drawing.Size(933, 405);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 3;
            // 
            // tlDarwings
            // 
            this.tlDarwings.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcName,
            this.tlcDesignation,
            this.tlcNumberOnSpec,
            this.tlcProfile,
            this.tlcStandartSize,
            this.tlcGostOnSort,
            this.tlcMarkSteal,
            this.tlcGostOnMaterial,
            this.tlcLength,
            this.tlcWidth,
            this.tlcCount,
            this.tlcCountAll,
            this.tlcWeigth,
            this.tlcWeightAll,
            this.tlcCountFiles});
            this.tlDarwings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDarwings.FooterPanelHeight = 30;
            this.tlDarwings.KeyFieldName = "Id";
            this.tlDarwings.Location = new System.Drawing.Point(0, 0);
            this.tlDarwings.Name = "tlDarwings";
            this.tlDarwings.OptionsBehavior.EnableFiltering = true;
            this.tlDarwings.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended;
            this.tlDarwings.ParentFieldName = "ParentId";
            this.tlDarwings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoTechRoutes});
            this.tlDarwings.RootValue = null;
            this.tlDarwings.Size = new System.Drawing.Size(933, 312);
            this.tlDarwings.TabIndex = 5;
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Наименование";
            this.tlcName.FieldName = "Name";
            this.tlcName.Name = "tlcName";
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 1;
            this.tlcName.Width = 73;
            // 
            // tlcDesignation
            // 
            this.tlcDesignation.Caption = "Обозначение";
            this.tlcDesignation.FieldName = "Designation";
            this.tlcDesignation.Name = "tlcDesignation";
            this.tlcDesignation.Visible = true;
            this.tlcDesignation.VisibleIndex = 0;
            this.tlcDesignation.Width = 74;
            // 
            // tlcNumberOnSpec
            // 
            this.tlcNumberOnSpec.Caption = "Номер по спец.";
            this.tlcNumberOnSpec.FieldName = "NumberOnSpec";
            this.tlcNumberOnSpec.Name = "tlcNumberOnSpec";
            this.tlcNumberOnSpec.Visible = true;
            this.tlcNumberOnSpec.VisibleIndex = 2;
            this.tlcNumberOnSpec.Width = 53;
            // 
            // tlcProfile
            // 
            this.tlcProfile.Caption = "Профиль";
            this.tlcProfile.FieldName = "Profile";
            this.tlcProfile.Name = "tlcProfile";
            this.tlcProfile.Visible = true;
            this.tlcProfile.VisibleIndex = 3;
            this.tlcProfile.Width = 60;
            // 
            // tlcStandartSize
            // 
            this.tlcStandartSize.Caption = "Типоразмер";
            this.tlcStandartSize.FieldName = "StandartSize";
            this.tlcStandartSize.Name = "tlcStandartSize";
            this.tlcStandartSize.Visible = true;
            this.tlcStandartSize.VisibleIndex = 4;
            this.tlcStandartSize.Width = 53;
            // 
            // tlcGostOnSort
            // 
            this.tlcGostOnSort.Caption = "ГОСТ на сортамент";
            this.tlcGostOnSort.FieldName = "GostOnSort";
            this.tlcGostOnSort.Name = "tlcGostOnSort";
            this.tlcGostOnSort.Visible = true;
            this.tlcGostOnSort.VisibleIndex = 5;
            this.tlcGostOnSort.Width = 86;
            // 
            // tlcMarkSteal
            // 
            this.tlcMarkSteal.Caption = "Марка стали";
            this.tlcMarkSteal.FieldName = "MarkSteal";
            this.tlcMarkSteal.Name = "tlcMarkSteal";
            this.tlcMarkSteal.Visible = true;
            this.tlcMarkSteal.VisibleIndex = 6;
            this.tlcMarkSteal.Width = 57;
            // 
            // tlcGostOnMaterial
            // 
            this.tlcGostOnMaterial.Caption = "ГОСТ на материал";
            this.tlcGostOnMaterial.FieldName = "GostOnMaterial";
            this.tlcGostOnMaterial.Name = "tlcGostOnMaterial";
            this.tlcGostOnMaterial.Visible = true;
            this.tlcGostOnMaterial.VisibleIndex = 7;
            this.tlcGostOnMaterial.Width = 70;
            // 
            // tlcLength
            // 
            this.tlcLength.Caption = "Длина";
            this.tlcLength.FieldName = "Length";
            this.tlcLength.Name = "tlcLength";
            this.tlcLength.Visible = true;
            this.tlcLength.VisibleIndex = 8;
            this.tlcLength.Width = 46;
            // 
            // tlcWidth
            // 
            this.tlcWidth.Caption = "Ширина";
            this.tlcWidth.FieldName = "Width";
            this.tlcWidth.Name = "tlcWidth";
            this.tlcWidth.Visible = true;
            this.tlcWidth.VisibleIndex = 9;
            this.tlcWidth.Width = 54;
            // 
            // tlcCount
            // 
            this.tlcCount.Caption = "Кол-во";
            this.tlcCount.FieldName = "Count";
            this.tlcCount.Name = "tlcCount";
            this.tlcCount.OptionsColumn.AllowEdit = false;
            this.tlcCount.Visible = true;
            this.tlcCount.VisibleIndex = 10;
            this.tlcCount.Width = 56;
            // 
            // tlcCountAll
            // 
            this.tlcCountAll.Caption = "Кол-во всего";
            this.tlcCountAll.FieldName = "CountAll";
            this.tlcCountAll.Name = "tlcCountAll";
            this.tlcCountAll.OptionsColumn.AllowEdit = false;
            this.tlcCountAll.Visible = true;
            this.tlcCountAll.VisibleIndex = 11;
            this.tlcCountAll.Width = 52;
            // 
            // tlcWeigth
            // 
            this.tlcWeigth.Caption = "Вес";
            this.tlcWeigth.FieldName = "Weight";
            this.tlcWeigth.Format.FormatString = "N2";
            this.tlcWeigth.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tlcWeigth.Name = "tlcWeigth";
            this.tlcWeigth.OptionsColumn.AllowEdit = false;
            this.tlcWeigth.Visible = true;
            this.tlcWeigth.VisibleIndex = 12;
            this.tlcWeigth.Width = 62;
            // 
            // tlcWeightAll
            // 
            this.tlcWeightAll.Caption = "Вес всего";
            this.tlcWeightAll.FieldName = "WeightAll";
            this.tlcWeightAll.Format.FormatString = "N2";
            this.tlcWeightAll.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tlcWeightAll.Name = "tlcWeightAll";
            this.tlcWeightAll.OptionsColumn.AllowEdit = false;
            this.tlcWeightAll.Visible = true;
            this.tlcWeightAll.VisibleIndex = 13;
            this.tlcWeightAll.Width = 66;
            // 
            // tlcCountFiles
            // 
            this.tlcCountFiles.Caption = "Кол-во файлов";
            this.tlcCountFiles.FieldName = "CountFiles";
            this.tlcCountFiles.Name = "tlcCountFiles";
            this.tlcCountFiles.Visible = true;
            this.tlcCountFiles.VisibleIndex = 14;
            // 
            // repoTechRoutes
            // 
            this.repoTechRoutes.AutoHeight = false;
            this.repoTechRoutes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "showlist", null, true)});
            this.repoTechRoutes.DisplayMember = "Name";
            this.repoTechRoutes.Name = "repoTechRoutes";
            this.repoTechRoutes.ValueMember = "Id";
            // 
            // rtbConvertLog
            // 
            this.rtbConvertLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConvertLog.Location = new System.Drawing.Point(0, 0);
            this.rtbConvertLog.Name = "rtbConvertLog";
            this.rtbConvertLog.Size = new System.Drawing.Size(933, 89);
            this.rtbConvertLog.TabIndex = 0;
            this.rtbConvertLog.Text = "";
            // 
            // ImportDrawingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 550);
            this.Controls.Add(this.wcSiemensDataImport);
            this.Name = "ImportDrawingsForm";
            this.Text = "ImportDrawingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.wcSiemensDataImport)).EndInit();
            this.wcSiemensDataImport.ResumeLayout(false);
            this.welcomeWizardPage.ResumeLayout(false);
            this.welcomeWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath.Properties)).EndInit();
            this.wpPreviewPackSiemens.ResumeLayout(false);
            this.completionWizardPage.ResumeLayout(false);
            this.wpConvertedDataView.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDarwings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechRoutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wcSiemensDataImport;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraWizard.WizardPage wpPreviewPackSiemens;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraEditors.ButtonEdit btnPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox rtbPreviewLoad;
        private DevExpress.XtraWizard.WizardPage wpConvertedDataView;
        private DevExpress.XtraWaitForm.ProgressPanel waitPanel;
        private DevExpress.XtraWaitForm.ProgressPanel waitPanelConversion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbConvertLog;
        private DevExpress.XtraTreeList.TreeList tlDarwings;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDesignation;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcNumberOnSpec;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcProfile;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcStandartSize;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcGostOnSort;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcMarkSteal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcGostOnMaterial;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLength;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWidth;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCountAll;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWeigth;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWeightAll;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoTechRoutes;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCountFiles;
        private DevExpress.XtraWaitForm.ProgressPanel ppFinishLoad;
    }
}