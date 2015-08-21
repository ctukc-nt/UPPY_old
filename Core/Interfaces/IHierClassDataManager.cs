using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IHierClassDataManager<T> : IClassDataManager<T> where T : IEntity
    {
        List<T> GetListDocsInHierarchy(int? id);

        List<T> GetListAllChildrens(int? id);
    }
}