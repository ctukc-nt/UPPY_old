namespace Core.Interfaces
{
    /// <summary>
    /// Фабрика управленцев данными
    /// </summary>
    public interface IDataManagersFactory
    {
        /// <summary>
        /// Получить управленца данными
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <returns>Управленец данными</returns>
        IClassDataManager<T> GetDataManager<T>() where T : IEntity;
    }
}