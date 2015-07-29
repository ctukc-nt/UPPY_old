using Core.Interfaces;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IControllerListView<T> : IControllerList<T> where T:IEntity
    {
        bool ShowView();
    }
}