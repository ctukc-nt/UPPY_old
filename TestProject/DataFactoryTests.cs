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
    public class DataFactoryTests
    {
        [Test()]
        public void GetDrawingsTest()
        {
            DataFactory1C dataFactory1C = new DataFactory1C();
            var dr = dataFactory1C.GetDrawings();
            var topParent = dr.Where(x => x.Parent == null);
        }
    }
}
