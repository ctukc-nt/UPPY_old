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

        Stream GetFile(UppyFileInfo fileInfo);

        /// <summary>
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        string GetFileToTemp(UppyFileInfo fileInfo);
    }
}