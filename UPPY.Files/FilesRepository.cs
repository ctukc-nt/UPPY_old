using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using FileServer.Services;

namespace UPPY.Files
{
    public class FilesRepository : IFilesRepository
    {
        public FilesRepository()
        {

        }

        public List<UppyFileInfo> GetListFiels()
        {
            var listFiles = new List<UppyFileInfo>();

            using (var client = new FileRepositoryServiceClient())
            {
                var files = client.List(null);
                listFiles.AddRange(files.Select(storageFileInfo => new UppyFileInfo() { FileName = storageFileInfo.VirtualPath }));
            }

            return listFiles;
        }

        private UppyFileInfo PutFile(Stream stream, string fileName)
        {
            using (FileRepositoryServiceClient client = new FileRepositoryServiceClient())
            {
                var file = client.List().FirstOrDefault(x => x.VirtualPath == fileName);
                if (file == null)
                    client.PutFile(new FileUploadMessage() { DataStream = stream, VirtualPath = fileName });
            }

            UppyFileInfo uppyFileInfo = new UppyFileInfo();
            uppyFileInfo.FileName = fileName;

            return uppyFileInfo;
        }

        public UppyFileInfo PutFile(string path)
        {
            UppyFileInfo uppyInf;

            using (Stream stream = File.OpenRead(path))
            {
                uppyInf = PutFile(stream, Path.GetFileName(path));
            }

            return uppyInf;
        }

        public UppyFileInfo PutFile(string path, string name)
        {
            UppyFileInfo uppyInf;

            using (Stream stream = File.OpenRead(path))
            {
                uppyInf = PutFile(stream, name + Path.GetExtension(path));
            }

            return uppyInf;
        }

        public Stream GetFile(UppyFileInfo fileInfo)
        {
            using (var client = new FileRepositoryServiceClient())
            {
                return client.GetFile(fileInfo.FileName);
            }
        }

        public string GetFileToTemp(UppyFileInfo fileInfo)
        {
            using (var client = new FileRepositoryServiceClient())
            {
                var stream = client.GetFile(fileInfo.FileName);
                var pathFileSave = Path.Combine(Path.GetTempPath(), "UPPY" + Environment.TickCount + fileInfo.FileName);
                var writeFile = File.OpenWrite(pathFileSave);
                stream.CopyTo(writeFile);
                writeFile.Flush();
                writeFile.Close();

                return pathFileSave;
            }
        }
    }
}
