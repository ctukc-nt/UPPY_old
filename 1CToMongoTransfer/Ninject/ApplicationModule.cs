using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;
using Ninject.Modules;

namespace _1CToMongoTransfer.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            MongoDbConnection connection = new MongoDbConnection();
            Bind(typeof(IMongoDatabase)).ToConstant(connection.Database);
            Bind(typeof(IClassDataManager<>)).To(typeof(MongoDbDataManager<>));
            Bind(typeof(IDataManagerFactory)).To(typeof(DataManagerFactory));
        }
    }
}
