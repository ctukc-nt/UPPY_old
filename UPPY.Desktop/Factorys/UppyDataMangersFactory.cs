using System;
using Core.DomainModel;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;

namespace UPPY.Desktop.Factorys
{
    public class UppyDataMangersFactory : DataManagersFactory, IUppyDataManagersFactory
    {
        public UppyDataMangersFactory(IMongoDatabase database) : base(database)
        {

        }

        public IClassDataManager<Drawing> GetFilteredDrawingsByParent(int? parentId)
        {
            throw new NotImplementedException();
        }

        public IHierClassDataManager<Drawing> GetDrawingsHierClassDataManager()
        {
            throw new NotImplementedException();
        }
    }
}