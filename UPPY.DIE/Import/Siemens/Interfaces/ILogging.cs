namespace UPPY.DIE.Import.Siemens.Interfaces
{
    /// <summary>
    /// ��������� ������ ������������
    /// </summary>
    public interface ILogging
    {
        /// <summary>
        /// �������� ��������� � ���
        /// </summary>
        /// <param name="message"></param>
        void AppendMessage(string message);

        void Clear();
    }
}