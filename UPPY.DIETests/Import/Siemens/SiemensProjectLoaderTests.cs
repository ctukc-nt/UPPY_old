using NUnit.Framework;
using UPPY.DIE.Import.Siemens;

namespace UPPY.DIETests.Import.Siemens
{
    [TestFixture()]
    public class SiemensProjectLoaderTests
    {
        [Test()]
        public void LoadStructureProjectTest()
        {
            var filesNameGetter = new SiemensXmlDataFilesNameGetter();
            var docsFilesGetter = new SiemensDocsFilesNameGetter();

            docsFilesGetter.LocationDirectory = filesNameGetter.LocationDirectory = @"D:\Siemens\Y53_00_146-01_B_Бак";

            var filesArticlesFactory = new FilesArticlesFactory(filesNameGetter);
            var siemensProjectLoader = new SiemensProjectLoader(filesArticlesFactory, null, docsFilesGetter);

            var project = siemensProjectLoader.LoadStructureProject();
        }
    }
}