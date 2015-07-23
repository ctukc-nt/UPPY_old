using Core.Interfaces;

namespace DesktopApp.Interfaces
{
    public interface IControllerFactory 
    {
        IController<T> GetController<T>();
    }
}