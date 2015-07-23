using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoWork.MongoAdditional.Service;
using MongoWork.Properties;

namespace MongoWork
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;

        public IMongoDatabase Database { get { return _database; } }

        public MongoDbConnection()
        {
            var client = new MongoClient(Settings.Default.ConnectionString);
            _database = client.GetDatabase(Settings.Default.DbName);
        }


        public MongoDbConnection(string connectionString, string dbName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(dbName);
        }
    }

}