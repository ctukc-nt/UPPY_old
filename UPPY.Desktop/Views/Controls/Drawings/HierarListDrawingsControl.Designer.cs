namespace UPPY.Desktop.Views.Controls.Drawings
{
    partial class HierarListDrawingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcDrawings = new DevExpress.XtraGrid.GridControl();
            this.gvDrawings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colButtonSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDrawings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrawings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDrawings
            // 
            this.gcDrawings.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gcDrawings.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcDrawings.Location = new System.Drawing.Point(0, 0);
            this.gcDrawings.MainView = this.gvDrawings;
            this.gcDrawings.Name = "gcDrawings";
            this.gcDrawings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemButtonEdit1});
            this.gcDrawings.Size = new System.Drawing.Size(820, 426);
            this.gcDrawings.TabIndex = 1;
            this.gcDrawings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDrawings});
            // 
            // gvDrawings
            // 
            this.gvDrawings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
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
            this.colTechRouteId,
            this.colButtonSave});
            this.gvDrawings.GridControl = this.gcDrawings;
            this.gvDrawings.Name = "gvDrawings";
            this.gvDrawings.OptionsDetail.EnableMasterViewMode = false;
            this.gvDrawings.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDrawings.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDrawings_RowCellStyle);
            this.gvDrawings.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvDrawings_CustomUnboundColumnData);
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Номер п/п";
            this.colNumber.FieldName = "HierarchyNumber";
            this.colNumber.Name = "colNumber";
            this.colNumber.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 66;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 52;
            // 
            // colDesignation
            // 
            this.colDesignation.Caption = "Обозначение";
            this.colDesignation.FieldName = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Visible = true;
            this.colDesignation.VisibleIndex = 1;
            this.colDesignation.Width = 52;
            // 
            // colNumberOnSpec
            // 
            this.colNumberOnSpec.Caption = "Номер по сп-ции";
            this.colNumberOnSpec.FieldName = "NumberOnSpec";
            this.colNumberOnSpec.Name = "colNumberOnSpec";
            this.colNumberOnSpec.Visible = true;
            this.colNumberOnSpec.VisibleIndex = 3;
            this.colNumberOnSpec.Width = 87;
            // 
            // colProfile
            // 
            this.colProfile.Caption = "Профиль";
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 4;
            this.colProfile.Width = 49;
            // 
            // colStandartSize
            // 
            this.colStandartSize.Caption = "Типоразмер";
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 5;
            this.colStandartSize.Width = 49;
            // 
            // colGostOnSort
            // 
            this.colGostOnSort.Caption = "ГОСТ на сортамент";
            this.colGostOnSort.FieldName = "GostOnSort";
            this.colGostOnSort.Name = "colGostOnSort";
            this.colGostOnSort.Visible = true;
            this.colGostOnSort.VisibleIndex = 6;
            this.colGostOnSort.Width = 49;
            // 
            // colMarkSteal
            // 
            this.colMarkSteal.Caption = "Марка стали";
            this.colMarkSteal.FieldName = "MarkSteal";
            this.colMarkSteal.Name = "colMarkSteal";
            this.colMarkSteal.Visible = true;
            this.colMarkSteal.VisibleIndex = 7;
            this.colMarkSteal.Width = 49;
            // 
            // colGostOnMaterial
            // 
            this.colGostOnMaterial.Caption = "ГОСТ на материал";
            this.colGostOnMaterial.FieldName = "GostOnMaterial";
            this.colGostOnMaterial.Name = "colGostOnMaterial";
            this.colGostOnMaterial.Width = 49;
            // 
            // colLength
            // 
            this.colLength.Caption = "Длина";
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 8;
            this.colLength.Width = 49;
            // 
            // colWidth
            // 
            this.colWidth.Caption = "Ширина";
            this.colWidth.FieldName = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.Visible = true;
            this.colWidth.VisibleIndex = 9;
            this.colWidth.Width = 49;
            // 
            // colCount
            // 
            this.colCount.Caption = "Кол-во";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 10;
            this.colCount.Width = 49;
            // 
            // colCountAll
            // 
            this.colCountAll.Caption = "Кол-во всего";
            this.colCountAll.FieldName = "CountAll";
            this.colCountAll.Name = "colCountAll";
            this.colCountAll.Visible = true;
            this.colCountAll.VisibleIndex = 11;
            this.colCountAll.Width = 49;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Вес";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 12;
            this.colWeight.Width = 49;
            // 
            // colWeightAll
            // 
            this.colWeightAll.Caption = "Вес всего";
            this.colWeightAll.FieldName = "WeightAll";
            this.colWeightAll.Name = "colWeightAll";
            this.colWeightAll.Visible = true;
            this.colWeightAll.VisibleIndex = 13;
            this.colWeightAll.Width = 49;
            // 
            // colOP
            // 
            this.colOP.Caption = "ОП";
            this.colOP.FieldName = "OP";
            this.colOP.Name = "colOP";
            this.colOP.Visible = true;
            this.colOP.VisibleIndex = 14;
            this.colOP.Width = 49;
            // 
            // colPartOfDrawingId
            // 
            this.colPartOfDrawingId.Caption = "Входит в...";
            this.colPartOfDrawingId.FieldName = "PartOfDrawingId";
            this.colPartOfDrawingId.Name = "colPartOfDrawingId";
            this.colPartOfDrawingId.Visible = true;
            this.colPartOfDrawingId.VisibleIndex = 15;
            this.colPartOfDrawingId.Width = 49;
            // 
            // colTechRouteId
            // 
            this.colTechRouteId.Caption = "Тех. маршрут";
            this.colTechRouteId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTechRouteId.FieldName = "TechRouteId";
            this.colTechRouteId.Name = "colTechRouteId";
            this.colTechRouteId.Visible = true;
            this.colTechRouteId.VisibleIndex = 16;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // colButtonSave
            // 
            this.colButtonSave.Caption = "Сохранить";
            this.colButtonSave.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colButtonSave.Name = "colButtonSave";
            this.colButtonSave.Visible = true;
            this.colButtonSave.VisibleIndex = 17;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // HierarListDrawingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDrawings);
            this.Name = "HierarListDrawingsControl";
            this.Size = new System.Drawing.Size(820, 426);
            this.Load += new System.EventHandler(this.HierarListDraweingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDrawings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDrawings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDrawings;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDrawings;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colButtonSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
