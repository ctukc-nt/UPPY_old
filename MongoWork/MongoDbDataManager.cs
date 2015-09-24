using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork.MongoAdditional.Service;

namespace MongoWork
{
    /// <summary>
    ///     Универсальный менеджер объектов
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    public class MongoDbDataManager<T> : IClassDataManager<T> where T : IEntity
    {
        protected readonly IMongoDatabase MongoDb;

        public MongoDbDataManager(IMongoDatabase db)
        {
            MongoDb = db;
        }

        /// <summary>
        ///     Получить список документов асинхронно
        /// </summary> <returns></returns>
        public virtual async Task<List<T>> GetListCollectionAsync()
        {
            var collection = GetCollection();
            return await collection.Find(x => true).ToListAsync();
        }

        /// <summary>
        ///     Получить список документов
        /// </summary>
        public virtual List<T> GetListCollection()
        {
            var collection = GetCollection();
            return collection.Find(x => true).ToListAsync().Result;
        }

        public virtual List<T> GetListCollection(Func<T, bool> filter)
        {
            var collection = GetCollection();
            return collection.Find(x => filter(x)).ToListAsync().Result;
        }

        /// <summary>
        ///     Вставить документ
        /// </summary>
        public void Insert(T doc)
        {
            var collection = GetCollection();
            if (doc.Id == null)
            {
                doc.Id = GetIdDocument();
            }
            else
            {
                SetIdDocument((int) doc.Id);
            }

            collection.InsertOneAsync(doc).Wait();
        }

       /// <summary>
        ///     Вставить документ
        /// </summary>
        public void Update(T doc)
        {
            var collection = GetCollection();
            collection.ReplaceOneAsync(x => x.Id == doc.Id, doc).Wait();
        }
       
        /// <summary>
        ///     Удалить документ
        /// </summary>
        public void Delete(T doc)
        {
            var collection = GetCollection();
            collection.DeleteOneAsync(x => x.Id == doc.Id).Wait();
        }

        /// <summary>
        ///     Вставить или обновить документ
        /// </summary>
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

        public T GetDocument(int? id)
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
        public async Task<T> GetDocumentAsync(int? id)
        {
            var collection = MongoDb.GetCollection<T>(GetNameColection());
            var res = collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            await res;

            return res.Result;
        }

        protected IMongoCollection<T> GetCollection()
        {
            return MongoDb.GetCollection<T>(GetNameColection());
        }

        protected static string GetNameColection()
        {
            var nameColection = typeof (T).Name.ToLower() + "s";
            return nameColection;
        }

        protected int GetIdDocument()
        {
            var collection = MongoDb.GetCollection<DocsId>("docsid");
            var incrDocIdOptions = Builders<DocsId>.Update.Inc(x => x.DocId, 1);
            var rec = collection.Find(x => x.DocName == typeof (T).Name).CountAsync();
            rec.Wait();

            if (rec.Result == 0)
            {
                var res = collection.InsertOneAsync(new DocsId {DocId = 2, DocName = typeof (T).Name});
                res.Wait();
                if (res.Exception != null)
                {
                    return
                        collection.FindOneAndUpdateAsync(id => id.DocName == typeof (T).Name, incrDocIdOptions)
                            .Result.DocId;
                }

                return 1;
            }
            return collection.FindOneAndUpdateAsync(id => id.DocName == typeof (T).Name, incrDocIdOptions).Result.DocId;
        }

        protected int SetIdDocument(int idSet)
        {
            var collection = MongoDb.GetCollection<DocsId>("docsid");
            var setDocIdUpdate = Builders<DocsId>.Update.Max(x => x.DocId, idSet);
            var rec = collection.Find(x => x.DocName == typeof (T).Name).CountAsync();
            rec.Wait();

            if (rec.Result == 0)
            {
                var res = collection.InsertOneAsync(new DocsId {DocId = idSet, DocName = typeof (T).Name});
                res.Wait();
                if (res.Exception != null)
                {
                    return
                        collection.FindOneAndUpdateAsync(id => id.DocName == typeof (T).Name, setDocIdUpdate)
                            .Result.DocId;
                }

                return idSet;
            }

            return collection.FindOneAndUpdateAsync(id => id.DocName == typeof (T).Name, setDocIdUpdate).Result.DocId;
        }

        public Task InsertAsync(T doc)
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

            return collection.InsertOneAsync(doc);
        }

        /// <summary>
        ///     Обновить документ асинхронно
        /// </summary>
        public Task UpdateAsync(T doc)
        {
            var collection = GetCollection();
            return collection.ReplaceOneAsync(x => x.Id == doc.Id, doc);
        }

        /// <summary>
        ///     Удалить документ асинхронно
        /// </summary>
        public Task DeleteAsync(T doc)
        {
            var collection = GetCollection();
            return collection.DeleteOneAsync(x => x.Id == doc.Id);
        }
    }
}