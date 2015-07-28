using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.View;
using Moq;
using NUnit.Framework;

namespace DesktopApp.Controllers.Tests
{
    [TestFixture]
    public class HierarchyNumberDrawingControllerTests
    {
        private List<Drawing> _listDrawings = new List<Drawing>();

        [SetUp]
        public void SetUp()
        {
            Mapper.CreateMap<Drawing, HierarchyNumberDrawing>();
            _listDrawings = new List<Drawing>();
            var rndRandom = new Random();

            for (var i = 1; i < 30000; i++)
            {
                var random = new Random(i);
                var parentId = rndRandom.Next(0, 1) == 1 ? null : (i - 1 > 1 ? rndRandom.Next(1, i - 1) : (int?) null);
                _listDrawings.Add(new Drawing {Id = i, ParentId = parentId});
            }
        }

        [Test]
        public void HierarchyNumberDrawingControllerTest()
        {
            var dct = new Dictionary<int?, int>();
            dct.Add(null, 0);
        }

        [Test]
        public void GetDataTest()
        {
            var mockedDrawingDataAdapter = new Mock<IClassDataManager<Drawing>>();
            var mockedTechRouteDataAdapter = new Mock<IClassDataManager<TechRoute>>();
            var mockFabr = new Mock<IDataManagerFactory>();
            mockFabr.Setup(x => x.GetDataManager<Drawing>()).Returns(mockedDrawingDataAdapter.Object);
            mockFabr.Setup(x => x.GetDataManager<TechRoute>()).Returns(mockedTechRouteDataAdapter.Object);

            mockedDrawingDataAdapter.Setup(x => x.GetListCollection())
                .Returns(new List<Drawing>
                {
                    new Drawing {Id = 1},
                    new Drawing {Id = 2},
                    new Drawing {Id = 8, ParentId = 2},
                    new Drawing {Id = 3},
                    new Drawing {Id = 4, ParentId = 2},
                    new Drawing {Id = 5, ParentId = 4},
                    new Drawing {Id = 6},
                    new Drawing {Id = 7, ParentId = 5}
                });


            // mockedDrawingDataAdapter.Setup(x => x.GetListCollection()).Returns(_listDrawings);
            var hirDrControl = new HierarchyNumberDrawingController(mockFabr.Object);
            var assume = hirDrControl.GetData();

            Assert.NotNull(assume);
            Assert.AreEqual(assume.Count, 8);
            Assert.AreEqual(assume.FirstOrDefault(x => x.Id == 8).HierarchyNumber, "2.1.");
        }

        [Test]
        public void AddDocumentTest()
        {
        }

        [Test]
        public void UpdateDocumentTest()
        {
        }

        [Test]
        public void DeleteDocumentTest()
        {
        }

        [Test]
        public void GetListRelatedDocumentTest()
        {
        }

        [Test]
        public void CompareTwoDocumentsTest()
        {
            var mockedDrawingDataAdapter = new Mock<IClassDataManager<Drawing>>();
            var mockedTechRouteDataAdapter = new Mock<IClassDataManager<TechRoute>>();
            var mockFabr = new Mock<IDataManagerFactory>();
            mockFabr.Setup(x => x.GetDataManager<Drawing>()).Returns(mockedDrawingDataAdapter.Object);
            mockFabr.Setup(x => x.GetDataManager<TechRoute>()).Returns(mockedTechRouteDataAdapter.Object);

            var hirDrControl = new HierarchyNumberDrawingController(mockFabr.Object);

            var exp1 = hirDrControl.CompareTwoDocuments(new HierarchyNumberDrawing {HierarchyNumber = "1."},
                new HierarchyNumberDrawing {HierarchyNumber = "2."});
            var exp2 = hirDrControl.CompareTwoDocuments(new HierarchyNumberDrawing {HierarchyNumber = "2."},
                new HierarchyNumberDrawing {HierarchyNumber = "1."});
            var exp3 = hirDrControl.CompareTwoDocuments(new HierarchyNumberDrawing {HierarchyNumber = "2."},
                new HierarchyNumberDrawing {HierarchyNumber = "10."});

            Assert.AreEqual(-1, exp1);
            Assert.AreEqual(1, exp2);
            Assert.AreEqual(-1, exp3);
        }
    }
}