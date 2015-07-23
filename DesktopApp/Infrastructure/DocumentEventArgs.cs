namespace DesktopApp.Infrastructure
{
    public delegate void DocumentEventHandler<T>(object sender, DocumentEventArgs<T> args);

    public class DocumentEventArgs<T>
    {
        public T Document { get; set; }
    }
}