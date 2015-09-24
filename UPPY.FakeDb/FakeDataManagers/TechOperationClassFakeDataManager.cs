using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.FakeDb.FakeDataManagers
{
    public class TechOperationClassFakeDataManager : List<TechOperation>, IClassDataManager<TechOperation>
    {
        public TechOperationClassFakeDataManager()
        {
            Add(new TechOperation() {Id = 1, ShortName = "A", FullName = "AAAAA"});
            Add(new TechOperation() {Id = 2, ShortName = "B", FullName = "BBBBB"});
            Add(new TechOperation() {Id = 3, ShortName = "C", FullName = "CCCCC"});
            Add(new TechOperation() {Id = 4, ShortName = "D", FullName = "DDDDD"});
            Add(new TechOperation() {Id = 5, ShortName = "E", FullName = "EEEEE"});
        }

        private int _count = 6;

        public Task<List<TechOperation>> GetListCollectionAsync()
        {
            return new Task<List<TechOperation>>(() => this);
        }
        public List<TechOperation> GetListCollection()
        {
            return this;
        }

        public List<TechOperation> GetListCollection(Func<TechOperation, bool> filter)
        {
            return this.Where(filter).ToList();
        }

        public void Insert(TechOperation doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(TechOperation doc)
        {
            Insert(doc);
        }

        public void Update(TechOperation doc)
        {

        }

        public void UpdateAsync(TechOperation doc)
        {

        }

        public void Delete(TechOperation doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(TechOperation doc)
        {
            Remove(doc);
        }

        public void InsertOrUpdate(TechOperation doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public TechOperation GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<TechOperation> GetDocumentAsync(int? id)
        {
            return new Task<TechOperation>(() => GetDocument(id));
        }

        public List<TechOperation> FindInDbDirectly(Func<TechOperation, bool> id)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<TechOperation>.InsertAsync(TechOperation doc)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<TechOperation>.UpdateAsync(TechOperation doc)
        {
            throw new NotImplementedException();
        }

        Task IClassDataManager<TechOperation>.DeleteAsync(TechOperation doc)
        {
            throw new NotImplementedException();
        }
    }
}