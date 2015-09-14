using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.Controllers.TechOpers;
using UPPY.Desktop.Views.TechOpers;

namespace UPPY.Desktop.Concrete.Controllers.TechOpers
{
    public class TechOpersListController : ITechOpersListController, IListViewController
    {
        private readonly IClassDataManager<TechOperation> _techOpersDataManager;

        public TechOpersListController(IClassDataManager<TechOperation> techOpersDataManager)
        {
            _techOpersDataManager = techOpersDataManager;
        }

        public List<TechOperation> GetTechOperationsList()
        {
            return _techOpersDataManager.GetListCollection();
        }

        public TechOperation CreateDocument()
        {
            return new TechOperation();
        }

        public void Save(TechOperation document)
        {
            _techOpersDataManager.InsertOrUpdate(document);
        }

        public void Delete(TechOperation doc)
        {
            _techOpersDataManager.Delete(doc);
        }

        public void ShowViewDialog()
        {
            TechOpersListForm form = new TechOpersListForm(this);
            form.ShowDialog();
        }
    }
}