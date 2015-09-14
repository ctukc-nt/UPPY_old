using System;
using System.Collections.Generic;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Gosts;

namespace UPPY.Desktop.Concrete.Controllers.Gosts
{
    public class GostListController : IGostListController
    {
        public List<Gost> GetGostList()
        {
            throw new NotImplementedException();
        }

        public Gost CreateDocument()
        {
            throw new NotImplementedException();
        }

        public void Save(Gost document)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gost document)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> DataRefreshed;
        public void ShowGostInAnotherView(Gost gost)
        {
            throw new NotImplementedException();
        }
    }
}