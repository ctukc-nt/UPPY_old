namespace UPPY.Desktop.Views
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
            this.btnOrders = new DevExpress.XtraEditors.SimpleButton();
            this.btnStandarts = new DevExpress.XtraEditors.SimpleButton();
            this.btnSSI = new DevExpress.XtraEditors.SimpleButton();
            this.btnGosts = new DevExpress.XtraEditors.SimpleButton();
            this.btnTechOpers = new DevExpress.XtraEditors.SimpleButton();
            this.btnTechRoutes = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(12, 12);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStandarts
            // 
            this.btnStandarts.Location = new System.Drawing.Point(12, 41);
            this.btnStandarts.Name = "btnStandarts";
            this.btnStandarts.Size = new System.Drawing.Size(75, 23);
            this.btnStandarts.TabIndex = 1;
            this.btnStandarts.Text = "Нормы";
            this.btnStandarts.Click += new System.EventHandler(this.btnStandarts_Click);
            // 
            // btnSSI
            // 
            this.btnSSI.Location = new System.Drawing.Point(379, 12);
            this.btnSSI.Name = "btnSSI";
            this.btnSSI.Size = new System.Drawing.Size(108, 23);
            this.btnSSI.TabIndex = 2;
            this.btnSSI.Text = "ССИ";
            // 
            // btnGosts
            // 
            this.btnGosts.Location = new System.Drawing.Point(379, 41);
            this.btnGosts.Name = "btnGosts";
            this.btnGosts.Size = new System.Drawing.Size(108, 23);
            this.btnGosts.TabIndex = 3;
            this.btnGosts.Text = "ГОСТы";
            this.btnGosts.Click += new System.EventHandler(this.btnGosts_Click);
            // 
            // btnTechOpers
            // 
            this.btnTechOpers.Location = new System.Drawing.Point(379, 70);
            this.btnTechOpers.Name = "btnTechOpers";
            this.btnTechOpers.Size = new System.Drawing.Size(108, 23);
            this.btnTechOpers.TabIndex = 4;
            this.btnTechOpers.Text = "ТО";
            this.btnTechOpers.Click += new System.EventHandler(this.btnTechOpers_Click);
            // 
            // btnTechRoutes
            // 
            this.btnTechRoutes.Location = new System.Drawing.Point(379, 99);
            this.btnTechRoutes.Name = "btnTechRoutes";
            this.btnTechRoutes.Size = new System.Drawing.Size(108, 23);
            this.btnTechRoutes.TabIndex = 5;
            this.btnTechRoutes.Text = "Тех. маршруты";
            this.btnTechRoutes.Click += new System.EventHandler(this.btnTechRoutes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 246);
            this.Controls.Add(this.btnTechRoutes);
            this.Controls.Add(this.btnTechOpers);
            this.Controls.Add(this.btnGosts);
            this.Controls.Add(this.btnSSI);
            this.Controls.Add(this.btnStandarts);
            this.Controls.Add(this.btnOrders);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOrders;
        private DevExpress.XtraEditors.SimpleButton btnStandarts;
        private DevExpress.XtraEditors.SimpleButton btnSSI;
        private DevExpress.XtraEditors.SimpleButton btnGosts;
        private DevExpress.XtraEditors.SimpleButton btnTechOpers;
        private DevExpress.XtraEditors.SimpleButton btnTechRoutes;
    }
}