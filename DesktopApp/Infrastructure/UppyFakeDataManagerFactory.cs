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

        private Dictionary<string, object> _data;

        public UppyFakeDataManagerFactory(IMongoDatabase database)
            : base(database)
        {
            _data = new Dictionary<string, object>();
        }

        public override IClassDataManager<T> GetDataManager<T>()
        {
            if (typeof (T) == typeof (Drawing))
            {
                if (!_data.ContainsKey("dr"))
                    _data.Add("dr", new DrawingListClassFakeDataManager());
                
                return (IClassDataManager<T>) _data["dr"];
            }

            if (typeof(T) == typeof(TechRoute))
            {
                if (!_data.ContainsKey("tr"))
                    _data.Add("tr", new TechRoutesClassFakeDataManager());

                return (IClassDataManager<T>)_data["tr"];
            }

            if (typeof(T) == typeof(Standart))
            {
                if (!_data.ContainsKey("st"))
                    _data.Add("st", new StandartClassFakeDataManager());

                return (IClassDataManager<T>)_data["st"];
            }

            if (typeof(T) == typeof(TechOperation))
            {
                if (!_data.ContainsKey("to"))
                    _data.Add("to", new TechOperationClassFakeDataManager());

                return (IClassDataManager<T>)_data["to"];
            }

            return null;
        }
    }
}
