using NUnit.Framework;
using UPPY.Desktop.Classes;
using System;
using System.Collections.Generic;
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

        }

        [Test()]
        public void LoadFilesFromDrawingsAndConvertPathTest1()
        {

        }

        [Test()]
        public void GetFileNameTest()
        {
            Mock<IFilesRepository> repoMock = new Mock<IFilesRepository>();
            repoMock.Setup(x => x.PutFile(It.IsAny<string>())).Returns(new UppyFileInfo() { FileName = "AAA" });
            FilesLoaderToRepository loader = new FilesLoaderToRepository(repoMock.Object);
            var fileName = loader.GetFileName(new Drawing() {Designation = "Y53 00 189-01"}, true,
                @"D:\Siemens\Y53_00_146-01_B_Бак\BOM\Y53_00_189_01_B.pdf");

        }
    }
}