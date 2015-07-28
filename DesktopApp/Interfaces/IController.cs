using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Infrastructure;

namespace DesktopApp.Interfaces
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IController<T> where T:IEntity
    {
        List<T> GetData();

        /// <summary>
        ///     Эвент, что данные обновились
        /// </summary>
        event EventHandler SourceRefreshed;

        T CreateDocument();
        void AddDocument(T doc);
        void UpdateDocument(T doc);
        void DeleteDocument(T doc);
        List<IEntity> GetListRelatedDocument<TO>() where TO:IEntity;

        int CompareTwoDocuments(T doc1, T doc2);
    }
}