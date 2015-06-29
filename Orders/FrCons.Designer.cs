namespace Orders
{
    partial class FrCons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCons));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.grCons = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 31);
            this.panel1.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(533, 0);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(140, 31);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 25);
            this.panel2.TabIndex = 1;
            // 
            // tbFind
            // 
            this.tbFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFind.Location = new System.Drawing.Point(0, 0);
            this.tbFind.Margin = new System.Windows.Forms.Padding(4);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(250, 22);
            this.tbFind.TabIndex = 0;
            this.tbFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyUp);
            // 
            // grCons
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grCons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cTypeId,
            this.cType,
            this.cAmount,
            this.cCert,
            this.cComment,
            this.cDelete});
            this.grCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCons.Location = new System.Drawing.Point(0, 25);
            this.grCons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grCons.Name = "grCons";
            this.grCons.RowHeadersVisible = false;
            this.grCons.RowTemplate.Height = 24;
            this.grCons.Size = new System.Drawing.Size(673, 407);
            this.grCons.TabIndex = 2;
            this.grCons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCons_CellClick);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "cId";
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // cTypeId
            // 
            this.cTypeId.HeaderText = "TypeId";
            this.cTypeId.Name = "cTypeId";
            this.cTypeId.Visible = false;
            // 
            // cType
            // 
            this.cType.HeaderText = "Тип";
            this.cType.Name = "cType";
            // 
            // cAmount
            // 
            this.cAmount.DataPropertyName = "cAmount";
            this.cAmount.HeaderText = "Сумма";
            this.cAmount.Name = "cAmount";
            // 
            // cCert
            // 
            this.cCert.DataPropertyName = "cCert";
            this.cCert.FalseValue = "0";
            this.cCert.HeaderText = "Услуга серт.";
            this.cCert.Name = "cCert";
            this.cCert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cCert.TrueValue = "1";
            this.cCert.Visible = false;
            this.cCert.Width = 120;
            // 
            // cComment
            // 
            this.cComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cComment.DataPropertyName = "cComment";
            this.cComment.HeaderText = "Комментарий";
            this.cComment.Name = "cComment";
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "X";
            this.cDelete.Name = "cDelete";
            this.cDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cDelete.Text = "X";
            this.cDelete.ToolTipText = "Удалить запись";
            this.cDelete.UseColumnTextForButtonValue = true;
            this.cDelete.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cAmount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cComment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cComment";
            this.dataGridViewTextBoxColumn5.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 463);
            this.Controls.Add(this.grCons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrCons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расход";
            this.Load += new System.EventHandler(this.FrCons_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.DataGridView grCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn cComment;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
    }
}