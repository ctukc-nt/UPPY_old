using System;
using System.Globalization;
using System.Linq;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class MaterialParser : IMaterialParser
    {
        private static readonly string DecimalSeparator =
            CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

        public int? GetWidth(Position position)
        {
            var varDim = position.ARTARTVarDim;

            if (!string.IsNullOrWhiteSpace(varDim) && varDim.ToLower().Contains("dm"))
            {
                return GetLength(position);
            }

            var itemWidth = GetStringItemFromPosition(position, ItemsChoiceType.ARTARTRM2);
            if (!string.IsNullOrWhiteSpace(itemWidth))
                return GetInt(itemWidth);

            return null;
        }

        public int? GetLength(Position position)
        {
            var itemLength = GetStringItemFromPosition(position, ItemsChoiceType.ARTARTRM1);
            if (!string.IsNullOrWhiteSpace(itemLength))
                return GetInt(itemLength);

            return null;
        }

        public string GetMarkSteal(Position position)
        {
            var ident = GetMaterialIdentification(position);

            var splittedIdent = ident.Split('=');
            if (splittedIdent.Length == 3)
            {
                return splittedIdent[1];
            }

            return string.Empty;
        }

        public string GetGOSTS(Position position)
        {
            var ident = GetMaterialIdentification(position);

            if (string.IsNullOrWhiteSpace(ident))
                return string.Empty;

            if (ident.Contains("TUN") || ident.Contains("SN"))
            {
                return string.Empty;
            }

            var splittedIdent = ident.Split('=');
            if (splittedIdent.Length == 3 || splittedIdent.Length == 4)
            {
                return splittedIdent[0];
            }

            return string.Empty;
        }

        public string GetStandartSize(Position position)
        {
            var ident = GetMaterialIdentification(position);

            if (string.IsNullOrWhiteSpace(ident))
                return string.Empty;

            if (ident.Contains("TUN") || ident.Contains("SN"))
            {
                return string.Empty;
            }

            var splittedIdent = ident.Split('=');
            if (splittedIdent.Length == 3)
            {
                return splittedIdent[2];
            }

            if (splittedIdent.Length == 4)
            {
                return splittedIdent[1];
            }

            return string.Empty;
        }

        public string GetDesignation(Position position)
        {
            var ident = GetMaterialIdentification(position).ToUpper();

            if (string.IsNullOrWhiteSpace(ident))
                return string.Empty;

            if (ident.Contains("TUN") || ident.Contains("SN"))
            {
                var firstPos = string.Empty;
                var secondPos = string.Empty;

                var splitted = ident.Split('=');
                if (splitted.Length == 3 || splitted.Length == 4)
                {
                    firstPos = splitted[0];
                }

                if (splitted.Length == 3)
                {
                    secondPos = splitted[2];
                }

                if (splitted.Length == 4)
                {
                    secondPos = splitted[1];
                }

                return $"{firstPos}={secondPos}".Trim();
            }


            return string.Empty;
        }

        private static int GetInt(string str)
        {
            try
            {
                return Convert.ToInt32(Convert.ToDecimal(str.Replace(".", DecimalSeparator).Replace(",", DecimalSeparator)));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private static string GetStringItemFromPosition(Position position, ItemsChoiceType itemsChoice)
        {
            var indItemChoice = position.ItemsElementName.ToList().FindIndex(x => x == itemsChoice);
            return indItemChoice >= 0 ? position.Items[indItemChoice] : null;
        }

        private static string GetMaterialIdentification(Position position)
        {
            return string.IsNullOrWhiteSpace(position.ARTARTLtNormLocLn5)
                ? (string.IsNullOrWhiteSpace(position.ARTARTStdDes) ? string.Empty : position.ARTARTStdDes)
                : position.ARTARTLtNormLocLn5;
        }
    }
}