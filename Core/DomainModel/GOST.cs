using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModel
{
    public class Gost
    {
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
    }

    internal class StandartWeight
    {
        public string StandartSize { get; set; }

        public double Weight { get; set; }
    }

    internal enum WeightMethodCalculate
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
        LengthAndThikness
    }
}
