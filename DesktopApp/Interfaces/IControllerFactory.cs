using Core.Interfaces;
using Ninject.Activation;

namespace DesktopApp.Interfaces
{
    public interface IControllerFactory
    {
        IController<T> GetController<T>() where T:IEntity;
    }
}