using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Interfaces
{
    public interface IView<T>
    {
        T Document { get; set; }

        IControllerDocument<T> Controller { get; } 
    }
}