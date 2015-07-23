namespace DesktopApp.Interfaces
{
    public delegate void DocumentEventHandler<T>(object sender, DocumentEventArgs<T> args);

    public class DocumentEventArgs<T>
    {
        T Document { get; set; }
    }
}