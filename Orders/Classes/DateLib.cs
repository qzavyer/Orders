using System;
using Orders.Models;

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

        public static DatePeriod MonthPeriod(this DateTime date)
        {
            var period = new DatePeriod();
            var dateMonthStart = new DateTime(date.Year, date.Month, 1);
            var dateMonthEnd = dateMonthStart.AddMonths(1);
            period.Start = dateMonthStart;
            period.End = dateMonthEnd;
            return period;
        }

        public static DatePeriod YearPeriod(this DateTime date)
        {
            var period = new DatePeriod();
            var dateYearStart = new DateTime(date.Year, 1, 1);
            var dateYearEnd = dateYearStart.AddYears(1);
            period.Start = dateYearStart;
            period.End = dateYearEnd;
            return period;
        }
    }
}
