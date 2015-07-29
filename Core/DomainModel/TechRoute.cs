﻿using System.Collections.Generic;
using Core.Interfaces;

namespace Core.DomainModel
{
    /// <summary>
    ///     Технологический маршрут изделия
    /// </summary>
    public class TechRoute : IEntity
    {
        public TechRoute()
        {
            TechOperations = new List<TechOperation>();
        }

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

        /// <summary>
        /// Создаёт имя тех маршрута по тех. операции
        /// </summary>
        public void CreateNameByTechOperations()
        {
            
        }
    }
}