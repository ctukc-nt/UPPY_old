namespace UPPY.Desktop.Views.Gosts
{
    partial class GostsListViewForm
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
            this.cmCommands = new UPPY.Desktop.Views.Controls.CommandButtons();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gcGosts = new DevExpress.XtraGrid.GridControl();
            this.gostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvGosts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeExtraDimension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightMethodCalculate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGosts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmCommands
            // 
            this.cmCommands.AllowDelete = true;
            this.cmCommands.AllowEdit = true;
            this.cmCommands.AllowNew = true;
            this.cmCommands.Location = new System.Drawing.Point(12, 5);
            this.cmCommands.Name = "cmCommands";
            this.cmCommands.Size = new System.Drawing.Size(147, 34);
            this.cmCommands.TabIndex = 0;
            this.cmCommands.ButtonRefreshClick += new System.EventHandler(this.cmCommands_ButtonRefreshClick);
            this.cmCommands.ButtonAddClick += new System.EventHandler(this.cmCommands_ButtonAddClick);
            this.cmCommands.ButtonEditClick += new System.EventHandler(this.cmCommands_ButtonEditClick);
            this.cmCommands.ButtonDeleteClick += new System.EventHandler(this.cmCommands_ButtonDeleteClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 45);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(614, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gcGosts
            // 
            this.gcGosts.DataSource = this.gostBindingSource;
            this.gcGosts.Location = new System.Drawing.Point(12, 45);
            this.gcGosts.MainView = this.gvGosts;
            this.gcGosts.Name = "gcGosts";
            this.gcGosts.Size = new System.Drawing.Size(683, 238);
            this.gcGosts.TabIndex = 2;
            this.gcGosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGosts});
            // 
            // gostBindingSource
            // 
            this.gostBindingSource.DataSource = typeof(Core.DomainModel.Gost);
            // 
            // gvGosts
            // 
            this.gvGosts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeExtraDimension,
            this.colWeightMethodCalculate,
            this.colName,
            this.colNote,
            this.colId,
            this.colProfile});
            this.gvGosts.GridControl = this.gcGosts;
            this.gvGosts.Name = "gvGosts";
            this.gvGosts.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colTypeExtraDimension
            // 
            this.colTypeExtraDimension.Caption = "Тип доп. ед. изм.";
            this.colTypeExtraDimension.FieldName = "TypeExtraDimension";
            this.colTypeExtraDimension.Name = "colTypeExtraDimension";
            this.colTypeExtraDimension.Visible = true;
            this.colTypeExtraDimension.VisibleIndex = 2;
            // 
            // colWeightMethodCalculate
            // 
            this.colWeightMethodCalculate.Caption = "Метод расчета веса";
            this.colWeightMethodCalculate.FieldName = "WeightMethodCalculate";
            this.colWeightMethodCalculate.Name = "colWeightMethodCalculate";
            this.colWeightMethodCalculate.Visible = true;
            this.colWeightMethodCalculate.VisibleIndex = 3;
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            // 
            // colId
            // 
            this.colId.Caption = "ИД";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colProfile
            // 
            this.colProfile.Caption = "Профиль";
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 1;
            // 
            // GostsListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 334);
            this.Controls.Add(this.gcGosts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmCommands);
            this.Name = "GostsListViewForm";
            this.Text = "GostsListViewForm";
            this.Load += new System.EventHandler(this.GostsListViewForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CommandButtons cmCommands;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcGosts;
        private System.Windows.Forms.BindingSource gostBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGosts;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeExtraDimension;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightMethodCalculate;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colProfile;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}