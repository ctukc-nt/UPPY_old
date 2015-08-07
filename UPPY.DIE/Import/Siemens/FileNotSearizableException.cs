using System.IO;

namespace UPPY.DIE.Import.Siemens
{
    internal class FileNotSearizableException : FileNotFoundException
    {
        public FileNotSearizableException(string drawingName, string path)
            : base(drawingName, path)
        {
        }
    }
}