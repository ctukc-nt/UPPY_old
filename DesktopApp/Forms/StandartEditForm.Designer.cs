namespace DesktopApp.Forms
{
    partial class StandartEditForm
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
            this.gcPositions = new DevExpress.XtraGrid.GridControl();
            this.postitionStandartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStandartSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGostOnSort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkSteal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilizationRatio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeighWithWaste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdditionalMeasurement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeAdditionalMeasurement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddPosition = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelPosition = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.standartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leDrawing = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.tlcParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postitionStandartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDrawing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(109, 12);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(557, 20);
            this.teName.TabIndex = 0;
            // 
            // gcPositions
            // 
            this.gcPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPositions.DataSource = this.postitionStandartBindingSource;
            this.gcPositions.Location = new System.Drawing.Point(13, 164);
            this.gcPositions.MainView = this.gridView1;
            this.gcPositions.Name = "gcPositions";
            this.gcPositions.Size = new System.Drawing.Size(653, 188);
            this.gcPositions.TabIndex = 2;
            this.gcPositions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // postitionStandartBindingSource
            // 
            this.postitionStandartBindingSource.DataSource = typeof(Core.DomainModel.PostitionStandart);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProfile,
            this.colStandartSize,
            this.colGostOnSort,
            this.colMarkSteal,
            this.colUtilizationRatio,
            this.colWeight,
            this.colWeighWithWaste,
            this.colAdditionalMeasurement,
            this.colTypeAdditionalMeasurement,
            this.colNote});
            this.gridView1.GridControl = this.gcPositions;
            this.gridView1.Name = "gridView1";
            // 
            // colProfile
            // 
            this.colProfile.Caption = "Профиль";
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 0;
            // 
            // colStandartSize
            // 
            this.colStandartSize.Caption = "Типоразмер";
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 1;
            // 
            // colGostOnSort
            // 
            this.colGostOnSort.Caption = "ГОСТ на сортамент";
            this.colGostOnSort.FieldName = "GostOnSort";
            this.colGostOnSort.Name = "colGostOnSort";
            this.colGostOnSort.Visible = true;
            this.colGostOnSort.VisibleIndex = 2;
            // 
            // colMarkSteal
            // 
            this.colMarkSteal.Caption = "Марка стали";
            this.colMarkSteal.FieldName = "MarkSteal";
            this.colMarkSteal.Name = "colMarkSteal";
            this.colMarkSteal.Visible = true;
            this.colMarkSteal.VisibleIndex = 3;
            // 
            // colUtilizationRatio
            // 
            this.colUtilizationRatio.Caption = "К. исп.";
            this.colUtilizationRatio.FieldName = "UtilizationRatio";
            this.colUtilizationRatio.Name = "colUtilizationRatio";
            this.colUtilizationRatio.Visible = true;
            this.colUtilizationRatio.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Вес";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            // 
            // colWeighWithWaste
            // 
            this.colWeighWithWaste.Caption = "Вес с отходом";
            this.colWeighWithWaste.FieldName = "WeighWithWaste";
            this.colWeighWithWaste.Name = "colWeighWithWaste";
            this.colWeighWithWaste.Visible = true;
            this.colWeighWithWaste.VisibleIndex = 6;
            // 
            // colAdditionalMeasurement
            // 
            this.colAdditionalMeasurement.Caption = "В доп. ед.";
            this.colAdditionalMeasurement.FieldName = "AdditionalMeasurement";
            this.colAdditionalMeasurement.Name = "colAdditionalMeasurement";
            this.colAdditionalMeasurement.Visible = true;
            this.colAdditionalMeasurement.VisibleIndex = 7;
            // 
            // colTypeAdditionalMeasurement
            // 
            this.colTypeAdditionalMeasurement.Caption = "Тип доп. ед.";
            this.colTypeAdditionalMeasurement.FieldName = "TypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Name = "colTypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Visible = true;
            this.colTypeAdditionalMeasurement.VisibleIndex = 8;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 9;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(13, 135);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(75, 23);
            this.btnAddPosition.TabIndex = 3;
            this.btnAddPosition.Text = "Add";
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // btnDelPosition
            // 
            this.btnDelPosition.Location = new System.Drawing.Point(94, 135);
            this.btnDelPosition.Name = "btnDelPosition";
            this.btnDelPosition.Size = new System.Drawing.Size(75, 23);
            this.btnDelPosition.TabIndex = 4;
            this.btnDelPosition.Text = "Del";
            this.btnDelPosition.Click += new System.EventHandler(this.btnDelPosition_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Наименование";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Сборка";
            // 
            // standartBindingSource
            // 
            this.standartBindingSource.DataSource = typeof(Core.DomainModel.Standart);
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(Core.DomainModel.Drawing);
            // 
            // leDrawing
            // 
            this.leDrawing.Location = new System.Drawing.Point(109, 38);
            this.leDrawing.Name = "leDrawing";
            this.leDrawing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leDrawing.Properties.DataSource = this.drawingBindingSource;
            this.leDrawing.Properties.DisplayMember = "Name";
            this.leDrawing.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.leDrawing.Properties.ValueMember = "Id";
            this.leDrawing.Size = new System.Drawing.Size(557, 20);
            this.leDrawing.TabIndex = 8;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcId,
            this.tlcParent,
            this.tlcName});
            this.treeListLookUpEdit1TreeList.DataSource = this.drawingBindingSource;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.RootValue = null;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // tlcParent
            // 
            this.tlcParent.Caption = "ParentId";
            this.tlcParent.FieldName = "ParentId";
            this.tlcParent.Name = "tlcParent";
            this.tlcParent.Visible = true;
            this.tlcParent.VisibleIndex = 1;
            this.tlcParent.Width = 128;
            // 
            // tlcId
            // 
            this.tlcId.Caption = "Id";
            this.tlcId.FieldName = "Id";
            this.tlcId.Name = "tlcId";
            this.tlcId.Visible = true;
            this.tlcId.VisibleIndex = 0;
            this.tlcId.Width = 128;
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Name";
            this.tlcName.FieldName = "Name";
            this.tlcName.Name = "tlcName";
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 2;
            this.tlcName.Width = 128;
            // 
            // StandartEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 361);
            this.Controls.Add(this.leDrawing);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDelPosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.gcPositions);
            this.Controls.Add(this.teName);
            this.Name = "StandartEditForm";
            this.Text = "StandartEditForm";
            this.Load += new System.EventHandler(this.StandartEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postitionStandartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDrawing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraGrid.GridControl gcPositions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource postitionStandartBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProfile;
        private DevExpress.XtraGrid.Columns.GridColumn colStandartSize;
        private DevExpress.XtraGrid.Columns.GridColumn colGostOnSort;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkSteal;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilizationRatio;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWeighWithWaste;
        private DevExpress.XtraGrid.Columns.GridColumn colAdditionalMeasurement;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeAdditionalMeasurement;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.SimpleButton btnAddPosition;
        private DevExpress.XtraEditors.SimpleButton btnDelPosition;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource standartBindingSource;
        private System.Windows.Forms.BindingSource drawingBindingSource;
        private DevExpress.XtraEditors.TreeListLookUpEdit leDrawing;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcParent;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
    }
}