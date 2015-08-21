using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Views.Orders
{
    public partial class OrdersListForm : Form
    {
        private readonly IOrderListController _сontroller;

        public OrdersListForm(IOrderListController сontroller)
        {
            _сontroller = сontroller;
            InitializeComponent();
        }

        private void OrdersListForm_Load(object sender, System.EventArgs e)
        {
            gcOrders.DataSource = _сontroller.GetOrdersList();
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            var order = gvOrders.GetFocusedRow() as Order;
            if (order != null)
                _сontroller.EditDocument(order);
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            _сontroller.Save(_сontroller.CreateDocument());
            gvOrders.Focus();
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            var order = gvOrders.GetFocusedRow() as Order;
            if (order != null)
                _сontroller.Delete(order);
        }

        private void btnRefreshSource_Click(object sender, System.EventArgs e)
        {
            gcOrders.DataSource = _сontroller.GetOrdersList();
        }
    }
}