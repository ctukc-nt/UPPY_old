using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.TechOpers;

namespace UPPY.Desktop.Concrete.Controllers.TechOpers
{
    public class TechOpersListController : ITechOpersListController
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
    }
}