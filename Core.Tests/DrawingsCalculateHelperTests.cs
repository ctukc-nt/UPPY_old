using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using Moq;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture()]
    public class DrawingsCalculateHelperTests
    {
        [Test()]
        public void RecalculateProjectByWeightTest()
        {
            var draws = new List<Drawing>
                {
                    new Drawing {Id = 1, Count = 1, CountAll = 1, Weight = 1, WeightAll = 1},
                    new Drawing {Id = 2, Count = 1, CountAll = 1, Weight = 1, WeightAll = 2},
                    new Drawing {Id = 3, Count = 1, CountAll = 1, Weight = 7, WeightAll = 7},
                    new Drawing {Id = 4, ParentId = 3, Count = 2, CountAll = 2, Weight = 2, WeightAll = 4},
                    new Drawing {Id = 5, ParentId = 4, Count = 1, CountAll = 2, Weight = 1, WeightAll = 2},
                    new Drawing {Id = 6, ParentId = 4, Count = 2, CountAll = 4, Weight = 5, WeightAll = 20},
                    new Drawing {Id = 7, ParentId = 3, Count = 2, CountAll = 2, Weight = 5, WeightAll = 10},
                };
            var dm = new Mock<IClassDataManager<Drawing>>();
            dm.Setup(x => x.GetListCollection()).Returns(draws);
            dm.Setup(x => x.GetListCollection(It.IsAny<Func<Drawing, bool>>())).Returns<Func<Drawing, bool>>(x => draws.Where(x).ToList());
            dm.Setup(x => x.GetDocument(It.IsAny<int?>())).Returns<int?>(x => draws.FirstOrDefault(y => y.Id == x));
            var hellper = new DrawingsCalculateHelper();
            draws[4].Weight = 7;
            Assert.DoesNotThrow(() => hellper.RecalculateProjectByWeight(draws[4], dm.Object));
            Assert.AreEqual(44, draws[2].WeightAll);
            Assert.AreEqual(1, draws[0].WeightAll);
            Assert.AreEqual(34, draws[3].WeightAll);
        }

        [Test()]
        public void RecalculateProjectByCountTest()
        {
            var draws = new List<Drawing>
                {
                    new Drawing {Id = 1, Count = 1, CountAll = 1, Weight = 1, WeightAll = 1},
                    new Drawing {Id = 2, Count = 1, CountAll = 1, Weight = 1, WeightAll = 2},
                    new Drawing {Id = 3, Count = 1, CountAll = 1, Weight = 44, WeightAll = 44},
                    new Drawing {Id = 4, ParentId = 3, Count = 2, CountAll = 2, Weight = 17, WeightAll = 34},
                    new Drawing {Id = 5, ParentId = 4, Count = 1, CountAll = 2, Weight = 7, WeightAll = 14},
                    new Drawing {Id = 6, ParentId = 4, Count = 2, CountAll = 4, Weight = 5, WeightAll = 20},
                    new Drawing {Id = 7, ParentId = 3, Count = 2, CountAll = 2, Weight = 5, WeightAll = 10},
                };

            var dm = new Mock<IClassDataManager<Drawing>>();
            dm.Setup(x => x.GetListCollection()).Returns(draws);
            dm.Setup(x => x.GetListCollection(It.IsAny<Func<Drawing, bool>>())).Returns<Func<Drawing, bool>>(x => draws.Where(x).ToList());
            dm.Setup(x => x.GetDocument(It.IsAny<int?>())).Returns<int?>(x => draws.FirstOrDefault(y => y.Id == x));
            var hellper = new DrawingsCalculateHelper();
            draws[4].Count = 2;
            Assert.DoesNotThrow(() => hellper.RecalculateProjectByCount(draws[4], dm.Object));
            Assert.AreEqual(58, draws[2].WeightAll);
            Assert.AreEqual(1, draws[0].WeightAll);
        }

        [Test()]
        public void RecalculateProjectByCountChildrensTest()
        {
            var draws = new List<Drawing>
                {
                    new Drawing {Id = 1, Count = 1, CountAll = 1, Weight = 1, WeightAll = 1},
                    new Drawing {Id = 2, Count = 1, CountAll = 1, Weight = 1, WeightAll = 2},
                    new Drawing {Id = 3, Count = 1, CountAll = 1, Weight = 44, WeightAll = 44},
                    new Drawing {Id = 4, ParentId = 3, Count = 2, CountAll = 2, Weight = 17, WeightAll = 34},
                    new Drawing {Id = 5, ParentId = 4, Count = 1, CountAll = 2, Weight = 7, WeightAll = 14},
                    new Drawing {Id = 6, ParentId = 4, Count = 2, CountAll = 4, Weight = 5, WeightAll = 20},
                    new Drawing {Id = 7, ParentId = 3, Count = 2, CountAll = 2, Weight = 5, WeightAll = 10},
                };

            var dm = new Mock<IClassDataManager<Drawing>>();
            dm.Setup(x => x.GetListCollection()).Returns(draws);
            dm.Setup(x => x.GetListCollection(It.IsAny<Func<Drawing, bool>>())).Returns<Func<Drawing, bool>>(x => draws.Where(x).ToList());
            dm.Setup(x => x.GetDocument(It.IsAny<int?>())).Returns<int?>(x => draws.FirstOrDefault(y => y.Id == x));
            var hellper = new DrawingsCalculateHelper();
            draws[3].Count = 3;
            Assert.DoesNotThrow(() => hellper.RecalculateProjectByCount(draws[3], dm.Object));
            Assert.AreEqual(61, draws[2].WeightAll);
            Assert.AreEqual(1, draws[0].WeightAll);
        }
    }
}