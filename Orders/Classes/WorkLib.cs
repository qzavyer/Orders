using System;
using System.Collections.Generic;
using System.Linq;
using Orders.Executers;
using Orders.Models;

namespace Orders.Classes
{
    public static class WorkLib
    {
        /// <summary>
        /// Получить работы за месяц
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<EWork> GetMonthWorks(DateTime date)
        {
            var month = date.MonthPeriod();
            var workExecuter = new WorkExecuter();
            return workExecuter.GetPeriodWorks(month).ToList();
        }

        /// <summary>
        /// Получить работы за год
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<EWork> GetYearWorks(DateTime date)
        {
            var year = date.YearPeriod();
            var workExecuter = new WorkExecuter();
            return workExecuter.GetPeriodWorks(year).ToList();
        }

        /// <summary>
        /// Получить расходы за месяц
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECons> GetMonthConses(DateTime date)
        {
            var month = date.MonthPeriod();
            var consExecuter = new ConsExecuter();
            return consExecuter.GetPeriodConses(month).ToList();
        }

        /// <summary>
        /// Получить расходы за указанный год
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECons> GetYearConses(DateTime date)
        {
            var year = date.YearPeriod();
            var consExecuter = new ConsExecuter();
            return consExecuter.GetPeriodConses(year).ToList();
        }

        /// <summary>
        /// Получить все сертификаты за месяц
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECert> GetMonthCerts(DateTime date)
        {
            var month = date.MonthPeriod();
            var certExecuter = new CertExecuter();
            return certExecuter.GetPeriodCerts(month).ToList();
        }

        /// <summary>
        /// Получить сертификаты за год
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECert> GetYearCerts(DateTime date)
        {
            var year = date.YearPeriod();
            var certExecuter = new CertExecuter();
            return certExecuter.GetPeriodCerts(year).ToList();
        }

        /// <summary>
        /// Получить все сертификаты
        /// </summary>
        public static IEnumerable<ECert> GetCerts()
        {
            var certExecuter = new CertExecuter();
            return certExecuter.GetUnworkedCerts().ToList();
        }

        /// <summary>
        /// Получить должников
        /// </summary>
        public static IEnumerable<EWork> GetDuty()
        {
            var workExecuter = new WorkExecuter();
            var list = workExecuter.GetDuty().ToList();
            return new SortableBindingList<EWork>(list);
        }

        /// <summary>
        /// Получение минимальной даты в базе
        /// </summary>
        public static DateTime? GetMinDate()
        {
            var workExecuter = new WorkExecuter();
            return workExecuter.GetMinDate();
        }
    }
}
