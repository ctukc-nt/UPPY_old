using System;
using System.Collections.Generic;
using Core.Interfaces;

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
        void SaveDocument(T doc);
        void DeleteDocument(T doc);
        List<IEntity> GetListRelatedDocument<TO>() where TO:IEntity;
        int CompareTwoDocuments(T doc1, T doc2);
    }
}