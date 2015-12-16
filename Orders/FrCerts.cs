using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Orders.Properties;

namespace Orders
{
    public partial class FrCerts : Form
    {
        public ECert Cert;

        public FrCerts()
        {
            InitializeComponent();
        }

        private void FrCerts_Load(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                var workLst = db.Works.Select(l => l.CertId).ToList();
                var certs = db.Certs.Where(
                    r => !workLst.Contains(r.Id) || (Cert.Id > 0 && r.Id == Cert.Id))
                    .Include(r => r.Client).Include(r => r.Payer)
                    .Include(r => r.Source).Include(r => r.Type).ToList();
                if (Cert != null && Cert.Id == 0)
                {
                    Cert.Payer = db.Clients.Find(Cert.PayId);
                    Cert.Source = db.SourceTypes.Find(Cert.SourceId);
                    Cert.Type = db.WorkTypes.Find(Cert.TypeId);
                    certs.Add(Cert);
                }
                certs.Sort((item1,item2)=>item1.DatePay.CompareTo(item2.DatePay));

                foreach (var cert in certs)
                {
                    grCert.RowCount = grCert.RowCount + 1;
                    var iRow = grCert.Rows[grCert.RowCount - 1].Cells;
                    iRow["cId"].Value = cert.Id;
                    iRow["cPayerId"].Value = cert.PayId;
                    iRow["cPayer"].Value = cert.With(r=>r.Payer).Return(r=>r.Name,"");
                    iRow["cClientId"].Value = cert.ClientId;
                    iRow["cClient"].Value = cert.With(r => r.Client).Return(r => r.Name, "");
                    iRow["cTypeId"].Value = cert.TypeId;
                    iRow["cType"].Value = cert.With(r => r.Type).Return(r => r.Name, "");
                    iRow["cDatePay"].Value = cert.DatePay.ToString("dd.MM.yyyy");
                    iRow["cDateEnd"].Value = cert.DateEnd.ToString("dd.MM.yyyy");
                    iRow["cPrice"].Value = cert.Price;
                    iRow["cConsed"].Value = cert.Consed;
                    iRow["cHours"].Value = cert.Hours;
                    iRow["cSourceId"].Value = cert.SourceId;
                    iRow["cSource"].Value = cert.With(r=>r.Source).Return(r=>r.Name,"");
                    if (Cert != null && Cert.Id == cert.Id)
                    {
                        iRow["cPayer"].Selected = true;
                    }
                }                
                Cert = null;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var s = grCert.SelectedCells[0];
            var iRow = s.RowIndex;
            var row = grCert.Rows[iRow];
            int certId;
            int certPayer;
            int? certClient;
            int certType;
            int certSource;
            double certPrice;
            double certHours;
            DateTime? certDatePay;
            DateTime? certDateEnd;
            try
            {
                certId = Convert.ToInt32(row.Cells["cId"].Value);
            }
            catch
            {
                certId = 0;
            }
            try
            {
                certPayer = Convert.ToInt32(row.Cells["cPayerId"].Value);
            }
            catch
            {
                certPayer = 0;
            }
            try
            {
                certClient = Convert.ToInt32(row.Cells["cClientId"].Value);
            }
            catch
            {
                certClient = null;
            }
            try
            {
                certType = Convert.ToInt32(row.Cells["cTypeId"].Value);
            }
            catch
            {
                certType = 0;
            }
            try
            {
                certSource = Convert.ToInt32(row.Cells["cSourceId"].Value);
            }
            catch
            {
                certSource = 0;
            }
            try
            {
                var price = row.Cells["cPrice"].Value.ToString().Trim();
                price = Regex.Replace(price, " +", "");
                price = price.Replace(".", ",");
                certPrice = Convert.ToDouble(price);
            }
            catch
            {
                certPrice = 0;
            }
            
            try
            {
                var hours = row.Cells["cHours"].Value.ToString().Trim();
                hours = Regex.Replace(hours, " +", "");
                hours = hours.Replace(".", ",");
                certHours = Convert.ToDouble(hours);
            }
            catch
            {
                certHours = 0;
            }
            try
            {
                var dateP = row.Cells["cDatePay"].Value.ToString().Trim();
                certDatePay = Convert.ToDateTime(dateP);
            }
            catch
            {
                certDatePay = null;
            }
            try
            {
                var dateE = row.Cells["cDateEnd"].Value.ToString().Trim();
                certDateEnd = Convert.ToDateTime(dateE);
            }
            catch
            {
                certDateEnd = null;
            }
            if (certPayer == 0 || certType == 0 || certSource == 0 || certDatePay == null || certDateEnd == null)
            {
                Cert = null;
                if (MessageBox.Show(Resources.FrCertsErrorData, Resources.Orders, MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    Close();
                }
                return;
            }
            Cert = new ECert
            {
                Id = certId,
                Hours = certHours,
                PayId = certPayer,
                ClientId = certClient,
                Price = certPrice,
                SourceId = certSource,
                TypeId = certType,
                DatePay = certDatePay.Value,
                DateEnd = certDateEnd.Value
            };
            Close();
        }

        private void grCert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var iRow = e.RowIndex;
            if (iRow < 0) return;
            var iCol = e.ColumnIndex;
            switch (grCert.Columns[iCol].Name)
            {
                case "cClient":
                    var fr = new FrClient();
                    string cName;
                    try
                    {
                        cName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch (Exception)
                    {
                        cName = "";
                    }
                    fr.ClientName = new EClient {Name = cName};
                    fr.ShowDialog();
                    if (fr.ClientName != null && fr.ClientName.Id > 0)
                    {
                        grCert.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                        grCert.Rows[iRow].Cells["cClient"].Value = fr.ClientName.Name;
                    }
                    break;
                case "cPayer":
                    var frP = new FrClient();
                    string pName;
                    try
                    {
                        pName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch (Exception)
                    {
                        pName = "";
                    }
                    frP.ClientName = new EClient { Name = pName };
                    frP.ShowDialog();
                    if (frP.ClientName != null && frP.ClientName.Id > 0)
                    {
                        grCert.Rows[iRow].Cells["cPayerId"].Value = frP.ClientName.Id;
                        grCert.Rows[iRow].Cells["cPayer"].Value = frP.ClientName.Name;
                    }
                    break;
                case "cType":
                    var frWType = new FrWorkType();
                    string tName;
                    try
                    {
                        tName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch (Exception)
                    {
                        tName = "";
                    }
                    frWType.WorkType = new EWorkType { Name = tName };
                    frWType.ShowDialog();
                    if (frWType.WorkType != null&&frWType.WorkType.Id>0)
                    {
                        grCert.Rows[iRow].Cells["cTypeId"].Value = frWType.WorkType.Id;
                        grCert.Rows[iRow].Cells["cType"].Value = frWType.WorkType.Name;
                    }
                    break;
                case "cSource":
                    var frSource = new FrSource();
                    string sName;
                    try
                    {
                        sName = grCert.Rows[iRow].Cells[iCol].Value.ToString();
                    }
                    catch (Exception)
                    {
                        sName = "";
                    }
                    frSource.Source = new ESourceType { Name = sName };
                    frSource.ShowDialog();
                    if (frSource.Source != null&&frSource.Source.Id>0)
                    {
                        grCert.Rows[iRow].Cells["cSourceId"].Value = frSource.Source.Id;
                        grCert.Rows[iRow].Cells["cSource"].Value = frSource.Source.Name;
                    }
                    break;
            }
        }
    }
}
