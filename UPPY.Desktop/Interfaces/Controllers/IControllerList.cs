using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Interfaces
{
    public interface IBaseController
    {
        List<TO> GetListRelatedDocument<TO>() where TO : IEntity;
        void ShowAnotherListDocument<TO>() where TO:IEntity;
    }

    public interface IControllerList<T> : IBaseController where T : IEntity
    {
        event EventHandler<EventArgs> DataRefreshed;
        List<T> GetData();
        T CreateDocument();
        void Save(T document);
        void Delete(T document);

        void EditExternal(T document);
    }
}