using System;
using System.Collections.Generic;

namespace DesktopApp.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IController<T>
    {
        List<T> GetData(); 
        /// <summary>
        /// Эвент, что данные обновились
        /// </summary>
        event EventHandler SourceRefreshed;

        void AddDocument(object sender, DocumentEventArgs<Core.DomainModel.Drawing> args);
        void UpdateDocument(object sender, DocumentEventArgs<Core.DomainModel.Drawing> args);
        void DeleteDocument(object sender, DocumentEventArgs<Core.DomainModel.Drawing> args);
    }

    
}