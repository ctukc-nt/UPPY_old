using System.Collections.Generic;

namespace UPPY.Desktop.Interfaces.Controllers
{
    public interface IUppyControllersFactory : IControllersFactory
    {

    }


    public interface IControllersFactory
    {
        /// <summary>
        /// Получить контроллер, отображающий список
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IListDocumentController GetListController<T>();

        /// <summary>
        /// Получить контроллер редактирования документа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IDocumentController<T> GetDocumentController<T>();

        /// <summary>
        /// Получить контроллер выбора документа из списка
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        ISelectionController<T> GetDocumentSelectionController<T>();

        IListDocumentController GetStartController();
    }

    /// <summary>
    /// Контроллер может редактировать документ
    /// </summary>
    public interface IDocumentController<T>
    {
        T Document { get; set; }

        bool ShowViewDialog();
    }

    /// <summary>
    /// Контроллер может показывать список и выбирать документ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISelectionController<T>
    {
        T ShowViewToSelectOneDialog();

        List<T> ShowViewToSelectManyDialog();
    }

    /// <summary>
    /// Контроллер может показывать список документов
    /// </summary>
    public interface IListDocumentController
    {
        void ShowViewDialog();
    }
}