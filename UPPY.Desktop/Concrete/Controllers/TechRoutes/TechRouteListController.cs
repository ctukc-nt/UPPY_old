using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;
using UPPY.Desktop.Views.TechRoutes;

namespace UPPY.Desktop.Concrete.Controllers.TechRoutes
{
    public class TechRouteListController : ITechRouteListController, IListDocumentController
    {
        private readonly IDataManagersFactory _dataMangersfactory;
        private IControllersFactory _controllersFactory;

        public TechRouteListController(IDataManagersFactory dataMangersfactory, IControllersFactory controllersControllersFactory)
        {
            _controllersFactory = controllersControllersFactory;
            _dataMangersfactory = dataMangersfactory;
        }

        public event EventHandler<EventArgs> DataRefreshed;


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

        public void EditDocument(TechRoute document)
        {
            var controller = _controllersFactory.GetDocumentController<TechRoute>();
            controller.Document = document;
            controller.ShowViewDialog();
            //if ()
            //{
            //    document = controller.Document;
            //    Save(document);
            //    if (DataRefreshed != null)
            //        DataRefreshed(this, new EventArgs());
            //}
        }
        public void ShowViewDialog()
        {
            var view = new TechRoutesListForm(this);
            view.ShowDialog();
        }
    }
}