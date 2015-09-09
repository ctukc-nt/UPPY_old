using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Common
{
    /// <summary>
    /// Исключение проектов из загружаемых
    /// </summary>
    public interface IProjectExcluder
    {
        bool IsNeedExclude(Drawing project);
        bool IsNeedExclude(Position project);
    }
}