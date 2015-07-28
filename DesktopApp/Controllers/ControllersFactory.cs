using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;
using DesktopApp.Temp;

namespace DesktopApp.Controllers
{
    class ControllersFactory : IControllerFactory
    {
        private IDataManagerFactory _dataManagerFactory;

        public ControllersFactory(IDataManagerFactory dataManagerFactory)
        {
            _dataManagerFactory = dataManagerFactory;
        }

        public IController<T> GetController<T>()
        {
            var type = typeof(T);
            if (type == typeof(Drawing))
                return (IController<T>)new DrawingController(_dataManagerFactory);

            return null;
        }
    }
}
