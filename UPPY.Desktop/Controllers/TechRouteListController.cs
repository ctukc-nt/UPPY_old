using System;
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
        private readonly IControllersFactory _controllersFactory;
        private readonly IDataManagersFactory _dataMangersfactory;

        public TechRouteListController(IControllersFactory controllersControllersFactory, IDataManagersFactory dataMangersfactory)
        {
            _controllersFactory = controllersControllersFactory;
            _dataMangersfactory = dataMangersfactory;
        }

        public event EventHandler<EventArgs> DataRefreshed;

        public IClassDataManager<TechRoute> DataManager { get; set; }

        public List<TO> GetData<TO>() where TO : IEntity
        {
            return _dataMangersfactory.GetDataManager<TO>().GetListCollection();
        }


        public List<TechRoute> GetData()
        {
            return _dataMangersfactory.GetDataManager<TechRoute>().GetListCollection();
        }

        public TechRoute CreateDocument()
        {
            return new TechRoute();
        }

        public void Save(TechRoute document)
        {
            _dataMangersfactory.GetDataManager<TechRoute>().InsertOrUpdate(document);
        }

        public void Delete(TechRoute document)
        {
            _dataMangersfactory.GetDataManager<TechRoute>().Delete(document);
        }

        public void EditExternal(TechRoute document)
        {
            var controller = _controllersFactory.GetControllerDocument<TechRoute>();
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
            var controller = _controllersFactory.GetControllerListView<TO>();
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