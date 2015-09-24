using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.FakeDb.FakeDataManagers
{
    public class DrawingListClassFakeDataManager : IHierClassDataManager<Drawing>
    {
        protected static List<Drawing> _db = new List<Drawing>();
        private void SetUp()
        {
            var rndRandom = new Random();

            for (var i = 1; i < 2000; i++)
            {
                var random = new Random(i);
                var parentId = rndRandom.Next(0, 1) == 1 ? null : (i - 1 > 1 ? rndRandom.Next(1, i - 1) : (int?)null);
                _db.Add(new Drawing { Id = i, ParentId = parentId });
            }
        }

        private static int _count = 5000;

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
            return new Task<List<Drawing>>(() => _db);
        }

        public virtual List<Drawing> GetListCollection()
        {
            return _db;
        }

        public List<Drawing> GetListCollection(Func<Drawing, bool> filter)
        {
            return _db.Where(filter).ToList();
        }

        public void Insert(Drawing doc)
        {
            _db.Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(Drawing doc)
        {
            Insert(doc);
        }

        public void Update(Drawing doc)
        {
            var index = _db.FindIndex(x => x.Id == doc.Id);
            _db[index] = doc;
        }

        public void UpdateAsync(Drawing doc)
        {
        }

        public void Delete(Drawing doc)
        {
            if (doc == null)
                return;

            var allChildrens = GetListAllChildrens(doc.Id);
            _db.RemoveAll(x => allChildrens.Any(y => y.Id == x.Id));
            _db.Remove(doc);
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
            return _db.FirstOrDefault(x => x.Id == id);
        }

        public Task<Drawing> GetDocumentAsync(int? id)
        {
            return new Task<Drawing>(() => GetDocument(id));
        }

        public List<Drawing> GetListDocsInHierarchy(int? id)
        {
            var topParentId = GetTopParentId(id, _db);
            return GetListAllChildrens(topParentId);
        }

        public List<Drawing> GetListAllChildrens(int? id)
        {
            return GetAllChildrens(id, _db);
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

        Task IClassDataManager<Drawing>.InsertAsync(Drawing doc)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<Drawing>.UpdateAsync(Drawing doc)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<Drawing>.DeleteAsync(Drawing doc)
        {
            throw new NotImplementedException();
        }
    }
}