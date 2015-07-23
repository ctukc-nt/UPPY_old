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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcDesignation = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcNumberOnSpec = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcProfile = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rProfile = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
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
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnAddDrawing = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelDrawing = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSubDrawing = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
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
            this.treeList1.FooterPanelHeight = 30;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsFind.AllowFindPanel = true;
            this.treeList1.OptionsFind.AlwaysVisible = true;
            this.treeList1.ParentFieldName = "ParentId";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rProfile,
            this.repositoryItemComboBox1});
            this.treeList1.RootValue = null;
            this.treeList1.Size = new System.Drawing.Size(944, 350);
            this.treeList1.TabIndex = 2;
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Наименование";
            this.tlcName.FieldName = "Name";
            this.tlcName.Name = "tlcName";
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 1;
            // 
            // tlcDesignation
            // 
            this.tlcDesignation.Caption = "Обозначение";
            this.tlcDesignation.FieldName = "Designation";
            this.tlcDesignation.Name = "tlcDesignation";
            this.tlcDesignation.Visible = true;
            this.tlcDesignation.VisibleIndex = 0;
            // 
            // tlcNumberOnSpec
            // 
            this.tlcNumberOnSpec.Caption = "Номер по спец.";
            this.tlcNumberOnSpec.FieldName = "NumberOnSpec";
            this.tlcNumberOnSpec.Name = "tlcNumberOnSpec";
            this.tlcNumberOnSpec.Visible = true;
            this.tlcNumberOnSpec.VisibleIndex = 2;
            // 
            // tlcProfile
            // 
            this.tlcProfile.Caption = "Профиль";
            this.tlcProfile.ColumnEdit = this.rProfile;
            this.tlcProfile.FieldName = "Profile";
            this.tlcProfile.Name = "tlcProfile";
            this.tlcProfile.Visible = true;
            this.tlcProfile.VisibleIndex = 3;
            // 
            // rProfile
            // 
            this.rProfile.AutoHeight = false;
            this.rProfile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rProfile.Name = "rProfile";
            // 
            // tlcStandartSize
            // 
            this.tlcStandartSize.Caption = "Типоразмер";
            this.tlcStandartSize.FieldName = "StandartSize";
            this.tlcStandartSize.Name = "tlcStandartSize";
            this.tlcStandartSize.Visible = true;
            this.tlcStandartSize.VisibleIndex = 4;
            // 
            // tlcGostOnSort
            // 
            this.tlcGostOnSort.Caption = "ГОСТ на сортамент";
            this.tlcGostOnSort.FieldName = "GostOnSort";
            this.tlcGostOnSort.Name = "tlcGostOnSort";
            this.tlcGostOnSort.Visible = true;
            this.tlcGostOnSort.VisibleIndex = 5;
            // 
            // tlcMarkSteal
            // 
            this.tlcMarkSteal.Caption = "Марка стали";
            this.tlcMarkSteal.FieldName = "MarkSteal";
            this.tlcMarkSteal.Name = "tlcMarkSteal";
            this.tlcMarkSteal.Visible = true;
            this.tlcMarkSteal.VisibleIndex = 6;
            // 
            // tlcGostOnMaterial
            // 
            this.tlcGostOnMaterial.Caption = "ГОСТ на материал";
            this.tlcGostOnMaterial.FieldName = "GostOnMaterial";
            this.tlcGostOnMaterial.Name = "tlcGostOnMaterial";
            this.tlcGostOnMaterial.Visible = true;
            this.tlcGostOnMaterial.VisibleIndex = 7;
            // 
            // tlcLength
            // 
            this.tlcLength.Caption = "Длина";
            this.tlcLength.FieldName = "GostOnMaterial";
            this.tlcLength.Name = "tlcLength";
            this.tlcLength.Visible = true;
            this.tlcLength.VisibleIndex = 8;
            // 
            // tlcWidth
            // 
            this.tlcWidth.Caption = "Ширина";
            this.tlcWidth.FieldName = "Width";
            this.tlcWidth.Name = "tlcWidth";
            this.tlcWidth.Visible = true;
            this.tlcWidth.VisibleIndex = 9;
            // 
            // tlcCount
            // 
            this.tlcCount.Caption = "Кол-во";
            this.tlcCount.FieldName = "Count";
            this.tlcCount.Name = "tlcCount";
            this.tlcCount.Visible = true;
            this.tlcCount.VisibleIndex = 10;
            // 
            // tlcCountAll
            // 
            this.tlcCountAll.Caption = "Кол-во всего";
            this.tlcCountAll.FieldName = "CountAll";
            this.tlcCountAll.Name = "tlcCountAll";
            this.tlcCountAll.Visible = true;
            this.tlcCountAll.VisibleIndex = 11;
            // 
            // tlcWeigth
            // 
            this.tlcWeigth.Caption = "Вес";
            this.tlcWeigth.FieldName = "Weight";
            this.tlcWeigth.Name = "tlcWeigth";
            this.tlcWeigth.Visible = true;
            this.tlcWeigth.VisibleIndex = 12;
            // 
            // tlcWeightAll
            // 
            this.tlcWeightAll.Caption = "Вес всего";
            this.tlcWeightAll.FieldName = "WeightAll";
            this.tlcWeightAll.Name = "tlcWeightAll";
            this.tlcWeightAll.Visible = true;
            this.tlcWeightAll.VisibleIndex = 13;
            // 
            // tlcOp
            // 
            this.tlcOp.Caption = "ОП";
            this.tlcOp.FieldName = "Op";
            this.tlcOp.Name = "tlcOp";
            this.tlcOp.Visible = true;
            this.tlcOp.VisibleIndex = 14;
            // 
            // tlcPartOfDrawingId
            // 
            this.tlcPartOfDrawingId.Name = "tlcPartOfDrawingId";
            this.tlcPartOfDrawingId.Visible = true;
            this.tlcPartOfDrawingId.VisibleIndex = 15;
            // 
            // tlcTechRouteId
            // 
            this.tlcTechRouteId.Name = "tlcTechRouteId";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // btnAddDrawing
            // 
            this.btnAddDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDrawing.Location = new System.Drawing.Point(950, 12);
            this.btnAddDrawing.Name = "btnAddDrawing";
            this.btnAddDrawing.Size = new System.Drawing.Size(94, 23);
            this.btnAddDrawing.TabIndex = 3;
            this.btnAddDrawing.Text = "Add drawing";
            this.btnAddDrawing.Click += new System.EventHandler(this.btnAddDrawing_Click);
            // 
            // btnDelDrawing
            // 
            this.btnDelDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelDrawing.Location = new System.Drawing.Point(950, 70);
            this.btnDelDrawing.Name = "btnDelDrawing";
            this.btnDelDrawing.Size = new System.Drawing.Size(94, 23);
            this.btnDelDrawing.TabIndex = 4;
            this.btnDelDrawing.Text = "Del drawing";
            this.btnDelDrawing.Click += new System.EventHandler(this.btnDelDrawing_Click);
            // 
            // btnAddSubDrawing
            // 
            this.btnAddSubDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubDrawing.Location = new System.Drawing.Point(950, 41);
            this.btnAddSubDrawing.Name = "btnAddSubDrawing";
            this.btnAddSubDrawing.Size = new System.Drawing.Size(94, 23);
            this.btnAddSubDrawing.TabIndex = 5;
            this.btnAddSubDrawing.Text = "Add subdrawing";
            this.btnAddSubDrawing.Click += new System.EventHandler(this.btnAddSubDrawing_Click);
            // 
            // DrawingsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 350);
            this.Controls.Add(this.btnAddSubDrawing);
            this.Controls.Add(this.btnDelDrawing);
            this.Controls.Add(this.btnAddDrawing);
            this.Controls.Add(this.treeList1);
            this.Name = "DrawingsListForm";
            this.Text = "DrawingsListForm";
            this.Load += new System.EventHandler(this.DrawingsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDesignation;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcNumberOnSpec;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcProfile;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rProfile;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.SimpleButton btnAddDrawing;
        private DevExpress.XtraEditors.SimpleButton btnDelDrawing;
        private DevExpress.XtraEditors.SimpleButton btnAddSubDrawing;
    }
}