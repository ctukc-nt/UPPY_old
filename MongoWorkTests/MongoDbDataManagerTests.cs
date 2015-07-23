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
    public class MongoDbDataManagerTests
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
            var dataManager = new MongoDbDataManager<Drawing>(mongoDbTest.Database);
            var res = dataManager.GetListCollection();

            Assert.AreEqual(0, res.Count);
        }

        [Test()]
        public void InsertTest()
        {
            var dataManager = new MongoDbDataManager<Drawing>(mongoDbTest.Database);
            Assert.DoesNotThrow(() => dataManager.Insert(new Drawing() { Name = "Test" }));
            var data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "Test");
            Assert.NotNull(data);
            Assert.NotNull(data.Id);
            Assert.AreEqual("Test", data.Name);

        }

        [Test()]
        public void UpdateTest()
        {
            InsertTest();
            var dataManager = new MongoDbDataManager<Drawing>(mongoDbTest.Database);
            var data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "Test");
            Assert.NotNull(data);

            data.Name = "Test2";
            var tempId = data.Id;
            dataManager.Update(data);
            data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "Test2");

            Assert.NotNull(data);
            Assert.AreEqual(tempId, data.Id);
            Assert.AreEqual("Test2", data.Name);

        }

        [Test()]
        public void DeleteTest()
        {
            InsertTest();
            var dataManager = new MongoDbDataManager<Drawing>(mongoDbTest.Database);
            var data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "Test");
            Assert.NotNull(data);

            Assert.DoesNotThrow(() => dataManager.Delete(data));
            data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "Test");
            Assert.Null(data);
        }

        [Test()]
        public void InsertOrUpdateWhenExistTest()
        {
            var dataManager = new MongoDbDataManager<Drawing>(mongoDbTest.Database);
            Assert.DoesNotThrow(() => dataManager.Insert(new Drawing() { Name = "TestInsertOrUpdate" }));

            var data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "TestInsertOrUpdate");Assert.NotNull(data);

            dataManager.InsertOrUpdate(new Drawing() { Id = data.Id, Name = "Updates" });
            var data2 = dataManager.GetListCollection().FirstOrDefault(x => x.Id == data.Id);

            Assert.NotNull(data2);
            Assert.AreEqual(data2.Id, data.Id);
            Assert.AreEqual(data2.Name, "Updates");
        }

        [Test()]
        public void InsertOrUpdateWhenNotExistTest()
        {
            var dataManager = new MongoDbDataManager<Drawing>(mongoDbTest.Database);
            dataManager.InsertOrUpdate(new Drawing() {Name = "TestInserUpdateNotExist"});
            var data = dataManager.GetListCollection().FirstOrDefault(x => x.Name == "TestInserUpdateNotExist");
            Assert.NotNull(data);}

        [Test()]
        public void GetCollectionTest()
        {
            var dbDrawCol = new Mock<IMongoCollection<Drawing>>();
            var dbConn = new Mock<IMongoDatabase>();
            dbConn.Setup(x => x.GetCollection<Drawing>("drawings", null)).Returns(dbDrawCol.Object);

            var dataManager = new MongoDbDataManager<Drawing>(dbConn.Object);
            var res = dataManager.GetCollection();
            Assert.AreEqual(dbDrawCol.Object, res);

        }

        [Test()]
        public void GetDocumentTest()
        {

        }

        [Test()]
        public void GetDocumentAsyncTest()
        {

        }
    }
}
