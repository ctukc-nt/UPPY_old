using System.ComponentModel;
using Core.Classes;

namespace Core.DomainModel
{
    [TypeConverter(typeof(ExtraDimensionsConverter))]
    public enum ExtraDimensions
    {
        /// <summary>
        /// Метры погонные
        /// </summary>
        Meters,
        /// <summary>
        /// Метры квадратные
        /// </summary>
        SquareMeter,

        /// <summary>
        /// Штуки
        /// </summary>
        Piece,

        
    }
}