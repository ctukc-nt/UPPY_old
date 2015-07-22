using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core
{
    public interface IDataManager
    {
        void InsertOrUpdate<T>(T doc) where T : IEntity;
        Task<List<T>> GetListCollectionAsync<T>() where T : IEntity;
        List<T> GetListCollection<T>() where T : IEntity;
        void Update<T>(T doc) where T : IEntity;
        void UpdateAsync<T>(T doc) where T : IEntity;
        void Delete<T>(T doc) where T : IEntity;
        void DeleteAsync<T>(T doc) where T : IEntity;
        void Insert<T>(T doc) where T : IEntity;
        void InsertAsync<T>(T doc) where T : IEntity;
    }
}