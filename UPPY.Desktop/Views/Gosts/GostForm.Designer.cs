namespace UPPY.Desktop.Views.Gosts
{
    partial class GostForm
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
            this.gcStandartWeight = new DevExpress.XtraGrid.GridControl();
            this.standartWeightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStandartsWeights = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStandartSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rbDopMetrPog = new System.Windows.Forms.RadioButton();
            this.rbDopMetrSquare = new System.Windows.Forms.RadioButton();
            this.rbDopPieces = new System.Windows.Forms.RadioButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rbLengthCircle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbLengthThik = new System.Windows.Forms.RadioButton();
            this.rbLengthWidth = new System.Windows.Forms.RadioButton();
            this.rbTable = new System.Windows.Forms.RadioButton();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teNote = new DevExpress.XtraEditors.TextEdit();
            this.teProfile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcStandartWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standartWeightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStandartsWeights)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProfile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStandartWeight
            // 
            this.gcStandartWeight.DataSource = this.standartWeightBindingSource;
            this.gcStandartWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStandartWeight.Location = new System.Drawing.Point(2, 20);
            this.gcStandartWeight.MainView = this.gvStandartsWeights;
            this.gcStandartWeight.Name = "gcStandartWeight";
            this.gcStandartWeight.Size = new System.Drawing.Size(738, 139);
            this.gcStandartWeight.TabIndex = 0;
            this.gcStandartWeight.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStandartsWeights});
            // 
            // standartWeightBindingSource
            // 
            this.standartWeightBindingSource.DataSource = typeof(Core.DomainModel.StandartWeight);
            // 
            // gvStandartsWeights
            // 
            this.gvStandartsWeights.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStandartSize,
            this.colWeight});
            this.gvStandartsWeights.GridControl = this.gcStandartWeight;
            this.gvStandartsWeights.Name = "gvStandartsWeights";
            // 
            // colStandartSize
            // 
            this.colStandartSize.Caption = "Типоразмер";
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 0;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Вес 1 м. п.";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(573, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(677, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcStandartWeight);
            this.groupControl1.Location = new System.Drawing.Point(12, 204);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(742, 161);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Справочник табличных весов";
            // 
            // rbDopMetrPog
            // 
            this.rbDopMetrPog.AutoSize = true;
            this.rbDopMetrPog.Checked = true;
            this.rbDopMetrPog.Location = new System.Drawing.Point(5, 26);
            this.rbDopMetrPog.Name = "rbDopMetrPog";
            this.rbDopMetrPog.Size = new System.Drawing.Size(111, 17);
            this.rbDopMetrPog.TabIndex = 3;
            this.rbDopMetrPog.TabStop = true;
            this.rbDopMetrPog.Text = "Метры погонные";
            this.rbDopMetrPog.UseVisualStyleBackColor = true;
            // 
            // rbDopMetrSquare
            // 
            this.rbDopMetrSquare.AutoSize = true;
            this.rbDopMetrSquare.Location = new System.Drawing.Point(122, 26);
            this.rbDopMetrSquare.Name = "rbDopMetrSquare";
            this.rbDopMetrSquare.Size = new System.Drawing.Size(125, 17);
            this.rbDopMetrSquare.TabIndex = 4;
            this.rbDopMetrSquare.Text = "Метры квадратные";
            this.rbDopMetrSquare.UseVisualStyleBackColor = true;
            // 
            // rbDopPieces
            // 
            this.rbDopPieces.AutoSize = true;
            this.rbDopPieces.Location = new System.Drawing.Point(253, 26);
            this.rbDopPieces.Name = "rbDopPieces";
            this.rbDopPieces.Size = new System.Drawing.Size(59, 17);
            this.rbDopPieces.TabIndex = 5;
            this.rbDopPieces.Text = "Штуки";
            this.rbDopPieces.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.rbDopMetrPog);
            this.groupControl2.Controls.Add(this.rbDopPieces);
            this.groupControl2.Controls.Add(this.rbDopMetrSquare);
            this.groupControl2.Location = new System.Drawing.Point(12, 147);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(740, 51);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Тип дополнительной единицы измерения";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.rbLengthCircle);
            this.groupControl3.Controls.Add(this.rbSquare);
            this.groupControl3.Controls.Add(this.rbLengthThik);
            this.groupControl3.Controls.Add(this.rbLengthWidth);
            this.groupControl3.Controls.Add(this.rbTable);
            this.groupControl3.Location = new System.Drawing.Point(12, 90);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(740, 51);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Метод вычисления дополнительной едиинцы измерения";
            // 
            // rbLengthCircle
            // 
            this.rbLengthCircle.AutoSize = true;
            this.rbLengthCircle.Location = new System.Drawing.Point(281, 26);
            this.rbLengthCircle.Name = "rbLengthCircle";
            this.rbLengthCircle.Size = new System.Drawing.Size(91, 17);
            this.rbLengthCircle.TabIndex = 7;
            this.rbLengthCircle.TabStop = true;
            this.rbLengthCircle.Text = "Длина (круг)";
            this.rbLengthCircle.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(378, 26);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(69, 17);
            this.rbSquare.TabIndex = 6;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Квадрат";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbLengthThik
            // 
            this.rbLengthThik.AutoSize = true;
            this.rbLengthThik.Location = new System.Drawing.Point(175, 26);
            this.rbLengthThik.Name = "rbLengthThik";
            this.rbLengthThik.Size = new System.Drawing.Size(100, 17);
            this.rbLengthThik.TabIndex = 3;
            this.rbLengthThik.TabStop = true;
            this.rbLengthThik.Text = "Длина (трубы)";
            this.rbLengthThik.UseVisualStyleBackColor = true;
            // 
            // rbLengthWidth
            // 
            this.rbLengthWidth.AutoSize = true;
            this.rbLengthWidth.Checked = true;
            this.rbLengthWidth.Location = new System.Drawing.Point(5, 26);
            this.rbLengthWidth.Name = "rbLengthWidth";
            this.rbLengthWidth.Size = new System.Drawing.Size(164, 17);
            this.rbLengthWidth.TabIndex = 5;
            this.rbLengthWidth.TabStop = true;
            this.rbLengthWidth.Text = "По длине и ширине (листы)";
            this.rbLengthWidth.UseVisualStyleBackColor = true;
            // 
            // rbTable
            // 
            this.rbTable.AutoSize = true;
            this.rbTable.Location = new System.Drawing.Point(453, 26);
            this.rbTable.Name = "rbTable";
            this.rbTable.Size = new System.Drawing.Size(89, 17);
            this.rbTable.TabIndex = 4;
            this.rbTable.TabStop = true;
            this.rbTable.Text = "По таблицам";
            this.rbTable.UseVisualStyleBackColor = true;
            // 
            // teName
            // 
            this.teName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teName.Location = new System.Drawing.Point(233, 9);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(519, 20);
            this.teName.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Наименование (тип и через пробел номер)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Примечание";
            // 
            // teNote
            // 
            this.teNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teNote.Location = new System.Drawing.Point(233, 61);
            this.teNote.Name = "teNote";
            this.teNote.Size = new System.Drawing.Size(519, 20);
            this.teNote.TabIndex = 12;
            // 
            // teProfile
            // 
            this.teProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teProfile.Location = new System.Drawing.Point(233, 35);
            this.teProfile.Name = "teProfile";
            this.teProfile.Size = new System.Drawing.Size(519, 20);
            this.teProfile.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Профиль";
            // 
            // GostForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(766, 421);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teProfile);
            this.Controls.Add(this.teNote);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teName);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Name = "GostForm";
            this.Text = "ГОСТ";
            this.Load += new System.EventHandler(this.GostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStandartWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standartWeightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStandartsWeights)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProfile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStandartWeight;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStandartsWeights;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource standartWeightBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStandartSize;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private System.Windows.Forms.RadioButton rbDopMetrPog;
        private System.Windows.Forms.RadioButton rbDopMetrSquare;
        private System.Windows.Forms.RadioButton rbDopPieces;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.RadioButton rbLengthThik;
        private System.Windows.Forms.RadioButton rbLengthWidth;
        private System.Windows.Forms.RadioButton rbTable;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbLengthCircle;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teNote;
        private DevExpress.XtraEditors.TextEdit teProfile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}