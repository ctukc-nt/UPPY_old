using System;
using System.Collections.Generic;
using Core.DomainModel;
using UPPY.Desktop.Interfaces;

namespace UPPY.Desktop.Controllers
{
    public class TechRouteController : IControllerList<TechRoute>
    {
        public event EventHandler<EventArgs> DataRefreshed;
        public List<T> GetListRelatedDocument<T>()
        {
            throw new NotImplementedException();
        }

        public TechRoute GetData()
        {
            throw new NotImplementedException();
        }

        public TechRoute CreateDocument()
        {
            throw new NotImplementedException();
        }

        public void Save(TechRoute document)
        {
            throw new NotImplementedException();
        }

        public void Delete(TechRoute document)
        {
            throw new NotImplementedException();
        }

        public void EditExternal(TechRoute document)
        {
            throw new NotImplementedException();
        }
    }
}