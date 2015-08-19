using System;
using Core.Interfaces;
using Ninject.Modules;
using UPPY.Desktop.Concrete.Controllers.Orders;
using UPPY.Desktop.Factorys;
using UPPY.Desktop.Fake;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Interfaces.Controllers.Orders;
using UPPY.Desktop.Interfaces.DataManagers;

namespace UPPY.Desktop.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IControllersFactory)).To(typeof(UppyControllersFactory));
            Bind(typeof(IUppyControllersFactory)).To(typeof(UppyControllersFactory));
            Bind(typeof(IDataManagersFactory)).To(typeof(UppyFakeDataManagersFactory));
            Bind(typeof(IUppyDataManagersFactory)).To(typeof(UppyFakeDataManagersFactory));
            Bind(typeof(IOrderDocumentController)).ToConstant(new OrderDocumentController());
        }
    }
}