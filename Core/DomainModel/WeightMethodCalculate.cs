using System.ComponentModel;
using Core.Classes;

namespace Core.DomainModel
{
    [TypeConverter(typeof(WeightMethodCalculateConverter))]
    public enum WeightMethodCalculate
    {
        /// <summary>
        ///     Длина
        /// </summary>
        Length,

        /// <summary>
        ///     Длина и ширина (кв. м.)
        /// </summary>
        LengthAndWidth,

        /// <summary>
        ///     Длина и толщина (трубы)
        /// </summary>
        LengthAndThikness,

        /// <summary>
        ///     Длина и толщина (круги)
        /// </summary>
        LengthAndDoubleThikness,

        /// <summary>
        ///     По таблицам ГОСТа
        /// </summary>
        ByTable
    }
}