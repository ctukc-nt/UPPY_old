using System;
using UPPY.Desktop.Interfaces;

namespace UPPY.Desktop.Factorys
{
    internal class ControllersesFactory : IControllersFactory
    {
        public IViewListDocumentController GetListController<T>()
        {
            throw new NotImplementedException();
        }

        public IViewDocumentController<T> GetDocumentController<T>()
        {
            throw new NotImplementedException();
        }

        public ISelectionViewController<T> GetDocumentSelectionController<T>()
        {
            throw new NotImplementedException();
        }
    }
}