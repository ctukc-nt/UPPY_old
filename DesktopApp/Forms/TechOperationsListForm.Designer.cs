namespace DesktopApp.Forms
{
    partial class TechOperationsListForm
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.techOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvOperations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshSource = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.techOperationBindingSource;
            this.gridControl.Location = new System.Drawing.Point(13, 13);
            this.gridControl.MainView = this.gvOperations;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(810, 341);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOperations});
            // 
            // techOperationBindingSource
            // 
            this.techOperationBindingSource.DataSource = typeof(Core.DomainModel.TechOperation);
            // 
            // gvOperations
            // 
            this.gvOperations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colShortName,
            this.colFullName});
            this.gvOperations.GridControl = this.gridControl;
            this.gvOperations.Name = "gvOperations";
            // 
            // colId
            // 
            this.colId.Caption = "ИД";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colShortName
            // 
            this.colShortName.Caption = "Краткое наименование";
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Полное наименование";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 2;
            // 
            // btnRefreshSource
            // 
            this.btnRefreshSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSource.Location = new System.Drawing.Point(829, 71);
            this.btnRefreshSource.Name = "btnRefreshSource";
            this.btnRefreshSource.Size = new System.Drawing.Size(94, 23);
            this.btnRefreshSource.TabIndex = 10;
            this.btnRefreshSource.Text = "&Refresh";
            this.btnRefreshSource.Click += new System.EventHandler(this.btnRefreshSource_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(829, 42);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Del o&peration";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(829, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add &operation";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TechOperationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 366);
            this.Controls.Add(this.btnRefreshSource);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridControl);
            this.Name = "TechOperationsListForm";
            this.Text = "TechOperationsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOperations;
        private System.Windows.Forms.BindingSource techOperationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraEditors.SimpleButton btnRefreshSource;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}