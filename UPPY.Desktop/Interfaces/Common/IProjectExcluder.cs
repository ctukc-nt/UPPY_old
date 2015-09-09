using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Common
{
    /// <summary>
    /// ���������� �������� �� �����������
    /// </summary>
    public interface IProjectExcluder
    {
        bool IsNeedExclude(Drawing project);
        bool IsNeedExclude(Position project);
    }
}