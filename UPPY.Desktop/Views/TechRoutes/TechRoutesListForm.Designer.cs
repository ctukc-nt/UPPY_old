namespace UPPY.Desktop.Views.TechRoutes
{
    partial class TechRoutesListForm
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
            this.techRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcTechRoutes = new DevExpress.XtraGrid.GridControl();
            this.gvTechRoutes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commandButtons1 = new UPPY.Desktop.Views.Controls.CommandButtons();
            ((System.ComponentModel.ISupportInitialize)(this.techRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTechRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTechRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // techRouteBindingSource
            // 
            this.techRouteBindingSource.DataSource = typeof(Core.DomainModel.TechRoute);
            // 
            // techOperationsBindingSource
            // 
            this.techOperationsBindingSource.DataMember = "TechOperations";
            this.techOperationsBindingSource.DataSource = this.techRouteBindingSource;
            // 
            // gcTechRoutes
            // 
            this.gcTechRoutes.DataSource = this.techRouteBindingSource;
            this.gcTechRoutes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTechRoutes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTechRoutes.EmbeddedNavigator.Buttons.NextPage.Enabled = false;
            this.gcTechRoutes.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcTechRoutes.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcTechRoutes.EmbeddedNavigator.TextStringFormat = "";
            this.gcTechRoutes.Location = new System.Drawing.Point(12, 41);
            this.gcTechRoutes.MainView = this.gvTechRoutes;
            this.gcTechRoutes.Name = "gcTechRoutes";
            this.gcTechRoutes.Size = new System.Drawing.Size(900, 359);
            this.gcTechRoutes.TabIndex = 0;
            this.gcTechRoutes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTechRoutes});
            // 
            // gvTechRoutes
            // 
            this.gvTechRoutes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colNote});
            this.gvTechRoutes.DetailHeight = 200;
            this.gvTechRoutes.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gvTechRoutes.GridControl = this.gcTechRoutes;
            this.gvTechRoutes.GroupFormat = "";
            this.gvTechRoutes.Name = "gvTechRoutes";
            this.gvTechRoutes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvTechRoutes.OptionsDetail.EnableMasterViewMode = false;
            this.gvTechRoutes.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            // 
            // commandButtons1
            // 
            this.commandButtons1.AllowDelete = true;
            this.commandButtons1.AllowEdit = true;
            this.commandButtons1.AllowNew = true;
            this.commandButtons1.Location = new System.Drawing.Point(12, 3);
            this.commandButtons1.Name = "commandButtons1";
            this.commandButtons1.Size = new System.Drawing.Size(147, 34);
            this.commandButtons1.TabIndex = 13;
            this.commandButtons1.ButtonRefreshClick += new System.EventHandler(this.btnRefresh_Click);
            this.commandButtons1.ButtonAddClick += new System.EventHandler(this.btnAdd_Click);
            this.commandButtons1.ButtonEditClick += new System.EventHandler(this.btnEdit_Click);
            this.commandButtons1.ButtonDeleteClick += new System.EventHandler(this.btnDelete_Click);
            // 
            // TechRoutesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 412);
            this.Controls.Add(this.commandButtons1);
            this.Controls.Add(this.gcTechRoutes);
            this.Name = "TechRoutesListForm";
            this.Text = "TechRoutesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.techRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTechRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTechRoutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource techRouteBindingSource;
        private System.Windows.Forms.BindingSource techOperationsBindingSource;
        private DevExpress.XtraGrid.GridControl gcTechRoutes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTechRoutes;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private Controls.CommandButtons commandButtons1;
    }
}