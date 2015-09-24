using Core.Interfaces;
using Ninject.Modules;
using UPPY.Desktop.Factorys;
using UPPY.Desktop.Interfaces.Common;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.FakeDb;

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
            Bind(typeof(IDataImportToolsFactory)).To(typeof(ToolsFactory));
            //Bind(typeof(IOrderDocumentController)).ToConstant(new OrderDocumentController());
        }
    }
}