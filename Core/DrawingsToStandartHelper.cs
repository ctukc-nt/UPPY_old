﻿using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;

namespace Core
{
    public class DrawingsToStandartHelper
    {

        private double _density = 7.85;

        private double _defaultUtilizationRatio = 0.8;

        private List<char> _splittersStandartSize = new List<char>() { 'X', 'Х' };

        /// <summary>
        /// Плотность стали
        /// </summary>
        public double Density
        {
            get { return _density; }
            set { _density = value; }
        }

        /// <summary>
        /// Делители в типоразмере
        /// </summary>
        public List<char> SplittersStandartSize
        {
            get { return _splittersStandartSize; }
            set { _splittersStandartSize = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double DefaultUtilizationRatio
        {
            get { return _defaultUtilizationRatio; }
            set { _defaultUtilizationRatio = value; }
        }

        /// <summary>
        /// Создать нормы на деталь
        /// </summary>
        /// <param name="headDrawing">Деталь</param>
        /// <param name="dataManager">Дата манагер</param>
        /// <param name="gosts">Список ГОСТов</param>
        /// <returns></returns>
        public Standart CreateStandartByDrawing(Drawing headDrawing, IHierClassDataManager<Drawing> dataManager, List<Gost> gosts)
        {
            var allChildrens = dataManager.GetListAllChildrens(headDrawing.Id);
            var allParentId = allChildrens.Select(x => x.ParentId);
            var allDetails = allChildrens.Where(x => allParentId.Any(y => y.HasValue && y.Value == x.Id));

            var standart = new Standart();

            foreach (Drawing detail in allDetails)
            {
                var position = new PositionStandart();
                position.Profile = detail.Profile;
                if (string.IsNullOrWhiteSpace(position.Profile))
                    position.Profile = detail.Name;

                position.StandartSize = detail.StandartSize;
                position.GostOnSort = detail.GostOnSort;
                position.MarkSteal = detail.MarkSteal;
                position.UtilizationRatio = _defaultUtilizationRatio;
                position.Weight = 0;

                var dimensions = position.StandartSize.ToUpper().Split(_splittersStandartSize.ToArray());
                var gost =
                    gosts.FirstOrDefault(
                        x => String.Equals(x.Name.Replace(" ", ""), position.GostOnSort.Replace(" ", ""), StringComparison.CurrentCultureIgnoreCase));

                if (gost == null)
                    throw new ArgumentException("Справочник гостов не полный");

                switch (gost.WeightMethodCalculate)
                {
                    case WeightMethodCalculate.LengthAndWidth:
                        position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                        position.AdditionalMeasurement = ((double)detail.Length * detail.Width) / 1000 / 1000 * detail.CountAll;
                        position.Weight = position.AdditionalMeasurement * ConvertStandartSize(position.StandartSize) * Density;

                        break;
                    case WeightMethodCalculate.Length:
                        position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                        position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                        position.Weight = Math.PI * Math.Pow(ConvertStandartSizeByDelim(dimensions[0]), 2) / 4000 *
                                          position.AdditionalMeasurement * Density;
                        break;
                    case WeightMethodCalculate.ByTable:
                        position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                        position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                        var weigthByTable = gost.GetStandartWeight(position.StandartSize);
                        if (weigthByTable != null)
                            position.Weight = weigthByTable.Weight * position.AdditionalMeasurement;

                        break;
                    case WeightMethodCalculate.LengthAndThikness:
                        position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                        position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                        var outerSize = dimensions[0];
                        var widthWall = dimensions[1];
                        position.Weight = (Convert.ToDouble(outerSize) - Convert.ToDouble(widthWall)) * Convert.ToDouble(widthWall) / 40.55 *
                                          position.AdditionalMeasurement;

                        break;
                    case WeightMethodCalculate.LengthAndDoubleThikness:
                        position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                        position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                        position.Weight = position.AdditionalMeasurement * ConvertStandartSize(position.StandartSize) *
                                          ConvertStandartSize(position.StandartSize) * Density / 1000;
                        break;
                }

                position.WeightWithWaste = position.Weight / position.UtilizationRatio;
                position.AdditionalMeasurementWithWaste = position.AdditionalMeasurementWithWaste / position.UtilizationRatio;

                standart.Positions.Add(position);
            }

            return standart;

        }

        /// <summary>
        /// Сгруппировать позиции нормы на сборку
        /// </summary>
        /// <param name="standart"></param>
        /// <returns></returns>
        public Standart GroupAndSumPositionsStandart(Standart standart)
        {
            var grouppedPositionStandart = new Standart();
            grouppedPositionStandart.Id = standart.Id;
            grouppedPositionStandart.Name = standart.Name;
            grouppedPositionStandart.Drawing = standart.Drawing;
            grouppedPositionStandart.UtilizationRatio = standart.UtilizationRatio;

            grouppedPositionStandart.Positions = (from tempPosition in standart.Positions
                                                  orderby tempPosition.Profile, tempPosition.StandartSize, tempPosition.GostOnSort, tempPosition.MarkSteal
                                                  group tempPosition by
                                                      new
                                                      {
                                                          tempPosition.Profile,
                                                          tempPosition.StandartSize,
                                                          tempPosition.GostOnSort,
                                                          tempPosition.MarkSteal,
                                                          tempPosition.TypeAdditionalMeasurement
                                                      }
                                                      into grPosition
                                                      select new PositionStandart
                                                      {
                                                          Profile = grPosition.Key.Profile,
                                                          StandartSize = grPosition.Key.StandartSize,
                                                          GostOnSort = grPosition.Key.GostOnSort,
                                                          MarkSteal = grPosition.Key.MarkSteal,
                                                          TypeAdditionalMeasurement = grPosition.Key.TypeAdditionalMeasurement,
                                                          AdditionalMeasurement = grPosition.Sum(x => x.AdditionalMeasurement),
                                                          AdditionalMeasurementWithWaste = grPosition.Sum(x => x.AdditionalMeasurement) / _defaultUtilizationRatio,
                                                          Weight = grPosition.Sum(x => x.Weight),
                                                          WeightWithWaste = grPosition.Sum(x => x.Weight) / _defaultUtilizationRatio,
                                                          UtilizationRatio = _defaultUtilizationRatio,
                                                          Note = string.Empty
                                                      }).ToList();

            return grouppedPositionStandart;

        }

        private double ConvertStandartSize(string standartSize)
        {
            return Convert.ToDouble(standartSize);
        }

        private double ConvertStandartSizeByDelim(string standartSize)
        {
            var chars = standartSize.TakeWhile(char.IsDigit);
            return Convert.ToDouble(chars);
        }

        //public bool CreateStandartByDrawing(Drawing headDrawing, List<Drawing> drawings)
        //{

        //}
    }
}