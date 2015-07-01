namespace Orders
{
    partial class FrClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.grClient = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
=======
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grClient = new System.Windows.Forms.DataGridView();
            this.fId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
>>>>>>> origin/Расход
            ((System.ComponentModel.ISupportInitialize)(this.grClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 20);
            this.panel1.TabIndex = 3;
            // 
            // btOk
            // 
            this.btOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOk.Location = new System.Drawing.Point(0, 0);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(79, 20);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Выбрать";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(570, 0);
            this.btSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(79, 20);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
<<<<<<< HEAD
            // panel2
            // 
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.tbFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 20);
            this.panel2.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAdd.Location = new System.Drawing.Point(188, 0);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(79, 20);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbFind
            // 
            this.tbFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFind.Location = new System.Drawing.Point(0, 0);
            this.tbFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(188, 20);
            this.tbFind.TabIndex = 0;
            this.tbFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyUp);
=======
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fPhone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fEmail";
            this.dataGridViewTextBoxColumn4.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fNote";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
>>>>>>> origin/Расход
            // 
            // grClient
            // 
            this.grClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.grClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grClient.Location = new System.Drawing.Point(0, 20);
            this.grClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grClient.Name = "grClient";
            this.grClient.RowHeadersVisible = false;
            this.grClient.RowTemplate.Height = 24;
            this.grClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grClient.Size = new System.Drawing.Size(649, 434);
            this.grClient.TabIndex = 5;
            this.grClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grClient_CellContentClick);
            this.grClient.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grClient_CellValueChanged);
=======
            this.grClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fId,
            this.fName,
            this.fPhone,
            this.fEmail,
            this.fNote});
            this.grClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grClient.Location = new System.Drawing.Point(0, 0);
            this.grClient.Name = "grClient";
            this.grClient.RowHeadersVisible = false;
            this.grClient.RowTemplate.Height = 24;
            this.grClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grClient.Size = new System.Drawing.Size(521, 559);
            this.grClient.TabIndex = 4;
            // 
            // fId
            // 
            this.fId.DataPropertyName = "fId";
            this.fId.HeaderText = "Id";
            this.fId.Name = "fId";
            this.fId.Visible = false;
            // 
            // fName
            // 
            this.fName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fName.DataPropertyName = "fName";
            this.fName.HeaderText = "Имя";
            this.fName.MinimumWidth = 20;
            this.fName.Name = "fName";
            // 
            // fPhone
            // 
            this.fPhone.DataPropertyName = "fPhone";
            this.fPhone.HeaderText = "Телефон";
            this.fPhone.Name = "fPhone";
            // 
            // fEmail
            // 
            this.fEmail.DataPropertyName = "fEmail";
            this.fEmail.HeaderText = "e-mail";
            this.fEmail.Name = "fEmail";
            // 
            // fNote
            // 
            this.fNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fNote.DataPropertyName = "fNote";
            this.fNote.FillWeight = 50F;
            this.fNote.HeaderText = "Примечание";
            this.fNote.MinimumWidth = 20;
            this.fNote.Name = "fNote";
>>>>>>> origin/Расход
            // 
            // FrClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(649, 474);
            this.Controls.Add(this.grClient);
            this.Controls.Add(this.panel2);
=======
            this.ClientSize = new System.Drawing.Size(521, 584);
            this.Controls.Add(this.grClient);
>>>>>>> origin/Расход
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrClient";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор клиента";
            this.Load += new System.EventHandler(this.FrClient_Load);
            this.panel1.ResumeLayout(false);
<<<<<<< HEAD
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
=======
>>>>>>> origin/Расход
            ((System.ComponentModel.ISupportInitialize)(this.grClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btSave;
<<<<<<< HEAD
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grClient;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btAdd;
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView grClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn fId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNote;
>>>>>>> origin/Расход
    }
}