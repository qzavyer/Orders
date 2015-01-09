using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Orders
{
    public partial class FrCert : Form
    {
        public Cert Cert;
        public bool FrOk;
        public FrCert()
        {
            InitializeComponent();
        }

        private void FrCert_Load(object sender, EventArgs e)
        {
            var conn = Connections.GetConnection();
            try
            {
                conn.Open();
                var cert = new DataTable();
                const string crCmd = "SELECT DISTINCT Cr.fId AS fId,Cr.fPayId AS fPayId,P.fName AS fPayName," +
                                     "Cr.fClientId AS fClientId,Cl.fName AS fClientName,Cr.fTypeId AS fTypeId," +
                                     "Wt.fName AS fTypeName,Cr.fPrice AS fPrice,Cr.fHours AS fHours," +
                                     "strftime('%d.%m.%Y',date(Cr.fDatePay, 'unixepoch')) AS fDatePay," +
                                     "strftime('%d.%m.%Y',date(Cr.fDateEnd, 'unixepoch')) AS fDateEnd," +
                                     "Cr.fSource AS fSource,Sr.fName AS fSourceName,SUM(Cn.fAmount) AS cCons " +
                                     "FROM tSert Cr JOIN tClient P ON Cr.fPayId=P.fId " +
                                     "JOIN tClient Cl ON Cr.fClientId=Cl.fid " +
                                     "JOIN tWorkType Wt ON Cr.fTypeId=Wt.fId " +
                                     "JOIN tSource Sr ON Cr.fSource=Sr.fId " +
                                     "LEFT JOIN tCons Cn ON Cn.fCertId=Cr.fId " +
                                     "WHERE NOT EXISTS (SELECT fId FROM tWork WHERE fSertId=Cr.fId) OR Cr.fId=:cert " +
                                     "GROUP BY Cr.fId,fPayId,fPayName,fClientId,fClientName,Cr.fTypeId," +
                                     "fTypeName,fPrice,fHours,fDatePay,fDateEnd,fSource,fSourceName " +
                                     "ORDER BY fDatePay";
                var crAd = new SQLiteDataAdapter { SelectCommand = new SQLiteCommand(crCmd, conn) };
                crAd.SelectCommand.Parameters.AddWithValue("cert", Cert.Id);
                crAd.SelectCommand.Prepare();
                crAd.Fill(cert);
                grCert.DataSource = cert;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btChoise_Click(object sender, EventArgs e)
        {
            var row = grCert.SelectedRows[0];
            if (row.Cells[0].Value == null) return;
            Cert = new Cert
            {
                Id = Convert.ToInt32(row.Cells["cId"].Value),
                Clientid = Convert.ToInt32(row.Cells["cClientid"].Value),
                ClientName = row.Cells["cClientName"].Value.ToString(),
                DatePay = Convert.ToDateTime(row.Cells["cDatePay"].Value),
                DateEnd = Convert.ToDateTime(row.Cells["cDateEnd"].Value),
                Hours = Convert.ToInt32(row.Cells["cHours"].Value),
                PayId = Convert.ToInt32(row.Cells["cPayId"].Value),
                PayName = row.Cells["cPayName"].Value.ToString(),
                Price = Convert.ToDouble(row.Cells["cPrice"].Value),
                Cons = Convert.ToDouble(row.Cells["cCons"].Value),
                Source = Convert.ToInt32(row.Cells["cSource"].Value),
                SourceName = row.Cells["cSourceName"].Value.ToString(),
                TypeId = Convert.ToInt32(row.Cells["cTypeId"].Value),
                TypeName = row.Cells["cTypeName"].Value.ToString()
            };
            FrOk = true;
            Close();
        }
    }
}
