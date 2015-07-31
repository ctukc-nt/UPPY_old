using Core.Interfaces;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IControllerDocument<T> : IBaseController<T> where T : IEntity
    {
        T Document { get; set; }
        bool ShowEditor();
    }
}