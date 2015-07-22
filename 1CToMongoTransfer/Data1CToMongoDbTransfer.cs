using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using MongoWork;
using WebService1C;

namespace _1CToMongoTransfer
{
    public class Data1CToMongoDbTransfer
    {
        public void TransferData(DataFactory data1C, MongoDbConnector connector)
        {
            TransferTechOperation(data1C, connector);
        }

        private static void TransferTechOperation(DataFactory data1C, MongoDbConnector connector)
        {
            var techOperations = data1C.GetTechOperations();
            foreach (var operation in techOperations)
            {
                var techOperMongo = connector.GetListCollection<TechOperation>();
                if (techOperMongo.All(x => x.ShortName != operation.ShortName))
                {
                    connector.Insert(new TechOperation {FullName = operation.FullName, ShortName = operation.ShortName, Id = operation.Id});
                }
            }
        }

        private static void TransferTechRoute(DataFactory data1C, MongoDbConnector connector)
        {
            var techRoutes = data1C.GetTechRoutes();
            var techOpers = connector.GetListCollection<TechOperation>();
            foreach (var route in techRoutes)
            {
                var routesFromMongo = connector.GetListCollection<TechRoute>();
                IEqualityComparer<TechRoute> comparer = new Comparer();
                if (routesFromMongo.All(x => x.Name != route.Name) || !routesFromMongo.SequenceEqual(techRoutes, comparer))
                {
                    var techRoute = new TechRoute {Name = route.Name, Note = route.Note};
                    var operations = new List<TechOperation>();
                    foreach (var techOperation in route.TechOperations)
                    {
                        var techOperFromMongo = techOpers.FirstOrDefault(x => x.ShortName == techOperation.ShortName);
                        if (techOperFromMongo == null)
                            throw new ArgumentNullException();
                        operations.Add(techOperFromMongo);
                    }

                    techRoute.TechOperations = operations;
                    connector.Insert(techRoute);
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        private static void TransferDrawings(DataFactory data1C, MongoDbConnector connector)
        {
            var techRoutes = data1C.GetDrawings();

        }

        private class Comparer : IEqualityComparer<TechRoute>
        {
            public bool Equals(TechRoute x, TechRoute y)
            {
                if (x.TechOperations == null || y.TechOperations == null)
                    return false;

                if (x.TechOperations.Count != y.TechOperations.Count)
                    return false;

                return !x.TechOperations.Where((t, i) => t.ShortName != y.TechOperations[i].ShortName).Any();
            }

            public int GetHashCode(TechRoute obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}