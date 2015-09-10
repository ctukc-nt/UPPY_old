namespace UPPY.DIE.Import.Siemens.Interfaces
{
    /// <summary>
    /// ��������� ������ ������������
    /// </summary>
    public interface ILogging
    {

        bool ErrorHappens { get; }

        /// <summary>
        /// �������� ��������� � ���
        /// </summary>
        /// <param name="message"></param>
        void AppendMessage(string message);

        void Clear();
    }
}