namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IControllerDocument<T> : IBaseController
    {
        T Document { get; set; }
        bool ShowEditor();
    }
}