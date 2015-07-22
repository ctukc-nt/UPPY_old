using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using MongoDB.Driver;
using MongoWork;
using Moq;
using NUnit.Framework;
namespace MongoWork.Tests
{
    [TestFixture()]
    public class MongoDbConnectorTests
    {
        [Test()]
        public void GetListCollectionTest()
        {
            MongoDbInitializer initializer = new MongoDbInitializer();
            initializer.InitDatabase();
            var db = initializer.GetDbConnection();
            

            MongoDbConnector connector = new MongoDbConnector(db);
           // var id = connector.getIdDocument(new Drawing());

        }
    }
}
