namespace UPPY.Desktop.Interfaces.Common
{
    /// <summary>
    /// ������ ����������
    /// </summary>
    public interface IMaterialParser
    {
        /// <summary>
        ///     �������� ������
        /// </summary>
        /// <returns></returns>
        int GetWidth(Position position);

        /// <summary>
        ///     �������� �����
        /// </summary>
        /// <returns></returns>
        int GetLength(Position position);

        /// <summary>
        ///     �������� ����� �����
        /// </summary>
        /// <returns></returns>
        string GetMarkSteal(Position position);

        /// <summary>
        ///     �������� ���� �� ���������
        /// </summary>
        /// <returns></returns>
        string GetGOSTS(Position position);

        /// <summary>
        ///     �������� ����������
        /// </summary>
        /// <returns></returns>
        string GetStandartSize(Position position);

        /// <summary>
        ///     �������� �����������
        /// </summary>
        /// <returns></returns>
        string GetDesignation(Position position);
    }
}