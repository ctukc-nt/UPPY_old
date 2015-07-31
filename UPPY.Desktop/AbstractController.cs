using System.Collections.Generic;
using Core.Interfaces;
using UPPY.Desktop.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop
{
    //public abstract class AbstractController : IBaseController<IEntity>
    //{
    //    private readonly IControllersFactory _controllersFactory;
    //    private IDataManagersFactory _dataManagersFactory;


    //    protected AbstractController(IControllersFactory controllersFactory, IDataManagersFactory dataManagersFactory)
    //    {
    //        _controllersFactory = controllersFactory;
    //        _dataManagersFactory = dataManagersFactory;
    //    }

    //    public List<TO> GetListRelatedDocument<TO>() where TO : IEntity
    //    {
    //        return _dataManagersFactory.GetDataManager<TO>().GetListCollection();
    //    }

    //    public void ShowAnotherListDocument<TO>() where TO : IEntity
    //    {
    //        var controller = _controllersFactory.GetControllerListView<TO>();
    //        controller.ShowView();
    //    }


    //}
}