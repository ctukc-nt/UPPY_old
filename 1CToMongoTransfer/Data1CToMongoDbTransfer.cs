using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Core.DomainModel;
using Core.Interfaces;
using MongoWork;
using WebService1C;

namespace _1CToMongoTransfer
{
    public class Data1CToMongoDbTransfer
    {
        public void TransferData(DataFactory1C data1C, IDataManagersFactory dataManagers)
        {
            TransferTechOperation(data1C, dataManagers);
            TransferTechRoute(data1C, dataManagers);
            TransferDrawings(data1C, dataManagers);
        }

        private static void TransferTechOperation(DataFactory1C data1C, IDataManagersFactory dataManagers)
        {
            var dataManTech = dataManagers.GetDataManager<TechOperation>();
            var techOperations = data1C.GetTechOperations();
            foreach (var operation in techOperations)
            {
                var techOperMongo = dataManTech.GetListCollection();
                if (techOperMongo.All(x => x.ShortName != operation.ShortName))
                {
                    dataManTech.Insert(new TechOperation { FullName = operation.FullName, ShortName = operation.ShortName, Id = operation.Id });
                }
            }
        }

        private static void TransferTechRoute(DataFactory1C data1C, IDataManagersFactory dataManagers)
        {
            var techRoutes = data1C.GetTechRoutes();
            var techOpersMan = dataManagers.GetDataManager<TechOperation>();
            var techOpers = techOpersMan.GetListCollection();
            var techRoutesMan = dataManagers.GetDataManager<TechRoute>();

            foreach (var route in techRoutes)
            {
                var routesFromMongo = techRoutesMan.GetListCollection();
                IEqualityComparer<TechRoute> comparer = new Comparer();
                if (routesFromMongo.All(x => x.Name != route.Name) || !routesFromMongo.SequenceEqual(techRoutes, comparer))
                {
                    var techRoute = new TechRoute { Name = route.Name, Note = route.Note };
                    var operations = new List<TechOperation>();
                    foreach (var techOperation in route.TechOperations)
                    {
                        var techOperFromMongo = techOpers.FirstOrDefault(x => x.ShortName == techOperation.ShortName);
                        if (techOperFromMongo == null)
                            throw new ArgumentNullException();
                        operations.Add(techOperFromMongo);
                    }

                    techRoute.TechOperations = operations;
                    techRoutesMan.Insert(techRoute);
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        private static void TransferDrawings(DataFactory1C data1C, IDataManagersFactory dataManagers)
        {
            var drawings = data1C.GetDrawings();
            var techRoutesMan = dataManagers.GetDataManager<TechRoute>();
            var drawingsMan = dataManagers.GetDataManager<Drawing>();

            var techRoutes = techRoutesMan.GetListCollection();

            foreach (var drawing in drawings.Where(x => x.PartOfDrawingId != null))
            {
                var partOfDrawing = drawings.FirstOrDefault(y => y.Id == drawing.PartOfDrawingId);
                if (partOfDrawing != null)
                {
                    drawing.PartOfDrawingId = partOfDrawing.Id;
                }
            }

            foreach (var drawing in drawings.Where(x => x.TechRouteId != null))
            {
                var techRouteMongo = techRoutes.FirstOrDefault(y => y.Id == drawing.TechRouteId);
                if (techRouteMongo != null)
                {
                    drawing.TechRouteId = techRouteMongo.Id;
                }
            }

            foreach (var drawing in drawings.Where(x => x.ParentId != null))
            {
                var parentDrawing = drawings.FirstOrDefault(y => y.Id == drawing.ParentId);
                if (parentDrawing != null)
                {
                    drawing.ParentId = parentDrawing.Id;
                }
            }
            
            foreach (var drawing in drawings)
            {
                drawingsMan.Insert(drawing);
            }
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