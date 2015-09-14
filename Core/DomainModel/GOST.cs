using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.DomainModel
{
    public class Gost:IEntity
    {

        public Gost()
        {
            StandartWeights = new List<StandartWeight>();
        }


        /// <summary>
        /// Дополнительная единица измерения
        /// </summary>
        public ExtraDimensions TypeExtraDimension { get; set; }

        public WeightMethodCalculate WeightMethodCalculate { get; set; }

        public string Name { get; set; }

        public string Note { get; set; }

        /// <summary>
        /// Веса по типоразмерам
        /// </summary>
        public List<StandartWeight> StandartWeights { get; set; }

        /// <summary>
        /// Получить вес по таблице
        /// </summary>
        /// <param name="standartSize"></param>
        /// <returns></returns>
        public StandartWeight GetStandartWeight(string standartSize)
        {
            return
                StandartWeights.FirstOrDefault(
                    x =>
                        x.StandartSize.ToLower().Replace("x", "").Replace("х", "") ==
                        standartSize.ToLower().Replace("x", "").Replace("х", ""));
        }

        public int? Id { get; set; }

        public string Profile { get; set; }
    }

    public class StandartWeight
    {
        public string StandartSize { get; set; }

        public double Weight { get; set; }
    }

    public enum WeightMethodCalculate
    {
        /// <summary>
        /// Длина
        /// </summary>
        Length,

        /// <summary>
        /// Длина и ширина (кв. м.)
        /// </summary>
        LengthAndWidth,

        /// <summary>
        /// Длина и толщина (трубы)
        /// </summary>
        LengthAndThikness,

        /// <summary>
        /// Длина и толщина (круги)
        /// </summary>
        LengthAndDoubleThikness,

        /// <summary>
        /// По таблицам ГОСТа
        /// </summary>
        ByTable
    }
}
