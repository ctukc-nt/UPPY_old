using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class GostClassFakeDataManager : List<Gost>, IClassDataManager<Gost>
    {
        private int _count = 1;

        public Task<List<Gost>> GetListCollectionAsync()
        {
            return new Task<List<Gost>>(() => this);
        }

        public List<Gost> GetListCollection()
        {
            return this;
        }

        public List<Gost> GetListCollection(Func<Gost, bool> filter)
        {
            return this.Where(filter).ToList();
        }

        public void Insert(Gost doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(Gost doc)
        {
            Insert(doc);
        }

        public void Update(Gost doc)
        {
        }

        public void UpdateAsync(Gost doc)
        {
        }

        public void Delete(Gost doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(Gost doc)
        {
            Remove(doc);
        }

        public void InsertOrUpdate(Gost doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public Gost GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<Gost> GetDocumentAsync(int? id)
        {
            return new Task<Gost>(() => GetDocument(id));
        }
       
    }
}