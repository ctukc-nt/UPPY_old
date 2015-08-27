using System;
using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Interfaces.Views;

namespace UPPY.Desktop.Views.Orders
{
    public partial class OrderForm : Form, IDocumentView<Order>
    {
        private readonly IOrderDocumentController _controller;

        public OrderForm(IOrderDocumentController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        public Order Document { get; set; }

        public bool AutoSaveDocument { get; set; }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadFromDocument();
            treeListDrawingsControl1.Controller = _controller.GetDrawingsController(Document.DrawingId);
            treeListDrawingsControl1.ParentId = Document.DrawingId;
            treeListDrawingsControl1.Refresh();
        }

        private void LoadFromDocument()
        {
            if (Document == null)
                return;

            teClient.Text = Document.Client;
            teName.Text = Document.Name;
            teNote.Text = Document.Note;
            teNumber.Text = Document.OrderNo;
            ceIsClosed.Checked = Document.IsClosed;
            dtcDateSend.DateTime = Document.DateSend;
            dtcDateStart.DateTime = Document.DateStart;
            dtcDeadlineDate.DateTime = Document.DeadlineDate;
        }

        private void SaveToDocument()
        {
            if (Document == null)
                return;

            Document.Client = teClient.Text;
            Document.Name = teName.Text;
            Document.Note = teNote.Text;
            Document.OrderNo = teNumber.Text;
            Document.IsClosed = ceIsClosed.Checked;
            Document.DateSend = dtcDateSend.DateTime;
            Document.DateStart = dtcDateStart.DateTime;
            Document.DeadlineDate = dtcDeadlineDate.DateTime;
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Document.DrawingId != null)
            {
                var res = MessageBox.Show("Are you sure?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var drawCtontroller = _controller.InitNewDrawingAndGetController();
                    Document.DrawingId = _controller.Document.DrawingId;

                    treeListDrawingsControl1.Controller = drawCtontroller;
                    treeListDrawingsControl1.ParentId = Document.DrawingId;
                }
            }
        }



    }
}