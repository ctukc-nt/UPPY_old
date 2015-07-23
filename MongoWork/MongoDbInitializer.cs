using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoWork.MongoAdditional.Service;
using MongoWork.Properties;

namespace MongoWork
{
    public class MongoDbInitializer
    {
        private IMongoDatabase _database;
        private static volatile MongoDbInitializer _instance;

        public static MongoDbInitializer MongoDb
        {
            get
            {
                if (_instance == null)
                    _instance = new MongoDbInitializer();

                return _instance;
            }
        }

        private MongoDbInitializer()
        {
            
        }

        private void ConnectToDb()
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

        private void InitDatabase()
        {
            var connection = GetDbConnection();

            try
            {
                var resDocsId = connection.CreateCollectionAsync("docsid");
                var resAudit = connection.CreateCollectionAsync("audit");

                Task.WaitAll(resDocsId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //private void CreateIndexes()
        //{
        //    var connection = GetDbConnection();
        //    var collection = connection.GetCollection<DocsId>("docsid");

        //    var index = Builders<DocsId>.IndexKeys.Ascending(x => x.DocName);
        //    collection.Indexes.CreateOneAsync(index);
        //}
    }
}