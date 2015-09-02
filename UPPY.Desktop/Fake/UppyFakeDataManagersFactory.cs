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
        private static readonly Dictionary<string, object> Data = new Dictionary<string, object>();

        public IClassDataManager<T> GetDataManager<T>() where T : IEntity
        {
            if (typeof (T) == typeof (Drawing))
            {
                if (!Data.ContainsKey("dr"))
                    Data.Add("dr", new DrawingListClassFakeDataManager());

                return (IClassDataManager<T>) Data["dr"];
            }

            if (typeof (T) == typeof (TechRoute))
            {
                if (!Data.ContainsKey("tr"))
                    Data.Add("tr", new TechRoutesClassFakeDataManager());

                return (IClassDataManager<T>) Data["tr"];
            }

            if (typeof (T) == typeof (Standart))
            {
                if (!Data.ContainsKey("st"))
                    Data.Add("st", new StandartClassFakeDataManager());

                return (IClassDataManager<T>) Data["st"];
            }

            if (typeof (T) == typeof (TechOperation))
            {
                if (!Data.ContainsKey("to"))
                    Data.Add("to", new TechOperationClassFakeDataManager());

                return (IClassDataManager<T>) Data["to"];
            }

            if (typeof(T) == typeof(Order))
            {
                if (!Data.ContainsKey("or"))
                    Data.Add("or", new OrderClassFakeDataManager());

                return (IClassDataManager<T>)Data["or"];
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

        public IHierClassDataManager<Drawing> GetDrawingsHierClassDataManager()
        {
            var manager = GetDataManager<Drawing>();
            return (IHierClassDataManager<Drawing>) manager;
        }

        private int? GetTopParentId(int? startDrawingId, IClassDataManager<Drawing> drawingDm)
        {
            var drawing = drawingDm.GetDocument(startDrawingId);
            if (drawing != null)
            {
                if (drawing.ParentId != null)
                    return GetTopParentId(drawing.ParentId, drawingDm);
                else
                {
                    return startDrawingId;
                }
            }

            return startDrawingId;
        }
    }
}