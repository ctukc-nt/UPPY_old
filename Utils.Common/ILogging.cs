using System.Collections.Generic;

namespace Utils.Common
{
    /// <summary>
    /// Интерфейс класса логгирования
    /// </summary>
    public interface ILogging
    {
        /// <summary>
        /// Произошли ошибки
        /// </summary>
        bool ErrorHappens { get; }

        IEnumerable<LogMessage> Messages { get; } 

        /// <summary>
        /// Добавить сообщение в лог
        /// </summary>
        /// <param name="message"></param>
        void AppendMessage(string message);

        /// <summary>
        /// Добавить сообщение в лог
        /// </summary>
        /// <param name="message"></param>
        /// <param name="typeMessage"></param>
        void AppendMessage(string message, TypeMessage typeMessage);

        /// <summary>
        /// Добавить сообщение в лог и прицепить к нему объект
        /// </summary>
        /// <param name="message"></param>
        /// <param name="obj"></param>
        void AppendMessage(string message, object obj);

        /// <summary>
        /// Добавить сообщение в лог и прицепить к нему объект
        /// </summary>
        /// <param name="message"></param>
        /// <param name="obj"></param>
        /// <param name="typeMessage"></param>
        void AppendMessage(string message, object obj, TypeMessage typeMessage);

        void Clear();
    }
}