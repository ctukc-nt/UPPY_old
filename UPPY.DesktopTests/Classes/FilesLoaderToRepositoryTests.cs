using NUnit.Framework;
using UPPY.Desktop.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using Moq;

namespace UPPY.Desktop.Classes.Tests
{
    [TestFixture()]
    public class FilesLoaderToRepositoryTests
    {
        /*
            D:\Siemens\Y53_00_146-01_B_Бак\BOM\Y53_00_189_01_B.pdf
            D:\Siemens\Y53_00_146-01_B_Бак\Doc\Y53_00_189_IZ_Z;_Sh.01_(A).pdf
            D:\Siemens\Y53_00_146-01_B_Бак\Doc\Y53_00_189_IZ_Z;_Sh.02_(A).pdf
            D:\Siemens\Y53_00_146-01_B_Бак\Doc\Y53_00_189_IZ_Z;_Sh.03_(A).pdf
        */

        [Test()]
        public void FilesLoaderToRepositoryTest()
        {
            Mock<IFilesRepository> repoMock = new Mock<IFilesRepository>();
            repoMock.Setup(x => x.PutFile(It.IsAny<string>())).Returns(new UppyFileInfo() { FileName = "AAA" });
            FilesLoaderToRepository loader = new FilesLoaderToRepository(repoMock.Object);
            //loader.LoadFilesFromDrawingsAndConvertPath();
        }

        [Test()]
        public void LoadFilesFromDrawingsAndConvertPathTest()
        {
            Mock<IFilesRepository> repoMock = new Mock<IFilesRepository>();
            repoMock.Setup(x => x.PutFile(It.IsAny<string>())).Returns<string>(x => new UppyFileInfo() { FileName = "AAA" });
            FilesLoaderToRepository loader = new FilesLoaderToRepository(repoMock.Object);

            var drawing = new Drawing() {Designation = "Y53 00 186-01", Name = "ДНО БАКА"};
            drawing.Files.Add(new UppyFileInfo() {FileName = @"D:\Siemens\Y53_00_146 - 01_B_Бак\Bom\Y53_00_186_01_A.pdf" });
            drawing.Files.Add(new UppyFileInfo() { FileName = @"D:\Siemens\Y53_00_146-01_B_Бак\Doc\Y53_00_186_IZ_Z;_Sh.01_(A).pdf" });
            drawing.Files.Add(new UppyFileInfo() { FileName = @"D:\Siemens\Y53_00_146-01_B_Бак\Doc\Y53_00_186_IZ_Z;_Sh.02_(A).pdf" });

            var fileName = loader.GetFileName(drawing, true, @"D:\Siemens\Y53_00_146-01_B_Бак\Doc\Y53_00_186_IZ_Z;_Sh.02_(A).pdf");
            Debug.WriteLine(fileName);

        }

        [Test()]
        public void GetFileNameTest()
        {
            Mock<IFilesRepository> repoMock = new Mock<IFilesRepository>();
            repoMock.Setup(x => x.PutFile(It.IsAny<string>())).Returns(new UppyFileInfo() { FileName = "AAA" });
            FilesLoaderToRepository loader = new FilesLoaderToRepository(repoMock.Object);
            var fileName = loader.GetFileName(new Drawing() { Designation = "Y53 00 189-01" }, true,
                @"D:\Siemens\Y53_00_146-01_B_Бак\BOM\Y53_00_189_01_B.pdf");

        }

    }
}

