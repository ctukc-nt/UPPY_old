using System;
using Core.DomainModel;
using Core.Interfaces;
using MongoDB.Driver;
using MongoWork;
using UPPY.Desktop.Concrete.DataManager.Drawings;

namespace UPPY.Desktop.Factorys
{
    public class UppyDataMangersFactory : DataManagersFactory, IUppyDataManagersFactory
    {
        public UppyDataMangersFactory(IMongoDatabase database) : base(database)
        {

        }

        public IClassDataManager<Drawing> GetFilteredDrawingsByParent(int? parentId)
        {
            return new DrawingsFilteredDataManager(Database, parentId);
        }

        public IHierClassDataManager<Drawing> GetDrawingsHierClassDataManager()
        {
            return new HierarchyDrawingsDataManager(Database);
        }
    }
}