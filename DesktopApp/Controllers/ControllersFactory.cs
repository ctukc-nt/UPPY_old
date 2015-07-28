using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    internal class ControllersFactory : IControllerFactory
    {
        private readonly IDataManagersFactory _dataManagersFactory;

        public ControllersFactory(IDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }

        public IController<T> GetController<T>() where T : IEntity
        {
            var type = typeof (T);
            if (type == typeof (Drawing))
                return (IController<T>) new DrawingController(_dataManagersFactory);

            return new Controller<T>(_dataManagersFactory);
        }
    }
}