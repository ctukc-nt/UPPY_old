namespace UPPY.DIE.Import.Siemens.Interfaces
{
    /// <summary>
    ///     Интрефес классов, которые могут возвращать файлы
    /// </summary>
    public interface IFilesNameGetter
    {
        /// <summary>
        ///     Директория поиска
        /// </summary>
        string LocationDirectory { get; set; }

        string GetFirstFilePath();
        string GetFileByNameDrawing(string name);
    }
}