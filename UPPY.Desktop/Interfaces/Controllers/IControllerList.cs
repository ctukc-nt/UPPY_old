using System;
using System.Collections.Generic;
using Core.Interfaces;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IBaseController<T> where T : IEntity
    {
        IClassDataManager<T> DataManager { get; set; }

        List<TO> GetData<TO>() where TO : IEntity;
    }

    public interface IControllerList<T> : IBaseController<T> where T : IEntity
    {
        event EventHandler<EventArgs> DataRefreshed;
        List<T> GetData();

        T CreateDocument();
        void Save(T document);
        void Delete(T document);
        void EditDocument(T document);
    }
}