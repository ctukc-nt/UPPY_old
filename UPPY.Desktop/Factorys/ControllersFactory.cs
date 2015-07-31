using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Controllers;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Ninject;

namespace UPPY.Desktop.Factorys
{
    class ControllersFactory : IControllersFactory
    {
        public IControllerList<T> GetControllerList<T>() where T : IEntity
        {
            throw new NotImplementedException();
        }

        public IControllerDocument<T> GetControllerDocument<T>() where T : IEntity
        {
            if (typeof (T) == typeof (TechRoute))
                return(IControllerDocument<T>)
                        new TechRouteDocumentController(this, CompositionRoot.Resolve<IDataManagersFactory>());
            
            return null;
        }

        public IControllerListView<T> GetControllerListView<T>() where T : IEntity
        {
            throw new NotImplementedException();
        }
    }
}
