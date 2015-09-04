﻿namespace UPPY.Desktop.Views.Standarts
{
    partial class DrawingToStandartForm
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
            this.wcStandarts = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wpUngrouppedPositions = new DevExpress.XtraWizard.WizardPage();
            this.gcUngPositions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStandartSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGostOnSort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkSteal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizationRatio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightWithWaste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalMeasurement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalMeasurementWithWaste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeAdditionalMeasurement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wpGrouppedPositions = new DevExpress.XtraWizard.WizardPage();
            this.gcGrpPositions = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wcStandarts)).BeginInit();
            this.wcStandarts.SuspendLayout();
            this.wpUngrouppedPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUngPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.wpGrouppedPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrpPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // wcStandarts
            // 
            this.wcStandarts.CancelText = "Отмена";
            this.wcStandarts.Controls.Add(this.welcomeWizardPage);
            this.wcStandarts.Controls.Add(this.completionWizardPage);
            this.wcStandarts.Controls.Add(this.wpUngrouppedPositions);
            this.wcStandarts.Controls.Add(this.wpGrouppedPositions);
            this.wcStandarts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wcStandarts.FinishText = "&Конец";
            this.wcStandarts.HelpText = "&Помощь";
            this.wcStandarts.Location = new System.Drawing.Point(0, 0);
            this.wcStandarts.Name = "wcStandarts";
            this.wcStandarts.NextText = "&Далее >";
            this.wcStandarts.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wpUngrouppedPositions,
            this.wpGrouppedPositions,
            this.completionWizardPage});
            this.wcStandarts.PreviousText = "< &Назад";
            this.wcStandarts.Size = new System.Drawing.Size(889, 499);
            this.wcStandarts.Text = "Создание норм на основании сборки";
            this.wcStandarts.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.IntroductionText = "Создание норм на основании сборки";
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.ProceedText = "Для продолжения, нажмите Далее";
            this.welcomeWizardPage.Size = new System.Drawing.Size(672, 389);
            this.welcomeWizardPage.Text = "";
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.FinishText = "Создание норм завершено";
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.ProceedText = "Для сохранения нажмите Готово";
            this.completionWizardPage.Size = new System.Drawing.Size(672, 366);
            this.completionWizardPage.Text = "Завершение";
            // 
            // wpUngrouppedPositions
            // 
            this.wpUngrouppedPositions.Controls.Add(this.gcUngPositions);
            this.wpUngrouppedPositions.DescriptionText = "Анализ по позиционно";
            this.wpUngrouppedPositions.Name = "wpUngrouppedPositions";
            this.wpUngrouppedPositions.Size = new System.Drawing.Size(857, 354);
            this.wpUngrouppedPositions.Text = "Предварительный анализ";
            // 
            // gcUngPositions
            // 
            this.gcUngPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUngPositions.Location = new System.Drawing.Point(0, 0);
            this.gcUngPositions.MainView = this.gridView1;
            this.gcUngPositions.Name = "gcUngPositions";
            this.gcUngPositions.Size = new System.Drawing.Size(857, 354);
            this.gcUngPositions.TabIndex = 1;
            this.gcUngPositions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProfile,
            this.colStandartSize,
            this.colGostOnSort,
            this.colMarkSteal,
            this.colUtilizationRatio,
            this.colWeight,
            this.colWeightWithWaste,
            this.colAdditionalMeasurement,
            this.colAdditionalMeasurementWithWaste,
            this.colTypeAdditionalMeasurement,
            this.colNote});
            this.gridView1.GridControl = this.gcUngPositions;
            this.gridView1.Name = "gridView1";
            // 
            // colProfile
            // 
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 0;
            // 
            // colStandartSize
            // 
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 1;
            // 
            // colGostOnSort
            // 
            this.colGostOnSort.FieldName = "GostOnSort";
            this.colGostOnSort.Name = "colGostOnSort";
            this.colGostOnSort.Visible = true;
            this.colGostOnSort.VisibleIndex = 2;
            // 
            // colMarkSteal
            // 
            this.colMarkSteal.FieldName = "MarkSteal";
            this.colMarkSteal.Name = "colMarkSteal";
            this.colMarkSteal.Visible = true;
            this.colMarkSteal.VisibleIndex = 3;
            // 
            // colUtilizationRatio
            // 
            this.colUtilizationRatio.FieldName = "UtilizationRatio";
            this.colUtilizationRatio.Name = "colUtilizationRatio";
            this.colUtilizationRatio.Visible = true;
            this.colUtilizationRatio.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            // 
            // colWeightWithWaste
            // 
            this.colWeightWithWaste.FieldName = "WeightWithWaste";
            this.colWeightWithWaste.Name = "colWeightWithWaste";
            this.colWeightWithWaste.Visible = true;
            this.colWeightWithWaste.VisibleIndex = 6;
            // 
            // colAdditionalMeasurement
            // 
            this.colAdditionalMeasurement.FieldName = "AdditionalMeasurement";
            this.colAdditionalMeasurement.Name = "colAdditionalMeasurement";
            this.colAdditionalMeasurement.Visible = true;
            this.colAdditionalMeasurement.VisibleIndex = 7;
            // 
            // colAdditionalMeasurementWithWaste
            // 
            this.colAdditionalMeasurementWithWaste.FieldName = "AdditionalMeasurementWithWaste";
            this.colAdditionalMeasurementWithWaste.Name = "colAdditionalMeasurementWithWaste";
            this.colAdditionalMeasurementWithWaste.Visible = true;
            this.colAdditionalMeasurementWithWaste.VisibleIndex = 8;
            // 
            // colTypeAdditionalMeasurement
            // 
            this.colTypeAdditionalMeasurement.FieldName = "TypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Name = "colTypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Visible = true;
            this.colTypeAdditionalMeasurement.VisibleIndex = 9;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 10;
            // 
            // wpGrouppedPositions
            // 
            this.wpGrouppedPositions.Controls.Add(this.gcGrpPositions);
            this.wpGrouppedPositions.DescriptionText = "Сгруппированные и просуммированные нормы ";
            this.wpGrouppedPositions.Name = "wpGrouppedPositions";
            this.wpGrouppedPositions.Size = new System.Drawing.Size(857, 354);
            this.wpGrouppedPositions.Text = "Сводные нормы";
            // 
            // gcGrpPositions
            // 
            this.gcGrpPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGrpPositions.Location = new System.Drawing.Point(0, 0);
            this.gcGrpPositions.MainView = this.gridView2;
            this.gcGrpPositions.Name = "gcGrpPositions";
            this.gcGrpPositions.Size = new System.Drawing.Size(857, 354);
            this.gcGrpPositions.TabIndex = 2;
            this.gcGrpPositions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView2.GridControl = this.gcGrpPositions;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Profile";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "StandartSize";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "GostOnSort";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "MarkSteal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "UtilizationRatio";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Weight";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "WeightWithWaste";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "AdditionalMeasurement";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "AdditionalMeasurementWithWaste";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "TypeAdditionalMeasurement";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "Note";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // DrawingToStandartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 499);
            this.Controls.Add(this.wcStandarts);
            this.Name = "DrawingToStandartForm";
            this.Text = "DrawingToStandartForm";
            ((System.ComponentModel.ISupportInitialize)(this.wcStandarts)).EndInit();
            this.wcStandarts.ResumeLayout(false);
            this.wpUngrouppedPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUngPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.wpGrouppedPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGrpPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wcStandarts;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraWizard.WizardPage wpUngrouppedPositions;
        private DevExpress.XtraWizard.WizardPage wpGrouppedPositions;
        private DevExpress.XtraGrid.GridControl gcUngPositions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colStandartSize;
        private DevExpress.XtraGrid.Columns.GridColumn colGostOnSort;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkSteal;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizationRatio;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightWithWaste;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalMeasurement;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalMeasurementWithWaste;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeAdditionalMeasurement;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.GridControl gcGrpPositions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}