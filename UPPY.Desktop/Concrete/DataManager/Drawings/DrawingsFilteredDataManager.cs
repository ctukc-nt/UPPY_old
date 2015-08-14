using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DomainModel;
using MongoDB.Driver;
using MongoWork;

namespace UPPY.Desktop.Concrete.DataManager.Drawings
{
    public class DrawingsFilteredDataManager : MongoDbDataManager<Drawing>
    {
        private List<Drawing> _cashedList = null;

        private int? _parentId;

        private Task<List<Drawing>> GetChildrenDrawingsAsync(int? parentId)
        {
            var collection = GetCollection();
            return collection.Find(x => x.ParentId == parentId).ToListAsync();
        }

        private List<Drawing> GetChildrenDrawings(int? parentId)
        {
            var collection = GetCollection();
            return GetChildrenDrawingsAsync(parentId).Result;
        }

        private List<Drawing> GetAllChildrens(int? parentId)
        {
            var result = new List<Drawing>();
            var childrens = GetChildrenDrawings(parentId);
            result.AddRange(childrens);
            foreach (var drawing in result)
            {
                result.AddRange(GetAllChildrens(drawing.Id));
            }

            return result;
        }

        public DrawingsFilteredDataManager(IMongoDatabase db, int? parentId) : base(db)
        {
            _parentId = parentId;
        }

        public new async Task<List<Drawing>> GetListCollectionAsync()
        {
            throw new NotImplementedException();
            var collection = GetCollection();
            return await collection.Find(x => true).ToListAsync();
        }

        /// <summary>
        ///     Получить список документов
        /// </summary>
        public new List<Drawing> GetListCollection()
        {
            return GetAllChildrens(_parentId);
        }

        /// <summary>
        ///     Вставить документ
        /// </summary>
        public new void Insert(Drawing doc)
        {
            var task = InsertAsync(doc);
            task.Wait();
        }

        /// <summary>
        ///     Вставить документ асинхронно
        /// </summary>
        public new async Task InsertAsync(Drawing doc)
        {
            var collection = GetCollection();
            if (doc.Id == null)
            {
                doc.Id = GetIdDocument();
            }
            else
            {
                SetIdDocument((int)doc.Id);
            }

            await collection.InsertOneAsync(doc);
        }

        /// <summary>
        ///     Вставить документ
        /// </summary>
        public new void Update(Drawing doc)
        {
            var collection = GetCollection();
            collection.ReplaceOneAsync(x => x.Id == doc.Id, doc).Wait();
        }
        /// <summary>
        ///     Обновить документ асинхронно
        /// </summary>
        public new async void UpdateAsync(Drawing doc)
        {
            var collection = GetCollection();
            await collection.ReplaceOneAsync(x => x.Id == doc.Id, doc);
        }

        /// <summary>
        ///     Удалить документ
        /// </summary>
        public new void Delete(Drawing doc)
        {
            var collection = GetCollection();
            collection.DeleteOneAsync(x => x.Id == doc.Id).Wait();
        }

        /// <summary>
        ///     Удалить документ асинхронно
        /// </summary>
        public new async void DeleteAsync(Drawing doc)
        {
            var collection = GetCollection();
            await collection.DeleteOneAsync(x => x.Id == doc.Id);
        }

        /// <summary>
        ///     Вставить или обновить документ
        /// </summary>
        public override void InsertOrUpdate(Drawing doc)
        {
            var collection = GetCollection();
            var finded = collection.Find(x => x.Id == doc.Id).FirstOrDefaultAsync();

            finded.Wait();

            if (finded.Result != null)
            {
                Update(doc);
            }
            else
            {
                Insert(doc);
            }
        }

        public new Drawing GetDocument(int? id)
        {
            var wait = GetDocumentAsync(id);
            wait.Wait();
            return wait.Result;
        }

        /// <summary>
        ///     Получить документ асинхронно
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Drawing> GetDocumentAsync(int? id)
        {
            var collection = MongoDb.GetCollection<Drawing>(GetNameColection());
            var res = collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            await res;

            return res.Result;
        }

        public new List<Drawing> FindInDbDirectly(Func<Drawing, bool> filter)
        {
            return GetCollection().Find(x => filter(x)).ToListAsync().Result;
        }
    }
}