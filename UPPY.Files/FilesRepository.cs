using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

            using (FileRepositoryServiceClient client = new FileRepositoryServiceClient())
            {
                var files = client.List(null);
                foreach (var storageFileInfo in files)
                {
                    listFiles.Add(new UppyFileInfo() { Hash = storageFileInfo.VirtualPath.Remove(storageFileInfo.VirtualPath.LastIndexOf(".", StringComparison.Ordinal)), Extension = storageFileInfo.VirtualPath.Remove(0, storageFileInfo.VirtualPath.LastIndexOf(".", StringComparison.Ordinal)) });
                }
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
            uppyFileInfo.Hash = fileName;

            return uppyFileInfo;
        }

        public UppyFileInfo PutFile(string path)
        {
            UppyFileInfo uppyInf;

            using (Stream stream = File.OpenRead(path))
            {
                MD5 md5 = MD5.Create();
                var bytes = md5.ComputeHash(stream);
                stream.Position = 0;
                var base64Hash = Convert.ToBase64String(bytes);
                uppyInf = PutFile(stream, base64Hash + Path.GetExtension(path));
            }

            uppyInf.Extension = Path.GetExtension(path);

            return uppyInf;
        }

        public Stream GetFile(UppyFileInfo fileInfo)
        {
            throw new NotImplementedException();
        }

        public string GetFileToTemp(UppyFileInfo fileInfo)
        {
            throw new NotImplementedException();
        }
    }
}
