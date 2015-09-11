using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.Standarts;
using UPPY.Desktop.Views.Standarts;

namespace UPPY.Desktop.Concrete.Controllers.Standarts
{
    public class StandartsListController : IStandartsListController, IListViewController
    {
        private readonly IUppyControllersFactory _factory;
        private readonly IClassDataManager<Standart> _standartDataManager;

        public StandartsListController(IUppyControllersFactory factory, IClassDataManager<Standart> standartDataManager)
        {
            _factory = factory;
            _standartDataManager = standartDataManager;
        }

        public void ShowViewDialog()
        {
            StandartsListForm form = new StandartsListForm(this);
            form.ShowDialog();
        }

        public List<Standart> GetStandartsList()
        {
            return _standartDataManager.GetListCollection();
        }

        public Standart CreateDocument()
        {
            return new Standart();
        }

        public void Save(Standart document)
        {
            _standartDataManager.InsertOrUpdate(document);
        }
    }
}