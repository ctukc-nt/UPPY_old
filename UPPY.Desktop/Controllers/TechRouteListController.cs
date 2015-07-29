using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers
{
    public class TechRouteListController : IControllerListView<TechRoute>
    {
        private readonly IControllersFactory _factory;
        private readonly IDataManagersFactory _dataManagersFactory;

        public TechRouteListController(IControllersFactory controllersFactory, IDataManagersFactory dataManagersFactory)
        {
            _factory = controllersFactory;
            _dataManagersFactory = dataManagersFactory;
        }

        public event EventHandler<EventArgs> DataRefreshed;
        public List<T> GetListRelatedDocument<T>() where T : IEntity
        {
            return _dataManagersFactory.GetDataManager<T>().GetListCollection();
        }

        public List<TechRoute> GetData()
        {
            return _dataManagersFactory.GetDataManager<TechRoute>().GetListCollection();
        }

        public TechRoute CreateDocument()
        {
            return new TechRoute();
        }

        public void Save(TechRoute document)
        {
            _dataManagersFactory.GetDataManager<TechRoute>().InsertOrUpdate(document);
        }

        public void Delete(TechRoute document)
        {
            _dataManagersFactory.GetDataManager<TechRoute>().Delete(document);
        }

        public void EditExternal(TechRoute document)
        {
            var controller = _factory.GetControllerDocument<TechRoute>();
            controller.Document = document;

            controller.ShowEditor();
        }

        public void ShowAnotherListDocument<TO>() where TO : IEntity
        {
            var controller = _factory.GetControllerListView<TechRoute>();
            controller.ShowView();
        }

        public void ShowView()
        {
            var view = new TechRoutesListForm(this);
            view.ShowDialog();
        }
    }
}