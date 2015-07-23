using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IClassDataManager<T> where T : IEntity
    {
        /// <summary>
        /// Получить список документов асинхронно
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetListCollectionAsync();
        
        /// <summary>
        /// Получить список документов
        /// </summary>
        List<T> GetListCollection();

        /// <summary>
        /// Вставить документ
        /// </summary>
        void Insert(T doc);

        /// <summary>
        /// Вставить документ асинхронно
        /// </summary>
        void InsertAsync(T doc);void Update(T doc);

        /// <summary>
        /// Обновить документ асинхронно
        /// </summary>
        void UpdateAsync(T doc);

        /// <summary>
        /// Удалить документ
        /// </summary>
        void Delete(T doc);

        /// <summary>
        /// Удалить документ асинхронно
        /// </summary>
        void DeleteAsync(T doc);

        /// <summary>
        /// Вставить или обновить документ
        /// </summary>
        void InsertOrUpdate(T doc);
        T GetDocument(int? id);

        /// <summary>
        /// Получить документ асинхронно
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetDocumentAsync(int? id);
    }
}