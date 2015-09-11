namespace UPPY.Desktop.Views.Standarts
{
    partial class StandartsListForm
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
            this.gcStandarts = new DevExpress.XtraGrid.GridControl();
            this.standartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvStandarts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDrawing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizationRatio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcStandarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStandarts)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStandarts
            // 
            this.gcStandarts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStandarts.DataSource = this.standartBindingSource;
            this.gcStandarts.Location = new System.Drawing.Point(12, 41);
            this.gcStandarts.MainView = this.gvStandarts;
            this.gcStandarts.Name = "gcStandarts";
            this.gcStandarts.Size = new System.Drawing.Size(844, 430);
            this.gcStandarts.TabIndex = 0;
            this.gcStandarts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStandarts});
            // 
            // standartBindingSource
            // 
            this.standartBindingSource.DataSource = typeof(Core.DomainModel.Standart);
            // 
            // gvStandarts
            // 
            this.gvStandarts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDrawing,
            this.colUtilizationRatio,
            this.colId});
            this.gvStandarts.GridControl = this.gcStandarts;
            this.gvStandarts.Name = "gvStandarts";
            this.gvStandarts.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDrawing
            // 
            this.colDrawing.Caption = "Сброчная единица";
            this.colDrawing.FieldName = "Drawing";
            this.colDrawing.Name = "colDrawing";
            this.colDrawing.Visible = true;
            this.colDrawing.VisibleIndex = 2;
            // 
            // colUtilizationRatio
            // 
            this.colUtilizationRatio.Caption = "Коэф. использования";
            this.colUtilizationRatio.FieldName = "UtilizationRatio";
            this.colUtilizationRatio.Name = "colUtilizationRatio";
            this.colUtilizationRatio.Visible = true;
            this.colUtilizationRatio.VisibleIndex = 1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // StandartsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 483);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gcStandarts);
            this.Name = "StandartsListForm";
            this.Text = "StandartsListForm";
            this.Load += new System.EventHandler(this.StandartsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStandarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStandarts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStandarts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStandarts;
        private System.Windows.Forms.BindingSource standartBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizationRatio;
        private DevExpress.XtraGrid.Columns.GridColumn colDrawing;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}