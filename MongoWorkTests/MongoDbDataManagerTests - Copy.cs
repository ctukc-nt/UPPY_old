using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Core.DomainModel;
using MongoDB.Driver;
using MongoWork;
using Moq;
using NUnit.Framework;

namespace MongoWorkTests
{
    [TestFixture()]
    public class MongoDbDataManagerTests2
    {
        private MongoDbConnection mongoDbTest;

        [SetUp]
        public void SetUp()
        {
            mongoDbTest = new MongoDbConnection("mongodb://localhost", "Test" + Environment.TickCount);
        }

        [TearDown]
        public void Dispose()
        {
            mongoDbTest.DropDatabase();
        }

        [Test()]
        public void GetListCollectionTest()
        {

        }
    }
}
