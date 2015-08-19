namespace UPPY.Desktop.Views.Orders
{
    partial class OrdersListForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeadlineDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.orderBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1010, 518);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Core.DomainModel.Order);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colOrderNo,
            this.colClient,
            this.colDateStart,
            this.colDeadlineDate,
            this.colDateSend,
            this.colIsClosed,
            this.colNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colOrderNo
            // 
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 1;
            // 
            // colClient
            // 
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 2;
            // 
            // colDateStart
            // 
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 3;
            // 
            // colDeadlineDate
            // 
            this.colDeadlineDate.FieldName = "DeadlineDate";
            this.colDeadlineDate.Name = "colDeadlineDate";
            this.colDeadlineDate.Visible = true;
            this.colDeadlineDate.VisibleIndex = 4;
            // 
            // colDateSend
            // 
            this.colDateSend.FieldName = "DateSend";
            this.colDateSend.Name = "colDateSend";
            this.colDateSend.Visible = true;
            this.colDateSend.VisibleIndex = 5;
            // 
            // colIsClosed
            // 
            this.colIsClosed.FieldName = "IsClosed";
            this.colIsClosed.Name = "colIsClosed";
            this.colIsClosed.Visible = true;
            this.colIsClosed.VisibleIndex = 6;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            // 
            // OrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 567);
            this.Controls.Add(this.gridControl1);
            this.Name = "OrdersListForm";
            this.Text = "OrdersListForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDeadlineDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSend;
        private DevExpress.XtraGrid.Columns.GridColumn colIsClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
    }
}