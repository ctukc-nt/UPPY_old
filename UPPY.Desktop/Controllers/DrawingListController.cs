using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    public class DrawingListController : IDrawingListController
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

        public void ShowTechRoutesListToSelect()
        {
            throw new NotImplementedException();
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

        public List<TechRoute> GetTechRoutes()
        {
            return _techRouteDataManager.GetListCollection();
        }

        public bool ShowView()
        {
            var view = new DrawingsListTreeForm(this);
            return view.ShowDialog() == DialogResult.OK;
        }
    }
}