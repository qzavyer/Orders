﻿namespace Orders
{
    partial class FrWorkType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrWorkType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.grWorkTypes = new System.Windows.Forms.DataGridView();
            this.eWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grWorkTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 518);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 25);
            this.panel1.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(327, 0);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 25);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btOk
            // 
            this.btOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOk.Location = new System.Drawing.Point(0, 0);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(105, 25);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Выбрать";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.tbFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 25);
            this.panel2.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(249, 0);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(249, 22);
            this.tbFind.TabIndex = 0;
            this.tbFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFind_KeyUp);
            // 
            // grWorkTypes
            // 
            this.grWorkTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grWorkTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grWorkTypes.Location = new System.Drawing.Point(0, 25);
            this.grWorkTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grWorkTypes.Name = "grWorkTypes";
            this.grWorkTypes.RowHeadersVisible = false;
            this.grWorkTypes.RowTemplate.Height = 24;
            this.grWorkTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grWorkTypes.Size = new System.Drawing.Size(432, 493);
            this.grWorkTypes.TabIndex = 2;
            // 
            // eWorkBindingSource
            // 
            this.eWorkBindingSource.DataSource = typeof(Orders.EWork);
            // 
            // FrWorkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 543);
            this.Controls.Add(this.grWorkTypes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(440, 568);
            this.Name = "FrWorkType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Виды работ";
            this.Load += new System.EventHandler(this.FrWorkType_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grWorkTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWorkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.DataGridView grWorkTypes;
        private System.Windows.Forms.BindingSource eWorkBindingSource;
        private System.Windows.Forms.Button btAdd;
    }
}