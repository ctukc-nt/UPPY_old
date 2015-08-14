using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views.Drawings;

namespace UPPY.Desktop.Concrete.Controllers.Drawings
{
    public class FilteredDrawingsListController : IDrawingListController, IListDocumentController
    {
        private readonly List<Drawing> _data;
        private readonly IDataManagersFactory _dataManagersFactory;
        private readonly IControllersFactory _controllersFactory;

        public FilteredDrawingsListController(List<Drawing> data, IDataManagersFactory dataManagersFactory, IControllersFactory controllersFactory)
        {
            _data = data;
            _dataManagersFactory = dataManagersFactory;
            _controllersFactory = controllersFactory;
        }

        public List<Drawing> GetDrawingsList()
        {
            return _data;
        }

        public Drawing CreateDocument()
        {
             return new Drawing();
        }

        public void Save(Drawing document)
        {
            _dataManagersFactory.GetDataManager<Drawing>().InsertOrUpdate(document);
        }

        public void Delete(Drawing document)
        {
            _dataManagersFactory.GetDataManager<Drawing>().Delete(document);
            _data.Remove(document);
        }

        public List<TechRoute> GetTechRoutes()
        {
            return _dataManagersFactory.GetDataManager<TechRoute>().GetListCollection();
        }

        public void ShowTechRoutesList()
        {
            var c = _controllersFactory.GetListController<TechRoute>();
            c.ShowViewDialog();
        }

        public void CreateStandartByDrawing()
        {
            throw new NotImplementedException();throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> DataRefreshed;
        public void ShowViewDialog()
        {
            var view = new DrawingsListTreeForm(this);
            view.ShowDialog();
        }
    }
}