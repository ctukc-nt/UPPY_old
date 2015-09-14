namespace UPPY.Desktop.Views.TechRoutes
{
    partial class TechRouteDocumentForm
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
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teNote = new DevExpress.XtraEditors.TextEdit();
            this.gcTechOperations = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTechOper = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoTechOperations = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.techOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.commandButtons1 = new UPPY.Desktop.Views.Controls.CommandButtons();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTechOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // teName
            // 
            this.teName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teName.Location = new System.Drawing.Point(105, 13);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(583, 20);
            this.teName.TabIndex = 0;
            // 
            // teNote
            // 
            this.teNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teNote.Location = new System.Drawing.Point(105, 40);
            this.teNote.Name = "teNote";
            this.teNote.Size = new System.Drawing.Size(583, 20);
            this.teNote.TabIndex = 1;
            // 
            // gcTechOperations
            // 
            this.gcTechOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTechOperations.Location = new System.Drawing.Point(12, 112);
            this.gcTechOperations.MainView = this.gridView1;
            this.gcTechOperations.Name = "gcTechOperations";
            this.gcTechOperations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoTechOperations});
            this.gcTechOperations.Size = new System.Drawing.Size(676, 228);
            this.gcTechOperations.TabIndex = 2;
            this.gcTechOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcOrder,
            this.gcTechOper});
            this.gridView1.GridControl = this.gcTechOperations;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            // 
            // gcOrder
            // 
            this.gcOrder.Caption = "Номер";
            this.gcOrder.FieldName = "Order";
            this.gcOrder.MaxWidth = 75;
            this.gcOrder.MinWidth = 75;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.OptionsColumn.AllowEdit = false;
            this.gcOrder.OptionsColumn.AllowFocus = false;
            this.gcOrder.OptionsColumn.AllowMove = false;
            this.gcOrder.Visible = true;
            this.gcOrder.VisibleIndex = 0;
            // 
            // gcTechOper
            // 
            this.gcTechOper.Caption = "Тех. операция";
            this.gcTechOper.ColumnEdit = this.repoTechOperations;
            this.gcTechOper.FieldName = "TechOperationId";
            this.gcTechOper.Name = "gcTechOper";
            this.gcTechOper.Visible = true;
            this.gcTechOper.VisibleIndex = 1;
            // 
            // repoTechOperations
            // 
            this.repoTechOperations.AutoHeight = false;
            this.repoTechOperations.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoTechOperations.DataSource = this.techOperationBindingSource;
            this.repoTechOperations.DisplayMember = "ShortName";
            this.repoTechOperations.Name = "repoTechOperations";
            this.repoTechOperations.ValueMember = "Id";
            this.repoTechOperations.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // techOperationBindingSource
            // 
            this.techOperationBindingSource.DataSource = typeof(Core.DomainModel.TechOperation);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Наименование";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Примечание";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(513, 356);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(613, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // commandButtons1
            // 
            this.commandButtons1.AllowDelete = true;
            this.commandButtons1.AllowEdit = false;
            this.commandButtons1.AllowNew = true;
            this.commandButtons1.Location = new System.Drawing.Point(13, 72);
            this.commandButtons1.Name = "commandButtons1";
            this.commandButtons1.Size = new System.Drawing.Size(147, 34);
            this.commandButtons1.TabIndex = 10;
            this.commandButtons1.ButtonAddClick += new System.EventHandler(this.btnAdd_Click);
            this.commandButtons1.ButtonDeleteClick += new System.EventHandler(this.btnDelete_Click);
            // 
            // TechRouteDocumentForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(698, 391);
            this.Controls.Add(this.commandButtons1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcTechOperations);
            this.Controls.Add(this.teNote);
            this.Controls.Add(this.teName);
            this.Name = "TechRouteDocumentForm";
            this.Text = "TechRouteDocumentForm";
            this.Load += new System.EventHandler(this.TechRouteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTechOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teNote;
        private DevExpress.XtraGrid.GridControl gcTechOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gcTechOper;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repoTechOperations;
        private System.Windows.Forms.BindingSource techOperationBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private Controls.CommandButtons commandButtons1;
    }
}