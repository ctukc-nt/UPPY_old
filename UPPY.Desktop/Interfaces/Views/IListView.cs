namespace UPPY.Desktop.Interfaces.Views
{
    public interface IListView<T>
    {
        T SelectedDocument { get; set; }
    }
}