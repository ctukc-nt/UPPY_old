using System;

namespace DesktopApp.Interfaces
{
    public interface IDocForm<T>
    {
        IController<T> Controller { get; }

        event DocumentEventHandler<T> UpdateDocument;
        event DocumentEventHandler<T> DeleteDocument;
        event DocumentEventHandler<T> AddDocument;

        void RefreshSource(object sender, EventArgs e);
    }
}