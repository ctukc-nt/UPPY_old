namespace UPPY.DIE.Import.Siemens
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