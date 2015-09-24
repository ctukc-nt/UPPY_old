using Core;
using Core.Interfaces;
using MongoDB.Driver;

namespace MongoWork
{
    public class DataManagersFactory : IDataManagersFactory
    {
        protected readonly IMongoDatabase Database;

        public DataManagersFactory(IMongoDatabase database)
        {
            Database = database;
        }

        /// <summary>
        /// Получить управленца данными
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <returns>Управленец данными</returns>
        public virtual IClassDataManager<T> GetDataManager<T>() where T : IEntity
        {
            return new MongoDbDataManager<T>(Database);
        }
    }
}