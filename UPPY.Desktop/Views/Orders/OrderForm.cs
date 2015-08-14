using System.Windows.Forms;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Views.Orders
{
    public partial class OrderForm : Form
    {
        public OrderForm(IOrderDocumentController controller)
        {
            InitializeComponent();
        }

        public Order Order { get; set; }
        public bool AutoSaveDocument { get; set; }
    }
}