using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DomainModel;

namespace Core.Interfaces
{
    public interface IClassDataManager<T> where T : IEntity
    {
        /// <summary>
        ///     Получить список документов асинхронно
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetListCollectionAsync();

        /// <summary>
        ///     Получить список документов
        /// </summary>
        List<T> GetListCollection();

        List<T> GetListCollection(Func<T, bool> filter);

        /// <summary>
        ///     Вставить документ
        /// </summary>
        void Insert(T doc);

        /// <summary>
        ///     Вставить документ асинхронно
        /// </summary>
        Task InsertAsync(T doc);

        /// <summary>
        ///     Вставить документ
        /// </summary>
        void Update(T doc);

        /// <summary>
        ///     Обновить документ асинхронно
        /// </summary>
        Task UpdateAsync(T doc);

        /// <summary>
        ///     Удалить документ
        /// </summary>
        void Delete(T doc);

        /// <summary>
        ///     Удалить документ асинхронно
        /// </summary>
        Task DeleteAsync(T doc);

        /// <summary>
        ///     Вставить или обновить документ
        /// </summary>
        void InsertOrUpdate(T doc);

        /// <summary>
        ///     Получить документ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetDocument(int? id);

        /// <summary>
        ///     Получить документ асинхронно
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetDocumentAsync(int? id);
    }
}