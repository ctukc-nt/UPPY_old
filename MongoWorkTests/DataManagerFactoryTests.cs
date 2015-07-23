using Core.DomainModel;
using MongoDB.Driver;
using MongoWork;
using Moq;
using NUnit.Framework;

namespace MongoWorkTests
{
    [TestFixture()]
    public class DataManagerFactoryTests
    {
        [Test()]
        public void GetDataManagerTest()
        {
            var dbMock = new Mock<IMongoDatabase>();
            DataManagerFactory dataManagerFactory = new DataManagerFactory(dbMock.Object);
            var dm = dataManagerFactory.GetDataManager<Drawing>();
            var trm = dataManagerFactory.GetDataManager<TechRoute>();
            var tom = dataManagerFactory.GetDataManager<TechOperation>();

            Assert.NotNull(dm);
            Assert.NotNull(trm);
            Assert.NotNull(trm);
        }
    }
}
