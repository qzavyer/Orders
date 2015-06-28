using System;

namespace Orders
{
    static class DateLib
    {
        private static readonly DateTime Date = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        public static int GetDateInt(DateTime date)
        {
            return (int)((date - Date).TotalSeconds);
        }

        public static DateTime GetDateFromInt(int intDate)
        {
            return Date.AddSeconds(intDate);
        }
    }
}
