using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;

namespace DesktopApp.Infrastructure
{
    public class UppyDataManagerFactory : DataManagerFactory
    {
        public UppyDataManagerFactory(IMongoDatabase database) : base(database)
        {

        }

        public override IClassDataManager<T> GetDataManager<T>()
        {
            return base.GetDataManager<T>();
        }
    }
}
