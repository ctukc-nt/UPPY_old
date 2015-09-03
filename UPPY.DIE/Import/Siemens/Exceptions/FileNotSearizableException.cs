using System.IO;

namespace UPPY.DIE.Import.Siemens.Exceptions
{
    internal class FileNotSearizableException : FileNotFoundException
    {
        public FileNotSearizableException(string drawingName, string path)
            : base(drawingName, path)
        {
        }
    }
}