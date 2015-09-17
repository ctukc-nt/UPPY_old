using NUnit.Framework;
using UPPY.DIE.Export;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Moq;

namespace UPPY.DIE.Export.Tests
{
    [TestFixture()]
    public class ExportExcelFileTests
    {
        [Test()]
        public void CreatePassportProjectToFileTest()
        {
            var pathFileSave = Path.Combine(Path.GetTempPath(), "UPPY" + Environment.TickCount +".tmp");
            var list = new List<HierarchyNumberDrawing>();
            list.Add(new HierarchyNumberDrawing() {HierarchyNumber = "1."});
            list.Add(new HierarchyNumberDrawing() {HierarchyNumber = "1.1."});
            list.Add(new HierarchyNumberDrawing() {HierarchyNumber = "2."});
            list.Add(new HierarchyNumberDrawing() {HierarchyNumber = "3."});

            var header = new HierarchyNumberDrawing();

            ExportExcelFile excelFile = new ExportExcelFile();

            Debug.WriteLine(pathFileSave);

            Assert.DoesNotThrow(() =>
            {
                excelFile.CreatePassportProjectToFile(header, list, pathFileSave);
            });


        }
    }
}