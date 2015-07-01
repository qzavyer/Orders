namespace Orders
{
    partial class FrCert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btChoise = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.grCert = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btChoise);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 25);
            this.panel1.TabIndex = 0;
            // 
            // btChoise
            // 
            this.btChoise.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChoise.Location = new System.Drawing.Point(0, 0);
            this.btChoise.Name = "btChoise";
            this.btChoise.Size = new System.Drawing.Size(105, 25);
            this.btChoise.TabIndex = 1;
            this.btChoise.Text = "Выбрать";
            this.btChoise.UseVisualStyleBackColor = true;
            this.btChoise.Click += new System.EventHandler(this.btChoise_Click);
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(1105, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 25);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Visible = false;
            // 
            // grCert
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grCert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grCert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cPayId,
            this.cClientId,
            this.cTypeId,
            this.cSource,
            this.cPayName,
            this.cClientName,
            this.cTypeName,
            this.cDatePay,
            this.cDateEnd,
            this.cPrice,
            this.cCons,
            this.cHours,
            this.cSourceName});
            this.grCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCert.Location = new System.Drawing.Point(0, 0);
            this.grCert.Name = "grCert";
            this.grCert.RowHeadersVisible = false;
            this.grCert.RowTemplate.Height = 24;
            this.grCert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grCert.Size = new System.Drawing.Size(1210, 503);
            this.grCert.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fPayId";
            this.dataGridViewTextBoxColumn2.HeaderText = "PayId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fClientId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClientId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fTypeId";
            this.dataGridViewTextBoxColumn4.HeaderText = "TypeId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fSource";
            this.dataGridViewTextBoxColumn5.HeaderText = "SourceId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fPayName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Плательщик";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fClientName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fTypeName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Тип съёмки";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fDatePay";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата оплаты";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 110;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fDateEnd";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "fPrice";
            this.dataGridViewTextBoxColumn11.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 85;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cCons";
            this.dataGridViewTextBoxColumn12.HeaderText = "Расход";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "fHours";
            this.dataGridViewTextBoxColumn13.HeaderText = "Часов";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "fSourceName";
            this.dataGridViewTextBoxColumn14.HeaderText = "Источник";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 110;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "fId";
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // cPayId
            // 
            this.cPayId.DataPropertyName = "fPayId";
            this.cPayId.HeaderText = "PayId";
            this.cPayId.Name = "cPayId";
            this.cPayId.Visible = false;
            // 
            // cClientId
            // 
            this.cClientId.DataPropertyName = "fClientId";
            this.cClientId.HeaderText = "ClientId";
            this.cClientId.Name = "cClientId";
            this.cClientId.Visible = false;
            // 
            // cTypeId
            // 
            this.cTypeId.DataPropertyName = "fTypeId";
            this.cTypeId.HeaderText = "TypeId";
            this.cTypeId.Name = "cTypeId";
            this.cTypeId.Visible = false;
            // 
            // cSource
            // 
            this.cSource.DataPropertyName = "fSource";
            this.cSource.HeaderText = "SourceId";
            this.cSource.Name = "cSource";
            this.cSource.Visible = false;
            // 
            // cPayName
            // 
            this.cPayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPayName.DataPropertyName = "fPayName";
            this.cPayName.HeaderText = "Плательщик";
            this.cPayName.MinimumWidth = 50;
            this.cPayName.Name = "cPayName";
            this.cPayName.ReadOnly = true;
            // 
            // cClientName
            // 
            this.cClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cClientName.DataPropertyName = "fClientName";
            this.cClientName.HeaderText = "Клиент";
            this.cClientName.MinimumWidth = 50;
            this.cClientName.Name = "cClientName";
            this.cClientName.ReadOnly = true;
            // 
            // cTypeName
            // 
            this.cTypeName.DataPropertyName = "fTypeName";
            this.cTypeName.HeaderText = "Тип съёмки";
            this.cTypeName.Name = "cTypeName";
            this.cTypeName.ReadOnly = true;
            this.cTypeName.Width = 110;
            // 
            // cDatePay
            // 
            this.cDatePay.DataPropertyName = "fDatePay";
            this.cDatePay.HeaderText = "Дата оплаты";
            this.cDatePay.Name = "cDatePay";
            this.cDatePay.ReadOnly = true;
            this.cDatePay.Width = 110;
            // 
            // cDateEnd
            // 
            this.cDateEnd.DataPropertyName = "fDateEnd";
            this.cDateEnd.HeaderText = "Дата окончания";
            this.cDateEnd.Name = "cDateEnd";
            this.cDateEnd.ReadOnly = true;
            this.cDateEnd.Width = 125;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "fPrice";
            this.cPrice.HeaderText = "Стоимость";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            this.cPrice.Width = 85;
            // 
            // cCons
            // 
            this.cCons.DataPropertyName = "cCons";
            this.cCons.HeaderText = "Расход";
            this.cCons.Name = "cCons";
            this.cCons.Width = 60;
            // 
            // cHours
            // 
            this.cHours.DataPropertyName = "fHours";
            this.cHours.HeaderText = "Часов";
            this.cHours.Name = "cHours";
            this.cHours.ReadOnly = true;
            this.cHours.Width = 60;
            // 
            // cSourceName
            // 
            this.cSourceName.DataPropertyName = "fSourceName";
            this.cSourceName.HeaderText = "Источник";
            this.cSourceName.Name = "cSourceName";
            this.cSourceName.ReadOnly = true;
            this.cSourceName.Width = 110;
            // 
            // FrCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 528);
            this.Controls.Add(this.grCert);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrCert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор сертификата";
            this.Load += new System.EventHandler(this.FrCert_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btChoise;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView grCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSourceName;
    }
}