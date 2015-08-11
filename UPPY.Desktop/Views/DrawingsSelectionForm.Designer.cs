﻿namespace UPPY.Desktop.Views
{
    partial class DrawingsSelectionForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.rProfile = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
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
            this.techRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefreshSource = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.rProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDarwings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techRouteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rProfile
            // 
            this.rProfile.AutoHeight = false;
            this.rProfile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rProfile.Name = "rProfile";
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
            this.tlDarwings.Location = new System.Drawing.Point(12, 12);
            this.tlDarwings.Name = "tlDarwings";
            this.tlDarwings.OptionsBehavior.EnableFiltering = true;
            this.tlDarwings.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended;
            this.tlDarwings.ParentFieldName = "ParentId";
            this.tlDarwings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoTechRoutes});
            this.tlDarwings.RootValue = null;
            this.tlDarwings.Size = new System.Drawing.Size(1146, 471);
            this.tlDarwings.TabIndex = 2;
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
            this.tlcLength.FieldName = "GostOnMaterial";
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "showlist", null, true)});
            this.repoTechRoutes.DataSource = this.techRouteBindingSource;
            this.repoTechRoutes.DisplayMember = "Name";
            this.repoTechRoutes.Name = "repoTechRoutes";
            this.repoTechRoutes.ValueMember = "Id";
            this.repoTechRoutes.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoTechRoutes_ButtonClick);
            // 
            // techRouteBindingSource
            // 
            this.techRouteBindingSource.DataSource = typeof(Core.DomainModel.TechRoute);
            // 
            // btnRefreshSource
            // 
            this.btnRefreshSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSource.Location = new System.Drawing.Point(1164, 99);
            this.btnRefreshSource.Name = "btnRefreshSource";
            this.btnRefreshSource.Size = new System.Drawing.Size(94, 23);
            this.btnRefreshSource.TabIndex = 6;
            this.btnRefreshSource.Text = "&Refresh";
            this.btnRefreshSource.Click += new System.EventHandler(this.btnRefreshSource_Click);
            // 
            // DrawingsSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 495);
            this.Controls.Add(this.btnRefreshSource);
            this.Controls.Add(this.tlDarwings);
            this.Name = "DrawingsSelectionForm";
            this.Text = "DrawingsListTreeForm";
            this.Load += new System.EventHandler(this.DrawingsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDarwings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoTechRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techRouteBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rProfile;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoTechRoutes;
        private System.Windows.Forms.BindingSource techRouteBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnRefreshSource;
    }
}