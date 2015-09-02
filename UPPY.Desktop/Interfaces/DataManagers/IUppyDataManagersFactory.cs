using Core.DomainModel;
using Core.Interfaces;

namespace UPPY.Desktop.Interfaces.DataManagers
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