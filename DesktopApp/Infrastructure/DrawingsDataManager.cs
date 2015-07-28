using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;

namespace DesktopApp.Infrastructure
{
    public class DrawingsDataManager : MongoDbDataManager<Drawing>, IHierClassDataManager<Drawing>
    {
        public DrawingsDataManager(IMongoDatabase db)
            : base(db)
        {
        }


        public List<Drawing> GetListDocsInHierarchy(int? id)
        {
            var topParent = GetTopParentId(id);
            return GetChildrenDrawings(topParent);
        }

        private List<Drawing> GetChildrenDrawings(int? id)
        {
            var list = new List<Drawing>();
            list.AddRange(FindInDbDirectly(x => x.ParentId == id).ToList());
            foreach (Drawing drawing in list)
            {
                list.InsertRange(list.IndexOf(drawing), GetChildrenDrawings(drawing.Id));
            }

            return list;
        }


        private int? GetTopParentId(int? id)
        {
            var par = FindInDbDirectly(x => x.Id == id).FirstOrDefault();
            if (par != null && par.ParentId != null)
                return GetTopParentId(par.ParentId);
            else
            {
                return par != null ? id : null;
            }

        }
    }
}