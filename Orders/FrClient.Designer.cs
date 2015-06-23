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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.grClient = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 25);
            this.panel1.TabIndex = 3;
            // 
            // btOk
            // 
            this.btOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOk.Location = new System.Drawing.Point(0, 0);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(105, 25);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Выбрать";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(416, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 25);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.tbFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 25);
            this.panel2.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAdd.Location = new System.Drawing.Point(250, 0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(105, 25);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbFind
            // 
            this.tbFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFind.Location = new System.Drawing.Point(0, 0);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(250, 22);
            this.tbFind.TabIndex = 0;
            this.tbFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyUp);
            // 
            // grClient
            // 
            this.grClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grClient.Location = new System.Drawing.Point(0, 25);
            this.grClient.Name = "grClient";
            this.grClient.RowHeadersVisible = false;
            this.grClient.RowTemplate.Height = 24;
            this.grClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grClient.Size = new System.Drawing.Size(521, 534);
            this.grClient.TabIndex = 5;
            this.grClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grClient_CellContentClick);
            this.grClient.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grClient_CellValueChanged);
            // 
            // FrClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 584);
            this.Controls.Add(this.grClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrClient";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор клиента";
            this.Load += new System.EventHandler(this.FrClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grClient;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btAdd;
    }
}