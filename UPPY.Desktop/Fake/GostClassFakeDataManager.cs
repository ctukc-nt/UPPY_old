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
        public GostClassFakeDataManager()
        {
            Add(new Gost { Profile = "ДВУТАВР", Name = "ГОСТ 26020-83" });
            Add(new Gost { Profile = "ДВУТАВР", Name = "ГОСТ 8239-89" });
            Add(new Gost { Profile = "КВАДРАТ", Name = "ГОСТ 2591-2006" });
            Add(new Gost { Profile = "КРУГ", Name = "ГОСТ 2590-2006" });
            Add(new Gost { Profile = "КРУГ", Name = "ГОСТ 2590-88" });
            Add(new Gost { Profile = "ЛИСТ ЧЕЧЕВИЦА", Name = "ГОСТ 8568-77" });
            Add(new Gost { Profile = "ЛИСТ", Name = "ГОСТ 19903-74" });
            Add(new Gost { Profile = "ЛИСТ", Name = "ГОСТ 8568-77" });
            Add(new Gost { Profile = "ОТВОД", Name = "ГОСТ 17375-01" });
            Add(new Gost { Profile = "ОТВОД", Name = "ГОСТ 17375-2001" });
            Add(new Gost { Profile = "ПРОВОЛОКА", Name = "ГОСТ 3282-74" });
            Add(new Gost { Profile = "СЕТКА", Name = "ГОСТ 3826-82" });
            Add(new Gost { Profile = "ТРУБА", Name = "ГОСТ 3262-75" });
            Add(new Gost { Profile = "ТРУБА", Name = "ГОСТ 8639-82" });
            Add(new Gost { Profile = "ТРУБА", Name = "ГОСТ 8732-78" });
            Add(new Gost { Profile = "ТРУБА", Name = "ГОСТ 8734-75" });
            Add(new Gost { Profile = "ТРУБА", Name = "ТУ 14-3Р-55-2001" });
            Add(new Gost { Profile = "УГОЛОК", Name = "ГОСТ 27772-88" });
            Add(new Gost { Profile = "УГОЛОК", Name = "ГОСТ 8509-93" });
            Add(new Gost { Profile = "УГОЛОК", Name = "ГОСТ 8510-86" });
            Add(new Gost { Profile = "ШВЕЛЛЕР", Name = "ГОСТ 8240-97" });
        }

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