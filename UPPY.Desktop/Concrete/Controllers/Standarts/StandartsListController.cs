using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Standarts;
using UPPY.Desktop.Views.Standarts;

namespace UPPY.Desktop.Concrete.Controllers.Standarts
{
    public class StandartsListController : IStandartsListController, IListViewController
    {
        public void ShowViewDialog()
        {
            StandartsListForm form = new StandartsListForm();
            form.ShowDialog();
        }
    }
}