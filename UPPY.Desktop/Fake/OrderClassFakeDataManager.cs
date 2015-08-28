using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Fake
{
    public class OrderClassFakeDataManager : List<Order>, IClassDataManager<Order>
    {
        private int _count = 1;

        public Task<List<Order>> GetListCollectionAsync()
        {
            return new Task<List<Order>>(() => this);
        }

        public List<Order> GetListCollection()
        {
            return this;
        }

        public List<Order> GetListCollection(Func<Order, bool> filter)
        {
            return this.Where(filter).ToList();
        }

        public void Insert(Order doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(Order doc)
        {
            Insert(doc);
        }

        public void Update(Order doc)
        {
        }

        public void UpdateAsync(Order doc)
        {
        }

        public void Delete(Order doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(Order doc)
        {
            Remove(doc);
        }

        public void InsertOrUpdate(Order doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public Order GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<Order> GetDocumentAsync(int? id)
        {
            return new Task<Order>(() => GetDocument(id));
        }

        public List<Order> FindInDbDirectly(Func<Order, bool> id)
        {
            throw new NotImplementedException();
        }

        public List<Order> FindInDbDirectlyById(int? id)
        {
            throw new NotImplementedException();
        }
    }
}