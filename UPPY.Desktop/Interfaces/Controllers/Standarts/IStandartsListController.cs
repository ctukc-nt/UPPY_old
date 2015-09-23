using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Standarts
{
    public interface IStandartsListController
    {
        event EventHandler<EventArgs> DataRefreshed;
        List<Standart> GetStandartsList();
        Standart CreateDocument();
        void Save(Standart document);
        void EditDocumentInAnotherWindow(Standart doc);
        void Delete(Standart doc);
    }
}