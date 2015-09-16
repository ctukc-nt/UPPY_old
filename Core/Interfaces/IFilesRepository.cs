using System.Collections.Generic;
using System.IO;
using Core.DomainModel;

namespace Core.Interfaces
{
    public interface IFilesRepository
    {
        List<UppyFileInfo> GetListFiels();

        UppyFileInfo PutFile(string path);

        /// <summary>
        /// Записать файл, заменив имя фала на параметр
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        UppyFileInfo PutFile(string path, string name);

        /// <summary>
        /// Получить файл из хранилища в поток
        /// </summary>
        /// <param name="fileInfo">>Инфо о файле в хранилище</param>
        /// <returns>Поток с содержимым файла</returns>
        Stream GetFile(UppyFileInfo fileInfo);

        /// <summary>
        /// Получить файл из хранилища и записать его во временные
        /// </summary>
        /// <param name="fileInfo">Инфо о файле в хранилище</param>
        /// <returns>Путь к временному файлу</returns>
        string GetFileToTemp(UppyFileInfo fileInfo);
    }
}