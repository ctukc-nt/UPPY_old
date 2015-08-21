namespace UPPY.Desktop.Views.Drawings
{
    partial class DrawingsListTreeForm
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
            this.treeListDrawingsControl1 = new UPPY.Desktop.Views.Controls.Drawings.TreeListDrawingsControl();
            this.SuspendLayout();
            // 
            // treeListDrawingsControl1
            // 
            this.treeListDrawingsControl1.Controller = null;
            this.treeListDrawingsControl1.Location = new System.Drawing.Point(6, 12);
            this.treeListDrawingsControl1.Name = "treeListDrawingsControl1";
            this.treeListDrawingsControl1.Size = new System.Drawing.Size(1224, 471);
            this.treeListDrawingsControl1.TabIndex = 8;
            // 
            // DrawingsListTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 495);
            this.Controls.Add(this.treeListDrawingsControl1);
            this.Name = "DrawingsListTreeForm";
            this.Text = "DrawingsListTreeForm";
            this.ResumeLayout(false);

        }

        #endregion
      
        private Controls.Drawings.TreeListDrawingsControl treeListDrawingsControl1;
    }
}