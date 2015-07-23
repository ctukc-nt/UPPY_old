using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace DesktopApp.Temp
{
    public class ListClassDataManager : List<Drawing>, IClassDataManager<Drawing>
    {

        private int _count = 0;

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
    }
}