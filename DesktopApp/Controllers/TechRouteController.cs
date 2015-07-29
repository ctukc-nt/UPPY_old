using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Interfaces;

namespace DesktopApp.Controllers
{
    class TechRouteController : IComplexController<TechRoute>
    {
        public List<TechRoute> GetData()
        {
            throw new NotImplementedException();
        }

        public event EventHandler DataRefreshed;
        public TechRoute CreateDocument()
        {
            throw new NotImplementedException();
        }

        public void SaveDocument(TechRoute doc)
        {
            throw new NotImplementedException();
        }

        public void DeleteDocument(TechRoute doc)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO : IEntity
        {
            throw new NotImplementedException();
        }

        public int CompareTwoDocuments(TechRoute doc1, TechRoute doc2)
        {
            throw new NotImplementedException();
        }

        public void ExternalAddDocument(TechRoute doc)
        {
            throw new NotImplementedException();
        }

        public void ExternalEditDocument(TechRoute doc)
        {
            throw new NotImplementedException();
        }

        public void ExternalDeleteDocument(TechRoute doc)
        {
            throw new NotImplementedException();
        }
    }
}
