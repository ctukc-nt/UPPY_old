using System.Collections.Generic;
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
            return GetListCollectionAsync<T>().Result;
        }

        public async void Insert<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            doc.Id = doc.Id ?? GetIdDocument<T>();
            await collection.InsertOneAsync(doc);
        }

        public async void Update<T>(T doc) where T : IEntity
        {
            var collection = GetCollection<T>();
            await collection.ReplaceOneAsync(x => x.Id == doc.Id, doc);
        }

        public async void Delete<T>(T doc) where T : IEntity
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

        private static string GetNameColection<T>()
        {
            var nameColection = typeof (T).Name.ToLower() + "s";
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
    }
}