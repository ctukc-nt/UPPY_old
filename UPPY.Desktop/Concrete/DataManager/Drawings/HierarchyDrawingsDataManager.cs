using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;

namespace UPPY.Desktop.Concrete.DataManager.Drawings
{
    public class HierarchyDrawingsDataManager: MongoDbDataManager<Drawing>, IHierClassDataManager<Drawing>
    {
        public HierarchyDrawingsDataManager(IMongoDatabase db) : base(db)
        {
        }

        public List<Drawing> GetListDocsInHierarchy(int? id)
        {
            var topParentId = GetTopParentId(id, GetCollection());
            return GetListAllChildrens(topParentId);
        }

        public List<Drawing> GetListAllChildrens(int? id)
        {
            return GetAllChildrens(id, GetCollection());
        }

        private static int? GetTopParentId(int? id, IMongoCollection<Drawing> drawingMongoCollection)
        {
            while (true)
            {
                var copyId = id;
                var drawing = drawingMongoCollection.Find(x => x.Id == copyId).FirstOrDefaultAsync().Result;
                if (drawing != null)
                {
                    if (drawing.ParentId != null)
                    {
                        id = drawing.ParentId;
                        continue;
                    }

                    return id;
                }

                return id;
            }
        }

        private List<Drawing> GetAllChildrens(int? parentId, IMongoCollection<Drawing> data)
        {
            var result = new List<Drawing>();
            var childrens = GetChildrenDrawings(parentId, data);
            result.AddRange(childrens);
            foreach (var drawing in childrens.AsParallel())
            {
                result.AddRange(GetAllChildrens(drawing.Id, data));
            }

            return result;
        }

        private List<Drawing> GetChildrenDrawings(int? parentId, IMongoCollection<Drawing> data)
        {
            return data.Find(x => x.ParentId == parentId).ToListAsync().Result;
        }
    }
}