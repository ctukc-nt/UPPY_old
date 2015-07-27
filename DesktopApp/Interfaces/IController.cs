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
    public interface IController<T>
    {
        List<T> GetData();

        /// <summary>
        ///     Эвент, что данные обновились
        /// </summary>
        event EventHandler SourceRefreshed;

        void AddDocument(object sender, DocumentEventArgs<T> args);
        void UpdateDocument(object sender, DocumentEventArgs<T> args);
        void DeleteDocument(object sender, DocumentEventArgs<T> args);
        List<IEntity> GetListRelatedDocument<TO>();

        int CompareTwoDocuments(T doc1, T doc2);
    }
}