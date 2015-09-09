namespace UPPY.Desktop.Interfaces.Common
{
    /// <summary>
    /// ����� ������������ ����������
    /// </summary>
    public interface INameMaterialSearch
    {
        /// <summary>
        ///  ����� ������������ �� ������ �����
        /// </summary>
        /// <param name="gost">����</param>
        /// <returns>������������</returns>
        string GetNameMaterialByGost(string gost);
    }
}