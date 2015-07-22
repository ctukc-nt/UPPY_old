using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService1C;
using NUnit.Framework;
namespace WebService1C.Tests
{
    [TestFixture()]
    public class DataFactory1CTests
    {
        [Test()]
        public void GetDrawingsTest()
        {
            DataFactory1C df = new DataFactory1C();
            Assert.DoesNotThrow(() => df.GetDrawings());
        }

        [Test()]
        public void GetTechRoutesTest()
        {
            DataFactory1C df = new DataFactory1C();
            Assert.DoesNotThrow(() => df.GetTechRoutes());
        }

        [Test()]
        public void GetTechOperations()
        {
            DataFactory1C df = new DataFactory1C();
            Assert.DoesNotThrow(() => df.GetTechOperations());
        }
    }
}
