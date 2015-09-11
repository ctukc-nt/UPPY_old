using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class DrawingListClassFakeDataManager : List<Drawing>, IHierClassDataManager<Drawing>
    {
        
        private void SetUp()
        {
            var rndRandom = new Random();

            for (var i = 1; i < 2000; i++)
            {
                var random = new Random(i);
                var parentId = rndRandom.Next(0, 1) == 1 ? null : (i - 1 > 1 ? rndRandom.Next(1, i - 1) : (int?)null);
                Add(new Drawing { Id = i, ParentId = parentId });
            }
        }

        private int _count = 5000;

        public DrawingListClassFakeDataManager()
        {
            //AddRange(new List<Drawing>
            //{
            //    new Drawing {Id = 1, Name = "1"},
            //    new Drawing {Id = 2, Name = "2"},
            //    new Drawing {Id = 8, ParentId = 2, Name = "2.1."},
            //    new Drawing {Id = 3, Name = "3"},
            //    new Drawing {Id = 4, ParentId = 2, Name = "2.2."},
            //    new Drawing {Id = 5, ParentId = 4, Name = "2.2.1"},
            //    new Drawing {Id = 6, Name = "4"},
            //    new Drawing {Id = 7, ParentId = 5, Name = "2.1.1.1"}
           //});

            //SetUp();
        }

        public Task<List<Drawing>> GetListCollectionAsync()
        {
            return new Task<List<Drawing>>(() => this);
        }

        public List<Drawing> GetListCollection()
        {
            return this;
        }

        public List<Drawing> GetListCollection(Func<Drawing, bool> filter)
        {
            return this.Where(filter).ToList();
        }

        public void Insert(Drawing doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(Drawing doc)
        {
            Insert(doc);
        }

        public void Update(Drawing doc)
        {
            var index =this.FindIndex(x => x.Id == doc.Id);
            this[index] = doc;
        }

        public void UpdateAsync(Drawing doc)
        {
        }

        public void Delete(Drawing doc)
        {
            if (doc == null)
                return;

            var allChildrens = GetListAllChildrens(doc.Id);
            RemoveAll(x => allChildrens.Any(y => y.Id == x.Id));
            Remove(doc);
        }

        public void DeleteAsync(Drawing doc)
        {
            Delete(doc);
        }

        public void InsertOrUpdate(Drawing doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public Drawing GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<Drawing> GetDocumentAsync(int? id)
        {
            return new Task<Drawing>(() => GetDocument(id));
        }

        public List<Drawing> GetListDocsInHierarchy(int? id)
        {
            var topParentId = GetTopParentId(id, this);
            return GetListAllChildrens(topParentId);
        }

        public List<Drawing> GetListAllChildrens(int? id)
        {
            return GetAllChildrens(id, this);
        }

        private static int? GetTopParentId(int? id, List<Drawing> drawingMongoCollection)
        {
            while (true)
            {
                var copyId = id;
                var drawing = drawingMongoCollection.FirstOrDefault(x => x.Id == copyId);
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

        private List<Drawing> GetAllChildrens(int? parentId, List<Drawing> data)
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

        private List<Drawing> GetChildrenDrawings(int? parentId, List<Drawing> data)
        {
            return data.Where(x => x.ParentId == parentId).ToList();
        }
    }
}