using System;
using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;

namespace Core
{
    public class DrawingsToStandartHelper
    {

        private double _density = 7.85;

        private char[] _splittersStandartSize = new[] { 'X', 'Х' };

        /// <summary>
        /// Плотность
        /// </summary>
        public double Density
        {
            get { return _density; }
            set { _density = value; }
        }

        public char[] SplittersStandartSize
        {
            get { return _splittersStandartSize; }
            set { _splittersStandartSize = value; }
        }

        public Standart CreateStandartByDrawing(Drawing headDrawing, IHierClassDataManager<Drawing> dataManager, List<Gost> gosts)
        {
            var allChildrens = dataManager.GetListAllChildrens(headDrawing.Id);
            var allParentId = allChildrens.Select(x => x.ParentId);
            var allDetails = allChildrens.Where(x => allParentId.Any(y => y.HasValue && y.Value == x.Id));

            var standart = new Standart();

            foreach (Drawing detail in allDetails)
            {
                var position = new PostitionStandart();
                position.Profile = detail.Profile;
                if (string.IsNullOrWhiteSpace(position.Profile))
                    position.Profile = detail.Name;

                position.StandartSize = detail.StandartSize;
                position.GostOnSort = detail.GostOnSort;
                position.MarkSteal = detail.MarkSteal;
                position.UtilizationRatio = 0.8;
                position.Weight = 0;

                var dimensions = position.StandartSize.ToUpper().Split(_splittersStandartSize);
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
                    default:
                        break;
                }

                position.WeighWithWaste = position.Weight / position.UtilizationRatio;



            }

            return standart;

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