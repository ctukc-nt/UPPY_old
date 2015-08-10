using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModel
{
    public class PostitionStandart
    {/// <summary>
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

        /// <summary>
        /// Коэффициент использования
        /// </summary>
        public double UtilizationRatio { get; set; }
        
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Вес с отходом
        /// </summary>
        public double WeighWithWaste { get; set; }

        /// <summary>
        /// Дополнительная единица измерения
        /// </summary>
        public double AdditionalMeasurement { get; set; }

        /// <summary>
        /// Тип дополнительной единицы измерения
        /// </summary>
        public ExtraDimensions TypeAdditionalMeasurement { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

    }
}
