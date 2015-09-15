using System.Collections.Generic;
using System.IO;
using Core.DomainModel;

namespace Core.Interfaces
{
    public interface IFilesRepository
    {
        List<UppyFileInfo> GetListFiels();
        //UppyFileInfo PutFile(Stream stream);

        UppyFileInfo PutFile(string path);

        /// <summary>
        /// Записать файл, заменив имя фала на параметр
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        UppyFileInfo PutFile(string path, string name);

        Stream GetFile(UppyFileInfo fileInfo);

        /// <summary>
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        string GetFileToTemp(UppyFileInfo fileInfo);
    }
}