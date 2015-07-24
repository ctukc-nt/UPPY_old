using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;

namespace DesktopApp.Temp
{
    public class TechRoutesClassDataManager : List<TechRoute>, IClassDataManager<TechRoute>
    {
        public TechRoutesClassDataManager()
        {
            Add(new TechRoute()
            {
                Id = 1,
                Name = "A - B",
                TechOperations = new List<TechOperation>()
                        {
                            new TechOperation() {ShortName = "A"},
                            new TechOperation() {ShortName = "B"},
                        }
            });

            Add(new TechRoute()
            {
                Id = 2,
                Name = "B - C",
                TechOperations = new List<TechOperation>()
                        {
                            new TechOperation() {ShortName = "B"},
                            new TechOperation() {ShortName = "C"},
                        }
            });
        }

        private int _count = 0;

        public Task<List<TechRoute>> GetListCollectionAsync()
        {
            return new Task<List<TechRoute>>(() => this);
        }
        public List<TechRoute> GetListCollection()
        {
            return this;
        }

        public void Insert(TechRoute doc)
        {
            Add(doc);
            doc.Id = _count++;
        }

        public void InsertAsync(TechRoute doc)
        {
            Insert(doc);
        }

        public void Update(TechRoute doc)
        {

        }

        public void UpdateAsync(TechRoute doc)
        {

        }

        public void Delete(TechRoute doc)
        {
            Remove(doc);
        }

        public void DeleteAsync(TechRoute doc)
        {
            Remove(doc);
        }

        public void InsertOrUpdate(TechRoute doc)
        {
            if (doc.Id != null)
                Update(doc);
            else
            {
                Insert(doc);
            }
        }

        public TechRoute GetDocument(int? id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public Task<TechRoute> GetDocumentAsync(int? id)
        {
            return new Task<TechRoute>(() => GetDocument(id));
        }
    }
}