using System;
using System.ComponentModel;
using System.Globalization;
using Core.DomainModel;

namespace Core.Classes
{
    public class WeightMethodCalculateConverter : EnumConverter
    {
        public WeightMethodCalculateConverter()
            : base(
                typeof(WeightMethodCalculate))
        {
        }

        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture, object value,
            Type destinationType)
        {
            if (destinationType == typeof(string) && value is WeightMethodCalculate)
            {
                var valueEnum = (WeightMethodCalculate)value;
                switch (valueEnum)
                {
                    case WeightMethodCalculate.Length:
                        return "Длина и сечение (круг)";

                    case WeightMethodCalculate.LengthAndDoubleThikness:
                        return "Длина и сечение (квадрат)";

                    case WeightMethodCalculate.LengthAndThikness:
                        return "Длина и толщина стенки (труба)";

                    case WeightMethodCalculate.LengthAndWidth:
                        return "Длина и ширина";

                    case WeightMethodCalculate.ByTable:
                        return "По таблице";
                }

                return value; // your code here
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}