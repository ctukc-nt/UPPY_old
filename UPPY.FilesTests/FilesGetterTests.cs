using NUnit.Framework;
using UPPY.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPPY.Files.Tests
{
    [TestFixture()]
    public class FilesGetterTests
    {
        [Test()]
        public void PutFileTest()
        {
            FilesRepository repository = new FilesRepository();
            var filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";
            var file = File.Create(filePath);
            file.Write(new byte[] { 5 }, 0, 1);
            file.Flush();
            file.Close();

            var fi = repository.PutFile(filePath);
            Assert.AreEqual(".xls", fi.Extension);

        }

        [Test()]
        public void GetListFielsTest()
        {
            FilesRepository repository = new FilesRepository();
            var filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xls";
            var file = File.Create(filePath);
            file.Write(new byte[] { 15, 12 }, 0, 2);
            file.Flush();
            file.Close();

            repository.PutFile(filePath);
            var fi = repository.GetListFiels();
            Assert.AreNotEqual(null, fi);

        }
    }
}