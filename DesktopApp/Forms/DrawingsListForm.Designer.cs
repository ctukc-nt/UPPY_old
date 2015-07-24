namespace DesktopApp.Forms
{
    partial class DrawingsListForm
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.drawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberOnSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStandartSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGostOnSort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkSteal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGostOnMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWidth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountAll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightAll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartOfDrawingId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechRouteId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(344, 108);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(736, 286);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colParentId,
            this.colName,
            this.colDesignation,
            this.colNumberOnSpec,
            this.colProfile,
            this.colStandartSize,
            this.colGostOnSort,
            this.colMarkSteal,
            this.colGostOnMaterial,
            this.colLength,
            this.colWidth,
            this.colCount,
            this.colCountAll,
            this.colWeight,
            this.colWeightAll,
            this.colOP,
            this.colPartOfDrawingId,
            this.colTechRouteId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(Core.DomainModel.Drawing);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colDesignation
            // 
            this.colDesignation.FieldName = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Visible = true;
            this.colDesignation.VisibleIndex = 3;
            // 
            // colNumberOnSpec
            // 
            this.colNumberOnSpec.FieldName = "NumberOnSpec";
            this.colNumberOnSpec.Name = "colNumberOnSpec";
            this.colNumberOnSpec.Visible = true;
            this.colNumberOnSpec.VisibleIndex = 4;
            // 
            // colProfile
            // 
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 5;
            // 
            // colStandartSize
            // 
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 6;
            // 
            // colGostOnSort
            // 
            this.colGostOnSort.FieldName = "GostOnSort";
            this.colGostOnSort.Name = "colGostOnSort";
            this.colGostOnSort.Visible = true;
            this.colGostOnSort.VisibleIndex = 7;
            // 
            // colMarkSteal
            // 
            this.colMarkSteal.FieldName = "MarkSteal";
            this.colMarkSteal.Name = "colMarkSteal";
            this.colMarkSteal.Visible = true;
            this.colMarkSteal.VisibleIndex = 8;
            // 
            // colGostOnMaterial
            // 
            this.colGostOnMaterial.FieldName = "GostOnMaterial";
            this.colGostOnMaterial.Name = "colGostOnMaterial";
            this.colGostOnMaterial.Visible = true;
            this.colGostOnMaterial.VisibleIndex = 9;
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 10;
            // 
            // colWidth
            // 
            this.colWidth.FieldName = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.Visible = true;
            this.colWidth.VisibleIndex = 11;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 12;
            // 
            // colCountAll
            // 
            this.colCountAll.FieldName = "CountAll";
            this.colCountAll.Name = "colCountAll";
            this.colCountAll.Visible = true;
            this.colCountAll.VisibleIndex = 13;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 14;
            // 
            // colWeightAll
            // 
            this.colWeightAll.FieldName = "WeightAll";
            this.colWeightAll.Name = "colWeightAll";
            this.colWeightAll.Visible = true;
            this.colWeightAll.VisibleIndex = 15;
            // 
            // colOP
            // 
            this.colOP.FieldName = "OP";
            this.colOP.Name = "colOP";
            this.colOP.Visible = true;
            this.colOP.VisibleIndex = 16;
            // 
            // colPartOfDrawingId
            // 
            this.colPartOfDrawingId.FieldName = "PartOfDrawingId";
            this.colPartOfDrawingId.Name = "colPartOfDrawingId";
            this.colPartOfDrawingId.Visible = true;
            this.colPartOfDrawingId.VisibleIndex = 17;
            // 
            // colTechRouteId
            // 
            this.colTechRouteId.FieldName = "TechRouteId";
            this.colTechRouteId.Name = "colTechRouteId";
            this.colTechRouteId.Visible = true;
            this.colTechRouteId.VisibleIndex = 18;
            // 
            // DrawingsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 406);
            this.Controls.Add(this.gridControl1);
            this.Name = "DrawingsListForm";
            this.Text = "DrawingsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colParentId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOnSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colStandartSize;
        private DevExpress.XtraGrid.Columns.GridColumn colGostOnSort;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkSteal;
        private DevExpress.XtraGrid.Columns.GridColumn colGostOnMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colWidth;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colCountAll;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightAll;
        private DevExpress.XtraGrid.Columns.GridColumn colOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPartOfDrawingId;
        private DevExpress.XtraGrid.Columns.GridColumn colTechRouteId;
        private System.Windows.Forms.BindingSource drawingBindingSource;
    }
}