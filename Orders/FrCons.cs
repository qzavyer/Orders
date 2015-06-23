using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Windows.Forms;
using Orders.Properties;

namespace Orders
{
    public partial class FrCons : Form
    {
        private static readonly OrderContext Db = new OrderContext();
        public readonly Cons Cons = new Cons();
        public int WorkId;
        public int CertId;
        public List<int> ConsId = new List<int>();
        public DateTime WorkDate;
        public bool FrOk;
        private DataTable _consType;
        public FrCons()
        {
            InitializeComponent();
        }

        private void ControlLoad()
        {
            var conn = new SQLiteConnection(Db.Database.Connection.ConnectionString);
            try
            {
                conn.Open();
                _consType = new DataTable();
                var adapter = new SQLiteDataAdapter
                {
                    SelectCommand = new SQLiteCommand("SELECT fId,fName FROM tConsType", conn)
                };
                adapter.Fill(_consType);

                var combo = new DataGridViewComboBoxColumn
                {
                    Name = "cType",
                    DataPropertyName = "cType",
                    DataSource = _consType,
                    ValueMember = "fId",
                    DisplayMember = "fName",
                    HeaderText = Resources.ConsType,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                grCons.Columns.Insert(1, combo);
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void ConsLoad()
        {
            var conn = new SQLiteConnection(Db.Database.Connection.ConnectionString);
            try
            {
                conn.Open();
                var consData = new DataTable();


                var cnsCmd = "SELECT DISTINCT fId AS cId, fTypeId AS cType,fAmount AS cAmount,fCertCons AS cCert," +
                             "fComment AS cComment FROM tCons WHERE fId IN (" + string.Join(",", ConsId) + ")";
                const string wrkCmd = "SELECT DISTINCT fId AS cId, fTypeId AS cType,fAmount AS cAmount,fCertCons AS cCert," +
                                      "fComment AS cComment FROM tCons WHERE fWorkId=:work OR fCertId=:cert";
                var adapter = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(conn) };
                if (WorkId == 0 && CertId == 0)
                {
                    adapter.SelectCommand.CommandText = cnsCmd;
                }
                else
                {
                    adapter.SelectCommand.CommandText = wrkCmd;
                    adapter.SelectCommand.Parameters.AddWithValue("work", WorkId);
                    adapter.SelectCommand.Parameters.AddWithValue("cert", ConsId);
                    adapter.SelectCommand.Prepare();
                }
                adapter.Fill(consData);

                //var a = consData.Rows.Count;

                var bSource = new BindingSource { DataSource = consData };
                grCons.DataSource = bSource;
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void FrCons_Load(object sender, EventArgs e)
        {
            ControlLoad();
            ConsLoad();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            const string updCmd = "UPDATE tCons SET fTypeId=:type,fAmount=:amount,fDate=strftime('%s', :date)," +
                                  "fComment=:comment,fWorkId=:work,fCertId=:cert,fCertCons=:iscert WHERE fId=:id";
            const string delCmd = "DELETE FROM tCons WHERE fId=:id";
            const string insCmd = "INSERT INTO tCons (fTypeId,fAmount,fDate,fComment,fWorkId,fCertId,fCertCons) " +
                                  "VALUES(:type,:amount,strftime('%s', :date),:comment,:work,:cert,:iscert);" +
                                  "SELECT DISTINCT last_insert_rowid() FROM tCons";
            Cons.Amount = 0;
            var conn = new SQLiteConnection(Db.Database.Connection.ConnectionString);
            try
            {
                conn.Open();

                foreach (DataGridViewRow row in grCons.Rows)
                {
                    if (row.Cells["cId"].Value == null) continue;
                    var svCom = new SQLiteCommand(conn);
                    var nulAmount = row.Cells["cAmount"].Value == null ||
                                    string.IsNullOrEmpty(row.Cells["cAmount"].Value.ToString()) ||
                                    Convert.ToDouble(row.Cells["cAmount"].Value) < 0.01;
                    if (!nulAmount)
                    {
                        if (string.IsNullOrEmpty(row.Cells["cCert"].Value.ToString())||
                            !Convert.ToBoolean(row.Cells["cCert"].Value))
                        {
                            Cons.Amount += Convert.ToDouble(row.Cells["cAmount"].Value);
                        }
                        svCom.Parameters.Add(new SQLiteParameter("type", DbType.Int32));
                        svCom.Parameters.Add(new SQLiteParameter("amount", DbType.Double));
                        svCom.Parameters.Add(new SQLiteParameter("date", DbType.Date));
                        svCom.Parameters.Add(new SQLiteParameter("comment", DbType.String));
                        svCom.Parameters.Add(new SQLiteParameter("work", DbType.Int32));
                        svCom.Parameters.Add(new SQLiteParameter("cert", DbType.Int32));
                        svCom.Parameters.Add(new SQLiteParameter("iscert", DbType.Int32));
                        svCom.Parameters["type"].Value = row.Cells["cType"].Value;
                        svCom.Parameters["amount"].Value = row.Cells["cAmount"].Value;
                        svCom.Parameters["date"].Value = WorkDate;
                        svCom.Parameters["comment"].Value = row.Cells["cComment"].Value;
                        svCom.Parameters["work"].Value = WorkId;
                        svCom.Parameters["cert"].Value = CertId;
                        svCom.Parameters["iscert"].Value = string.IsNullOrEmpty(row.Cells["cCert"].Value.ToString())
                            ? false
                            : row.Cells["cCert"].Value;
                    }
                    if (string.IsNullOrEmpty(row.Cells["cId"].Value.ToString()))
                    {
                        if (nulAmount) continue;
                        svCom.CommandText = insCmd;
                        svCom.Prepare();
                        var svDr = svCom.ExecuteReader();
                        if (WorkId != 0 || CertId != 0) continue;
                        while (svDr.Read())
                        {
                            ConsId.Add(Convert.ToInt32(svDr[0]));
                        }
                    }
                    else
                    {
                        svCom.CommandText = nulAmount ? delCmd : updCmd;
                        svCom.Parameters.Add(new SQLiteParameter("id", DbType.Int32));
                        svCom.Parameters["id"].Value = row.Cells["cId"].Value;
                        svCom.Prepare();
                        svCom.ExecuteNonQuery();
                    }
                }
                FrOk = true;
                Close();
            }
            catch (Exception ex)
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                {
                    var cName = declaringType.Name;
                    var mName = MethodBase.GetCurrentMethod().Name;
                    Errors.SaveError(ex.Message, cName + "/" + mName);
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
