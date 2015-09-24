using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.FakeDb.FakeDataManagers
{

    public class StandartClassFakeDataManager : List<Standart>, IClassDataManager<Standart>
    {
        private int _count = 0;

        public Task<List<Standart>> GetListCollectionAsync()
        {
            return new Task<List<Standart>>(() => this);
        }
        public List<Standart> GetListCollection()
        {
            return this;
        }

        public List<Standart> GetListCollection(Func<Standart, bool> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Standart doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(Standart doc)
        {
            Insert(doc);
        }

        public void Update(Standart doc)
        {

        }

        public void UpdateAsync(Standart doc)
        {

        }

        public void Delete(Standart doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(Standart doc)
        {
            Remove(doc);
        }

        public void InsertOrUpdate(Standart doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public Standart GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<Standart> GetDocumentAsync(int? id)
        {
            return new Task<Standart>(() => GetDocument(id));
        }

        public List<Standart> FindInDbDirectly(Func<Standart, bool> id)
        {
            throw new NotImplementedException();
        }

        public List<Standart> FindInDbDirectlyById(int? id)
        {
            throw new System.NotImplementedException();
        }

        Task IClassDataManager<Standart>.InsertAsync(Standart doc)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<Standart>.UpdateAsync(Standart doc)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<Standart>.DeleteAsync(Standart doc)
        {
            throw new NotImplementedException();
        }
    }
}