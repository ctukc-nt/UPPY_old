﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
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

            if (controller.ShowEditor())
            {
                Save(controller.Document);
                if (DataRefreshed != null)
                    DataRefreshed(this, new EventArgs());
            }
        }

        public void ShowAnotherListDocument<TO>() where TO : IEntity
        {
            var controller = _factory.GetControllerListView<TechRoute>();
            controller.ShowView();
        }

        public bool ShowView()
        {
            var view = new TechRoutesListForm(this);
            if (view.ShowDialog() == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
    }
}