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
            DataManagersFactory dataManagersFactory = new DataManagersFactory(dbMock.Object);
            var dm = dataManagersFactory.GetDataManager<Drawing>();
            var trm = dataManagersFactory.GetDataManager<TechRoute>();
            var tom = dataManagersFactory.GetDataManager<TechOperation>();

            Assert.NotNull(dm);
            Assert.NotNull(trm);
            Assert.NotNull(trm);
        }
    }
}
