namespace UPPY.Desktop.Interfaces
{
    public interface IListView<T>
    {
        T SelectedDocument { get; set; }
    }
}