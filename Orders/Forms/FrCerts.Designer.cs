namespace Orders.Forms
{
    partial class FrCerts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCerts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.grCert = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatePay = new Orders.Classes.CalendarColumn();
            this.cDateEnd = new Orders.Classes.CalendarColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new Orders.Classes.CalendarColumn();
            this.calendarColumn2 = new Orders.Classes.CalendarColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 31);
            this.panel2.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOk.Location = new System.Drawing.Point(0, 0);
            this.btOk.Margin = new System.Windows.Forms.Padding(4);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(140, 31);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Выбрать";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // grCert
            // 
            this.grCert.AllowUserToAddRows = false;
            this.grCert.AllowUserToDeleteRows = false;
            this.grCert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cPayerId,
            this.cPayer,
            this.cClientId,
            this.cClient,
            this.cTypeId,
            this.cType,
            this.cDatePay,
            this.cDateEnd,
            this.cPrice,
            this.cConsed,
            this.cHours,
            this.cSourceId,
            this.cSource});
            this.grCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCert.Location = new System.Drawing.Point(0, 31);
            this.grCert.Margin = new System.Windows.Forms.Padding(4);
            this.grCert.MultiSelect = false;
            this.grCert.Name = "grCert";
            this.grCert.RowHeadersVisible = false;
            this.grCert.Size = new System.Drawing.Size(1083, 403);
            this.grCert.TabIndex = 2;
            this.grCert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCert_CellClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // cPayerId
            // 
            this.cPayerId.DataPropertyName = "PayId";
            this.cPayerId.HeaderText = "PayerId";
            this.cPayerId.Name = "cPayerId";
            this.cPayerId.Visible = false;
            // 
            // cPayer
            // 
            this.cPayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPayer.DataPropertyName = "Payer.Name";
            this.cPayer.HeaderText = "Плательщик";
            this.cPayer.Name = "cPayer";
            this.cPayer.Width = 115;
            // 
            // cClientId
            // 
            this.cClientId.DataPropertyName = "ClientId";
            this.cClientId.HeaderText = "ClientId";
            this.cClientId.Name = "cClientId";
            this.cClientId.Visible = false;
            // 
            // cClient
            // 
            this.cClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cClient.DataPropertyName = "Client.Name";
            this.cClient.HeaderText = "Клиент";
            this.cClient.Name = "cClient";
            this.cClient.Width = 81;
            // 
            // cTypeId
            // 
            this.cTypeId.HeaderText = "TypeId";
            this.cTypeId.Name = "cTypeId";
            this.cTypeId.Visible = false;
            // 
            // cType
            // 
            this.cType.HeaderText = "Вид работы";
            this.cType.Name = "cType";
            // 
            // cDatePay
            // 
            this.cDatePay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cDatePay.DataPropertyName = "DatePay";
            this.cDatePay.HeaderText = "Дата оплаты";
            this.cDatePay.Name = "cDatePay";
            this.cDatePay.Width = 91;
            // 
            // cDateEnd
            // 
            this.cDateEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cDateEnd.DataPropertyName = "DateEnd";
            this.cDateEnd.HeaderText = "Дата окончания";
            this.cDateEnd.Name = "cDateEnd";
            this.cDateEnd.Width = 111;
            // 
            // cPrice
            // 
            this.cPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cPrice.DataPropertyName = "Price";
            this.cPrice.HeaderText = "Стоимость";
            this.cPrice.Name = "cPrice";
            this.cPrice.Width = 103;
            // 
            // cConsed
            // 
            this.cConsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cConsed.DataPropertyName = "Consed";
            this.cConsed.HeaderText = "Потрачено";
            this.cConsed.Name = "cConsed";
            this.cConsed.Width = 106;
            // 
            // cHours
            // 
            this.cHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cHours.DataPropertyName = "Hours";
            this.cHours.HeaderText = "Часов";
            this.cHours.Name = "cHours";
            this.cHours.Width = 73;
            // 
            // cSourceId
            // 
            this.cSourceId.DataPropertyName = "SourceId";
            this.cSourceId.HeaderText = "SourceId";
            this.cSourceId.Name = "cSourceId";
            this.cSourceId.Visible = false;
            // 
            // cSource
            // 
            this.cSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cSource.DataPropertyName = "Source.Name";
            this.cSource.HeaderText = "Источник";
            this.cSource.Name = "cSource";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PayerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Плательщик";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ClientId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calendarColumn1.HeaderText = "Дата оплаты";
            this.calendarColumn1.Name = "calendarColumn1";
            // 
            // calendarColumn2
            // 
            this.calendarColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calendarColumn2.HeaderText = "Дата окончания";
            this.calendarColumn2.Name = "calendarColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Потрачено";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Часов";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "SourceId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Источник";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FrCerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 465);
            this.Controls.Add(this.grCert);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrCerts";
            this.Text = "Сертификаты";
            this.Load += new System.EventHandler(this.FrCerts_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.DataGridView grCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Classes.CalendarColumn calendarColumn1;
        private Classes.CalendarColumn calendarColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private Classes.CalendarColumn cDatePay;
        private Classes.CalendarColumn cDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSource;
    }
}