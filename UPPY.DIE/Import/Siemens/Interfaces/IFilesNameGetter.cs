namespace UPPY.DIE.Import.Siemens.Interfaces
{
    /// <summary>
    ///     �������� �������, ������� ����� ���������� �����
    /// </summary>
    public interface IFilesNameGetter
    {
        /// <summary>
        ///     ���������� ������
        /// </summary>
        string LocationDirectory { get; set; }

        string GetFirstFilePath();
        string GetFileByNameDrawing(string name);
    }
}