using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.DataManagers;

namespace UPPY.Desktop.Fake
{
    public class UppyFakeDataManagersFactory : IUppyDataManagersFactory
    {
        private static readonly Dictionary<string, object> _data = new Dictionary<string, object>();

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

            if (typeof(T) == typeof(Order))
            {
                if (!_data.ContainsKey("or"))
                    _data.Add("or", new OrderClassFakeDataManager());

                return (IClassDataManager<T>)_data["or"];
            }

            return null;
        }

        private List<Drawing> GetChildrenDrawings(int? parentId, List<Drawing> data)
        {
           
            return data.Where(x=>x.ParentId == parentId).ToList();
        }

        private List<Drawing> GetAllChildrens(int? parentId, List<Drawing> data)
        {
            var result = new List<Drawing>();
            var childrens = GetChildrenDrawings(parentId, data);
            result.AddRange(childrens);
            foreach (var drawing in childrens)
            {
                result.AddRange(GetAllChildrens(drawing.Id, data));
            }

            return result;
        }


        public IClassDataManager<Drawing> GetFilteredDrawingsByParent(int? parentId)
        {
            var manager = GetDataManager<Drawing>();
            var childrens = GetAllChildrens(parentId, (List<Drawing>) manager);

            ((List<Drawing>) manager).RemoveAll(x => childrens.All(y => y.Id != x.Id));

            return manager;
        }
    }
}