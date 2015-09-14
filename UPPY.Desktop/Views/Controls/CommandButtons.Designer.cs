namespace UPPY.Desktop.Views.Controls
{
    partial class CommandButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandButtons));
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowAnotherView = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 28);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "&R";
            this.btnRefresh.ToolTip = "Обновить список";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(118, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&D";
            this.btnDelete.ToolTip = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(56, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&N";
            this.btnAdd.ToolTip = "Добавить новый на тот же уровень";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowAnotherView
            // 
            this.btnShowAnotherView.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAnotherView.Image")));
            this.btnShowAnotherView.Location = new System.Drawing.Point(87, 3);
            this.btnShowAnotherView.Name = "btnShowAnotherView";
            this.btnShowAnotherView.Size = new System.Drawing.Size(25, 28);
            this.btnShowAnotherView.TabIndex = 12;
            this.btnShowAnotherView.Text = "&O";
            this.btnShowAnotherView.ToolTip = "Открыть в отдельном окне";
            this.btnShowAnotherView.Click += new System.EventHandler(this.btnShowAnotherView_Click);
            // 
            // CommandButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowAnotherView);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "CommandButtons";
            this.Size = new System.Drawing.Size(147, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnShowAnotherView;
    }
}
