using Core.Interfaces;

namespace DesktopApp.Interfaces
{
    public interface IDocsListForm<T> where T : IEntity
    {
        IController<T> Controller { get; }
    }
}