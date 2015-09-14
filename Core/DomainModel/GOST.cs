using System.Collections.Generic;
using System.Linq;
using Core.Interfaces;

namespace Core.DomainModel
{
    public class Gost : IEntity
    {
        public Gost()
        {
            StandartWeights = new List<StandartWeight>();
        }

        /// <summary>
        ///     Дополнительная единица измерения
        /// </summary>
        public ExtraDimensions TypeExtraDimension { get; set; }

        public WeightMethodCalculate WeightMethodCalculate { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        /// <summary>
        ///     Веса по типоразмерам
        /// </summary>
        public List<StandartWeight> StandartWeights { get; set; }

        public string Profile { get; set; }
        public int? Id { get; set; }

        /// <summary>
        ///     Получить вес по таблице
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
    }

    public class StandartWeight
    {
        public string StandartSize { get; set; }
        public double Weight { get; set; }
    }
}