using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Orders
{
    public static class WorkLib
    {
        

        public static IEnumerable<EWork> GetMonthWorks(DateTime date)
        {
            OrderContext Db = new OrderContext();
            var monthWorkLst = new List<EWork>();
            try
            {
                var dateMonthStart = new DateTime(date.Year, date.Month, 1);
                var dateMonthEnd = dateMonthStart.AddMonths(1);
                var dateMonthStartInt = DateLib.GetDateInt(dateMonthStart);
                var dateMonthEndInt = DateLib.GetDateInt(dateMonthEnd);
                // список всех работ за месяц
                    monthWorkLst = Db.Works
                    .Where(w =>w.datePay >= dateMonthStartInt && w.datePay < dateMonthEndInt)
                    .Include(r => r.Client)
                    .Include(r => r.Source)
                    .Include(r => r.Type)
                    .ToList();
                foreach (var eWork in monthWorkLst)
                {
                    eWork.Cons = Db.Conses.Where(r => r.WorkId == eWork.Id).ToList().Sum(r => r.Amount);
                }
            }
            catch(Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception.Message, cName + "/" + mName);
                }
            }
            return monthWorkLst;
        }

        public static IEnumerable<EWork> GetYearWorks(DateTime date)
        {
            OrderContext Db = new OrderContext();
            var monthWorkLst = new List<EWork>();
            try
            {
                var dateYearStart = new DateTime(date.Year, 1, 1);
                var dateYearEnd = dateYearStart.AddYears(1);
                var dateYearStartInt = DateLib.GetDateInt(dateYearStart);
                var dateYearEndInt = DateLib.GetDateInt(dateYearEnd);
                // список всех работ за год
                monthWorkLst = Db.Works.Where(w =>
                    w.datePay >= dateYearStartInt && w.datePay < dateYearEndInt)
                    .Include(r => r.Client)
                    .Include(r => r.Source)
                    .Include(r => r.Type)
                    .ToList();
                foreach (var eWork in monthWorkLst)
                {
                    eWork.Cons = Db.Conses.Where(r => r.WorkId == eWork.Id).ToList().Sum(r => r.Amount);
                }
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception.Message, cName + "/" + mName);
                }
            }
            return monthWorkLst;
        }

        public static IEnumerable<ECons> GetMonthConses(DateTime date)
        {
            OrderContext Db = new OrderContext();
            var monthWorkLst = new List<ECons>();
            try
            {
                var dateMonthStart = new DateTime(date.Year, date.Month, 1);
                var dateMonthEnd = dateMonthStart.AddMonths(1);
                var dateMonthStartInt = DateLib.GetDateInt(dateMonthStart);
                var dateMonthEndInt = DateLib.GetDateInt(dateMonthEnd);
                // список всех расходов за месяц
                monthWorkLst = Db.Conses.Where(w =>
                    w.date >= dateMonthStartInt && w.date < dateMonthEndInt)
                    .Include(r => r.Work)
                    .Include(r => r.Work.Type)
                    .Include(r => r.Type).OrderBy(r => r.date)
                    .ToList();
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception.Message, cName + "/" + mName);
                }
            }
            return monthWorkLst;
        }

        public static IEnumerable<ECons> GetYearConses(DateTime date)
        {
            OrderContext Db = new OrderContext();
            var monthWorkLst = new List<ECons>();
            try
            {
                var dateYearStart = new DateTime(date.Year, 1, 1);
                var dateYearEnd = dateYearStart.AddYears(1);
                var dateYearStartInt = DateLib.GetDateInt(dateYearStart);
                var dateYearEndInt = DateLib.GetDateInt(dateYearEnd);
                // список всех расходов за год
                monthWorkLst = Db.Conses.Where(w =>
                    w.date >= dateYearStartInt && w.date < dateYearEndInt)
                    .Include(r => r.Work)
                    .Include(r=>r.Work.Type)
                    .Include(r => r.Type).OrderBy(r => r.date)
                    .ToList();
            }
            catch (Exception exception)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(exception.Message, cName + "/" + mName);
                }
            }
            return monthWorkLst;
        }

        public static DateTime GetMinDate()
        {
            OrderContext Db = new OrderContext();
            var mindate = Db.Works.Min(r => r.datePay);
            return DateLib.GetDateFromInt(mindate);
        }
    }
}
