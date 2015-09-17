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
            var pathFileSave = Path.Combine(Path.GetTempPath(), "UPPY" + Environment.TickCount + ".tmp");
            var list = new List<HierarchyNumberDrawing>();
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "1." });
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "1.1." });
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "2." });
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "3." });

            var header = new HierarchyNumberDrawing();

            ExportExcelFile excelFile = new ExportExcelFile();

            Debug.WriteLine(pathFileSave);

            Assert.DoesNotThrow(() =>
            {
                excelFile.CreatePassportProjectToFile(header, list, pathFileSave);
            });


        }

        [Test()]
        public void CreatePassportProjectToFileWithToTest()
        {
            var pathFileSave = Path.Combine(Path.GetTempPath(), "UPPY" + Environment.TickCount + ".tmp");
            var list = new List<HierarchyNumberDrawing>();
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "1.", TechRouteId = 2 });
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "1.1.", TechRouteId = 4 });
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "2.", });// TechRouteId = 1
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "3.", TechRouteId = 3 });
            list.Add(new HierarchyNumberDrawing() { HierarchyNumber = "4.", TechRouteId = 5 });

            var listTo = new List<TechOperation>();
            listTo.Add(new TechOperation() { Id = 1, ShortName = "A" });
            listTo.Add(new TechOperation() { Id = 2, ShortName = "B" });
            listTo.Add(new TechOperation() { Id = 3, ShortName = "C" });
            listTo.Add(new TechOperation() { Id = 4, ShortName = "D" });
            listTo.Add(new TechOperation() { Id = 5, ShortName = "E" });


            var listTr = new List<TechRoute>();
            listTr.Add(new TechRoute() { Id = 1, TechOperations = new List<TechOperation>() { new TechOperation() { Id = 1 }, new TechOperation() { Id = 2 } } });
            listTr.Add(new TechRoute() { Id = 2, TechOperations = new List<TechOperation>() { new TechOperation() { Id = 2 }, new TechOperation() { Id = 3 } } });
            listTr.Add(new TechRoute() { Id = 3, TechOperations = new List<TechOperation>() { new TechOperation() { Id = 3 }, new TechOperation() { Id = 5 } } });
            listTr.Add(new TechRoute() { Id = 4, TechOperations = new List<TechOperation>() { new TechOperation() { Id = 1 }, new TechOperation() { Id = 2 }, new TechOperation() { Id = 4 } } });
            listTr.Add(new TechRoute() { Id = 5, TechOperations = new List<TechOperation>() { new TechOperation() { Id = 5 } } });


            var header = new HierarchyNumberDrawing();

            ExportExcelFile excelFile = new ExportExcelFile();

            Debug.WriteLine(pathFileSave);

            Assert.DoesNotThrow(() =>
            {
                excelFile.CreatePassportProjectToFile(header, list, listTo, listTr, pathFileSave);
            });
        }

        [Test()]
        public void CreateReportClearWeightsTest()
        {
            var pathFileSave = Path.Combine(Path.GetTempPath(), "UPPY" + Environment.TickCount + ".tmp");
            ExportExcelFile excelFile = new ExportExcelFile();

            Debug.WriteLine(pathFileSave);

            var st = new Standart();
            st.Positions.Add(new PositionStandart() {});
            st.Positions.Add(new PositionStandart() {});
            st.Positions.Add(new PositionStandart() {});
            st.Positions.Add(new PositionStandart() {});

            Assert.DoesNotThrow(() =>
            {
                excelFile.CreateReportClearWeights(st, pathFileSave);
            });
        }
    }
}