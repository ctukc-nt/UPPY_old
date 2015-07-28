using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    internal class ControllersFactory : IControllerFactory
    {
        private readonly IDataManagerFactory _dataManagerFactory;

        public ControllersFactory(IDataManagerFactory dataManagerFactory)
        {
            _dataManagerFactory = dataManagerFactory;
        }

        public IController<T> GetController<T>() where T : IEntity
        {
            var type = typeof (T);
            if (type == typeof (Drawing))
                return (IController<T>) new DrawingController(_dataManagerFactory);

            return null;
        }
    }
}