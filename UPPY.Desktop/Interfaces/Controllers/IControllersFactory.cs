using Core.Interfaces;

namespace UPPY.Desktop.Interfaces.Controllers
{
    /// <summary>
    /// Фабрика контроллеров
    /// </summary>
    public interface IControllersFactory
    {
        /// <summary>
        /// Получить контроллер для списка типа Т
        /// </summary>
        /// <typeparam name="T">Тип документа</typeparam>
        /// <returns></returns>
        IControllerList<T> GetControllerList<T>() where T : IEntity; 

        /// <summary>
        /// Получить контроллер для документа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IControllerDocument<T> GetControllerDocument<T>() where T : IEntity;

        /// <summary>
        /// Получить контроллер для документа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IControllerListView<T> GetControllerListView<T>() where T : IEntity; 

    }
}