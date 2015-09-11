using System;
using System.Globalization;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class FieldsNormalizer:IFieldsNormalizer
    {
        public string RemoveUnUseInfoAboutMarkSteal(string markSteal)
        {
            markSteal = markSteal.Replace("345-", "");
            markSteal = markSteal.Replace("325-", "");
            markSteal = markSteal.Replace("295-", "");
            markSteal = markSteal.Replace("265-", "");
            markSteal = markSteal.Replace("-6", "");
            markSteal = markSteal.Replace("09G2S", "09Г2С");
            markSteal = markSteal.Replace("Cт20", "Ст20");
            markSteal = markSteal.Replace("Cт20", "Ст20");
            markSteal = markSteal.Replace("X5CRNI18-10", "08Х18Н10");

            return markSteal;
        }

        public string NormalizePositionNumber(string numberBySpec)
        {
            var posNumber = numberBySpec.Trim();
            try
            {
                return Convert.ToUInt32(posNumber).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return numberBySpec;
            }
        }

        public string SetEmptySpacesGost(string gost)
        {
            var result = gost;
            result = result.Replace(" ", "");
            if (result.ToUpper().Contains("ГОСТ"))
            {
                result = result.Replace("ГОСТ", "ГОСТ ");
            }

            if (result.ToUpper().Contains("SN"))
            {
                result = result.Replace("SN", "SN ");
            }

            if (result.ToUpper().Contains("EN"))
            {
                result = result.Replace("EN", "EN ");
            }

            if (result.ToUpper().Contains("DIN"))
            {
                result = result.Replace("DIN", "DIN ");
            }

            if (result.ToUpper().Contains("GOST"))
            {
                result = result.Replace("ГОСТ", "ГОСТ ");
            }

            if (result.ToUpper().Contains("ISO"))
            {
                result = result.Replace("ISO", "ISO ");
            }

            return result;

        }
    }
}
