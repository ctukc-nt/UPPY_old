namespace UPPY.DIE.Import.Siemens
{
    /// <summary>
    /// Интерфейс класса логгирования
    /// </summary>
    public interface ILogging
    {
        /// <summary>
        /// Добавить сообщение в лог
        /// </summary>
        /// <param name="message"></param>
        void AppendMessage(string message);

        void Clear();
    }
}