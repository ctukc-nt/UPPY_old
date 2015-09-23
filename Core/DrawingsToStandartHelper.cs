using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using Utils.Common;

namespace Core
{
    public class DrawingsToStandartHelper
    {
        /// <summary>
        ///     Плотность стали
        /// </summary>
        public double Density { get; set; } = 7.85;

        /// <summary>
        /// Бросать исключения
        /// </summary>
        public bool ThrowExceptions { get; set; } = false;

        /// <summary>
        ///     Делители в типоразмере
        /// </summary>
        public List<char> SplittersStandartSize { get; set; } = new List<char> { 'X', 'Х' };

        public ILogging Log { get; set; }

        /// <summary>
        /// </summary>
        public double DefaultUtilizationRatio { get; set; } = 0.8;

        /// <summary>
        ///     Создать нормы на деталь
        /// </summary>
        /// <param name="headDrawing">Деталь</param>
        /// <param name="dataManager">Дата манагер</param>
        /// <param name="gosts">Список ГОСТов</param>
        /// <returns></returns>
        public Standart CreateStandartByDrawing(Drawing headDrawing, IHierClassDataManager<Drawing> dataManager,
            List<Gost> gosts)
        {
            var allChildrens = dataManager.GetListAllChildrens(headDrawing.Id);
            var allParentId = allChildrens.Select(x => x.ParentId).Distinct();
            var allDetails = allChildrens.AsParallel().Where(x => allParentId.FirstOrDefault(y => y != null && y.Value == x.Id) == null);

            var standart = new Standart();

            foreach (var detail in allDetails)
            {
                var position = new PositionStandart
                {
                    Profile = detail.Profile,
                    StandartSize = detail.StandartSize,
                    GostOnSort = detail.GostOnSort,
                    MarkSteal = detail.MarkSteal,
                    UtilizationRatio = DefaultUtilizationRatio,
                    Weight = 0
                };

                if (string.IsNullOrWhiteSpace(position.Profile))
                    position.Profile = detail.Name;

                var gost =
                    gosts.FirstOrDefault(
                        x =>
                            string.Equals(x.Name.Replace(" ", ""), position.GostOnSort.Replace(" ", ""),
                                StringComparison.CurrentCultureIgnoreCase));

                if (string.IsNullOrWhiteSpace(position.GostOnSort))
                {
                    Log?.AppendMessage("Поле ГОСТ на сортамент не заполнено." + position.GostOnSort, position, TypeMessage.Error);
                    standart.Positions.Add(position);
                    continue;
                }

                if (gost == null)
                {
                    if (ThrowExceptions)
                    {
                        var argEx = new ArgumentException($"Справочник гостов не полный. Отсутствует ГОСТ {position.GostOnSort}.");
                        argEx.Data.Add("detail", detail);
                        throw argEx;
                    }
                    else
                    {
                        position.Note = "Не найден ГОСТ в справочнике, позиция без обработки!";
                        Log?.AppendMessage("Не найден ГОСТ " + position.GostOnSort, position, TypeMessage.Error);
                        standart.Positions.Add(position);
                        continue;
                    }
                }

                switch (gost.TypeExtraDimension)
                {
                        case ExtraDimensions.Meters:
                        case ExtraDimensions.SquareMeter:

                        switch (gost.WeightMethodCalculate)
                        {
                            case WeightMethodCalculate.LengthAndWidth:

                                if (detail.Length.HasValue && detail.Width.HasValue && !string.IsNullOrEmpty(position.StandartSize))
                                {
                                    position.AdditionalMeasurement = (double)(((double)detail.Length * detail.Width) / 1000 / 1000 *
                                                                               detail.CountAll);
                                    position.Weight = position.AdditionalMeasurement * ConvertStandartSize(position.StandartSize) *
                                                      Density;
                                    position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                                    position.Note = $"{(double)detail.Length} x {(double)detail.Width} x {detail.CountAll}";
                                }
                                else
                                {
                                    Log?.AppendMessage("Поля Длина и/или Ширина и/или Типоразмер не заполнено в соответствии выбранному методу вычисления по типу ГОСТа " + gost.Name);
                                }
                                break;
                            case WeightMethodCalculate.Length:
                                if (detail.Length.HasValue && !string.IsNullOrEmpty(position.StandartSize))
                                {
                                    var dimensions = position.StandartSize.ToUpper().Split(SplittersStandartSize.ToArray());
                                    position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                                    position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                                    position.Weight = Math.PI * Math.Pow(ConvertStandartSizeByDelim(dimensions[0]), 2) / 4000 *
                                                      position.AdditionalMeasurement * Density;
                                }
                                else
                                {
                                    Log?.AppendMessage("Поля не Длина и/или Ширина и/или Типоразмер не заполнено в соответствии выбранному методу вычисления по типу ГОСТа " + gost.Name);
                                }
                                break;
                            case WeightMethodCalculate.ByTable:
                                if (detail.Length.HasValue && !string.IsNullOrEmpty(position.StandartSize))
                                {
                                    position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                                    position.AdditionalMeasurement = ((double)detail.Length.Value) / 1000 * detail.CountAll;
                                    var weigthByTable = gost.GetStandartWeight(position.StandartSize);
                                    if (weigthByTable != null)
                                        position.Weight = weigthByTable.Weight * position.AdditionalMeasurement;
                                    else
                                    {
                                        Log?.AppendMessage(
                                            $"Не заполнен табличный типоразмер для ГОСТа {gost.Name} и типоразмера {position.StandartSize}");
                                    }
                                }
                                else
                                {
                                    Log?.AppendMessage("Поле Длина и/или Типоразмер не заполнено в соответствии выбранному методу вычисления по типу ГОСТа " + gost.Name);
                                }
                                break;
                            case WeightMethodCalculate.LengthAndThikness:


                                if (!string.IsNullOrEmpty(position.StandartSize))
                                {
                                    var splStSize = position.StandartSize.ToUpper().Split(SplittersStandartSize.ToArray());
                                    var outerSize = splStSize[0];
                                    var widthWall = splStSize[1];

                                    if (detail.Length.HasValue)
                                    {
                                        if (!string.IsNullOrEmpty(outerSize) && !string.IsNullOrEmpty(widthWall))
                                        {
                                            position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                                            position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                                            position.Weight = (Convert.ToDouble(outerSize) - Convert.ToDouble(widthWall)) *
                                                              Convert.ToDouble(widthWall) / 40.55 *
                                                              position.AdditionalMeasurement;
                                        }
                                        else
                                        {
                                            Log?.AppendMessage("Поле Типоразмер не заполнено в соответствии выбранному методу вычисления по типу ГОСТа " + gost.Name);
                                        }
                                    }
                                    else
                                    {
                                        Log?.AppendMessage("Поле Длина не заполнено в соответствии выбранному методу вычисления по типу ГОСТа " + gost.Name);
                                    }
                                }
                                else
                                {
                                    Log?.AppendMessage("Поле Типоразмер не заполнено");
                                }


                                break;
                            case WeightMethodCalculate.LengthAndDoubleThikness:

                                if (detail.Length.HasValue && !string.IsNullOrEmpty(position.StandartSize))
                                {
                                    position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                                    position.AdditionalMeasurement = ((double)detail.Length) / 1000 * detail.CountAll;
                                    position.Weight = position.AdditionalMeasurement * ConvertStandartSize(position.StandartSize) *
                                                      ConvertStandartSize(position.StandartSize) * Density / 1000;
                                }
                                else
                                {
                                    Log?.AppendMessage("Поле Длина и/или Типоразмер не заполнено в соответствии выбранному методу вычисления по типу ГОСТа " + gost.Name);
                                }
                                break;
                        }

                        position.WeightWithWaste = position.Weight / position.UtilizationRatio;
                        position.AdditionalMeasurementWithWaste = position.AdditionalMeasurement /
                                                                  position.UtilizationRatio;

                        break;

                        case ExtraDimensions.Piece:
                        position.Weight = 0;
                        position.WeightWithWaste = 0;
                        position.UtilizationRatio = 1;

                        position.TypeAdditionalMeasurement = gost.TypeExtraDimension;
                        position.AdditionalMeasurement = detail.CountAll;
                        position.AdditionalMeasurementWithWaste = detail.CountAll;
                        break;
                }

                standart.Positions.Add(position);
            }

            return standart;
        }


        /// <summary>
        ///     Сгруппировать позиции нормы на сборку
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
                                                      AdditionalMeasurementWithWaste = grPosition.Sum(x => x.AdditionalMeasurementWithWaste) ,
                                                      Weight = grPosition.Sum(x => x.Weight),
                                                      WeightWithWaste = grPosition.Sum(x => x.WeightWithWaste),
                                                      UtilizationRatio = DefaultUtilizationRatio,
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
            var chars = standartSize.TakeWhile(char.IsDigit).ToArray();
            return Convert.ToDouble(new string(chars));
        }
    }
}