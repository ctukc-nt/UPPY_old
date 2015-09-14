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
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeadlineDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commandButtons1 = new UPPY.Desktop.Views.Controls.CommandButtons();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOrders
            // 
            this.gcOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOrders.DataSource = this.orderBindingSource;
            this.gcOrders.Location = new System.Drawing.Point(12, 46);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(1017, 509);
            this.gcOrders.TabIndex = 0;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders});
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Core.DomainModel.Order);
            // 
            // gvOrders
            // 
            this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colOrderNo,
            this.colClient,
            this.colDateStart,
            this.colDeadlineDate,
            this.colDateSend,
            this.colIsClosed,
            this.colNote});
            this.gvOrders.GridControl = this.gcOrders;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvOrders_CellValueChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colOrderNo
            // 
            this.colOrderNo.Caption = "Номер заказа";
            this.colOrderNo.FieldName = "OrderNo";
            this.colOrderNo.Name = "colOrderNo";
            this.colOrderNo.Visible = true;
            this.colOrderNo.VisibleIndex = 1;
            // 
            // colClient
            // 
            this.colClient.Caption = "Покупатель";
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 2;
            // 
            // colDateStart
            // 
            this.colDateStart.Caption = "Дата запуска";
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 3;
            // 
            // colDeadlineDate
            // 
            this.colDeadlineDate.Caption = "Дата поставки по договору";
            this.colDeadlineDate.FieldName = "DeadlineDate";
            this.colDeadlineDate.Name = "colDeadlineDate";
            this.colDeadlineDate.Visible = true;
            this.colDeadlineDate.VisibleIndex = 4;
            // 
            // colDateSend
            // 
            this.colDateSend.Caption = "Дата отправки";
            this.colDateSend.FieldName = "DateSend";
            this.colDateSend.Name = "colDateSend";
            this.colDateSend.Visible = true;
            this.colDateSend.VisibleIndex = 5;
            // 
            // colIsClosed
            // 
            this.colIsClosed.Caption = "Заказ выполнен";
            this.colIsClosed.FieldName = "IsClosed";
            this.colIsClosed.Name = "colIsClosed";
            this.colIsClosed.Visible = true;
            this.colIsClosed.VisibleIndex = 6;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            // 
            // commandButtons1
            // 
            this.commandButtons1.AllowDelete = true;
            this.commandButtons1.AllowEdit = true;
            this.commandButtons1.AllowNew = true;
            this.commandButtons1.Location = new System.Drawing.Point(12, 6);
            this.commandButtons1.Name = "commandButtons1";
            this.commandButtons1.Size = new System.Drawing.Size(147, 34);
            this.commandButtons1.TabIndex = 12;
            this.commandButtons1.ButtonRefreshClick += new System.EventHandler(this.btnRefreshSource_Click);
            this.commandButtons1.ButtonAddClick += new System.EventHandler(this.btnAdd_Click);
            this.commandButtons1.ButtonEditClick += new System.EventHandler(this.btnOpen_Click);
            this.commandButtons1.ButtonDeleteClick += new System.EventHandler(this.btnDel_Click);
            // 
            // OrdersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 567);
            this.Controls.Add(this.commandButtons1);
            this.Controls.Add(this.gcOrders);
            this.Name = "OrdersListForm";
            this.Text = "OrdersListForm";
            this.Load += new System.EventHandler(this.OrdersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDeadlineDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSend;
        private DevExpress.XtraGrid.Columns.GridColumn colIsClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private Controls.CommandButtons commandButtons1;
    }
}