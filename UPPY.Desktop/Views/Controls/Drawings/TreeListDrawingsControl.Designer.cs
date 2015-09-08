namespace UPPY.Desktop.Views.Controls.Drawings
{
    partial class TreeListDrawingsControl
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeListDrawingsControl));
            this.tlDarwings = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcDesignation = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcNumberOnSpec = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcProfile = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcStandartSize = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcGostOnSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcMarkSteal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcGostOnMaterial = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcLength = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcWidth = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcCountAll = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcWeigth = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcWeightAll = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcOp = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcPartOfDrawingId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcTechRouteId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repoTechRoutes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAnotherView = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController();
            this.btnAddChild = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnPaste = new DevExpress.XtraEditors.SimpleButton();
            this.sbCreateStandart = new DevExpress.XtraEditors.SimpleButton();
            this.sbShowInTable = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tlDarwings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tlDarwings
            // 
            this.tlDarwings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDarwings.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcName,
            this.tlcDesignation,
            this.tlcNumberOnSpec,
            this.tlcProfile,
            this.tlcStandartSize,
            this.tlcGostOnSort,
            this.tlcMarkSteal,
            this.tlcGostOnMaterial,
            this.tlcLength,
            this.tlcWidth,
            this.tlcCount,
            this.tlcCountAll,
            this.tlcWeigth,
            this.tlcWeightAll,
            this.tlcOp,
            this.tlcPartOfDrawingId,
            this.tlcTechRouteId});
            this.tlDarwings.FooterPanelHeight = 30;
            this.tlDarwings.KeyFieldName = "Id";
            this.tlDarwings.Location = new System.Drawing.Point(0, 39);
            this.tlDarwings.Name = "tlDarwings";
            this.tlDarwings.OptionsBehavior.EnableFiltering = true;
            this.tlDarwings.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended;
            this.tlDarwings.ParentFieldName = "ParentId";
            this.tlDarwings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoTechRoutes});
            this.tlDarwings.RootValue = null;
            this.tlDarwings.Size = new System.Drawing.Size(910, 418);
            this.tlDarwings.TabIndex = 4;
            this.tlDarwings.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tlDarwings_CellValueChanged);
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Наименование";
            this.tlcName.FieldName = "Name";
            this.tlcName.Name = "tlcName";
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 1;
            this.tlcName.Width = 73;
            // 
            // tlcDesignation
            // 
            this.tlcDesignation.Caption = "Обозначение";
            this.tlcDesignation.FieldName = "Designation";
            this.tlcDesignation.Name = "tlcDesignation";
            this.tlcDesignation.Visible = true;
            this.tlcDesignation.VisibleIndex = 0;
            this.tlcDesignation.Width = 74;
            // 
            // tlcNumberOnSpec
            // 
            this.tlcNumberOnSpec.Caption = "Номер по спец.";
            this.tlcNumberOnSpec.FieldName = "NumberOnSpec";
            this.tlcNumberOnSpec.Name = "tlcNumberOnSpec";
            this.tlcNumberOnSpec.Visible = true;
            this.tlcNumberOnSpec.VisibleIndex = 2;
            this.tlcNumberOnSpec.Width = 53;
            // 
            // tlcProfile
            // 
            this.tlcProfile.Caption = "Профиль";
            this.tlcProfile.FieldName = "Profile";
            this.tlcProfile.Name = "tlcProfile";
            this.tlcProfile.Visible = true;
            this.tlcProfile.VisibleIndex = 3;
            this.tlcProfile.Width = 60;
            // 
            // tlcStandartSize
            // 
            this.tlcStandartSize.Caption = "Типоразмер";
            this.tlcStandartSize.FieldName = "StandartSize";
            this.tlcStandartSize.Name = "tlcStandartSize";
            this.tlcStandartSize.Visible = true;
            this.tlcStandartSize.VisibleIndex = 4;
            this.tlcStandartSize.Width = 53;
            // 
            // tlcGostOnSort
            // 
            this.tlcGostOnSort.Caption = "ГОСТ на сортамент";
            this.tlcGostOnSort.FieldName = "GostOnSort";
            this.tlcGostOnSort.Name = "tlcGostOnSort";
            this.tlcGostOnSort.Visible = true;
            this.tlcGostOnSort.VisibleIndex = 5;
            this.tlcGostOnSort.Width = 86;
            // 
            // tlcMarkSteal
            // 
            this.tlcMarkSteal.Caption = "Марка стали";
            this.tlcMarkSteal.FieldName = "MarkSteal";
            this.tlcMarkSteal.Name = "tlcMarkSteal";
            this.tlcMarkSteal.Visible = true;
            this.tlcMarkSteal.VisibleIndex = 6;
            this.tlcMarkSteal.Width = 57;
            // 
            // tlcGostOnMaterial
            // 
            this.tlcGostOnMaterial.Caption = "ГОСТ на материал";
            this.tlcGostOnMaterial.FieldName = "GostOnMaterial";
            this.tlcGostOnMaterial.Name = "tlcGostOnMaterial";
            this.tlcGostOnMaterial.Visible = true;
            this.tlcGostOnMaterial.VisibleIndex = 7;
            this.tlcGostOnMaterial.Width = 70;
            // 
            // tlcLength
            // 
            this.tlcLength.Caption = "Длина";
            this.tlcLength.FieldName = "Length";
            this.tlcLength.Name = "tlcLength";
            this.tlcLength.Visible = true;
            this.tlcLength.VisibleIndex = 8;
            this.tlcLength.Width = 46;
            // 
            // tlcWidth
            // 
            this.tlcWidth.Caption = "Ширина";
            this.tlcWidth.FieldName = "Width";
            this.tlcWidth.Name = "tlcWidth";
            this.tlcWidth.Visible = true;
            this.tlcWidth.VisibleIndex = 9;
            this.tlcWidth.Width = 54;
            // 
            // tlcCount
            // 
            this.tlcCount.Caption = "Кол-во";
            this.tlcCount.FieldName = "Count";
            this.tlcCount.Name = "tlcCount";
            this.tlcCount.Visible = true;
            this.tlcCount.VisibleIndex = 10;
            this.tlcCount.Width = 56;
            // 
            // tlcCountAll
            // 
            this.tlcCountAll.Caption = "Кол-во всего";
            this.tlcCountAll.FieldName = "CountAll";
            this.tlcCountAll.Name = "tlcCountAll";
            this.tlcCountAll.OptionsColumn.AllowEdit = false;
            this.tlcCountAll.Visible = true;
            this.tlcCountAll.VisibleIndex = 11;
            this.tlcCountAll.Width = 52;
            // 
            // tlcWeigth
            // 
            this.tlcWeigth.Caption = "Вес";
            this.tlcWeigth.FieldName = "Weight";
            this.tlcWeigth.Name = "tlcWeigth";
            this.tlcWeigth.Visible = true;
            this.tlcWeigth.VisibleIndex = 12;
            this.tlcWeigth.Width = 62;
            // 
            // tlcWeightAll
            // 
            this.tlcWeightAll.Caption = "Вес всего";
            this.tlcWeightAll.FieldName = "WeightAll";
            this.tlcWeightAll.Name = "tlcWeightAll";
            this.tlcWeightAll.OptionsColumn.AllowEdit = false;
            this.tlcWeightAll.Visible = true;
            this.tlcWeightAll.VisibleIndex = 13;
            this.tlcWeightAll.Width = 66;
            // 
            // tlcOp
            // 
            this.tlcOp.Caption = "ОП";
            this.tlcOp.FieldName = "Op";
            this.tlcOp.Name = "tlcOp";
            this.tlcOp.Visible = true;
            this.tlcOp.VisibleIndex = 14;
            this.tlcOp.Width = 65;
            // 
            // tlcPartOfDrawingId
            // 
            this.tlcPartOfDrawingId.Name = "tlcPartOfDrawingId";
            // 
            // tlcTechRouteId
            // 
            this.tlcTechRouteId.Caption = "Тех. маршрут";
            this.tlcTechRouteId.ColumnEdit = this.repoTechRoutes;
            this.tlcTechRouteId.FieldName = "TechRouteId";
            this.tlcTechRouteId.Name = "tlcTechRouteId";
            this.tlcTechRouteId.Visible = true;
            this.tlcTechRouteId.VisibleIndex = 15;
            this.tlcTechRouteId.Width = 153;
            // 
            // repoTechRoutes
            // 
            this.repoTechRoutes.AutoHeight = false;
            this.repoTechRoutes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "showlist", null, true)});
            this.repoTechRoutes.DisplayMember = "Name";
            this.repoTechRoutes.Name = "repoTechRoutes";
            this.repoTechRoutes.ValueMember = "Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(51, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&N";
            this.btnAdd.ToolTip = "Добавить новый на тот же уровень";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowAnotherView
            // 
            this.btnShowAnotherView.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAnotherView.Image")));
            this.btnShowAnotherView.Location = new System.Drawing.Point(107, 5);
            this.btnShowAnotherView.Name = "btnShowAnotherView";
            this.btnShowAnotherView.Size = new System.Drawing.Size(25, 28);
            this.btnShowAnotherView.TabIndex = 6;
            this.btnShowAnotherView.Text = "&O";
            this.btnShowAnotherView.ToolTip = "Открыть в отделшьном окне";
            this.btnShowAnotherView.Click += new System.EventHandler(this.btnShowAnotherView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(188, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&D";
            this.btnDelete.ToolTip = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(3, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 28);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "&R";
            this.btnRefresh.ToolTip = "Обновить список";
            this.btnRefresh.ToolTipController = this.toolTipController1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Image = ((System.Drawing.Image)(resources.GetObject("btnAddChild.Image")));
            this.btnAddChild.Location = new System.Drawing.Point(79, 5);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(25, 28);
            this.btnAddChild.TabIndex = 9;
            this.btnAddChild.Text = "&S";
            this.btnAddChild.ToolTip = "Добавить новый потомком";
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(244, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(25, 28);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "&B";
            this.btnCopy.ToolTip = "Копировать";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Enabled = false;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.Location = new System.Drawing.Point(275, 5);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(25, 28);
            this.btnPaste.TabIndex = 11;
            this.btnPaste.Text = "&V";
            this.btnPaste.ToolTip = "Вставить";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // sbCreateStandart
            // 
            this.sbCreateStandart.Image = ((System.Drawing.Image)(resources.GetObject("sbCreateStandart.Image")));
            this.sbCreateStandart.Location = new System.Drawing.Point(330, 5);
            this.sbCreateStandart.Name = "sbCreateStandart";
            this.sbCreateStandart.Size = new System.Drawing.Size(25, 28);
            this.sbCreateStandart.TabIndex = 12;
            this.sbCreateStandart.Text = "&L";
            this.sbCreateStandart.ToolTip = "Создать нормы на основании выделенной строки";
            this.sbCreateStandart.Click += new System.EventHandler(this.sbCreateStandart_Click);
            // 
            // sbShowInTable
            // 
            this.sbShowInTable.Image = ((System.Drawing.Image)(resources.GetObject("sbShowInTable.Image")));
            this.sbShowInTable.Location = new System.Drawing.Point(138, 5);
            this.sbShowInTable.Name = "sbShowInTable";
            this.sbShowInTable.Size = new System.Drawing.Size(25, 28);
            this.sbShowInTable.TabIndex = 13;
            this.sbShowInTable.Text = "&L";
            this.sbShowInTable.ToolTip = "Показать в виде таблицы";
            this.sbShowInTable.Click += new System.EventHandler(this.sbShowInTable_Click);
            // 
            // TreeListDrawingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbShowInTable);
            this.Controls.Add(this.sbCreateStandart);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowAnotherView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tlDarwings);
            this.Name = "TreeListDrawingsControl";
            this.Size = new System.Drawing.Size(910, 457);
            ((System.ComponentModel.ISupportInitialize)(this.tlDarwings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechRoutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlDarwings;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDesignation;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcNumberOnSpec;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcProfile;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcStandartSize;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcGostOnSort;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcMarkSteal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcGostOnMaterial;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLength;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWidth;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCountAll;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWeigth;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWeightAll;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcOp;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcPartOfDrawingId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcTechRouteId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoTechRoutes;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnShowAnotherView;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.SimpleButton btnAddChild;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnPaste;
        private DevExpress.XtraEditors.SimpleButton sbCreateStandart;
        private DevExpress.XtraEditors.SimpleButton sbShowInTable;
    }
}
