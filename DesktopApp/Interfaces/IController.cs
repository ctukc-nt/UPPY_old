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

        void AddDocument(object sender, DocumentEventArgs<Drawing> args);
        void UpdateDocument(object sender, DocumentEventArgs<Drawing> args);
        void DeleteDocument(object sender, DocumentEventArgs<Drawing> args);
        List<IEntity> GetListRelatedDocument<TO>();
    }
}