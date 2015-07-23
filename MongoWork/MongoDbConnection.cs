using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoWork.MongoAdditional.Service;
using MongoWork.Properties;

namespace MongoWork
{
    public class MongoDbConnection
    {
        private IMongoClient _client;
        private IMongoDatabase _database;

        public IMongoDatabase Database { get { return _database; } }

        public MongoDbConnection()
        {
            _client = new MongoClient(Settings.Default.ConnectionString);
            _database = _client.GetDatabase(Settings.Default.DbName);
        }


        public MongoDbConnection(string connectionString, string dbName)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(dbName);
        }

        public void DropDatabase()
        {
            _client.DropDatabaseAsync(_database.DatabaseNamespace.DatabaseName);
        }
    }

}