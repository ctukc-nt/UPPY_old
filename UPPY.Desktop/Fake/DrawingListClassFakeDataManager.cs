using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class DrawingListClassFakeDataManager : List<Drawing>, IClassDataManager<Drawing>
    {
        private int _count = 9;

        public DrawingListClassFakeDataManager()
        {
            AddRange(new List<Drawing>
            {
                new Drawing {Id = 1, Name = "1"},
                new Drawing {Id = 2, Name = "2"},
                new Drawing {Id = 8, ParentId = 2, Name = "2.1."},
                new Drawing {Id = 3, Name = "3"},
                new Drawing {Id = 4, ParentId = 2, Name = "2.2."},
                new Drawing {Id = 5, ParentId = 4, Name = "2.2.1"},
                new Drawing {Id = 6, Name = "4"},
                new Drawing {Id = 7, ParentId = 5, Name = "2.1.1.1"}
            });
        }

        public Task<List<Drawing>> GetListCollectionAsync()
        {
            return new Task<List<Drawing>>(() => this);
        }

        public List<Drawing> GetListCollection()
        {
            return this;
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
        }

        public void UpdateAsync(Drawing doc)
        {
        }

        public void Delete(Drawing doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(Drawing doc)
        {
            Remove(doc);
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

        public List<Drawing> FindInDbDirectly(Func<Drawing, bool> id)
        {
            throw new NotImplementedException();
        }

        public List<Drawing> FindInDbDirectlyById(int? id)
        {
            throw new NotImplementedException();
        }
    }
}