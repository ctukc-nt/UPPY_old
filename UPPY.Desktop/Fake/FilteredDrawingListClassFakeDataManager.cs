using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class FilteredDrawingListClassFakeDataManager : DrawingListClassFakeDataManager
    {
        private readonly int? _parentId;


        public FilteredDrawingListClassFakeDataManager(int? parentId)
        {
            _parentId = parentId;
        }

        public override List<Drawing> GetListCollection()
        {
            return GetAllChildrens(_parentId, _db);
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

        private List<Drawing> GetChildrenDrawings(int? parentId, List<Drawing> data)
        {
            return data.Where(x => x.ParentId == parentId).ToList();
        }
    }
}