using System.Collections.Generic;
using Core.Interfaces;

namespace Core.DomainModel
{
    /// <summary>
    ///     Технологический маршрут изделия
    /// </summary>
    public class TechRoute : IEntity
    {
        /// <summary>
        /// ИД
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        ///     Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Список технологических операций
        /// </summary>
        public List<TechOperation> TechOperations { get; set; }

        public string Note { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}