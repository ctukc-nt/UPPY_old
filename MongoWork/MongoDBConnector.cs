using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using MongoDB.Driver;
using MongoWork.MongoAdditional;

namespace MongoWork
{
    public class MongoDbConnector : IDataManager
    {
        private readonly IMongoDatabase _mongoDb;

        public MongoDbConnector(IMongoDatabase db)
        {
            _mongoDb = db;
        }

        public async Task<List<T>> GetListCollectionAsync<T>() where T : IEntity
        {
            var collection = GetCollection<T>();
            return await collection.Find(x => true).ToListAsync();
        }

        public List<T> GetListCollection<T>() where T : IEntity
        {
            var collection = GetCollection<T>();
            return collection.Find(x => true).ToListAsync().Result;
        }

        public void Insert<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            if (doc.Id == null)
            {
                doc.Id = GetIdDocument<T>();
            }
            else
            {
                SetIdDocument<T>((int)doc.Id);
            }

            collection.InsertOneAsync(doc).Wait();
        }

        public async void InsertAsync<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            if (doc.Id == null)
            {
                doc.Id = GetIdDocument<T>();
            }
            else
            {
                SetIdDocument<T>((int)doc.Id);
            }

            await collection.InsertOneAsync(doc);
        }

        public void Update<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            collection.ReplaceOneAsync(x => x.Id == doc.Id, doc).Wait();
        }

        public async void UpdateAsync<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            await collection.ReplaceOneAsync(x => x.Id == doc.Id, doc);
        }

        public void Delete<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            collection.DeleteOneAsync(x => x.Id == doc.Id).Wait();
        }

        public async void DeleteAsync<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            await collection.DeleteOneAsync(x => x.Id == doc.Id);
        }

        public void InsertOrUpdate<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
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

        public IMongoCollection<T> GetCollection<T>()
        {
            return _mongoDb.GetCollection<T>(GetNameColection<T>());
        }

        public T GetDocument<T>(int? id) where T : IEntity
        {
            var collection = _mongoDb.GetCollection<T>(GetNameColection<T>());
            return collection.Find(x => x.Id == id).FirstOrDefaultAsync().Result;
        }

        private static string GetNameColection<T>()
        {
            var nameColection = typeof(T).Name.ToLower() + "s";
            return nameColection;
        }

        private int GetIdDocument<T>()
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

        private int SetIdDocument<T>(int idSet)
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