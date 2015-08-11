using System;
using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Views;

namespace UPPY.Desktop.Controllers.Drawings
{
    public class DrawingsSelectionController :IDrawingsSelectionController, ISelectionController<Drawing>
    {
        private readonly IDataManagersFactory _dataManagersFactory;
        private readonly IControllersFactory _controllersFactory;

        public DrawingsSelectionController(IDataManagersFactory dataManagersFactory, IControllersFactory controllersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
            _controllersFactory = controllersFactory;
        }

        public Drawing ShowViewToSelectOneDialog()
        {
            var selectionForm = new DrawingsSelectionForm(this);
            selectionForm.ShowDialog();
            return selectionForm.SelectedDocuments[0];
        }

        public List<Drawing> ShowViewToSelectManyDialog()
        {
            var selectionForm = new DrawingsSelectionForm(this, true);
            selectionForm.ShowDialog();
            return selectionForm.SelectedDocuments;
        }

        public List<Drawing> GetDrawingsList()
        {
            return _dataManagersFactory.GetDataManager<Drawing>().GetListCollection();
        }

        public List<TechRoute> GetTechRoutes()
        {
            return _dataManagersFactory.GetDataManager<TechRoute>().GetListCollection();
        }

        public event EventHandler<EventArgs> DataRefreshed;
    }
}