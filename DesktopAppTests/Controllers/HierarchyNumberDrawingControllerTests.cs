﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using DesktopApp.Controllers;
using DesktopApp.View;
using Moq;
using NUnit.Framework;
namespace DesktopApp.Controllers.Tests
{
    [TestFixture()]
    public class HierarchyNumberDrawingControllerTests
    {
        List<Drawing> _listDrawings = new List<Drawing>();

        [SetUp]
        public void SetUp()
        {
            AutoMapper.Mapper.CreateMap<Drawing, HierarchyNumberDrawing>();
            _listDrawings = new List<Drawing>();
            Random rndRandom = new Random();

            for (int i = 1; i < 30000; i++)
            {
                Random random = new Random(i);
                var parentId = rndRandom.Next(0, 1) == 1 ? (int?)null : (i - 1 > 1 ? rndRandom.Next(1, i - 1) : (int?)null);
                _listDrawings.Add(new Drawing() { Id = i, ParentId = parentId });
            }
        }

        [Test()]
        public void HierarchyNumberDrawingControllerTest()
        {
            var dct = new Dictionary<int?, int>();
            dct.Add(null, 0);
        }

        [Test()]
        public void GetDataTest()
        {


            var mockedDrawingDataAdapter = new Mock<IClassDataManager<Drawing>>();
            var mockedTechRouteDataAdapter = new Mock<IClassDataManager<TechRoute>>();

            mockedDrawingDataAdapter.Setup(x => x.GetListCollection())
                .Returns(new List<Drawing>()
                {
                    new Drawing() {Id = 1},
                    new Drawing() {Id = 2},
                    new Drawing() {Id = 8, ParentId = 2},
                    new Drawing() {Id = 3},
                    new Drawing() {Id = 4, ParentId = 2},
                    new Drawing() {Id = 5, ParentId = 4},
                    new Drawing() {Id = 6},
                    new Drawing() {Id = 7, ParentId = 5}
                });



           // mockedDrawingDataAdapter.Setup(x => x.GetListCollection()).Returns(_listDrawings);

            var dtBegin = DateTime.Now;
            Debug.WriteLine(dtBegin);
            Debug.WriteLine(Environment.TickCount);

            var hirDrControl = new HierarchyNumberDrawingController(mockedDrawingDataAdapter.Object, mockedTechRouteDataAdapter.Object);
            var assume = hirDrControl.GetData();

            var dtEnd = DateTime.Now;
            Debug.WriteLine(dtEnd);
            Debug.WriteLine(dtEnd.Subtract(dtBegin).Ticks);

            Assert.NotNull(assume);
            Assert.AreEqual(assume.Count, 7);
            Assert.AreEqual(assume[0].HierarchyNumber, "1.");

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

        }

        [Test()]
        public void CompareTwoDocumentsTest()
        {
            var mockedDrawingDataAdapter = new Mock<IClassDataManager<Drawing>>();
            var mockedTechRouteDataAdapter = new Mock<IClassDataManager<TechRoute>>();
            var hirDrControl = new HierarchyNumberDrawingController(mockedDrawingDataAdapter.Object, mockedTechRouteDataAdapter.Object);

            var exp1 = hirDrControl.CompareTwoDocuments(new HierarchyNumberDrawing() {HierarchyNumber = "1."}, new HierarchyNumberDrawing() {HierarchyNumber = "2."});
            var exp2 = hirDrControl.CompareTwoDocuments(new HierarchyNumberDrawing() { HierarchyNumber = "2." }, new HierarchyNumberDrawing() { HierarchyNumber = "1." });
            var exp3 = hirDrControl.CompareTwoDocuments(new HierarchyNumberDrawing() { HierarchyNumber = "2." }, new HierarchyNumberDrawing() { HierarchyNumber = "10." });

            Assert.AreEqual(-1, exp1);
            Assert.AreEqual(1, exp2);
            Assert.AreEqual(-1, exp3);
        }
    }
}
