namespace UPPY.Desktop.Interfaces.Common
{
    /// <summary>
    /// Поиск наименования материалов
    /// </summary>
    public interface INameMaterialSearch
    {
        /// <summary>
        ///  Поиск наименования по номеру ГОСТа
        /// </summary>
        /// <param name="gost">ГОСТ</param>
        /// <returns>Наименование</returns>
        string GetNameMaterialByGost(string gost);
    }
}