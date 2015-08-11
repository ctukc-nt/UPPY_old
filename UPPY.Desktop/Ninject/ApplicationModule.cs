using Core.Interfaces;
using Ninject.Modules;
using UPPY.Desktop.Factorys;
using UPPY.Desktop.Fake;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IControllersFactory)).ToConstant(ControllersFactory.Instance);
            Bind(typeof(IDataManagersFactory)).To(typeof(UppyFakeDataManagersFactory));
        }
    }
}