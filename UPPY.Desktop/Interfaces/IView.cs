using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers;

namespace UPPY.Desktop.Interfaces
{
    public interface IView<T> where T : IEntity
    {
        T Document { get; set; }

        IControllerDocument<T> Controller { get; } 
    }
}