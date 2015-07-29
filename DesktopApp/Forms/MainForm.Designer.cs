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
            this.btnStandarts = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(Core.DomainModel.Drawing);
            // 
            // bDrawings
            // 
            this.bDrawings.Location = new System.Drawing.Point(12, 48);
            this.bDrawings.Name = "bDrawings";
            this.bDrawings.Size = new System.Drawing.Size(169, 51);
            this.bDrawings.TabIndex = 1;
            this.bDrawings.Text = "Проекты";
            this.bDrawings.Click += new System.EventHandler(this.bDrawings_Click);
            // 
            // btnStandarts
            // 
            this.btnStandarts.Location = new System.Drawing.Point(198, 48);
            this.btnStandarts.Name = "btnStandarts";
            this.btnStandarts.Size = new System.Drawing.Size(169, 51);
            this.btnStandarts.TabIndex = 2;
            this.btnStandarts.Text = "Нормы";
            this.btnStandarts.Click += new System.EventHandler(this.btnStandarts_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 127);
            this.Controls.Add(this.btnStandarts);
            this.Controls.Add(this.bDrawings);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOSTOnSortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gOSTOnMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drawingBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcWeigthAll;
        private DevExpress.XtraEditors.SimpleButton bDrawings;
        private DevExpress.XtraEditors.SimpleButton btnStandarts;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

