using System;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Executers;
using Orders.Models;
using Orders.Properties;

namespace Orders.Forms
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
            var certExecuter = new CertExecuter();
            var certs = certExecuter.GetUnworkedCerts(Cert?.Id).ToList();
            var certId = Cert?.Id??0;
            if (certId == 0)
            {
                var clientExecuter = new ClientExecuter();
                var sourceExecuter = new SourceTypeExecuter();
                var workExecuter = new WorkTypeExecuter();
                Cert.Payer = clientExecuter.Get(Cert.PayId);
                Cert.Source = sourceExecuter.Get(Cert.SourceId);
                Cert.Type = workExecuter.Get(Cert.TypeId);
                certs.Add(Cert);
            }
            certs.Sort((item1, item2) => item1.DatePay.CompareTo(item2.DatePay));
            foreach (var cert in certs)
            {
                grCert.RowCount = grCert.RowCount + 1;
                var iRow = grCert.Rows[grCert.RowCount - 1].Cells;
                iRow["cId"].Value = cert.Id;
                iRow["cPayerId"].Value = cert.PayId;
                iRow[CertPayerColumn].Value = cert.With(r => r.Payer).Return(r => r.Name, "");
                iRow["cClientId"].Value = cert.ClientId;
                iRow[CertClientColumn].Value = cert.With(r => r.Client).Return(r => r.Name, "");
                iRow["cTypeId"].Value = cert.TypeId;
                iRow[CertTypeColumn].Value = cert.With(r => r.Type).Return(r => r.Name, "");
                iRow["cDatePay"].Value = cert.DatePay.ToString("dd.MM.yyyy");
                iRow["cDateEnd"].Value = cert.DateEnd.ToString("dd.MM.yyyy");
                iRow["cPrice"].Value = cert.Price;
                iRow["cConsed"].Value = cert.Consed;
                iRow["cHours"].Value = cert.Hours;
                iRow["cSourceId"].Value = cert.SourceId;
                iRow[CertSourceColumn].Value = cert.With(r => r.Source).Return(r => r.Name, "");
                if (cert.Id == certId)
                {
                    iRow[CertPayerColumn].Selected = true;
                }
            }
            Cert = null;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var s = grCert.SelectedCells[0];
            var iRow = s.RowIndex;
            var row = grCert.Rows[iRow];
            int? certClient;
            double certPrice;
            double certHours;
            DateTime? certDatePay;
            DateTime? certDateEnd;
            var certId = Convert.ToInt32(row.Cells["cId"]?.Value ?? 0);
            var certPayer = Convert.ToInt32(row.Cells["cPayerId"]?.Value ?? 0);
            certClient = Convert.ToInt32(row.Cells["cClientId"]?.Value ?? 0);
            var certType = Convert.ToInt32(row.Cells["cTypeId"]?.Value ?? 0);
            var certSource = Convert.ToInt32(row.Cells["cSourceId"]?.Value ?? 0);
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
                case CertClientColumn:
                    CertClientClick(iRow, iCol);                    
                    break;
                case CertPayerColumn:
                    CertPayerClick(iRow, iCol);
                    break;
                case CertTypeColumn:
                    CertTypeClick(iRow, iCol);
                    break;
                case CertSourceColumn:
                    CertSourceClick(iRow, iCol);
                    break;
            }
        }

        private void CertClientClick(int iRow, int iCol)
        {
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
            fr.ClientName = new EClient { Name = cName };
            fr.ShowDialog();
            if (fr.ClientName != null && fr.ClientName.Id > 0)
            {
                grCert.Rows[iRow].Cells["cClientId"].Value = fr.ClientName.Id;
                grCert.Rows[iRow].Cells[CertClientColumn].Value = fr.ClientName.Name;
            }
        }

        private void CertPayerClick(int iRow, int iCol)
        {
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
                grCert.Rows[iRow].Cells[CertPayerColumn].Value = frP.ClientName.Name;
            }
        }

        private void CertTypeClick(int iRow, int iCol)
        {
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
            if (frWType.WorkType != null && frWType.WorkType.Id > 0)
            {
                grCert.Rows[iRow].Cells["cTypeId"].Value = frWType.WorkType.Id;
                grCert.Rows[iRow].Cells[CertTypeColumn].Value = frWType.WorkType.Name;
            }
        }

        private void CertSourceClick(int iRow, int iCol)
        {
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
            if (frSource.Source != null && frSource.Source.Id > 0)
            {
                grCert.Rows[iRow].Cells["cSourceId"].Value = frSource.Source.Id;
                grCert.Rows[iRow].Cells[CertSourceColumn].Value = frSource.Source.Name;
            }
        }
    }
}
