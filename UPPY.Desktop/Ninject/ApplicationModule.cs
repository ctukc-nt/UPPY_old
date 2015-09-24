using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;
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
            var connection = new MongoDbConnection();
            Bind(typeof(IControllersFactory)).To(typeof(UppyControllersFactory));
            Bind(typeof(IUppyControllersFactory)).To(typeof(UppyControllersFactory));
            Bind(typeof(IDataManagersFactory)).To(typeof(UppyDataMangersFactory));
            Bind(typeof(IUppyDataManagersFactory)).To(typeof(UppyDataMangersFactory));
            Bind(typeof(IDataImportToolsFactory)).To(typeof(ToolsFactory));
            Bind(typeof (IMongoDatabase)).ToConstant(connection.Database);
            //Bind(typeof(IOrderDocumentController)).ToConstant(new OrderDocumentController());
        }
    }
}