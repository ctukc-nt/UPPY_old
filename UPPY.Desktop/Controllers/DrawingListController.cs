using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    public class DrawingListController : IControllerListView<Drawing>
    {
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public DrawingListController(IDataManagersFactory dataManagersFactory)
        {
            var dataManagerFactory1 = dataManagersFactory;
            _drawingsDataManager = dataManagerFactory1.GetDataManager<Drawing>();
            _techRouteDataManager = dataManagerFactory1.GetDataManager<TechRoute>();
        }

        public List<Drawing> GetData()
        {
            return _drawingsDataManager.GetListCollection();
        }

        public event EventHandler<EventArgs> DataRefreshed;

        public Drawing CreateDocument()
        {
           return new Drawing();
        }

        public void Save(Drawing document)
        {
            _drawingsDataManager.InsertOrUpdate(document);
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public void Delete(Drawing document)
        {
            _drawingsDataManager.Delete(document);
            if (DataRefreshed != null)
                DataRefreshed(this, new EventArgs());
        }

        public void EditDocument(Drawing document)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetListRelatedDocument<TO>() where TO:IEntity
        {
            if (typeof (TO) == typeof (TechRoute))
            {
                return _techRouteDataManager.GetListCollection().ConvertAll(input => (IEntity) input);
            }

            return null;
        }

        public int CompareTwoDocuments(Drawing doc1, Drawing doc2)
        {
            throw new NotImplementedException();
        }

        public IClassDataManager<Drawing> DataManager
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public List<TO> GetData<TO>() where TO : IEntity
        {
            throw new NotImplementedException();
        }

        public bool ShowView()
        {
            var view = new DrawingsListTreeForm(this);
            return view.ShowDialog() == DialogResult.OK;
        }
    }
}