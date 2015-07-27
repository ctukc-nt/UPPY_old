using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModel
{
    class PostitionsStandarts
    {
        /// <summary>
        ///     Профиль
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        ///     Типоразмер
        /// </summary>
        public string StandartSize { get; set; }

        /// <summary>
        ///     ГОСТ на сортамент
        /// </summary>
        public string GostOnSort { get; set; }

        /// <summary>
        ///     Марка стали
        /// </summary>
        public string MarkSteal { get; set; }

        public double UtilizationRatio { get; set; }
        
        public double Weight { get; set; }

        public double WeighWithWaste { get; set; }

        public double AdditionalMeasurement { get; set; }

        public string TypeAdditionalMeasurement { get; set; }

        public string Note { get; set; }

    }
}
