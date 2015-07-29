using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces
{
    public interface IControllerList<T>
    {
        event EventHandler<EventArgs> DataRefreshed;
        List<T> GetListRelatedDocument<T>();
        T GetData();
        T CreateDocument();
        void Save(T document);
        void Delete(T document);

        void EditExternal(T document);
    }

    public interface IControllerListView<T> : IControllerList<T>
    {
        void ShowView();
    }
}