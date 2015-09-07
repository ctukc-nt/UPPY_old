namespace UPPY.Desktop.Views.Drawings
{
    partial class HierarchyDrawingsForm
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
            this.hierarListDrawingsControl = new UPPY.Desktop.Views.Controls.Drawings.HierarListDrawingsControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hierarListDrawingsControl
            // 
            this.hierarListDrawingsControl.Controller = null;
            this.hierarListDrawingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarListDrawingsControl.Location = new System.Drawing.Point(0, 0);
            this.hierarListDrawingsControl.Name = "hierarListDrawingsControl";
            this.hierarListDrawingsControl.Size = new System.Drawing.Size(1050, 449);
            this.hierarListDrawingsControl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(918, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HierarchyDrawingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 493);
            this.Controls.Add(this.hierarListDrawingsControl);
            this.Controls.Add(this.panel1);
            this.Name = "HierarchyDrawingsForm";
            this.Text = "HierarchyDrawingsForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Drawings.HierarListDrawingsControl hierarListDrawingsControl;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}