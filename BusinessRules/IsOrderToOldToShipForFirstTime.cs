using System;

namespace BusinessRules
{
    public static class IsOrderToOldToShipForFirstTime
    {
        public static bool Execute(DateTime dtOrderDate)
        {
            if ((DateTime.Now - dtOrderDate).TotalDays > 30) return true;

            return false;
        }
    }
}