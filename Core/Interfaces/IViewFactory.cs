namespace Core.Interfaces
{
    /// <summary>
    /// Фабрика отображения данных
    /// </summary>
    public interface IViewFactory
    {
        IView GetViewDocument<T>();
        IView GetViewList<T>();
    }

    public interface IView
    {
        bool ShowView();
    }
}