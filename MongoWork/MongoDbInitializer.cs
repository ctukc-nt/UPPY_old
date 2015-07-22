using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoWork.MongoAdditional;
using MongoWork.Properties;

namespace MongoWork
{
    public class MongoDbInitializer
    {
        private IMongoDatabase _database;

        public void ConnectToDb()
        {
            var client = new MongoClient(Settings.Default.ConnectionString);
            _database = client.GetDatabase(Settings.Default.DbName);
        }

        public IMongoDatabase GetDbConnection()
        {
            if (_database == null)
                ConnectToDb();

            if (_database == null)
                throw new NullReferenceException("Connection to db not established");

            return _database;
        }

        public void InitDatabase()
        {
            var connection = GetDbConnection();

            try
            {
                var resDraw = connection.CreateCollectionAsync("drawings");
                var resTecOper = connection.CreateCollectionAsync("techroutes");
                var resTechRoute = connection.CreateCollectionAsync("techopers");
                var resDocsId = connection.CreateCollectionAsync("docsid");

                Task.WaitAll(resDraw, resTecOper, resTechRoute, resDocsId);

                CreateIndexes();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void CreateIndexes()
        {
            var connection = GetDbConnection();
            var collection = connection.GetCollection<DocsId>("docsid");

            IndexKeysDefinition<DocsId> index = Builders<DocsId>.IndexKeys.Ascending(x => x.DocName);
            collection.Indexes.CreateOneAsync(index);
        }
    }
}