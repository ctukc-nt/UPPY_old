using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.TechRoutes;
using UPPY.Desktop.Views.TechRoutes;

namespace UPPY.Desktop.Concrete.Controllers.TechRoutes
{
    public class TechRouteListController : ITechRouteListController, IListViewController
    {
        private readonly IClassDataManager<TechRoute> _techRouteDataManager;
        private readonly IControllersFactory _controllersFactory;

        public TechRouteListController(IControllersFactory controllersControllersFactory, IClassDataManager<TechRoute> techRouteDataManager )
        {
            _controllersFactory = controllersControllersFactory;
            _techRouteDataManager = techRouteDataManager;
        }

        public event EventHandler<EventArgs> DataRefreshed;


        public List<TechRoute> GetData()
        {
            return _techRouteDataManager.GetListCollection();
        }

        public TechRoute CreateDocument()
        {
            return new TechRoute();
        }

        public void Save(TechRoute document)
        {
            _techRouteDataManager.InsertOrUpdate(document);
        }

        public void Delete(TechRoute document)
        {
            _techRouteDataManager.Delete(document);
        }

        public void EditDocument(TechRoute document)
        {
            var controller = _controllersFactory.GetDocumentController<TechRoute>();
            controller.Document = document;
            controller.ShowViewDialog();
        }
        public void ShowViewDialog()
        {
            var view = new TechRoutesListForm(this);
            view.ShowDialog();
        }
    }
}