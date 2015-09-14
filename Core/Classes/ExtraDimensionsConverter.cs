using System;
using System.ComponentModel;
using System.Globalization;
using Core.DomainModel;

namespace Core.Classes
{
    public class ExtraDimensionsConverter : EnumConverter
    {
        public ExtraDimensionsConverter()
            : base(
                typeof(ExtraDimensions))
        {
        }

        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture, object value,
            Type destinationType)
        {
            if (destinationType == typeof(string) && value is ExtraDimensions)
            {
                var valueEnum = (ExtraDimensions)value;
                switch (valueEnum)
                {
                    case ExtraDimensions.Meters:
                        return "Пог. м.";

                    case ExtraDimensions.SquareMeter:
                        return "Кв. м.";

                    case ExtraDimensions.Piece:
                        return "Шт.";
                }

                return value; // your code here
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}