using System.IO;
using System.ServiceModel;

namespace FileServer.Services
{
    [MessageContract]
    public class FileUploadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string VirtualPath { get; set; }

        [MessageBodyMember(Order = 1)]
        public Stream DataStream { get; set; }
    }
}