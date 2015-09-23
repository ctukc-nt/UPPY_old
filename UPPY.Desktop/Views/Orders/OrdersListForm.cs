using System;
using System.Windows.Forms;
using Core.DomainModel;
using DevExpress.XtraGrid.Views.Base;
using UPPY.Desktop.Interfaces.Controllers.Orders;

namespace UPPY.Desktop.Views.Orders
{
    public partial class OrdersListForm : Form
    {
        private readonly IOrderListController _сontroller;

        public OrdersListForm(IOrderListController сontroller)
        {
            _сontroller = сontroller;
            _сontroller.DataRefreshed += _сontroller_DataRefreshed;
            InitializeComponent();
        }

        private void _сontroller_DataRefreshed(object sender, EventArgs e)
        {
            RefreshSource();
        }

        private void OrdersListForm_Load(object sender, EventArgs e)
        {
            RefreshSource();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var order = gvOrders.GetFocusedRow() as Order;
            if (order != null)
                _сontroller.EditDocument(order);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _сontroller.Save(_сontroller.CreateDocument());
            gvOrders.Focus();
            RefreshSource();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var order = gvOrders.GetFocusedRow() as Order;
            if (order != null)
                _сontroller.Delete(order);

            RefreshSource();
        }

        private void btnRefreshSource_Click(object sender, EventArgs e)
        {
            RefreshSource();
        }

        private void RefreshSource()
        {
            gcOrders.DataSource = _сontroller.GetOrdersList();
            gvOrders.RefreshData();
        }

        private void gvOrders_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var data = gvOrders.GetRow(e.RowHandle);
            _сontroller.Save((Order) data);
        }
    }
}