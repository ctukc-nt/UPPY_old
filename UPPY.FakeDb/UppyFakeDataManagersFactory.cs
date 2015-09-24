﻿using System.Collections.Generic;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.FakeDb.FakeDataManagers;

namespace UPPY.FakeDb
{
    public class UppyFakeDataManagersFactory : IUppyDataManagersFactory
    {
        public static readonly Dictionary<string, object> Data = new Dictionary<string, object>();

        public IClassDataManager<T> GetDataManager<T>() where T : IEntity
        {
            if (typeof (T) == typeof (Drawing))
            {
                return (IClassDataManager<T>) new DrawingListClassFakeDataManager();
            }

            if (typeof (T) == typeof (TechRoute))
            {
                if (!Data.ContainsKey("tr"))
                    Data.Add("tr", new TechRoutesClassFakeDataManager());

                return (IClassDataManager<T>) Data["tr"];
            }

            if (typeof (T) == typeof (Standart))
            {
                if (!Data.ContainsKey("st"))
                    Data.Add("st", new StandartClassFakeDataManager());

                return (IClassDataManager<T>) Data["st"];
            }

            if (typeof (T) == typeof (TechOperation))
            {
                if (!Data.ContainsKey("to"))
                    Data.Add("to", new TechOperationClassFakeDataManager());

                return (IClassDataManager<T>) Data["to"];
            }

            if (typeof(T) == typeof(Order))
            {
                if (!Data.ContainsKey("or"))
                    Data.Add("or", new OrderClassFakeDataManager());

                return (IClassDataManager<T>)Data["or"];
            }

            if (typeof(T) == typeof(Gost))
            {
                if (!Data.ContainsKey("go"))
                    Data.Add("go", new GostClassFakeDataManager());

                return (IClassDataManager<T>)Data["go"];
            }

            return null;
        }

        public IClassDataManager<Drawing> GetFilteredDrawingsByParent(int? parentId)
        {
           var filtered = new FilteredDrawingListClassFakeDataManager(parentId);
            return filtered;
        }

        public IHierClassDataManager<Drawing> GetDrawingsHierClassDataManager()
        {
            var manager = GetDataManager<Drawing>();
            return (IHierClassDataManager<Drawing>) manager;
        }
    }
}