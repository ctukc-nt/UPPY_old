using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork.MongoAdditional;
using MongoWork.MongoAdditional.Service;

namespace MongoWork
{
    /// <summary>
    /// Универсальный менеджер объектов
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    public class MongoDbDataManager<T> : IClassDataManager<T> where T : IEntity
    {
        protected readonly IMongoDatabase _mongoDb;

        public MongoDbDataManager(IMongoDatabase db)
        {
            _mongoDb = db;
        }

        public async Task<List<T>> GetListCollectionAsync()
        {
            var collection = GetCollection();
            return await collection.Find(x => true).ToListAsync();
        }

        public List<T> GetListCollection()
        {
            var collection = GetCollection();
            return collection.Find(x => true).ToListAsync().Result;
        }

        public void Insert(T doc)
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

            collection.InsertOneAsync(doc).Wait();
        }

        public async void InsertAsync(T doc)
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

        public void Update(T doc)
        {
            var collection = GetCollection();
            collection.ReplaceOneAsync(x => x.Id == doc.Id, doc).Wait();
        }

        public async void UpdateAsync(T doc)
        {
            var collection = GetCollection();
            await collection.ReplaceOneAsync(x => x.Id == doc.Id, doc);
        }

        public void Delete(T doc)
        {
            var collection = GetCollection();
            collection.DeleteOneAsync(x => x.Id == doc.Id).Wait();
        }

        public async void DeleteAsync(T doc)
        {
            var collection = GetCollection();
            await collection.DeleteOneAsync(x => x.Id == doc.Id);
        }

        public virtual void InsertOrUpdate(T doc)
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

        public IMongoCollection<T> GetCollection()
        {
            return _mongoDb.GetCollection<T>(GetNameColection());
        }


        public T GetDocument(int? id)
        {
            var wait = GetDocumentAsync(id);
            wait.Wait();
            return wait.Result;
        }

       /// <summary>
        /// Получить документ асинхронно
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetDocumentAsync(int? id)
        {
            var collection = _mongoDb.GetCollection<T>(GetNameColection());
            var res = collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            await res;

            return res.Result;
        }

        private static string GetNameColection()
        {
            var nameColection = typeof(T).Name.ToLower() + "s";
            return nameColection;
        }

        private int GetIdDocument()
        {
            var collection = _mongoDb.GetCollection<DocsId>("docsid");
            var incrDocIdOptions = Builders<DocsId>.Update.Inc(x => x.DocId, 1);
            var rec = collection.Find(x => x.DocName == typeof(T).Name).CountAsync();
            rec.Wait();

            if (rec.Result == 0)
            {
                var res = collection.InsertOneAsync(new DocsId { DocId = 2, DocName = typeof(T).Name });
                res.Wait();
                if (res.Exception != null)
                {
                    return
                        collection.FindOneAndUpdateAsync(id => id.DocName == typeof(T).Name, incrDocIdOptions).Result.DocId;
                }

                return 1;
            }

            return collection.FindOneAndUpdateAsync(id => id.DocName == typeof(T).Name, incrDocIdOptions).Result.DocId;
        }

        private int SetIdDocument(int idSet)
        {
            var collection = _mongoDb.GetCollection<DocsId>("docsid");
            var setDocIdUpdate = Builders<DocsId>.Update.Max(x => x.DocId, idSet);
            var rec = collection.Find(x => x.DocName == typeof(T).Name).CountAsync();
            rec.Wait();

            if (rec.Result == 0)
            {
                var res = collection.InsertOneAsync(new DocsId { DocId = idSet, DocName = typeof(T).Name });
                res.Wait();
                if (res.Exception != null)
                {
                    return
                        collection.FindOneAndUpdateAsync(id => id.DocName == typeof(T).Name, setDocIdUpdate).Result.DocId;
                }

                return idSet;
            }

            return collection.FindOneAndUpdateAsync(id => id.DocName == typeof(T).Name, setDocIdUpdate).Result.DocId;
        }
    }
}