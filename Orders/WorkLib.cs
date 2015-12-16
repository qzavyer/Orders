﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Orders.Classes;

namespace Orders
{
    public static class WorkLib
    {
        public static IEnumerable<EWork> GetMonthWorks(DateTime date)
        {
            using (var db = new OrderContext())
            {
                var monthWorkLst = new List<EWork>();
                try
                {
                    var dateMonthStart = new DateTime(date.Year, date.Month, 1);
                    var dateMonthEnd = dateMonthStart.AddMonths(1);
                    var dateMonthStartInt = DateLib.GetDateInt(dateMonthStart);
                    var dateMonthEndInt = DateLib.GetDateInt(dateMonthEnd);
                    // список всех работ за месяц
                    monthWorkLst = db.Works
                        .Where(w => w.datePay >= dateMonthStartInt && w.datePay < dateMonthEndInt)
                        .Include(r => r.Client).Include(r => r.Source)
                        .Include(r => r.Type).ToList();
                    foreach (var eWork in monthWorkLst)
                    {
                        eWork.Cons = db.Conses.Where(r => r.WorkId == eWork.Id).ToList().Sum(r => r.Amount);
                    }
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return monthWorkLst;
            }
        }

        public static IEnumerable<EWork> GetYearWorks(DateTime date)
        {
            using (var db = new OrderContext())
            {
                var monthWorkLst = new List<EWork>();
                try
                {
                    var dateYearStart = new DateTime(date.Year, 1, 1);
                    var dateYearEnd = dateYearStart.AddYears(1);
                    var dateYearStartInt = DateLib.GetDateInt(dateYearStart);
                    var dateYearEndInt = DateLib.GetDateInt(dateYearEnd);
                    // список всех работ за год
                    monthWorkLst = db.Works.Where(w =>
                        w.datePay >= dateYearStartInt && w.datePay < dateYearEndInt)
                        .Include(r => r.Client)
                        .Include(r => r.Source)
                        .Include(r => r.Type)
                        .ToList();
                    foreach (var eWork in monthWorkLst)
                    {
                        eWork.Cons = db.Conses.Where(r => r.WorkId == eWork.Id).ToList().Sum(r => r.Amount);
                    }
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return monthWorkLst;
            }
        }

        public static IEnumerable<ECons> GetMonthConses(DateTime date)
        {
            using (var db = new OrderContext())
            {
                var monthWorkLst = new List<ECons>();
                try
                {
                    var dateMonthStart = new DateTime(date.Year, date.Month, 1);
                    var dateMonthEnd = dateMonthStart.AddMonths(1);
                    var dateMonthStartInt = DateLib.GetDateInt(dateMonthStart);
                    var dateMonthEndInt = DateLib.GetDateInt(dateMonthEnd);
                    // список всех расходов за месяц
                    monthWorkLst = db.Conses.Where(w =>
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
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return monthWorkLst;
            }
        }

        public static IEnumerable<ECons> GetYearConses(DateTime date)
        {
            using (var db = new OrderContext())
            {
                var monthWorkLst = new List<ECons>();
                try
                {
                    var dateYearStart = new DateTime(date.Year, 1, 1);
                    var dateYearEnd = dateYearStart.AddYears(1);
                    var dateYearStartInt = DateLib.GetDateInt(dateYearStart);
                    var dateYearEndInt = DateLib.GetDateInt(dateYearEnd);
                    // список всех расходов за год
                    monthWorkLst = db.Conses.Where(w =>
                        w.date >= dateYearStartInt && w.date < dateYearEndInt)
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
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return monthWorkLst;
            }
        }

        public static IEnumerable<ECert> GetCerts(DateTime date)
        {
            using (var db = new OrderContext())
            {
                var lst = new List<ECert>();
                try
                {
                    var dateMonthStart = new DateTime(date.Year, date.Month, 1);
                    var dateMonthEnd = dateMonthStart.AddMonths(1);
                    var dateMonthStartInt = DateLib.GetDateInt(dateMonthStart);
                    var dateMonthEndInt = DateLib.GetDateInt(dateMonthEnd);
                    // список всех расходов за год
                    lst = db.Certs.Where(w =>
                        w.datePay >= dateMonthStartInt && w.datePay < dateMonthEndInt)
                        .Include(r => r.Type).Include(r => r.Client).Include(r => r.Payer).Include(r => r.Source)
                        .OrderBy(r => r.datePay)
                        .ToList();
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return lst;
            }
        }

        public static IEnumerable<ECert> GetCerts()
        {
            using (var db = new OrderContext())
            {
                var lst = new List<ECert>();
                try
                {
                    var workLst = db.Works.Select(r => r.CertId).ToList();
                    lst = db.Certs.Where(w => !workLst.Contains(w.Id))
                        .Include(r => r.Type).Include(r => r.Client).Include(r => r.Payer).Include(r => r.Source)
                        .OrderBy(r => r.datePay)
                        .ToList();
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return lst;
            }
        }

        public static IEnumerable<ECert> GetYearCerts(DateTime date)
        {
            using (var db = new OrderContext())
            {
                var lst = new List<ECert>();
                try
                {
                    var dateYearStart = new DateTime(date.Year, 1, 1);
                    var dateYearEnd = dateYearStart.AddYears(1);
                    var dateYearStartInt = DateLib.GetDateInt(dateYearStart);
                    var dateYearEndInt = DateLib.GetDateInt(dateYearEnd);
                    // список всех расходов за год
                    lst = db.Certs.Where(w =>
                        w.datePay >= dateYearStartInt && w.datePay < dateYearEndInt).ToList();
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return lst;
            }
        }

        public static IEnumerable<EWork> GetDuty()
        {
            using (var db = new OrderContext())
            {
                var lst = new SortableBindingList<EWork>();
                try
                {
                    var list = db.Works.Where(r => r.Duty > 0)
                        .Include(r => r.Type).Include(r => r.Client)
                        .ToList();
                    list.Sort((item1, item2) => item1.DatePay.CompareTo(item2.DatePay));
                    lst = new SortableBindingList<EWork>(list);
                }
                catch (Exception exception)
                {
                    var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                    if (declaringType != null)
                    {
                        var cName = declaringType.Name;
                        var mName = MethodBase.GetCurrentMethod().Name;
                        Errors.SaveError(exception, cName + "/" + mName);
                    }
                }
                return lst;
            }
        } 

        public static DateTime? GetMinDate()
        {
            using (var db = new OrderContext())
            {
                if (!db.Works.Any()) return null;
                var mindate = db.Works.Min(r => r.datePay);
                if (mindate == 0) return null;
                return DateLib.GetDateFromInt(mindate);
            }
        }
    }
}