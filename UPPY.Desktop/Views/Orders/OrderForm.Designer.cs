namespace UPPY.Desktop.Views.Orders
{
    partial class OrderForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ceIsClosed = new DevExpress.XtraEditors.CheckEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.dtcDeadlineDate = new DevExpress.XtraEditors.DateEdit();
            this.dtcDateSend = new DevExpress.XtraEditors.DateEdit();
            this.lDeadlineDate = new DevExpress.XtraEditors.LabelControl();
            this.lDateSend = new DevExpress.XtraEditors.LabelControl();
            this.lDateStart = new DevExpress.XtraEditors.LabelControl();
            this.dtcDateStart = new DevExpress.XtraEditors.DateEdit();
            this.lNote = new DevExpress.XtraEditors.LabelControl();
            this.teNote = new DevExpress.XtraEditors.TextEdit();
            this.lClient = new DevExpress.XtraEditors.LabelControl();
            this.teClient = new DevExpress.XtraEditors.TextEdit();
            this.lOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.teNumber = new DevExpress.XtraEditors.TextEdit();
            this.lName = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.treeListDrawingsControl1 = new UPPY.Desktop.Views.Controls.Drawings.TreeListDrawingsControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSiemensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedDrawingInAnotherWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asLinearGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsClosed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDeadlineDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDeadlineDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateSend.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateSend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ceIsClosed);
            this.splitContainer1.Panel1.Controls.Add(this.teName);
            this.splitContainer1.Panel1.Controls.Add(this.dtcDeadlineDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtcDateSend);
            this.splitContainer1.Panel1.Controls.Add(this.lDeadlineDate);
            this.splitContainer1.Panel1.Controls.Add(this.lDateSend);
            this.splitContainer1.Panel1.Controls.Add(this.lDateStart);
            this.splitContainer1.Panel1.Controls.Add(this.dtcDateStart);
            this.splitContainer1.Panel1.Controls.Add(this.lNote);
            this.splitContainer1.Panel1.Controls.Add(this.teNote);
            this.splitContainer1.Panel1.Controls.Add(this.lClient);
            this.splitContainer1.Panel1.Controls.Add(this.teClient);
            this.splitContainer1.Panel1.Controls.Add(this.lOrderNo);
            this.splitContainer1.Panel1.Controls.Add(this.teNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lName);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 661);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // ceIsClosed
            // 
            this.ceIsClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceIsClosed.Location = new System.Drawing.Point(1026, 71);
            this.ceIsClosed.Name = "ceIsClosed";
            this.ceIsClosed.Properties.Caption = "Заказ закрыт";
            this.ceIsClosed.Size = new System.Drawing.Size(88, 19);
            this.ceIsClosed.TabIndex = 7;
            // 
            // teName
            // 
            this.teName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teName.Location = new System.Drawing.Point(285, 19);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(627, 20);
            this.teName.TabIndex = 1;
            // 
            // dtcDeadlineDate
            // 
            this.dtcDeadlineDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtcDeadlineDate.EditValue = null;
            this.dtcDeadlineDate.Location = new System.Drawing.Point(1027, 45);
            this.dtcDeadlineDate.Name = "dtcDeadlineDate";
            this.dtcDeadlineDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtcDeadlineDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtcDeadlineDate.Size = new System.Drawing.Size(87, 20);
            this.dtcDeadlineDate.TabIndex = 4;
            // 
            // dtcDateSend
            // 
            this.dtcDateSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtcDateSend.EditValue = null;
            this.dtcDateSend.Location = new System.Drawing.Point(933, 71);
            this.dtcDateSend.Name = "dtcDateSend";
            this.dtcDateSend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtcDateSend.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtcDateSend.Size = new System.Drawing.Size(87, 20);
            this.dtcDateSend.TabIndex = 6;
            // 
            // lDeadlineDate
            // 
            this.lDeadlineDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDeadlineDate.Location = new System.Drawing.Point(918, 48);
            this.lDeadlineDate.Name = "lDeadlineDate";
            this.lDeadlineDate.Size = new System.Drawing.Size(98, 13);
            this.lDeadlineDate.TabIndex = 12;
            this.lDeadlineDate.Text = "Срок изготовления";
            // 
            // lDateSend
            // 
            this.lDateSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDateSend.Location = new System.Drawing.Point(850, 74);
            this.lDateSend.Name = "lDateSend";
            this.lDateSend.Size = new System.Drawing.Size(77, 13);
            this.lDateSend.TabIndex = 11;
            this.lDateSend.Text = "Дата отправки";
            // 
            // lDateStart
            // 
            this.lDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDateStart.Location = new System.Drawing.Point(918, 22);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(69, 13);
            this.lDateStart.TabIndex = 10;
            this.lDateStart.Text = "Дата запуска";
            // 
            // dtcDateStart
            // 
            this.dtcDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtcDateStart.EditValue = null;
            this.dtcDateStart.Location = new System.Drawing.Point(1027, 19);
            this.dtcDateStart.Name = "dtcDateStart";
            this.dtcDateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtcDateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtcDateStart.Size = new System.Drawing.Size(87, 20);
            this.dtcDateStart.TabIndex = 2;
            // 
            // lNote
            // 
            this.lNote.Location = new System.Drawing.Point(12, 74);
            this.lNote.Name = "lNote";
            this.lNote.Size = new System.Drawing.Size(61, 13);
            this.lNote.TabIndex = 7;
            this.lNote.Text = "Примечание";
            // 
            // teNote
            // 
            this.teNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teNote.Location = new System.Drawing.Point(86, 71);
            this.teNote.Name = "teNote";
            this.teNote.Size = new System.Drawing.Size(758, 20);
            this.teNote.TabIndex = 5;
            // 
            // lClient
            // 
            this.lClient.Location = new System.Drawing.Point(12, 48);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(47, 13);
            this.lClient.TabIndex = 5;
            this.lClient.Text = "Заказчик";
            // 
            // teClient
            // 
            this.teClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teClient.Location = new System.Drawing.Point(86, 45);
            this.teClient.Name = "teClient";
            this.teClient.Size = new System.Drawing.Size(826, 20);
            this.teClient.TabIndex = 3;
            // 
            // lOrderNo
            // 
            this.lOrderNo.LineColor = System.Drawing.Color.White;
            this.lOrderNo.Location = new System.Drawing.Point(12, 22);
            this.lOrderNo.Name = "lOrderNo";
            this.lOrderNo.Size = new System.Drawing.Size(68, 13);
            this.lOrderNo.TabIndex = 10;
            this.lOrderNo.Text = "Номер заказа";
            // 
            // teNumber
            // 
            this.teNumber.Location = new System.Drawing.Point(86, 19);
            this.teNumber.Name = "teNumber";
            this.teNumber.Size = new System.Drawing.Size(114, 20);
            this.teNumber.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(206, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(73, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Наименование";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1122, 557);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.treeListDrawingsControl1);
            this.xtraTabPage1.Controls.Add(this.menuStrip1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1116, 529);
            this.xtraTabPage1.Text = "Древовидная структура";
            // 
            // treeListDrawingsControl1
            // 
            this.treeListDrawingsControl1.Controller = null;
            this.treeListDrawingsControl1.Location = new System.Drawing.Point(3, 27);
            this.treeListDrawingsControl1.Name = "treeListDrawingsControl1";
            this.treeListDrawingsControl1.ParentId = null;
            this.treeListDrawingsControl1.Size = new System.Drawing.Size(1110, 499);
            this.treeListDrawingsControl1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.unloadToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.initToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSiemensToolStripMenuItem,
            this.fromExcelToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // fromSiemensToolStripMenuItem
            // 
            this.fromSiemensToolStripMenuItem.Name = "fromSiemensToolStripMenuItem";
            this.fromSiemensToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromSiemensToolStripMenuItem.Text = "From Siemens";
            this.fromSiemensToolStripMenuItem.Click += new System.EventHandler(this.fromSiemensToolStripMenuItem_Click);
            // 
            // fromExcelToolStripMenuItem
            // 
            this.fromExcelToolStripMenuItem.Name = "fromExcelToolStripMenuItem";
            this.fromExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromExcelToolStripMenuItem.Text = "From Excel";
            // 
            // unloadToolStripMenuItem
            // 
            this.unloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visibleToolStripMenuItem,
            this.allToolStripMenuItem});
            this.unloadToolStripMenuItem.Name = "unloadToolStripMenuItem";
            this.unloadToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.unloadToolStripMenuItem.Text = "Unload";
            // 
            // visibleToolStripMenuItem
            // 
            this.visibleToolStripMenuItem.Name = "visibleToolStripMenuItem";
            this.visibleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.visibleToolStripMenuItem.Text = "Visible";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedDrawingInAnotherWindowToolStripMenuItem,
            this.drawingToolStripMenuItem,
            this.asLinearGridToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // selectedDrawingInAnotherWindowToolStripMenuItem
            // 
            this.selectedDrawingInAnotherWindowToolStripMenuItem.Name = "selectedDrawingInAnotherWindowToolStripMenuItem";
            this.selectedDrawingInAnotherWindowToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.selectedDrawingInAnotherWindowToolStripMenuItem.Text = "Selected drawing in another window";
            // 
            // drawingToolStripMenuItem
            // 
            this.drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            this.drawingToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.drawingToolStripMenuItem.Text = "Image drawing";
            // 
            // asLinearGridToolStripMenuItem
            // 
            this.asLinearGridToolStripMenuItem.Name = "asLinearGridToolStripMenuItem";
            this.asLinearGridToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.asLinearGridToolStripMenuItem.Text = "As linear grid";
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1116, 529);
            this.xtraTabPage2.Text = "Список файлов чертежей";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 661);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceIsClosed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDeadlineDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDeadlineDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateSend.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateSend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl lClient;
        private DevExpress.XtraEditors.TextEdit teClient;
        private DevExpress.XtraEditors.LabelControl lOrderNo;
        private DevExpress.XtraEditors.TextEdit teNumber;
        private DevExpress.XtraEditors.LabelControl lName;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.DateEdit dtcDeadlineDate;
        private DevExpress.XtraEditors.DateEdit dtcDateSend;
        private DevExpress.XtraEditors.LabelControl lDeadlineDate;
        private DevExpress.XtraEditors.LabelControl lDateSend;
        private DevExpress.XtraEditors.LabelControl lDateStart;
        private DevExpress.XtraEditors.DateEdit dtcDateStart;
        private DevExpress.XtraEditors.CheckEdit ceIsClosed;
        private DevExpress.XtraEditors.LabelControl lNote;
        private DevExpress.XtraEditors.TextEdit teNote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSiemensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedDrawingInAnotherWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asLinearGridToolStripMenuItem;
        private Controls.Drawings.TreeListDrawingsControl treeListDrawingsControl1;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
    }
}