using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Interfaces.Views;

namespace UPPY.Desktop.Views.Orders
{
    public partial class OrderForm : Form, IDocumentView<Order>
    {
        public OrderForm(IOrderDocumentController controller)
        {
            InitializeComponent();
        }

        public Order Document { get; set; }

        public bool AutoSaveDocument { get; set; }
    }
}