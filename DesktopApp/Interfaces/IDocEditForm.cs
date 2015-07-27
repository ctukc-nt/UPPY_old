using DesktopApp.Infrastructure;

namespace DesktopApp.Interfaces
{
    public interface IDocEditForm<T>
    {
        T Document { get; }
        event DocumentEventHandler<T> UpdateDocument;
    }
}