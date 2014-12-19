﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using Orders.Classes;
using Orders.Properties;

namespace Orders
{
    public partial class Form1 : Form
    {
        private DataTable _workType;
        private DataTable _consType;
        private DataTable _sourceType;
        private bool _hasChange = false;

        private enum TableCol
        {
            TypeColIndex = 3,
            NameColIndex = 4,
            PreDateColIndex = 6,
            ExDateColIndex = 9,
            ConsColIndex = 8,
            SourColIndex = 11,
            SertColIndex = 15,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS \"Id\",W.fClientId AS ClientId,Wt.fId AS \"Type\"," +
                                     "datetime(W.fDate, 'unixepoch') AS \"Date\",W.fPrepay AS \"Prepay\"," +
                                     "W.fExcess AS Excess,W.fCons AS Cons,W.fHours AS Hours,S.fId AS Source," +
                                     "W.fSertId AS Sert,C.fName AS Client,datetime(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "W.fConsTypeId AS ConsType " +
                                     "FROM tWork W JOIN tClient C ON W.fClientId=C.fId LEFT JOIN tConsType Ct ON W.fConsTypeId=Ct.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "ORDER BY \"Date\",Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);
                
                _workType = new DataTable();
                _sourceType = new DataTable();
                _consType = new DataTable();
                var adapter = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tWorkType",conn)};
                adapter.Fill(_workType);
                adapter.SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tSource", conn);
                adapter.Fill(_sourceType);
                adapter.SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tConsType", conn);
                adapter.Fill(_consType);

                //lst.Sort((item1,item2)=>DateTime.Compare(item1.Date, item2.Date));
                var mLst = new List<History>();
                var currDate = DateTime.Now;
                for (var i = 1; i <= 12; i++)
                {
                    mLst.Add(new History{Month = i});
                }
                
                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "cTypeA",
                    DataSource = _workType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = "Тип"
                };
                grWork.Columns.Insert((int) TableCol.TypeColIndex, combo);
                combo = new DataGridViewComboBoxColumn
                {
                    Name = "cSourceA",
                    DataSource = _sourceType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = "Источник"
                };
                grWork.Columns.Insert((int) TableCol.SourColIndex, combo);

                combo = new DataGridViewComboBoxColumn
                {
                    Name = "cConsA",
                    DataSource = _consType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = "Тип расх."
                };
                grWork.Columns.Insert((int)TableCol.ConsColIndex, combo);

                const string csCmd = "SELECT fTypeId AS \"Type\",fAmount AS Amount," +
                                     "datetime(fDate, 'unixepoch') AS \"Date\",fComment AS \"Comment\" " +
                                     "FROM tCons " +
                                     "WHERE fDate>=strftime('%s', :start) AND fDate<strftime('%s', :end)";
                var csCom = new SQLiteCommand(csCmd, conn);
                var curr = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                csCom.Parameters.AddWithValue("start", curr);
                csCom.Parameters.AddWithValue("end", curr.AddMonths(1));
                csCom.Prepare();
                var csTable = new DataTable();
                var csAdapt = new SQLiteDataAdapter(csCom);
                csAdapt.Fill(csTable);

                grCons.Columns.Insert(0, combo);
                foreach (DataRow row in csTable.Rows)
                {
                    var cons = new Cons(row);
                    var iRow = grCons.Rows[grCons.RowCount - 2].Cells;
                    iRow["csNumber"].Value = grCons.RowCount - 1;
                    iRow["csType"].Value = cons.Type;
                    iRow["csAmount"].Value = cons.Amount;
                    iRow["csDate"].Value = cons.Date;
                    iRow["csComment"].Value = cons.Comment;
                }

                var date = new CalendarColumn {Name = "cPreDate", HeaderText = Resources.Date, Width = 120};
                grWork.Columns.Insert((int)TableCol.PreDateColIndex, date);

                date = new CalendarColumn { Name = "cExDate", HeaderText = Resources.ExDate, Width = 120 };
                grWork.Columns.Insert((int)TableCol.ExDateColIndex, date);
                var inc = 0D;
                var con = 0D;
                var hrs = 0D;
                var yInc = 0D;
                var yCon = 0D;
                var yHrs = 0D;

                foreach (DataRow row in wkTable.Rows)
                {
                    var work = new Work(row);
                    foreach (var history in mLst)
                    {
                        if (history.Month == work.Date.Month && work.Date.Year == currDate.Year)
                        {
                            history.CIncome += work.Prepay + work.Excess;
                            break;
                        }
                        if (history.Month != work.Date.Month || work.Date.Year != currDate.Year - 1) continue;
                        history.LIncome += work.Prepay + work.Excess;
                        break;
                    }

                    if (work.Date.Year != currDate.Year) continue;
                    yInc += work.Prepay + work.Excess;
                    yCon += work.Cons;
                    yHrs += work.Hours;

                    if (work.Date.Month != currDate.Month) continue;
                    grWork.RowCount = grWork.RowCount + 1;
                    var iRow = grWork.Rows[grWork.RowCount - 2].Cells;
                    iRow["cNumber"].Value = grWork.RowCount - 1;
                    iRow["cId"].Value = work.Date;
                    iRow["cClientId"].Value = work.ClientId;
                    iRow["cClient"].Value = work.Client;
                    var c = iRow["cTypeA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Type;
                    iRow["cPreDate"].Value = work.Date.ToString("dd.MM.yyyy");
                    iRow["cPrepay"].Value = work.Prepay;
                    iRow["cExcess"].Value = work.Excess;
                    c = iRow["cConsA"] as DataGridViewComboBoxCell;
                    if (c != null && work.ConsType>0)
                        c.Value = work.ConsType;
                    iRow["cCons"].Value = work.Cons;
                    iRow["cHours"].Value = work.Hours;

                    c = iRow["cSourceA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Source;
                    iRow["cSert"].Value = work.Sert > 0;
                    iRow["cExDate"].Value = work.ExDate == null
                        ? ""
                        : work.ExDate.Value.ToString("dd.MM.yyyy");

                    inc += work.Prepay + work.Excess;
                    con += work.Cons;
                    hrs += work.Hours;
                }


                lMonthC.Text = currDate.ToString("MMMM");
                
                lIncomeC.Text = inc.ToString("C0");
                lConsC.Text = con.ToString("C0");
                lProfitC.Text = (inc - con).ToString("C0");
                lHoursC.Text = hrs.ToString("N0");

                lIncomeY.Text = yInc.ToString("C0");
                lConsY.Text = yCon.ToString("C0");
                lProfitY.Text = (yInc - yCon).ToString("C0");
                lHoursY.Text = yHrs.ToString("N0");
                lIncomeYA.Text = (yInc/currDate.Month).ToString("C0");
                
                lYearC.Text = currDate.Year.ToString("D");
                lYearL.Text = (currDate.Year-1).ToString("D");
                lSumCAll.Text = mLst.Sum(m => m.CIncome).ToString("C0");
                lSumLAll.Text = mLst.Sum(m => m.LIncome).ToString("C0");
                foreach (var history in mLst)
                {
                    Controls.Find("lSumC" + history.Month, true)[0].Text = history.CIncome.ToString("C0");
                    Controls.Find("lSumL" + history.Month, true)[0].Text = history.LIncome.ToString("C0");
                }
                _hasChange = false;
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }

      private void History_Click(object sender, EventArgs e)
        {
          if (_hasChange)
          {
              var svResult = MessageBox.Show("Данные были изменены. Сохранить?", "Orders", MessageBoxButtons.YesNo);
              if (svResult == DialogResult.Yes)
              {
                  SaveChanges();
              }
          }
            var button = sender as Button;
            if (button == null) return;
            GridMonthLoad(Convert.ToInt32(button.Tag), DateTime.Now.Year);
            _hasChange = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void grWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = sender as DataGridViewCell;
            //if (cell!=typeof(DataGridViewCheckBoxCell)) return;
            var iRow = e.RowIndex;
            var iCol = e.ColumnIndex;
            switch (iCol)
            {
                case (int)TableCol.SertColIndex:
                    {
                        
                        if (grWork.Rows[iRow].Cells[iCol].Value != null && (bool) grWork.Rows[iRow].Cells[iCol].Value)
                            grWork.Rows[iRow].Cells[iCol].Value = false;
                        else
                        {
                            grWork.Rows[iRow].Cells[iCol].Value = true;
                            MessageBox.Show("Функционал сертификатов в разработке", "Обработка заказов",
                                MessageBoxButtons.OK);
                        }
                    }
                    break;
                case (int) TableCol.NameColIndex:
                    return;
                    var fr = new FrClient();
                    fr.ShowDialog();
                    grWork.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                    grWork.Rows[iRow].Cells["cClient"].Value = fr.ClientName.Name;
                    break;
            }
        }

        private void GridMonthLoad(int month,int year)
        {
            var sDate = new DateTime(year, month, 1);
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
            var eDate = new DateTime(year, month, 1);
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                const string wkCmd = "SELECT W.fId AS \"Id\",W.fClientId AS ClientId,Wt.fId AS \"Type\"," +
                                     "datetime(W.fDate, 'unixepoch') AS \"Date\",W.fPrepay AS \"Prepay\"," +
                                     "W.fExcess AS Excess,W.fCons AS Cons,W.fHours AS Hours,S.fId AS Source," +
                                     "W.fSertId AS Sert,C.fName AS Client,datetime(W.fExcessDate, 'unixepoch') AS ExDate," +
                                     "W.fConsTypeId AS ConsType " +
                                     "FROM tWork W JOIN tClient C ON W.fClientId=C.fId LEFT JOIN tConsType Ct ON W.fConsTypeId=Ct.fId " +
                                     "JOIN tSource S ON W.fSourceId=S.fId JOIN tWorkType Wt ON W.fTypeId=Wt.fId " +
                                     "WHERE W.fDate>=strftime('%s', :start) AND W.fDate<strftime('%s', :end)" +
                                     "ORDER BY \"Date\",Client";
                var wkCom = new SQLiteCommand(wkCmd, conn);
                wkCom.Parameters.AddWithValue("start", sDate);
                wkCom.Parameters.AddWithValue("end", eDate);
                var wkTable = new DataTable();
                var wkAdapt = new SQLiteDataAdapter(wkCom);
                wkAdapt.Fill(wkTable);
                var inc = 0D;
                var con = 0D;
                var hrs = 0D;
                grWork.RowCount = 1;
                foreach (var work in from DataRow row in wkTable.Rows select new Work(row))
                {
                    grWork.RowCount = grWork.RowCount + 1;
                    var iRow = grWork.Rows[grWork.RowCount - 2].Cells;
                    iRow["cNumber"].Value = grWork.RowCount - 1;
                    iRow["cId"].Value = work.Date;
                    iRow["cClientId"].Value = work.ClientId;
                    iRow["cClient"].Value = work.Client;
                    var c = iRow["cTypeA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Type;
                    iRow["cPreDate"].Value = work.Date.ToString("dd.MM.yyyy");
                    iRow["cPrepay"].Value = work.Prepay;
                    iRow["cExcess"].Value = work.Excess;
                    c = iRow["cConsA"] as DataGridViewComboBoxCell;
                    if (c != null && work.ConsType > 0)
                        c.Value = work.ConsType;
                    iRow["cCons"].Value = work.Cons;
                    iRow["cHours"].Value = work.Hours;

                    c = iRow["cSourceA"] as DataGridViewComboBoxCell;
                    if (c != null) c.Value = work.Source;
                    iRow["cSert"].Value = work.Sert > 0;
                    iRow["cExDate"].Value = work.ExDate == null
                        ? ""
                        : work.ExDate.Value.ToString("dd.MM.yyyy");

                    inc += work.Prepay + work.Excess;
                    con += work.Cons;
                    hrs += work.Hours;
                }
                lMonthC.Text = sDate.ToString("MMMM");
                lIncomeC.Text = inc.ToString("C0");
                lConsC.Text = con.ToString("C0");
                lProfitC.Text = (inc - con).ToString("C0");
                lHoursC.Text = hrs.ToString("N0");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var year = DateTime.Now.Year;
            var month = 1;
            var sDate = new DateTime(year, month, 1);
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
            var eDate = new DateTime(year, 12, 1);
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                var monthData = new DataTable();
                const string selCmd = "SELECT DISTINCT T.fName AS \"Type\",COUNT(W.fId) AS \"Count\",SUM((fPrepay+fExcess)/1000) AS \"Income\"" +
                                      "FROM tWork W  JOIN tWorkType T ON W.fTypeId=T.fId " +
                                      "WHERE W.fDate>=strftime('%s', :start) AND W.fDate<strftime('%s', :end) " +
                                      "GROUP BY fTypeId";
                var adapter = new SQLiteDataAdapter {SelectCommand = new SQLiteCommand(selCmd, conn)};
                adapter.SelectCommand.Parameters.AddWithValue("start", sDate);
                adapter.SelectCommand.Parameters.AddWithValue("end", eDate);
                adapter.Fill(monthData);
                chart1.Series["count"].XValueMember = "Type";
                chart1.Series["count"].YValueMembers = "Count";
                //chart1.Series["count"].YAxisType = AxisType.Secondary;
               // chart1.ChartAreas[1].AxisY.LabelStyle.Angle = 90; 
                
                //chart1.ChartAreas[1].AxisY2.LineWidth = 100;
                chart1.Series["income"].XValueMember = "Type";
                chart1.Series["income"].YValueMembers = "Income";
                //chart1.Series["income"].YAxisType = AxisType.Secondary;
                //chart1.Series["count"]["PixelPointWidth"] = "10";
                chart1.DataSource = monthData;
                chart1.DataBind();
            }
            finally
            {
                conn.Close();
            }
        }

        struct types
        {
            public int id;
            public int cnt;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void grWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var iRow = e.RowIndex;
            var iCol = e.ColumnIndex;
            switch (iCol)
            {
                case (int)TableCol.SertColIndex:
                    {

                        if (grWork.Rows[iRow].Cells[iCol].Value != null && (bool)grWork.Rows[iRow].Cells[iCol].Value)
                            grWork.Rows[iRow].Cells[iCol].Value = false;
                        else
                        {
                            grWork.Rows[iRow].Cells[iCol].Value = true;
                            MessageBox.Show("Функционал сертификатов в разработке", "Обработка заказов",
                                MessageBoxButtons.OK);
                        }
                    }
                    break;
                case (int)TableCol.NameColIndex:
                    var fr = new FrClient();
                    fr.ShowDialog();
                    grWork.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                    grWork.Rows[iRow].Cells["cClient"].Value = fr.ClientName.Name;
                    break;
            }
        }

        private void SaveChanges()
        {
            var conn = new SQLiteConnection("Data Source=order.db; Version=3;");
            try
            {
                conn.Open();
                const string insCmd = "INSERT INTO tWork (fClientId,fTypeId,fDate," +
                                      "fPrepay,fExcess,fExcessDate,fConsTypeId,fCons,fHours," +
                                      "fSourceId,fSertId) VALUES(:client,:type," +
                                      "strftime('%s', :date),:prepay,:excess," +
                                      "CASE WHEN :excess<1 THEN NULL ELSE strftime('%s', :exdate) END," +
                                      ":constype,:cons,:hour,:source," +
                                      "CASE WHEN :sert=0 THEN NULL ELSE :sert END)";
                var insCom = new SQLiteCommand(insCmd, conn);
                insCom.Parameters.AddWithValue("client", 1);
                insCom.Parameters.AddWithValue("type", 1);
                insCom.Parameters.Add(new SQLiteParameter("date", DbType.DateTime));
                insCom.Parameters.Add(new SQLiteParameter("prepay", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("excess", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("exdate", DbType.DateTime));
                insCom.Parameters.Add(new SQLiteParameter("constype", DbType.Int32));
                insCom.Parameters.Add(new SQLiteParameter("cons", DbType.Double));
                insCom.Parameters.Add(new SQLiteParameter("hour", DbType.Double));
                insCom.Parameters.AddWithValue("source", 1);
                insCom.Parameters.AddWithValue("sert", 0);
                for (var i = 0; i < grWork.RowCount - 1; i++)
                {
                    var a = grWork.Rows[i].Cells["cTypeA"].Value;
                    if (grWork.Rows[i].Cells["cId"].Value != null) continue;
                    insCom.Parameters["date"].Value = DateTime.Parse(grWork.Rows[i].Cells["cPreDate"].Value.ToString());
                    insCom.Parameters["prepay"].Value = grWork.Rows[i].Cells["cPrepay"].Value;
                    insCom.Parameters["excess"].Value = grWork.Rows[i].Cells["cExcess"].Value;
                    insCom.Parameters["exdate"].Value = string.IsNullOrEmpty(grWork.Rows[i].Cells["cExcess"].Value.ToString()) 
                        ? DateTime.Now 
                        : DateTime.Parse(grWork.Rows[i].Cells["cExDate"].Value.ToString());
                    insCom.Parameters["constype"].Value = string.IsNullOrEmpty(grWork.Rows[i].Cells["cExcess"].Value.ToString()) || Convert.ToDouble(grWork.Rows[i].Cells["cExcess"].Value) < 0.01 
                        ? 0 
                        : grWork.Rows[i].Cells["cConsA"].Value;
                    insCom.Parameters["cons"].Value = grWork.Rows[i].Cells["cCons"].Value;
                    insCom.Parameters["hour"].Value = grWork.Rows[i].Cells["cHours"].Value;
                    insCom.Prepare();
                    insCom.ExecuteNonQuery();
                }
                MessageBox.Show("Изменения сохранены", "Orders", MessageBoxButtons.OK);
                _hasChange = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_hasChange) return;
            var svResult = MessageBox.Show("Данные были изменены. Сохранить?", "Orders", MessageBoxButtons.YesNo);
            if (svResult == DialogResult.Yes)
            {
                SaveChanges();
            }
        }

        private void grWork_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;
        }

        private void grWork_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
           
        }
    }
}
