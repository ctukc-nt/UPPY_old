using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Factorys
{
    public class ViewFactory: IViewFactory
    {
        public IView GetViewDocument<T>()
        {
            throw new System.NotImplementedException();
        }

        public IView GetViewList<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}