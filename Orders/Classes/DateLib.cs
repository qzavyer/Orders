using System;

namespace Orders.Classes
{
    internal static class DateLib
    {
        private static readonly DateTime Date = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        public static int ToSqlDate(this DateTime date)
        {
            return (int) (date - Date).TotalSeconds;
        }

        public static DateTime ToDateTime(this int sqlDate)
        {
            return Date.AddSeconds(sqlDate);
        }
    }
}
