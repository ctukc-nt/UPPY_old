namespace UPPY.Desktop.Views.Drawings
{
    partial class FilesViewForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.commandButtons1 = new UPPY.Desktop.Views.Controls.CommandButtons();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ppOpenFile = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // commandButtons1
            // 
            this.commandButtons1.AllowDelete = true;
            this.commandButtons1.AllowEdit = true;
            this.commandButtons1.AllowNew = true;
            this.commandButtons1.Location = new System.Drawing.Point(12, 7);
            this.commandButtons1.Name = "commandButtons1";
            this.commandButtons1.Size = new System.Drawing.Size(147, 34);
            this.commandButtons1.TabIndex = 1;
            this.commandButtons1.ButtonAddClick += new System.EventHandler(this.cmd_ButtonAddClick);
            this.commandButtons1.ButtonEditClick += new System.EventHandler(this.cmd_ButtonEditClick);
            this.commandButtons1.ButtonDeleteClick += new System.EventHandler(this.cmd_ButtonDeleteClick);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(346, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            // 
            // ppOpenFile
            // 
            this.ppOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ppOpenFile.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppOpenFile.Appearance.Options.UseBackColor = true;
            this.ppOpenFile.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ppOpenFile.AppearanceCaption.Options.UseFont = true;
            this.ppOpenFile.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ppOpenFile.AppearanceDescription.Options.UseFont = true;
            this.ppOpenFile.Caption = "Пожалуйста, подождите";
            this.ppOpenFile.Description = "Выполняется загрузка и открытие файла ...";
            this.ppOpenFile.Location = new System.Drawing.Point(82, 91);
            this.ppOpenFile.Name = "ppOpenFile";
            this.ppOpenFile.Size = new System.Drawing.Size(275, 66);
            this.ppOpenFile.TabIndex = 3;
            this.ppOpenFile.Visible = false;
            // 
            // FilesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(429, 273);
            this.Controls.Add(this.ppOpenFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.commandButtons1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilesViewForm";
            this.Text = "FilesViewForm";
            this.Load += new System.EventHandler(this.FilesViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Controls.CommandButtons commandButtons1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraWaitForm.ProgressPanel ppOpenFile;
    }
}