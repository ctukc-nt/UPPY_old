namespace DesktopApp.Forms
{
    partial class MainForm
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
            this.drawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDrawings = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(Core.DomainModel.Drawing);
            // 
            // bDrawings
            // 
            this.bDrawings.Location = new System.Drawing.Point(12, 22);
            this.bDrawings.Name = "bDrawings";
            this.bDrawings.Size = new System.Drawing.Size(157, 81);
            this.bDrawings.TabIndex = 1;
            this.bDrawings.Text = "Проекты";
            this.bDrawings.Click += new System.EventHandler(this.bDrawings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 128);
            this.Controls.Add(this.bDrawings);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOSTOnSortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOSTOnMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drawingBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWeigthAll;
        private DevExpress.XtraEditors.SimpleButton bDrawings;
    }
}

