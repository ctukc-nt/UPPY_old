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

    public class LogMessage
    {
        public TypeMessage Type { get; set; }

        public string Message { get; set; }

        public object Tag { get; set; }

        public LogMessage()
        {
            Type = TypeMessage.Information;
            Tag = null;
            Message = string.Empty;
        }

        public LogMessage(string message):this()
        {
            Message = message;
        }

        public LogMessage(string message, TypeMessage type) : this()
        {
            Message = message;
            Type = type;
        }

        public LogMessage(string message, object tag) : this()
        {
            Message = message;
            Tag = tag;
        }

        public LogMessage(string message, object tag, TypeMessage type ) : this()
        {
            Message = message;
            Type = type;
            Tag = tag;
        }

        public LogMessage(object tag) : this()
        {
            Tag = tag;
        }

        public LogMessage(object tag, TypeMessage type) : this()
        {
            Type = type;
            Tag = tag;
        }

    }

    public enum TypeMessage
    {
        Warning,
        Error,
        Information
    }
}