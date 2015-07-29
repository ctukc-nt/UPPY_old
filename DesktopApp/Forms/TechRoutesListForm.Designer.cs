namespace DesktopApp.Forms
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cnTechRouteOperations = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.techRouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.techRouteBindingSource;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "";
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 359);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colNote});
            this.gridView1.DetailHeight = 200;
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFormat = "";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // cnTechRouteOperations
            // 
            this.cnTechRouteOperations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cnTechRouteOperations.Buttons.Append.Visible = false;
            this.cnTechRouteOperations.Buttons.CancelEdit.Visible = false;
            this.cnTechRouteOperations.Buttons.Edit.Visible = false;
            this.cnTechRouteOperations.Buttons.EndEdit.Visible = false;
            this.cnTechRouteOperations.Buttons.First.Visible = false;
            this.cnTechRouteOperations.Buttons.Last.Visible = false;
            this.cnTechRouteOperations.Buttons.Next.Visible = false;
            this.cnTechRouteOperations.Buttons.NextPage.Visible = false;
            this.cnTechRouteOperations.Buttons.Prev.Visible = false;
            this.cnTechRouteOperations.Buttons.PrevPage.Visible = false;
            this.cnTechRouteOperations.Buttons.Remove.Visible = false;
            this.cnTechRouteOperations.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.cnTechRouteOperations.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(6),
            new DevExpress.XtraEditors.NavigatorCustomButton(9),
            new DevExpress.XtraEditors.NavigatorCustomButton(10)});
            this.cnTechRouteOperations.Location = new System.Drawing.Point(12, 11);
            this.cnTechRouteOperations.Name = "cnTechRouteOperations";
            this.cnTechRouteOperations.ShowToolTips = true;
            this.cnTechRouteOperations.Size = new System.Drawing.Size(374, 24);
            this.cnTechRouteOperations.TabIndex = 1;
            this.cnTechRouteOperations.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.cnTechRouteOperations_ButtonClick);
            // 
            // TechRoutesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 412);
            this.Controls.Add(this.cnTechRouteOperations);
            this.Controls.Add(this.gridControl1);
            this.Name = "TechRoutesListForm";
            this.Text = "TechRoutesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.techRouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource techRouteBindingSource;
        private System.Windows.Forms.BindingSource techOperationsBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.ControlNavigator cnTechRouteOperations;

    }
}