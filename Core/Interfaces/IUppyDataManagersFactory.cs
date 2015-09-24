using Core.DomainModel;

namespace Core.Interfaces
{
    /// <summary>
    ///     Интерфейс базы данных УППИ
    /// </summary>
    public interface IUppyDataManagersFactory : IDataManagersFactory
    {
        IClassDataManager<Drawing> GetFilteredDrawingsByParent(int? parentId);

        IHierClassDataManager<Drawing> GetDrawingsHierClassDataManager();
    }
}