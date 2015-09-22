using System.Collections.Generic;
using System.Linq;
using Core.Interfaces;

namespace Core.DomainModel
{
    /// <summary>
    /// ГОСТ
    /// </summary>
    public class Gost : IEntity
    {
        public Gost()
        {
            StandartWeights = new List<StandartWeight>();
            TypeExtraDimension = ExtraDimensions.SquareMeter;
            WeightMethodCalculate = WeightMethodCalculate.LengthAndWidth;
        }

        /// <summary>
        ///     Дополнительная единица измерения
        /// </summary>
        public ExtraDimensions TypeExtraDimension { get; set; }

        /// <summary>
        /// Метод расчета веса
        /// </summary>
        public WeightMethodCalculate WeightMethodCalculate { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        ///     Веса по типоразмерам
        /// </summary>
        public List<StandartWeight> StandartWeights { get; set; }

        /// <summary>
        /// Профиль
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
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


    /// <summary>
    /// Вес одного метра типоразмера по таблицам справочников
    /// </summary>
    public class StandartWeight
    {
        public string StandartSize { get; set; }
        public double Weight { get; set; }
    }
}