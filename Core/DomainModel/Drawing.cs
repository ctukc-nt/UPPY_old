using System.Drawing;
using Core.Interfaces;

namespace Core.DomainModel
{
    public class Drawing : IEntity
    {
        /// <summary>
        ///     Родитель
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        ///     Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Обозначение
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        ///     Номер по спецификации
        /// </summary>
        public uint? NumberOnSpec { get; set; }

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

        /// <summary>
        ///     ГОСТ на материал
        /// </summary>
        public string GostOnMaterial { get; set; }

        /// <summary>
        ///     Длина
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        ///     Ширина
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        ///     Кол-во
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        ///     Кол-во всего
        /// </summary>
        public int CountAll { get; set; }

        /// <summary>
        ///     Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        ///     Вес всего
        /// </summary>
        public double WeightAll { get; set; }

        /// <summary>
        ///     Отправочная позиция
        /// </summary>
        /// public string OP { get; set; }
        /// <summary>
        ///     Входит в...
        /// </summary>
        public int? PartOfDrawingId { get; set; }

        /// <summary>
        ///     Технологический маршрут
        /// </summary>
        public int? TechRouteId { get; set; }

        /// <summary>
        ///     ИД
        /// </summary>
        public int? Id { get; set; }

        public int CompareByStandartSize(Drawing doc2)
        {
            return 0;
        }

        /// <summary>
        /// Цвет метки
        /// </summary>
        public Color Color { get; set; }

        public FileDrawingInfo FileDrawingInfo { get; set; }
    }

    public class FileDrawingInfo
    {
        public string Hash { get; set; }

        public string Extension { get; set; }
    }
}