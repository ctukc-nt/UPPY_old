using Core.Interfaces;

namespace UPPY.Desktop.Interfaces
{
    public interface IControllerListView<T> : IControllerList<T> where T:IEntity
    {
        void ShowView();
    }
}