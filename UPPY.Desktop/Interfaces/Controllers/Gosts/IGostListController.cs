﻿using System;
using System.Collections.Generic;
using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Gosts
{
    public interface IGostListController
    {
        List<Gost> GetGostsList();
        Gost CreateDocument();
        void Save(Gost document);
        void Delete(Gost document);
        event EventHandler<EventArgs> DataRefreshed;
        void EditDocumentInAnotherView(Gost gost);
    }
}