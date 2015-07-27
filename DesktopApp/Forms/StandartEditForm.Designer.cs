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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.buttonEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.postitionStandartBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postitionStandartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(109, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(264, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(109, 38);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.buttonEdit1.Properties.NullText = "";
            this.buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.buttonEdit1.Size = new System.Drawing.Size(264, 20);
            this.buttonEdit1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.postitionStandartBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(13, 164);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(653, 188);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // postitionStandartBindingSource
            // 
            this.postitionStandartBindingSource.DataSource = typeof(Core.DomainModel.PostitionStandart);
            // 
            // colProfile
            // 
            this.colProfile.FieldName = "Profile";
            this.colProfile.Name = "colProfile";
            this.colProfile.Visible = true;
            this.colProfile.VisibleIndex = 0;
            // 
            // colStandartSize
            // 
            this.colStandartSize.FieldName = "StandartSize";
            this.colStandartSize.Name = "colStandartSize";
            this.colStandartSize.Visible = true;
            this.colStandartSize.VisibleIndex = 1;
            // 
            // colGostOnSort
            // 
            this.colGostOnSort.FieldName = "GostOnSort";
            this.colGostOnSort.Name = "colGostOnSort";
            this.colGostOnSort.Visible = true;
            this.colGostOnSort.VisibleIndex = 2;
            // 
            // colMarkSteal
            // 
            this.colMarkSteal.FieldName = "MarkSteal";
            this.colMarkSteal.Name = "colMarkSteal";
            this.colMarkSteal.Visible = true;
            this.colMarkSteal.VisibleIndex = 3;
            // 
            // colUtilizationRatio
            // 
            this.colUtilizationRatio.FieldName = "UtilizationRatio";
            this.colUtilizationRatio.Name = "colUtilizationRatio";
            this.colUtilizationRatio.Visible = true;
            this.colUtilizationRatio.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 5;
            // 
            // colWeighWithWaste
            // 
            this.colWeighWithWaste.FieldName = "WeighWithWaste";
            this.colWeighWithWaste.Name = "colWeighWithWaste";
            this.colWeighWithWaste.Visible = true;
            this.colWeighWithWaste.VisibleIndex = 6;
            // 
            // colAdditionalMeasurement
            // 
            this.colAdditionalMeasurement.FieldName = "AdditionalMeasurement";
            this.colAdditionalMeasurement.Name = "colAdditionalMeasurement";
            this.colAdditionalMeasurement.Visible = true;
            this.colAdditionalMeasurement.VisibleIndex = 7;
            // 
            // colTypeAdditionalMeasurement
            // 
            this.colTypeAdditionalMeasurement.FieldName = "TypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Name = "colTypeAdditionalMeasurement";
            this.colTypeAdditionalMeasurement.Visible = true;
            this.colTypeAdditionalMeasurement.VisibleIndex = 8;
            // 
            // colNote
            // 
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
            // 
            // btnDelPosition
            // 
            this.btnDelPosition.Location = new System.Drawing.Point(94, 135);
            this.btnDelPosition.Name = "btnDelPosition";
            this.btnDelPosition.Size = new System.Drawing.Size(75, 23);
            this.btnDelPosition.TabIndex = 4;
            this.btnDelPosition.Text = "Del";
            // 
            // StandartEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 361);
            this.Controls.Add(this.btnDelPosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.buttonEdit1);
            this.Name = "StandartEditForm";
            this.Text = "StandartEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postitionStandartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit buttonEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
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
    }
}