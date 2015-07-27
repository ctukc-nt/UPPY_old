using System.Collections.Generic;
using Core.Interfaces;

namespace Core.DomainModel
{
    public class Standart : IEntity
    {
        /// <summary>
        /// Коэффициент использования
        /// </summary>
        public double UtilizationRatio { get; set; }

        /// <summary>
        /// Сборка
        /// </summary>
        public Drawing Drawing { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Позиции
        /// </summary>
        public List<PostitionStandart> Positions { get; set; }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int? Id { get; set; }
    }
}