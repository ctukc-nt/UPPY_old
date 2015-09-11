using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Standarts
{
    public interface IStandartsListController
    {
        List<Standart> GetStandartsList();
        Standart CreateDocument();
        void Save(Standart document);
    }
}