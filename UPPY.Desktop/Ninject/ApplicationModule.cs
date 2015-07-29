using Core.DomainModel;
using Core.Interfaces;
using Ninject.Modules;
using UPPY.Desktop.Controllers;
using UPPY.Desktop.Factorys;
using UPPY.Desktop.Fake;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {

            Bind(typeof (IControllerList<TechRoute>)).To(typeof (TechRouteListController));
            Bind(typeof(IControllersFactory)).To(typeof(ControllersFactory));
            Bind(typeof(IDataManagersFactory)).To(typeof(UppyFakeDataManagersFactory));


        }
    }
}