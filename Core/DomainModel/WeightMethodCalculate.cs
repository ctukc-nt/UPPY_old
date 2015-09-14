using System.ComponentModel;
using Core.Classes;

namespace Core.DomainModel
{
    [TypeConverter(typeof(WeightMethodCalculateConverter))]
    public enum WeightMethodCalculate
    {
        /// <summary>
        ///     �����
        /// </summary>
        Length,

        /// <summary>
        ///     ����� � ������ (��. �.)
        /// </summary>
        LengthAndWidth,

        /// <summary>
        ///     ����� � ������� (�����)
        /// </summary>
        LengthAndThikness,

        /// <summary>
        ///     ����� � ������� (�����)
        /// </summary>
        LengthAndDoubleThikness,

        /// <summary>
        ///     �� �������� �����
        /// </summary>
        ByTable
    }
}