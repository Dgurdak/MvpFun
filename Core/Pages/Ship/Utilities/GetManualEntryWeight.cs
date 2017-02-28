using System.Collections.Generic;

namespace Core.Pages.Ship.Utilities
{
    public static class GetManualEntryWeight
    {
        public static KeyValuePair<bool, decimal> Execute(string strManualEntryValue)
        {
            if (strManualEntryValue.Length == 0)
                return new KeyValuePair<bool, decimal>(false, 0);

            decimal decWeight;
            if (!decimal.TryParse(strManualEntryValue, out decWeight))
                return new KeyValuePair<bool, decimal>(false, 0);

            return new KeyValuePair<bool, decimal>(true, decWeight);
        }
    }
}