using Core;
using Core.Interfaces;
using MongoDB.Driver;

namespace MongoWork
{
    public class DataManagerFactory : IDataManagerFactory
    {
        private readonly IMongoDatabase _database;

        public DataManagerFactory(IMongoDatabase database)
        {
            _database = database;
        }

        /// <summary>
        /// Получить управленца данными
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <returns>Управленец данными</returns>
        public virtual IClassDataManager<T> GetDataManager<T>() where T : IEntity
        {
            return new MongoDbDataManager<T>(_database);
        }
    }
}