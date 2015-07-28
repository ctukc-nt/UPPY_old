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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.techOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefreshSource = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelDrawing = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDrawing = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.techOperationBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(810, 341);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // techOperationBindingSource
            // 
            this.techOperationBindingSource.DataSource = typeof(Core.DomainModel.TechOperation);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colShortName,
            this.colFullName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // 
            // btnDelDrawing
            // 
            this.btnDelDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelDrawing.Location = new System.Drawing.Point(829, 42);
            this.btnDelDrawing.Name = "btnDelDrawing";
            this.btnDelDrawing.Size = new System.Drawing.Size(94, 23);
            this.btnDelDrawing.TabIndex = 8;
            this.btnDelDrawing.Text = "Del o&peration";
            // 
            // btnAddDrawing
            // 
            this.btnAddDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDrawing.Location = new System.Drawing.Point(829, 13);
            this.btnAddDrawing.Name = "btnAddDrawing";
            this.btnAddDrawing.Size = new System.Drawing.Size(94, 23);
            this.btnAddDrawing.TabIndex = 7;
            this.btnAddDrawing.Text = "Add &operation";
            // 
            // TechOperationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 366);
            this.Controls.Add(this.btnRefreshSource);
            this.Controls.Add(this.btnDelDrawing);
            this.Controls.Add(this.btnAddDrawing);
            this.Controls.Add(this.gridControl1);
            this.Name = "TechOperationsListForm";
            this.Text = "TechOperationsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource techOperationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraEditors.SimpleButton btnRefreshSource;
        private DevExpress.XtraEditors.SimpleButton btnDelDrawing;
        private DevExpress.XtraEditors.SimpleButton btnAddDrawing;
    }
}