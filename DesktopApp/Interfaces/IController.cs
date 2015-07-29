using System;
using System.Collections.Generic;
using Core.Interfaces;

namespace DesktopApp.Interfaces
{
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IController<T> where T : IEntity
    {
        List<T> GetData();

        /// <summary>
        ///     Эвент, что данные обновились
        /// </summary>
        event EventHandler DataRefreshed;

        T CreateDocument();
        void SaveDocument(T doc);
        void DeleteDocument(T doc);
        List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity;
        int CompareTwoDocuments(T doc1, T doc2);
    }

    public interface IComplexController<T> : IController<T> where T : IEntity
    {
        void ExternalAddDocument(T doc);
        void ExternalEditDocument(T doc);
        void ExternalDeleteDocument(T doc);

    }
}