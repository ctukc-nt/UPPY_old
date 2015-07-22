using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeUtility;
using NUnit.Framework;
using WebService1C.dbsrv;

namespace TreeUtility.Tests
{
    [TestFixture()]
    public class TreeHelperTests
    {
        internal class Drawing : ITreeNode<Drawing>
        {
            public int Id { get; set; }

            public Drawing Parent
            { get; set; }

            public IList<Drawing> Children
            { get; set; }
        }

        [Test()]
        public void ConvertToForestTest()
        {
            var s = new List<Drawing>();
            s.Add(new Drawing { Id = 1 });
            s.Add(new Drawing { Id = 2 });
            s.Add(new Drawing { Id = 3 });

            var ss = s.ToArray().ConvertToForest();
        }
    }
}
