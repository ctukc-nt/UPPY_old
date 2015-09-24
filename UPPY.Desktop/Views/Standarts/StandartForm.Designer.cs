namespace UPPY.Desktop.Views.Standarts
{
    partial class StandartForm
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
            this.components = new System.ComponentModel.Container();
            this.gcPositions = new DevExpress.XtraGrid.GridControl();
            this.positionStandartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPositions = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teUtilRation = new DevExpress.XtraEditors.TextEdit();
            this.teDrawing = new DevExpress.XtraEditors.TextEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gcPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionStandartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPositions)).BeginInit();
            this.expandCollapsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teUtilRation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDrawing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPositions
            // 
            this.gcPositions.DataSource = this.positionStandartBindingSource;
            this.gcPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPositions.Location = new System.Drawing.Point(0, 102);
            this.gcPositions.MainView = this.gvPositions;
            this.gcPositions.Name = "gcPositions";
            this.gcPositions.Size = new System.Drawing.Size(1008, 586);
            this.gcPositions.TabIndex = 0;
            this.gcPositions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPositions});
            // 
            // positionStandartBindingSource
            // 
            this.positionStandartBindingSource.DataSource = typeof(Core.DomainModel.PositionStandart);
            // 
            // gvPositions
            // 
            this.gvPositions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gvPositions.GridControl = this.gcPositions;
            this.gvPositions.Name = "gvPositions";
            // 
            // colProfile
            // 
            this.colProfile.Caption = "Профиль";
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 0;
            // 
            // colStandartSize
            // 
            this.colStandartSize.Caption = "Типоразмер";
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 1;
            // 
            // colGostOnSort
            // 
            this.colGostOnSort.Caption = "ГОСТ на сортамент";
            this.colGostOnSort.FieldName = "GostOnSort";
            this.colGostOnSort.Name = "colGostOnSort";
            this.colGostOnSort.Visible = true;
            this.colGostOnSort.VisibleIndex = 2;
            // 
            // colMarkSteal
            // 
            this.colMarkSteal.Caption = "Марка стали";
            this.colMarkSteal.FieldName = "MarkSteal";
            this.colMarkSteal.Name = "colMarkSteal";
            this.colMarkSteal.Visible = true;
            this.colMarkSteal.VisibleIndex = 3;
            // 
            // colUtilizationRatio
            // 
            this.colUtilizationRatio.Caption = "Коэфф. исп.";
            this.colUtilizationRatio.FieldName = "UtilizationRatio";
            this.colUtilizationRatio.Name = "colUtilizationRatio";
            this.colUtilizationRatio.Visible = true;
            this.colUtilizationRatio.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Вес";
            this.colWeight.DisplayFormat.FormatString = "n3";
            this.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            // 
            // colWeightWithWaste
            // 
            this.colWeightWithWaste.Caption = "Вес с отходом";
            this.colWeightWithWaste.DisplayFormat.FormatString = "n3";
            this.colWeightWithWaste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeightWithWaste.FieldName = "WeightWithWaste";
            this.colWeightWithWaste.Name = "colWeightWithWaste";
            this.colWeightWithWaste.Visible = true;
            this.colWeightWithWaste.VisibleIndex = 6;
            // 
            // colAdditionalMeasurement
            // 
            this.colAdditionalMeasurement.Caption = "Доп. ед. изм.";
            this.colAdditionalMeasurement.DisplayFormat.FormatString = "n3";
            this.colAdditionalMeasurement.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAdditionalMeasurement.FieldName = "AdditionalMeasurement";
            this.colAdditionalMeasurement.Name = "colAdditionalMeasurement";
            this.colAdditionalMeasurement.Visible = true;
            this.colAdditionalMeasurement.VisibleIndex = 7;
            // 
            // colAdditionalMeasurementWithWaste
            // 
            this.colAdditionalMeasurementWithWaste.Caption = "Доп. ед. изм. с отх.";
            this.colAdditionalMeasurementWithWaste.DisplayFormat.FormatString = "n3";
            this.colAdditionalMeasurementWithWaste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAdditionalMeasurementWithWaste.FieldName = "AdditionalMeasurementWithWaste";
            this.colAdditionalMeasurementWithWaste.Name = "colAdditionalMeasurementWithWaste";
            this.colAdditionalMeasurementWithWaste.Visible = true;
            this.colAdditionalMeasurementWithWaste.VisibleIndex = 8;
            // 
            // colTypeAdditionalMeasurement
            // 
            this.colTypeAdditionalMeasurement.Caption = "Тип доп. ед. изм.";
            this.colTypeAdditionalMeasurement.FieldName = "TypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Name = "colTypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Visible = true;
            this.colTypeAdditionalMeasurement.VisibleIndex = 9;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 10;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.labelControl3);
            this.expandCollapsePanel1.Controls.Add(this.labelControl2);
            this.expandCollapsePanel1.Controls.Add(this.labelControl1);
            this.expandCollapsePanel1.Controls.Add(this.teUtilRation);
            this.expandCollapsePanel1.Controls.Add(this.teDrawing);
            this.expandCollapsePanel1.Controls.Add(this.teName);
            this.expandCollapsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandCollapsePanel1.ExpandedHeight = 0;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(1008, 102);
            this.expandCollapsePanel1.TabIndex = 1;
            this.expandCollapsePanel1.Text = "Общие данные";
            this.expandCollapsePanel1.UseAnimation = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(497, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Сб. единица";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Коэф. использования";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Наименование";
            // 
            // teUtilRation
            // 
            this.teUtilRation.Location = new System.Drawing.Point(127, 69);
            this.teUtilRation.Name = "teUtilRation";
            this.teUtilRation.Properties.Mask.EditMask = "n2";
            this.teUtilRation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teUtilRation.Size = new System.Drawing.Size(137, 20);
            this.teUtilRation.TabIndex = 3;
            // 
            // teDrawing
            // 
            this.teDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teDrawing.Location = new System.Drawing.Point(566, 43);
            this.teDrawing.Name = "teDrawing";
            this.teDrawing.Properties.Mask.EditMask = "n2";
            this.teDrawing.Properties.ReadOnly = true;
            this.teDrawing.Size = new System.Drawing.Size(426, 20);
            this.teDrawing.TabIndex = 2;
            // 
            // teName
            // 
            this.teName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teName.Location = new System.Drawing.Point(127, 43);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(364, 20);
            this.teName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 688);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 41);
            this.panel1.TabIndex = 2;
            // 
            // StandartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gcPositions);
            this.Controls.Add(this.expandCollapsePanel1);
            this.Controls.Add(this.panel1);
            this.Name = "StandartForm";
            this.Text = "Нормы на сборку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StandartForm_FormClosing);
            this.Load += new System.EventHandler(this.StandartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionStandartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPositions)).EndInit();
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teUtilRation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDrawing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPositions;
        private System.Windows.Forms.BindingSource positionStandartBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPositions;
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
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit teDrawing;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teUtilRation;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}