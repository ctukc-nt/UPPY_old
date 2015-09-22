using System.Collections.Generic;

namespace Utils.Common
{
    /// <summary>
    /// ��������� ������ ������������
    /// </summary>
    public interface ILogging
    {
        /// <summary>
        /// ��������� ������
        /// </summary>
        bool ErrorHappens { get; }

        IEnumerable<LogMessage> Messages { get; } 

        /// <summary>
        /// �������� ��������� � ���
        /// </summary>
        /// <param name="message"></param>
        void AppendMessage(string message);

        /// <summary>
        /// �������� ��������� � ���
        /// </summary>
        /// <param name="message"></param>
        /// <param name="typeMessage"></param>
        void AppendMessage(string message, TypeMessage typeMessage);

        /// <summary>
        /// �������� ��������� � ��� � ��������� � ���� ������
        /// </summary>
        /// <param name="message"></param>
        /// <param name="obj"></param>
        void AppendMessage(string message, object obj);

        /// <summary>
        /// �������� ��������� � ��� � ��������� � ���� ������
        /// </summary>
        /// <param name="message"></param>
        /// <param name="obj"></param>
        /// <param name="typeMessage"></param>
        void AppendMessage(string message, object obj, TypeMessage typeMessage);

        void Clear();
    }
}