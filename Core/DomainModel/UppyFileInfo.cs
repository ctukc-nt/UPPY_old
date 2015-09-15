using System.IO;

namespace Core.DomainModel
{
    public class UppyFileInfo
    {
        public string FileName { get; set; }

        public string Extension
        {
            get { return Path.GetExtension(FileName); } 
        }
    }
}