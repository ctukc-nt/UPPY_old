using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers.Drawings
{
    public class DrawingsListDocumentController : IDrawingListController, IListDocumentController
    {
        private readonly IControllersFactory _controllersFactory;
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;

        public DrawingsListDocumentController(IDataManagersFactory dataManagersFactory,
            IControllersFactory controllersFactory)
        {
            _controllersFactory = controllersFactory;
            var dataManagerFactory1 = dataManagersFactory;
            _drawingsDataManager = dataManagerFactory1.GetDataManager<Drawing>();
            _techRouteDataManager = dataManagerFactory1.GetDataManager<TechRoute>();
        }

        public List<Drawing> GetDrawingsList()
        {
            return _drawingsDataManager.GetListCollection();
        }

        public void ShowTechRoutesList()
        {
            var c = _controllersFactory.GetListController<TechRoute>();
            c.ShowViewDialog();
        }

        public void CreateStandartByDrawing()
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

        public void ShowViewDialog()
        {
            var view = new DrawingsListTreeForm(this);
            view.ShowDialog();
        }
    }
}