using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Controllers;
using Moq;
using NUnit.Framework;
namespace DesktopApp.Controllers.Tests
{
    [TestFixture()]
    public class DrawingControllerTests
    {
        [Test()]
        public void DrawingControllerTest()
        {

        }

        [Test()]
        public void GetDataTest()
        {

        }

        [Test()]
        public void AddDocumentTest()
        {

        }

        [Test()]
        public void UpdateDocumentTest()
        {

        }

        [Test()]
        public void DeleteDocumentTest()
        {

        }

        [Test()]
        public void GetListRelatedDocumentTest()
        {
            var mockDrawing = new Mock<IClassDataManager<Drawing>>();
            var mockTechRoute = new Mock<IClassDataManager<TechRoute>>();
            var mockFabr = new Mock<IDataManagerFactory>();
            mockFabr.Setup(x => x.GetDataManager<Drawing>()).Returns(mockDrawing.Object);
            mockFabr.Setup(x => x.GetDataManager<TechRoute>()).Returns(mockTechRoute.Object);


            mockTechRoute.Setup(x => x.GetListCollection())
                .Returns(new List<TechRoute>()
                {
                    new TechRoute()
                    {
                        TechOperations = new List<TechOperation>()
                        {
                            new TechOperation() {ShortName = "A"},
                            new TechOperation() {ShortName = "B"},
                        }
                    }
                });

            DrawingController controller = new DrawingController(mockFabr.Object);
            var list = controller.GetListRelatedDocument<TechRoute>().ConvertAll(x => (TechRoute)x);
            TechRoute techRoute = list[0];

            Assert.NotNull(techRoute);
            Assert.AreEqual(techRoute.TechOperations.Count, 2);
        }
    }
}
