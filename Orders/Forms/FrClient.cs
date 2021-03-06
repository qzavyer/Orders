﻿using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Orders.Classes;
using Orders.Executers;
using Orders.Models;
using Orders.Properties;

namespace Orders.Forms
{
    public partial class FrClient : Form
    {
        #region Поля класса

        private static bool _hasChange;
        public EClient ClientName;

        #endregion

        #region Управление формой
        
        public FrClient()
        {
            InitializeComponent();
        }

        private void FrClient_Load(object sender, EventArgs e)
        {
            try
            {
                if(ClientName!=null)
                    tbFind.Text = ClientName.Name;
                FilterClients();
                var cId = grClient.Columns["Id"];
                if (cId != null)
                {
                    cId.Visible = false;
                    cId.ReadOnly = true;
                }
                var cName = grClient.Columns["Name"];
                if (cName != null)
                {
                    cName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    cName.HeaderText = Resources.Name;
                }
                var cPhone = grClient.Columns["Phone"];
                if (cPhone != null)
                {
                    cPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cPhone.HeaderText = Resources.Phone;
                }
                var cEmail = grClient.Columns["Mail"];
                if (cEmail != null)
                {
                    cEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cEmail.HeaderText = Resources.Email;
                }
                var cNote = grClient.Columns["Note"];
                if (cNote != null)
                {
                    cNote.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    cNote.HeaderText = Resources.Note;
                }

                var cDateP = grClient.Columns["idate"];
                if (cDateP != null)
                {
                    cDateP.Visible = false;
                }

                var cDate = grClient.Columns["Date"];
                if (cDate != null)
                {
                    cDate.Visible = false;
                }
                _hasChange = false;
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
            }
        }

        #endregion

        #region Работа формы

        private void btOk_Click(object sender, EventArgs e)
        {
            if (_hasChange)
            {
                var svResult = MessageBox.Show(Resources.ChangeData, Resources.Orders, MessageBoxButtons.YesNo);
                if (svResult == DialogResult.Yes)
                {
                    SaveChanges();
                }
                return;
            }
            _hasChange = false;
            var row = grClient.SelectedRows[0];
            if (row == null) return;
            ClientName = new EClient { Id = Convert.ToInt32(row.Cells[0].Value), Name = row.Cells[1].Value.ToString() };
            Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            var fr = new FrAddClient {tbName = {Text = tbFind.Text}};
            fr.ShowDialog();
            FilterClients();
        }
        private void tbFind_KeyUp(object sender, KeyEventArgs e)
        {
            FilterClients();
        }
        private void grClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _hasChange = true;
        }

        private void FilterClients()
        {
            var text = tbFind.Text.Trim();
            text = Regex.Replace(text, " +", " ");
            var clientExecuter = new ClientExecuter();
            var clients = clientExecuter.GetAll().ToList();
            if (!string.IsNullOrEmpty(text))
                clients = clients.Where(r => r.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1).ToList();
            clients.Sort((item1, item2) =>
            {
                var order1 = item1.Date.CompareTo(item2.Date);
                return order1 == 0 ? String.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) : order1;
            });
            grClient.DataSource = clients;
        }

        private void SaveChanges()
        {
            try
            {
                var clientExecuter = new ClientExecuter();
                foreach (DataGridViewRow row in grClient.Rows)
                {
                    var name = row.Cells["Name"].Value.ToString().Trim();
                    name = Regex.Replace(name, " +", " ");
                    var phone = row.Cells["Phone"].Value.ToString().Trim();
                    phone = Regex.Replace(phone, " +", " ");
                    var mail = row.Cells["Mail"].Value.ToString().Trim();
                    mail = Regex.Replace(mail, " +", " ");
                    var note = row.Cells["Note"].Value.ToString().Trim();
                    note = Regex.Replace(note, " +", " ");
                    if (!string.IsNullOrEmpty(row.Cells["Id"].Value.ToString().Trim()))
                    {
                        var client = clientExecuter.Get(Convert.ToInt32(row.Cells["Id"].Value));
                        client.Name = name;
                        client.Phone = phone;
                        client.Mail = mail;
                        client.Note = note;
                    }
                    else
                    {
                        clientExecuter.Add(new EClient
                        {
                            Name = name,
                            Phone = phone,
                            Mail = mail,
                            Note = note
                        });
                    }
                }
                clientExecuter.Save();
                _hasChange = false;
                var clients = grClient.DataSource as DataTable;
                if (clients != null) clients.DefaultView.RowFilter = null;
                MessageBox.Show(Resources.SaveChange, Resources.Orders, MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                ErrorSaver.GetInstance().HandleError(MethodBase.GetCurrentMethod(), exception);
                tbFind.Clear();
            }
        }

        #endregion
    }
}
