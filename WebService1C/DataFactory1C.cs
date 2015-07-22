using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Core;
using WebService1C.dbsrv;
using Drawing = Core.Drawing;
using TechRoute = Core.TechRoute;

namespace WebService1C
{
    public class DataFactory1C : IDataFactory
    {
        public List<Drawing> GetDrawings()
        {
            var s = new DrawingsService();
            s.Credentials = new NetworkCredential("aaa", "aaa");

            var aaa = s.GetDrawings();
            return
                new List<Drawing>(
                    aaa.Select(
                        x =>
                            new Drawing
                            {
                                Name = x.Name,
                                NumberOnSpec = x.NumberOnSpec,
                                Count = x.Count,
                                CountAll = x.CountAll,
                                Designation = x.Designation,
                                GostOnMaterial = x.GostMat,
                                GostOnSort = x.GostSort,
                                Id = Convert.ToInt32(x.Code),
                                Length = x.Length,
                                Width = x.Width,
                                MarkSteal = x.MarkSteal,
                                ParentId =
                                    x.ParentCode == string.Empty
                                        ? (int?) null
                                        : Convert.ToInt32(x.ParentCode),
                                TechRouteId = 
                                    x.TechRouteCode == string.Empty
                                        ? (int?) null
                                        : Convert.ToInt32(x.TechRouteCode),
                                Profile = x.Profile,
                                StandartSize = x.TypeSize,
                                Weight = x.Weight,
                                WeightAll = x.WeightAll,
                                

                            }));
        }

        public List<TechRoute> GetTechRoutes()
        {
            var s = new DrawingsService();
            s.Credentials = new NetworkCredential("aaa", "aaa");

            var opers = s.GetTechRoutes();

            return
                new List<TechRoute>(
                    opers.Select(
                        x =>
                            new TechRoute
                            {
                                Id = Convert.ToInt32(x.Code),
                                Name = x.Name,
                                Note = x.Note,
                                TechOperations = x.ListOperations.Select(y =>
                                    new TechOperation
                                    {
                                        Id = Convert.ToInt32(y.Code),
                                        ShortName = y.Name,
                                        FullName = y.FullName
                                    }).ToList()
                            }));
        }

        public List<TechOperation> GetTechOperations()
        {
            var s = new DrawingsService();
            s.Credentials = new NetworkCredential("aaa", "aaa");

            var opers = s.GetTechOperations();

            return
                new List<TechOperation>(
                    opers.Select(
                        x =>
                            new TechOperation
                            {
                                Id = Convert.ToInt32(x.Code),
                                ShortName = x.Name,
                                FullName = x.FullName
                            }));
        }
    }
}