using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class UppyFakeDataManagersFactory : IDataManagersFactory
    {
        private readonly Dictionary<string, object> _data;

        public UppyFakeDataManagersFactory()
        {
            _data = new Dictionary<string, object>();
        }

        public IClassDataManager<T> GetDataManager<T>() where T : IEntity
        {
            if (typeof (T) == typeof (Drawing))
            {
                if (!_data.ContainsKey("dr"))
                    _data.Add("dr", new DrawingListClassFakeDataManager());

                return (IClassDataManager<T>) _data["dr"];
            }

            if (typeof (T) == typeof (TechRoute))
            {
                if (!_data.ContainsKey("tr"))
                    _data.Add("tr", new TechRoutesClassFakeDataManager());

                return (IClassDataManager<T>) _data["tr"];
            }

            if (typeof (T) == typeof (Standart))
            {
                if (!_data.ContainsKey("st"))
                    _data.Add("st", new StandartClassFakeDataManager());

                return (IClassDataManager<T>) _data["st"];
            }

            if (typeof (T) == typeof (TechOperation))
            {
                if (!_data.ContainsKey("to"))
                    _data.Add("to", new TechOperationClassFakeDataManager());

                return (IClassDataManager<T>) _data["to"];
            }

            return null;
        }
    }
}