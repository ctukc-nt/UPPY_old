namespace UPPY.Desktop.Views.TechOpers
{
    partial class TechOpersListForm
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
            this.gcTechOpers = new DevExpress.XtraGrid.GridControl();
            this.techOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTechOpers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderInPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.cmCommands = new UPPY.Desktop.Views.Controls.CommandButtons();
            ((System.ComponentModel.ISupportInitialize)(this.gcTechOpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTechOpers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcTechOpers
            // 
            this.gcTechOpers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTechOpers.DataSource = this.techOperationBindingSource;
            this.gcTechOpers.Location = new System.Drawing.Point(10, 39);
            this.gcTechOpers.MainView = this.gvTechOpers;
            this.gcTechOpers.Margin = new System.Windows.Forms.Padding(10);
            this.gcTechOpers.Name = "gcTechOpers";
            this.gcTechOpers.Size = new System.Drawing.Size(764, 425);
            this.gcTechOpers.TabIndex = 0;
            this.gcTechOpers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTechOpers});
            // 
            // techOperationBindingSource
            // 
            this.techOperationBindingSource.DataSource = typeof(Core.DomainModel.TechOperation);
            // 
            // gvTechOpers
            // 
            this.gvTechOpers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShortName,
            this.colFullName,
            this.colIsDelete,
            this.colId,
            this.colOrderInPrint});
            this.gvTechOpers.GridControl = this.gcTechOpers;
            this.gvTechOpers.Name = "gvTechOpers";
            this.gvTechOpers.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvTechOpers_CellValueChanged);
            // 
            // colShortName
            // 
            this.colShortName.Caption = "Краткое наименование";
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Полное наименование";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colIsDelete
            // 
            this.colIsDelete.Caption = "Удалена";
            this.colIsDelete.FieldName = "IsDelete";
            this.colIsDelete.Name = "colIsDelete";
            this.colIsDelete.Visible = true;
            this.colIsDelete.VisibleIndex = 3;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colOrderInPrint
            // 
            this.colOrderInPrint.Caption = "Порядок при выводе";
            this.colOrderInPrint.FieldName = "OrderInPrint";
            this.colOrderInPrint.Name = "colOrderInPrint";
            this.colOrderInPrint.Visible = true;
            this.colOrderInPrint.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 49);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(685, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmCommands
            // 
            this.cmCommands.AllowDelete = false;
            this.cmCommands.AllowEdit = false;
            this.cmCommands.AllowNew = true;
            this.cmCommands.Location = new System.Drawing.Point(10, 1);
            this.cmCommands.Margin = new System.Windows.Forms.Padding(10);
            this.cmCommands.Name = "cmCommands";
            this.cmCommands.Size = new System.Drawing.Size(147, 34);
            this.cmCommands.TabIndex = 2;
            this.cmCommands.ButtonRefreshClick += new System.EventHandler(this.cmCommands_ButtonRefreshClick);
            this.cmCommands.ButtonAddClick += new System.EventHandler(this.cmCommands_ButtonAddClick);
            this.cmCommands.ButtonEditClick += new System.EventHandler(this.cmCommands_ButtonEditClick);
            this.cmCommands.ButtonDeleteClick += new System.EventHandler(this.cmCommands_ButtonDeleteClick);
            // 
            // TechOpersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 526);
            this.Controls.Add(this.gcTechOpers);
            this.Controls.Add(this.cmCommands);
            this.Controls.Add(this.panel1);
            this.Name = "TechOpersListForm";
            this.Text = "Список тех. операций";
            this.Load += new System.EventHandler(this.TechOpersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTechOpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTechOpers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTechOpers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTechOpers;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource techOperationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private Controls.CommandButtons cmCommands;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderInPrint;
    }
}