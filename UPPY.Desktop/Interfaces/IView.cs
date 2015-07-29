namespace UPPY.Desktop.Interfaces
{
    public interface IView<T>
    {
        T Document { get; set; }
    }

    public interface IListView<T>
    {
        T SelectedDocument { get; set; }
    }
}