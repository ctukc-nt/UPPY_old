namespace UPPY.Desktop.Interfaces.Common
{
    /// <summary>
    /// Персер материалов
    /// </summary>
    public interface IMaterialParser
    {
        /// <summary>
        ///     Получить шиирну
        /// </summary>
        /// <returns></returns>
        int GetWidth(Position position);

        /// <summary>
        ///     Поулчить длину
        /// </summary>
        /// <returns></returns>
        int GetLength(Position position);

        /// <summary>
        ///     Получить марку стали
        /// </summary>
        /// <returns></returns>
        string GetMarkSteal(Position position);

        /// <summary>
        ///     Получить ГОСТ на сортамент
        /// </summary>
        /// <returns></returns>
        string GetGOSTS(Position position);

        /// <summary>
        ///     Поулчить типоразмер
        /// </summary>
        /// <returns></returns>
        string GetStandartSize(Position position);

        /// <summary>
        ///     Получить обозначение
        /// </summary>
        /// <returns></returns>
        string GetDesignation(Position position);
    }
}