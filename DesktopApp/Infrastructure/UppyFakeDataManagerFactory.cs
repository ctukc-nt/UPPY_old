using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Temp;
using MongoDB.Driver;
using MongoWork;

namespace DesktopApp.Infrastructure
{
    public class UppyFakeDataManagerFactory : DataManagerFactory
    {
        public UppyFakeDataManagerFactory(IMongoDatabase database)
            : base(database)
        {

        }

        public override IClassDataManager<T> GetDataManager<T>()
        {
            if (typeof (T) == typeof (Drawing))
            {
                return (IClassDataManager<T>) new DrawingListClassFakeDataManager();
            }

            if (typeof(T) == typeof(TechRoute))
            {
                return (IClassDataManager<T>)new TechRoutesClassFakeDataManager();
            }

            if (typeof(T) == typeof(Standart))
            {
                return (IClassDataManager<T>)new StandartClassFakeDataManager();
            }

            if (typeof(T) == typeof(TechOperation))
            {
                return (IClassDataManager<T>)new StandartClassFakeDataManager();
            }

            return null;
            //return base.GetDataManager<T>();
        }
    }
}
