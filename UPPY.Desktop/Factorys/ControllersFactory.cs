using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;

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
            throw new NotImplementedException();
        }

        public IControllerListView<T> GetControllerListView<T>() where T : IEntity
        {
            throw new NotImplementedException();
        }
    }
}
