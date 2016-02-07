using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            var monthWorkLst = new List<EWork>();
            try
            {
                var month = date.MonthPeriod();
                var workExecuter = new WorkExecuter();
                monthWorkLst = workExecuter.GetPeriodWorks(month).ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return monthWorkLst;
        }

        /// <summary>
        /// Получить работы за год
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<EWork> GetYearWorks(DateTime date)
        {
            var monthWorkLst = new List<EWork>();
            try
            {
                var year = date.YearPeriod();
                var workExecuter = new WorkExecuter();
                monthWorkLst = workExecuter.GetPeriodWorks(year).ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return monthWorkLst;
        }

        /// <summary>
        /// Получить расходы за месяц
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECons> GetMonthConses(DateTime date)
        {
            var monthConses = new List<ECons>();
            try
            {
                var month = date.MonthPeriod();
                var consExecuter = new ConsExecuter();
                monthConses = consExecuter.GetPeriodConses(month).ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return monthConses;
        }

        /// <summary>
        /// Получить расходы за указанный год
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECons> GetYearConses(DateTime date)
        {
            var yearConses = new List<ECons>();
            try
            {
                var year = date.YearPeriod();
                var consExecuter = new ConsExecuter();
                yearConses = consExecuter.GetPeriodConses(year).ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return yearConses;
        }

        /// <summary>
        /// Получить все сертификаты за месяц
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECert> GetMonthCerts(DateTime date)
        {
            var lst = new List<ECert>();
            try
            {
                var month = date.MonthPeriod();
                var certExecuter = new CertExecuter();
                lst = certExecuter.GetPeriodCerts(month).ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return lst;
        }

        /// <summary>
        /// Получить сертификаты за год
        /// </summary>
        /// <param name="date">Дата, входящая в исследуемый период</param>
        public static IEnumerable<ECert> GetYearCerts(DateTime date)
        {
            var lst = new List<ECert>();
            try
            {
                var year = date.YearPeriod();
                var certExecuter = new CertExecuter();
                lst = certExecuter.GetPeriodCerts(year).ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return lst;
        }

        /// <summary>
        /// Получить все сертификаты
        /// </summary>
        public static IEnumerable<ECert> GetCerts()
        {
            var lst = new List<ECert>();
            try
            {
                var certExecuter = new CertExecuter();
                lst = certExecuter.GetUnworkedCerts().ToList();
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return lst;
        }

        /// <summary>
        /// Получить должников
        /// </summary>
        public static IEnumerable<EWork> GetDuty()
        {
            var lst = new SortableBindingList<EWork>();
            try
            {
                var workExecuter = new WorkExecuter();
                var list = workExecuter.GetDuty().ToList();
                lst = new SortableBindingList<EWork>(list);
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
            return lst;
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
