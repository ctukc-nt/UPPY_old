using System.IO;
using System.ServiceModel;

namespace FileServer.Services
{
    [ServiceContract]
    public interface IFileRepositoryService
    {
        [OperationContract]
        Stream GetFile(string virtualPath);

        [OperationContract]
        void PutFile(FileUploadMessage msg);

        [OperationContract]
        void DeleteFile(string virtualPath);

        [OperationContract]
        StorageFileInfo[] List(string virtualPath);
    }
}