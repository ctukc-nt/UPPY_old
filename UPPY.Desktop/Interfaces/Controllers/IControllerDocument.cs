using System.Collections.Generic;

namespace UPPY.Desktop.Interfaces
{
    public interface IControllerDocument<T> : IBaseController
    {
        T Document { get; set; }
        void ShowEditor();
    }
}