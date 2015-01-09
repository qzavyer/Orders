using ZedGraph;

namespace Orders
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.grWork = new System.Windows.Forms.DataGridView();
            this.cType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cSource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cSert = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lHoursC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lIncomeC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lProfitC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lConsC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lMonthC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lHoursY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lIncomeY = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lIncomeYA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lProfitY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lConsY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pHistory = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lYearL = new System.Windows.Forms.Label();
            this.lYearC = new System.Windows.Forms.Label();
            this.lSumLAll = new System.Windows.Forms.Label();
            this.lSumCAll = new System.Windows.Forms.Label();
            this.lSumL12 = new System.Windows.Forms.Label();
            this.lSumC12 = new System.Windows.Forms.Label();
            this.btHistory12 = new System.Windows.Forms.Button();
            this.lSumL11 = new System.Windows.Forms.Label();
            this.lSumC11 = new System.Windows.Forms.Label();
            this.btHistory11 = new System.Windows.Forms.Button();
            this.lSumL9 = new System.Windows.Forms.Label();
            this.lSumC9 = new System.Windows.Forms.Label();
            this.lSumL10 = new System.Windows.Forms.Label();
            this.lSumC10 = new System.Windows.Forms.Label();
            this.lSumL7 = new System.Windows.Forms.Label();
            this.lSumC7 = new System.Windows.Forms.Label();
            this.lSumL8 = new System.Windows.Forms.Label();
            this.lSumC8 = new System.Windows.Forms.Label();
            this.lSumL5 = new System.Windows.Forms.Label();
            this.lSumC5 = new System.Windows.Forms.Label();
            this.lSumL6 = new System.Windows.Forms.Label();
            this.lSumC6 = new System.Windows.Forms.Label();
            this.lSumL3 = new System.Windows.Forms.Label();
            this.lSumC3 = new System.Windows.Forms.Label();
            this.lSumL4 = new System.Windows.Forms.Label();
            this.lSumC4 = new System.Windows.Forms.Label();
            this.lSumL1 = new System.Windows.Forms.Label();
            this.lSumC1 = new System.Windows.Forms.Label();
            this.lSumL2 = new System.Windows.Forms.Label();
            this.lSumC2 = new System.Windows.Forms.Label();
            this.btHistory10 = new System.Windows.Forms.Button();
            this.btHistory9 = new System.Windows.Forms.Button();
            this.btHistory8 = new System.Windows.Forms.Button();
            this.btHistory7 = new System.Windows.Forms.Button();
            this.btHistory6 = new System.Windows.Forms.Button();
            this.btHistory5 = new System.Windows.Forms.Button();
            this.btHistory4 = new System.Windows.Forms.Button();
            this.btHistory3 = new System.Windows.Forms.Button();
            this.btHistory2 = new System.Windows.Forms.Button();
            this.btHistory1 = new System.Windows.Forms.Button();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabSert = new System.Windows.Forms.TabPage();
            this.grCert = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btCertSave = new System.Windows.Forms.Button();
            this.tabConsum = new System.Windows.Forms.TabPage();
            this.grCons = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btConsSave = new System.Windows.Forms.Button();
            this.tabGloss = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.grDicClient = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btDicClientSave = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grDicSource = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btDicSourceSave = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grDicWork = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btDicWorkSave = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grDicCons = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btDicConsSave = new System.Windows.Forms.Button();
            this.tabArchive = new System.Windows.Forms.TabPage();
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
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCertId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdwId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdwName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabApp.SuspendLayout();
            this.tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grWork)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pHistory.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chYear)).BeginInit();
            this.tabSert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabConsum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabGloss.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicClient)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicSource)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicWork)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicCons)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.tabWork);
            this.tabApp.Controls.Add(this.tabGraph);
            this.tabApp.Controls.Add(this.tabSert);
            this.tabApp.Controls.Add(this.tabConsum);
            this.tabApp.Controls.Add(this.tabGloss);
            this.tabApp.Controls.Add(this.tabArchive);
            this.tabApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApp.Location = new System.Drawing.Point(0, 0);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(1421, 594);
            this.tabApp.TabIndex = 0;
            // 
            // tabWork
            // 
            this.tabWork.Controls.Add(this.grWork);
            this.tabWork.Controls.Add(this.panel3);
            this.tabWork.Controls.Add(this.panel2);
            this.tabWork.Controls.Add(this.pHistory);
            this.tabWork.Location = new System.Drawing.Point(4, 25);
            this.tabWork.Name = "tabWork";
            this.tabWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabWork.Size = new System.Drawing.Size(1413, 565);
            this.tabWork.TabIndex = 0;
            this.tabWork.Text = "Работа";
            this.tabWork.UseVisualStyleBackColor = true;
            // 
            // grWork
            // 
            this.grWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumber,
            this.cId,
            this.cClientId,
            this.cClient,
            this.cType,
            this.cPrepay,
            this.cExcess,
            this.cCons,
            this.cHours,
            this.cSource,
            this.cSert,
            this.cCertId});
            this.grWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grWork.Location = new System.Drawing.Point(3, 39);
            this.grWork.Name = "grWork";
            this.grWork.RowHeadersVisible = false;
            this.grWork.RowTemplate.Height = 24;
            this.grWork.Size = new System.Drawing.Size(1159, 487);
            this.grWork.TabIndex = 5;
            this.grWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grWork_CellClick);
            this.grWork.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grWork_CellValueChanged);
            // 
            // cType
            // 
            this.cType.HeaderText = "Тип";
            this.cType.Name = "cType";
            this.cType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cType.Visible = false;
            // 
            // cSource
            // 
            this.cSource.HeaderText = "Источник";
            this.cSource.Name = "cSource";
            this.cSource.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cSource.Visible = false;
            // 
            // cSert
            // 
            this.cSert.HeaderText = "Сертификат";
            this.cSert.Name = "cSert";
            this.cSert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lHoursC);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lProfitC);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lConsC);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lMonthC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1159, 36);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Часы:";
            // 
            // lHoursC
            // 
            this.lHoursC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHoursC.Location = new System.Drawing.Point(565, 1);
            this.lHoursC.Name = "lHoursC";
            this.lHoursC.Size = new System.Drawing.Size(78, 30);
            this.lHoursC.TabIndex = 46;
            this.lHoursC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lIncomeC);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(979, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 36);
            this.panel4.TabIndex = 34;
            // 
            // lIncomeC
            // 
            this.lIncomeC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncomeC.Location = new System.Drawing.Point(62, 1);
            this.lIncomeC.Name = "lIncomeC";
            this.lIncomeC.Size = new System.Drawing.Size(109, 30);
            this.lIncomeC.TabIndex = 31;
            this.lIncomeC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Доход:";
            // 
            // lProfitC
            // 
            this.lProfitC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lProfitC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProfitC.Location = new System.Drawing.Point(380, 1);
            this.lProfitC.Name = "lProfitC";
            this.lProfitC.Size = new System.Drawing.Size(78, 30);
            this.lProfitC.TabIndex = 33;
            this.lProfitC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Прибыль";
            // 
            // lConsC
            // 
            this.lConsC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsC.Location = new System.Drawing.Point(195, 1);
            this.lConsC.Name = "lConsC";
            this.lConsC.Size = new System.Drawing.Size(78, 30);
            this.lConsC.TabIndex = 31;
            this.lConsC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Расход:";
            // 
            // lMonthC
            // 
            this.lMonthC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMonthC.Location = new System.Drawing.Point(5, 2);
            this.lMonthC.Name = "lMonthC";
            this.lMonthC.Size = new System.Drawing.Size(120, 30);
            this.lMonthC.TabIndex = 27;
            this.lMonthC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lHoursY);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lIncomeYA);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lProfitY);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lConsY);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 36);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Часы:";
            // 
            // lHoursY
            // 
            this.lHoursY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHoursY.Location = new System.Drawing.Point(565, 1);
            this.lHoursY.Name = "lHoursY";
            this.lHoursY.Size = new System.Drawing.Size(78, 30);
            this.lHoursY.TabIndex = 44;
            this.lHoursY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lIncomeY);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(979, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 36);
            this.panel1.TabIndex = 43;
            // 
            // lIncomeY
            // 
            this.lIncomeY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncomeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncomeY.Location = new System.Drawing.Point(62, 1);
            this.lIncomeY.Name = "lIncomeY";
            this.lIncomeY.Size = new System.Drawing.Size(109, 30);
            this.lIncomeY.TabIndex = 37;
            this.lIncomeY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Доход:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(3, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 28);
            this.label15.TabIndex = 42;
            this.label15.Text = "За год:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lIncomeYA
            // 
            this.lIncomeYA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncomeYA.Location = new System.Drawing.Point(750, 1);
            this.lIncomeYA.Name = "lIncomeYA";
            this.lIncomeYA.Size = new System.Drawing.Size(78, 30);
            this.lIncomeYA.TabIndex = 41;
            this.lIncomeYA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(673, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Ср.доход:";
            // 
            // lProfitY
            // 
            this.lProfitY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lProfitY.Location = new System.Drawing.Point(380, 1);
            this.lProfitY.Name = "lProfitY";
            this.lProfitY.Size = new System.Drawing.Size(78, 30);
            this.lProfitY.TabIndex = 39;
            this.lProfitY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Прибыль";
            // 
            // lConsY
            // 
            this.lConsY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsY.Location = new System.Drawing.Point(195, 1);
            this.lConsY.Name = "lConsY";
            this.lConsY.Size = new System.Drawing.Size(78, 30);
            this.lConsY.TabIndex = 37;
            this.lConsY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Расход:";
            // 
            // pHistory
            // 
            this.pHistory.Controls.Add(this.btSave);
            this.pHistory.Controls.Add(this.label18);
            this.pHistory.Controls.Add(this.lYearL);
            this.pHistory.Controls.Add(this.lYearC);
            this.pHistory.Controls.Add(this.lSumLAll);
            this.pHistory.Controls.Add(this.lSumCAll);
            this.pHistory.Controls.Add(this.lSumL12);
            this.pHistory.Controls.Add(this.lSumC12);
            this.pHistory.Controls.Add(this.btHistory12);
            this.pHistory.Controls.Add(this.lSumL11);
            this.pHistory.Controls.Add(this.lSumC11);
            this.pHistory.Controls.Add(this.btHistory11);
            this.pHistory.Controls.Add(this.lSumL9);
            this.pHistory.Controls.Add(this.lSumC9);
            this.pHistory.Controls.Add(this.lSumL10);
            this.pHistory.Controls.Add(this.lSumC10);
            this.pHistory.Controls.Add(this.lSumL7);
            this.pHistory.Controls.Add(this.lSumC7);
            this.pHistory.Controls.Add(this.lSumL8);
            this.pHistory.Controls.Add(this.lSumC8);
            this.pHistory.Controls.Add(this.lSumL5);
            this.pHistory.Controls.Add(this.lSumC5);
            this.pHistory.Controls.Add(this.lSumL6);
            this.pHistory.Controls.Add(this.lSumC6);
            this.pHistory.Controls.Add(this.lSumL3);
            this.pHistory.Controls.Add(this.lSumC3);
            this.pHistory.Controls.Add(this.lSumL4);
            this.pHistory.Controls.Add(this.lSumC4);
            this.pHistory.Controls.Add(this.lSumL1);
            this.pHistory.Controls.Add(this.lSumC1);
            this.pHistory.Controls.Add(this.lSumL2);
            this.pHistory.Controls.Add(this.lSumC2);
            this.pHistory.Controls.Add(this.btHistory10);
            this.pHistory.Controls.Add(this.btHistory9);
            this.pHistory.Controls.Add(this.btHistory8);
            this.pHistory.Controls.Add(this.btHistory7);
            this.pHistory.Controls.Add(this.btHistory6);
            this.pHistory.Controls.Add(this.btHistory5);
            this.pHistory.Controls.Add(this.btHistory4);
            this.pHistory.Controls.Add(this.btHistory3);
            this.pHistory.Controls.Add(this.btHistory2);
            this.pHistory.Controls.Add(this.btHistory1);
            this.pHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pHistory.Location = new System.Drawing.Point(1162, 3);
            this.pHistory.Name = "pHistory";
            this.pHistory.Size = new System.Drawing.Size(248, 559);
            this.pHistory.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSave.Location = new System.Drawing.Point(0, 526);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(248, 33);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 477);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 30);
            this.label18.TabIndex = 46;
            this.label18.Text = "Итого:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lYearL
            // 
            this.lYearL.Location = new System.Drawing.Point(168, 6);
            this.lYearL.Name = "lYearL";
            this.lYearL.Size = new System.Drawing.Size(78, 30);
            this.lYearL.TabIndex = 45;
            this.lYearL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lYearC
            // 
            this.lYearC.Location = new System.Drawing.Point(88, 6);
            this.lYearC.Name = "lYearC";
            this.lYearC.Size = new System.Drawing.Size(78, 30);
            this.lYearC.TabIndex = 44;
            this.lYearC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lSumLAll
            // 
            this.lSumLAll.Location = new System.Drawing.Point(168, 477);
            this.lSumLAll.Name = "lSumLAll";
            this.lSumLAll.Size = new System.Drawing.Size(78, 30);
            this.lSumLAll.TabIndex = 43;
            this.lSumLAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumCAll
            // 
            this.lSumCAll.Location = new System.Drawing.Point(88, 477);
            this.lSumCAll.Name = "lSumCAll";
            this.lSumCAll.Size = new System.Drawing.Size(78, 30);
            this.lSumCAll.TabIndex = 42;
            this.lSumCAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL12
            // 
            this.lSumL12.Location = new System.Drawing.Point(168, 433);
            this.lSumL12.Name = "lSumL12";
            this.lSumL12.Size = new System.Drawing.Size(78, 30);
            this.lSumL12.TabIndex = 41;
            this.lSumL12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC12
            // 
            this.lSumC12.Location = new System.Drawing.Point(88, 433);
            this.lSumC12.Name = "lSumC12";
            this.lSumC12.Size = new System.Drawing.Size(78, 30);
            this.lSumC12.TabIndex = 40;
            this.lSumC12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btHistory12
            // 
            this.btHistory12.Location = new System.Drawing.Point(6, 433);
            this.btHistory12.Name = "btHistory12";
            this.btHistory12.Size = new System.Drawing.Size(82, 30);
            this.btHistory12.TabIndex = 39;
            this.btHistory12.Tag = "12";
            this.btHistory12.Text = "Декабрь";
            this.btHistory12.UseVisualStyleBackColor = true;
            this.btHistory12.Click += new System.EventHandler(this.History_Click);
            // 
            // lSumL11
            // 
            this.lSumL11.Location = new System.Drawing.Point(168, 397);
            this.lSumL11.Name = "lSumL11";
            this.lSumL11.Size = new System.Drawing.Size(78, 30);
            this.lSumL11.TabIndex = 38;
            this.lSumL11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC11
            // 
            this.lSumC11.Location = new System.Drawing.Point(88, 397);
            this.lSumC11.Name = "lSumC11";
            this.lSumC11.Size = new System.Drawing.Size(78, 30);
            this.lSumC11.TabIndex = 37;
            this.lSumC11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btHistory11
            // 
            this.btHistory11.Location = new System.Drawing.Point(6, 397);
            this.btHistory11.Name = "btHistory11";
            this.btHistory11.Size = new System.Drawing.Size(82, 30);
            this.btHistory11.TabIndex = 36;
            this.btHistory11.Tag = "11";
            this.btHistory11.Text = "Ноябрь";
            this.btHistory11.UseVisualStyleBackColor = true;
            this.btHistory11.Click += new System.EventHandler(this.History_Click);
            // 
            // lSumL9
            // 
            this.lSumL9.Location = new System.Drawing.Point(168, 325);
            this.lSumL9.Name = "lSumL9";
            this.lSumL9.Size = new System.Drawing.Size(78, 30);
            this.lSumL9.TabIndex = 35;
            this.lSumL9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC9
            // 
            this.lSumC9.Location = new System.Drawing.Point(88, 325);
            this.lSumC9.Name = "lSumC9";
            this.lSumC9.Size = new System.Drawing.Size(78, 30);
            this.lSumC9.TabIndex = 34;
            this.lSumC9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL10
            // 
            this.lSumL10.Location = new System.Drawing.Point(168, 361);
            this.lSumL10.Name = "lSumL10";
            this.lSumL10.Size = new System.Drawing.Size(78, 30);
            this.lSumL10.TabIndex = 33;
            this.lSumL10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC10
            // 
            this.lSumC10.Location = new System.Drawing.Point(88, 361);
            this.lSumC10.Name = "lSumC10";
            this.lSumC10.Size = new System.Drawing.Size(78, 30);
            this.lSumC10.TabIndex = 32;
            this.lSumC10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL7
            // 
            this.lSumL7.Location = new System.Drawing.Point(168, 253);
            this.lSumL7.Name = "lSumL7";
            this.lSumL7.Size = new System.Drawing.Size(78, 30);
            this.lSumL7.TabIndex = 31;
            this.lSumL7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC7
            // 
            this.lSumC7.Location = new System.Drawing.Point(88, 253);
            this.lSumC7.Name = "lSumC7";
            this.lSumC7.Size = new System.Drawing.Size(78, 30);
            this.lSumC7.TabIndex = 30;
            this.lSumC7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL8
            // 
            this.lSumL8.Location = new System.Drawing.Point(168, 289);
            this.lSumL8.Name = "lSumL8";
            this.lSumL8.Size = new System.Drawing.Size(78, 30);
            this.lSumL8.TabIndex = 29;
            this.lSumL8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC8
            // 
            this.lSumC8.Location = new System.Drawing.Point(88, 289);
            this.lSumC8.Name = "lSumC8";
            this.lSumC8.Size = new System.Drawing.Size(78, 30);
            this.lSumC8.TabIndex = 28;
            this.lSumC8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL5
            // 
            this.lSumL5.Location = new System.Drawing.Point(168, 181);
            this.lSumL5.Name = "lSumL5";
            this.lSumL5.Size = new System.Drawing.Size(78, 30);
            this.lSumL5.TabIndex = 27;
            this.lSumL5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC5
            // 
            this.lSumC5.Location = new System.Drawing.Point(88, 181);
            this.lSumC5.Name = "lSumC5";
            this.lSumC5.Size = new System.Drawing.Size(78, 30);
            this.lSumC5.TabIndex = 26;
            this.lSumC5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL6
            // 
            this.lSumL6.Location = new System.Drawing.Point(168, 217);
            this.lSumL6.Name = "lSumL6";
            this.lSumL6.Size = new System.Drawing.Size(78, 30);
            this.lSumL6.TabIndex = 25;
            this.lSumL6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC6
            // 
            this.lSumC6.Location = new System.Drawing.Point(88, 217);
            this.lSumC6.Name = "lSumC6";
            this.lSumC6.Size = new System.Drawing.Size(78, 30);
            this.lSumC6.TabIndex = 24;
            this.lSumC6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL3
            // 
            this.lSumL3.Location = new System.Drawing.Point(168, 109);
            this.lSumL3.Name = "lSumL3";
            this.lSumL3.Size = new System.Drawing.Size(78, 30);
            this.lSumL3.TabIndex = 23;
            this.lSumL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC3
            // 
            this.lSumC3.Location = new System.Drawing.Point(88, 109);
            this.lSumC3.Name = "lSumC3";
            this.lSumC3.Size = new System.Drawing.Size(78, 30);
            this.lSumC3.TabIndex = 22;
            this.lSumC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL4
            // 
            this.lSumL4.Location = new System.Drawing.Point(168, 145);
            this.lSumL4.Name = "lSumL4";
            this.lSumL4.Size = new System.Drawing.Size(78, 30);
            this.lSumL4.TabIndex = 21;
            this.lSumL4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC4
            // 
            this.lSumC4.Location = new System.Drawing.Point(88, 145);
            this.lSumC4.Name = "lSumC4";
            this.lSumC4.Size = new System.Drawing.Size(78, 30);
            this.lSumC4.TabIndex = 20;
            this.lSumC4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL1
            // 
            this.lSumL1.Location = new System.Drawing.Point(168, 37);
            this.lSumL1.Name = "lSumL1";
            this.lSumL1.Size = new System.Drawing.Size(78, 30);
            this.lSumL1.TabIndex = 19;
            this.lSumL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC1
            // 
            this.lSumC1.Location = new System.Drawing.Point(88, 37);
            this.lSumC1.Name = "lSumC1";
            this.lSumC1.Size = new System.Drawing.Size(78, 30);
            this.lSumC1.TabIndex = 18;
            this.lSumC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL2
            // 
            this.lSumL2.Location = new System.Drawing.Point(168, 73);
            this.lSumL2.Name = "lSumL2";
            this.lSumL2.Size = new System.Drawing.Size(78, 30);
            this.lSumL2.TabIndex = 17;
            this.lSumL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC2
            // 
            this.lSumC2.Location = new System.Drawing.Point(88, 73);
            this.lSumC2.Name = "lSumC2";
            this.lSumC2.Size = new System.Drawing.Size(78, 30);
            this.lSumC2.TabIndex = 14;
            this.lSumC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btHistory10
            // 
            this.btHistory10.Location = new System.Drawing.Point(6, 361);
            this.btHistory10.Name = "btHistory10";
            this.btHistory10.Size = new System.Drawing.Size(82, 30);
            this.btHistory10.TabIndex = 10;
            this.btHistory10.Tag = "10";
            this.btHistory10.Text = "Октябрь";
            this.btHistory10.UseVisualStyleBackColor = true;
            this.btHistory10.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory9
            // 
            this.btHistory9.Location = new System.Drawing.Point(6, 325);
            this.btHistory9.Name = "btHistory9";
            this.btHistory9.Size = new System.Drawing.Size(82, 30);
            this.btHistory9.TabIndex = 9;
            this.btHistory9.Tag = "9";
            this.btHistory9.Text = "Сентябрь";
            this.btHistory9.UseVisualStyleBackColor = true;
            this.btHistory9.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory8
            // 
            this.btHistory8.Location = new System.Drawing.Point(6, 289);
            this.btHistory8.Name = "btHistory8";
            this.btHistory8.Size = new System.Drawing.Size(82, 30);
            this.btHistory8.TabIndex = 8;
            this.btHistory8.Tag = "8";
            this.btHistory8.Text = "Август";
            this.btHistory8.UseVisualStyleBackColor = true;
            this.btHistory8.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory7
            // 
            this.btHistory7.Location = new System.Drawing.Point(6, 253);
            this.btHistory7.Name = "btHistory7";
            this.btHistory7.Size = new System.Drawing.Size(82, 30);
            this.btHistory7.TabIndex = 7;
            this.btHistory7.Tag = "7";
            this.btHistory7.Text = "Июль";
            this.btHistory7.UseVisualStyleBackColor = true;
            this.btHistory7.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory6
            // 
            this.btHistory6.Location = new System.Drawing.Point(6, 217);
            this.btHistory6.Name = "btHistory6";
            this.btHistory6.Size = new System.Drawing.Size(82, 30);
            this.btHistory6.TabIndex = 6;
            this.btHistory6.Tag = "6";
            this.btHistory6.Text = "Июнь";
            this.btHistory6.UseVisualStyleBackColor = true;
            this.btHistory6.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory5
            // 
            this.btHistory5.Location = new System.Drawing.Point(6, 181);
            this.btHistory5.Name = "btHistory5";
            this.btHistory5.Size = new System.Drawing.Size(82, 30);
            this.btHistory5.TabIndex = 5;
            this.btHistory5.Tag = "5";
            this.btHistory5.Text = "Май";
            this.btHistory5.UseVisualStyleBackColor = true;
            this.btHistory5.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory4
            // 
            this.btHistory4.Location = new System.Drawing.Point(6, 145);
            this.btHistory4.Name = "btHistory4";
            this.btHistory4.Size = new System.Drawing.Size(82, 30);
            this.btHistory4.TabIndex = 4;
            this.btHistory4.Tag = "4";
            this.btHistory4.Text = "Апрель";
            this.btHistory4.UseVisualStyleBackColor = true;
            this.btHistory4.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory3
            // 
            this.btHistory3.Location = new System.Drawing.Point(6, 109);
            this.btHistory3.Name = "btHistory3";
            this.btHistory3.Size = new System.Drawing.Size(82, 30);
            this.btHistory3.TabIndex = 3;
            this.btHistory3.Tag = "3";
            this.btHistory3.Text = "Март";
            this.btHistory3.UseVisualStyleBackColor = true;
            this.btHistory3.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory2
            // 
            this.btHistory2.Location = new System.Drawing.Point(6, 73);
            this.btHistory2.Name = "btHistory2";
            this.btHistory2.Size = new System.Drawing.Size(82, 30);
            this.btHistory2.TabIndex = 2;
            this.btHistory2.Tag = "2";
            this.btHistory2.Text = "Февраль";
            this.btHistory2.UseVisualStyleBackColor = true;
            this.btHistory2.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory1
            // 
            this.btHistory1.Location = new System.Drawing.Point(6, 37);
            this.btHistory1.Name = "btHistory1";
            this.btHistory1.Size = new System.Drawing.Size(82, 30);
            this.btHistory1.TabIndex = 0;
            this.btHistory1.Tag = "1";
            this.btHistory1.Text = "Январь";
            this.btHistory1.UseVisualStyleBackColor = true;
            this.btHistory1.Click += new System.EventHandler(this.History_Click);
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.splitContainer1);
            this.tabGraph.Location = new System.Drawing.Point(4, 25);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1413, 565);
            this.tabGraph.TabIndex = 4;
            this.tabGraph.Text = "Графики";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chMonth);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chYear);
            this.splitContainer1.Size = new System.Drawing.Size(1407, 559);
            this.splitContainer1.SplitterDistance = 682;
            this.splitContainer1.TabIndex = 3;
            // 
            // chMonth
            // 
            this.chMonth.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            chartArea1.AxisY.Title = "Количество";
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisY.Title = "Сумма (тыс.руб.)";
            chartArea2.Name = "ChartArea2";
            this.chMonth.ChartAreas.Add(chartArea1);
            this.chMonth.ChartAreas.Add(chartArea2);
            this.chMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chMonth.Location = new System.Drawing.Point(0, 0);
            this.chMonth.Name = "chMonth";
            this.chMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Name = "count";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea2";
            series2.Name = "income";
            this.chMonth.Series.Add(series1);
            this.chMonth.Series.Add(series2);
            this.chMonth.Size = new System.Drawing.Size(682, 559);
            this.chMonth.TabIndex = 1;
            this.chMonth.Text = "Месячный график";
            title1.Name = "Title1";
            title1.Text = "Месячный график";
            this.chMonth.Titles.Add(title1);
            // 
            // chYear
            // 
            chartArea3.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.MaximumAutoSize = 50F;
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "ChartArea2";
            this.chYear.ChartAreas.Add(chartArea3);
            this.chYear.ChartAreas.Add(chartArea4);
            this.chYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chYear.Location = new System.Drawing.Point(0, 0);
            this.chYear.Name = "chYear";
            this.chYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "count";
            series4.ChartArea = "ChartArea2";
            series4.Name = "income";
            this.chYear.Series.Add(series3);
            this.chYear.Series.Add(series4);
            this.chYear.Size = new System.Drawing.Size(721, 559);
            this.chYear.TabIndex = 3;
            this.chYear.Text = "Годовой график";
            title2.Name = "Title1";
            title2.Text = "Годовой график";
            this.chYear.Titles.Add(title2);
            // 
            // tabSert
            // 
            this.tabSert.Controls.Add(this.grCert);
            this.tabSert.Controls.Add(this.panel6);
            this.tabSert.Location = new System.Drawing.Point(4, 25);
            this.tabSert.Name = "tabSert";
            this.tabSert.Padding = new System.Windows.Forms.Padding(3);
            this.tabSert.Size = new System.Drawing.Size(1413, 565);
            this.tabSert.TabIndex = 1;
            this.tabSert.Text = "Сертификаты";
            this.tabSert.UseVisualStyleBackColor = true;
            // 
            // grCert
            // 
            this.grCert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccNumber,
            this.ccId,
            this.ccPayerId,
            this.ccPayerName,
            this.ccClientId,
            this.ccClientName,
            this.ccPrice,
            this.ccCons,
            this.ccHours});
            this.grCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCert.Location = new System.Drawing.Point(3, 3);
            this.grCert.Name = "grCert";
            this.grCert.RowHeadersVisible = false;
            this.grCert.RowTemplate.Height = 24;
            this.grCert.Size = new System.Drawing.Size(1407, 534);
            this.grCert.TabIndex = 1;
            this.grCert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCert_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btCertSave);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 537);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1407, 25);
            this.panel6.TabIndex = 0;
            // 
            // btCertSave
            // 
            this.btCertSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCertSave.Location = new System.Drawing.Point(1302, 0);
            this.btCertSave.Name = "btCertSave";
            this.btCertSave.Size = new System.Drawing.Size(105, 25);
            this.btCertSave.TabIndex = 0;
            this.btCertSave.Text = "Сохранить";
            this.btCertSave.UseVisualStyleBackColor = true;
            this.btCertSave.Click += new System.EventHandler(this.btCertSave_Click);
            // 
            // tabConsum
            // 
            this.tabConsum.Controls.Add(this.grCons);
            this.tabConsum.Controls.Add(this.panel5);
            this.tabConsum.Location = new System.Drawing.Point(4, 25);
            this.tabConsum.Name = "tabConsum";
            this.tabConsum.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsum.Size = new System.Drawing.Size(1413, 565);
            this.tabConsum.TabIndex = 2;
            this.tabConsum.Text = "Расходы";
            this.tabConsum.UseVisualStyleBackColor = true;
            // 
            // grCons
            // 
            this.grCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csId,
            this.csNumber,
            this.csAmount,
            this.csComment});
            this.grCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCons.Location = new System.Drawing.Point(3, 3);
            this.grCons.Name = "grCons";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grCons.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grCons.RowHeadersVisible = false;
            this.grCons.RowTemplate.Height = 24;
            this.grCons.Size = new System.Drawing.Size(1407, 534);
            this.grCons.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btConsSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 537);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1407, 25);
            this.panel5.TabIndex = 0;
            // 
            // btConsSave
            // 
            this.btConsSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btConsSave.Location = new System.Drawing.Point(1302, 0);
            this.btConsSave.Name = "btConsSave";
            this.btConsSave.Size = new System.Drawing.Size(105, 25);
            this.btConsSave.TabIndex = 0;
            this.btConsSave.Text = "Сохранить";
            this.btConsSave.UseVisualStyleBackColor = true;
            this.btConsSave.Click += new System.EventHandler(this.btConsSave_Click);
            // 
            // tabGloss
            // 
            this.tabGloss.Controls.Add(this.panel16);
            this.tabGloss.Controls.Add(this.panel7);
            this.tabGloss.Controls.Add(this.panel9);
            this.tabGloss.Controls.Add(this.panel8);
            this.tabGloss.Location = new System.Drawing.Point(4, 25);
            this.tabGloss.Name = "tabGloss";
            this.tabGloss.Padding = new System.Windows.Forms.Padding(3);
            this.tabGloss.Size = new System.Drawing.Size(1413, 565);
            this.tabGloss.TabIndex = 3;
            this.tabGloss.Text = "Справочники";
            this.tabGloss.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.grDicClient);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(597, 559);
            this.panel16.TabIndex = 5;
            // 
            // grDicClient
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grDicClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdpId,
            this.cdpName,
            this.cdpPhone,
            this.cdpMail,
            this.cdpNote});
            this.grDicClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicClient.Location = new System.Drawing.Point(0, 25);
            this.grDicClient.Name = "grDicClient";
            this.grDicClient.RowHeadersVisible = false;
            this.grDicClient.RowTemplate.Height = 24;
            this.grDicClient.Size = new System.Drawing.Size(597, 509);
            this.grDicClient.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label11);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(597, 25);
            this.panel17.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(597, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Клинеты";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btDicClientSave);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(0, 534);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(597, 25);
            this.panel18.TabIndex = 0;
            // 
            // btDicClientSave
            // 
            this.btDicClientSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDicClientSave.Location = new System.Drawing.Point(492, 0);
            this.btDicClientSave.Name = "btDicClientSave";
            this.btDicClientSave.Size = new System.Drawing.Size(105, 25);
            this.btDicClientSave.TabIndex = 1;
            this.btDicClientSave.Text = "Сохранить";
            this.btDicClientSave.UseVisualStyleBackColor = true;
            this.btDicClientSave.Click += new System.EventHandler(this.btDicClientSave_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grDicSource);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(600, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 559);
            this.panel7.TabIndex = 4;
            // 
            // grDicSource
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grDicSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdsId,
            this.cdsName});
            this.grDicSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicSource.Location = new System.Drawing.Point(0, 25);
            this.grDicSource.Name = "grDicSource";
            this.grDicSource.RowHeadersVisible = false;
            this.grDicSource.RowTemplate.Height = 24;
            this.grDicSource.Size = new System.Drawing.Size(270, 509);
            this.grDicSource.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label9);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(270, 25);
            this.panel13.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Источники";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btDicSourceSave);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 534);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(270, 25);
            this.panel10.TabIndex = 0;
            // 
            // btDicSourceSave
            // 
            this.btDicSourceSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDicSourceSave.Location = new System.Drawing.Point(165, 0);
            this.btDicSourceSave.Name = "btDicSourceSave";
            this.btDicSourceSave.Size = new System.Drawing.Size(105, 25);
            this.btDicSourceSave.TabIndex = 1;
            this.btDicSourceSave.Text = "Сохранить";
            this.btDicSourceSave.UseVisualStyleBackColor = true;
            this.btDicSourceSave.Click += new System.EventHandler(this.btDicSourceSave_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grDicWork);
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(870, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 559);
            this.panel9.TabIndex = 2;
            // 
            // grDicWork
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grDicWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdwId,
            this.cdwName});
            this.grDicWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicWork.Location = new System.Drawing.Point(0, 25);
            this.grDicWork.Name = "grDicWork";
            this.grDicWork.RowHeadersVisible = false;
            this.grDicWork.RowTemplate.Height = 24;
            this.grDicWork.Size = new System.Drawing.Size(270, 509);
            this.grDicWork.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label7);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(270, 25);
            this.panel14.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Тип работы";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btDicWorkSave);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 534);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(270, 25);
            this.panel11.TabIndex = 0;
            // 
            // btDicWorkSave
            // 
            this.btDicWorkSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDicWorkSave.Location = new System.Drawing.Point(165, 0);
            this.btDicWorkSave.Name = "btDicWorkSave";
            this.btDicWorkSave.Size = new System.Drawing.Size(105, 25);
            this.btDicWorkSave.TabIndex = 0;
            this.btDicWorkSave.Text = "Сохранить";
            this.btDicWorkSave.UseVisualStyleBackColor = true;
            this.btDicWorkSave.Click += new System.EventHandler(this.btDicWorkSave_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.grDicCons);
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1140, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 559);
            this.panel8.TabIndex = 1;
            // 
            // grDicCons
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicCons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grDicCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdcId,
            this.cdcName});
            this.grDicCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicCons.Location = new System.Drawing.Point(0, 25);
            this.grDicCons.Name = "grDicCons";
            this.grDicCons.RowHeadersVisible = false;
            this.grDicCons.RowTemplate.Height = 24;
            this.grDicCons.Size = new System.Drawing.Size(270, 509);
            this.grDicCons.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label5);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(270, 25);
            this.panel15.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тип расхода";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btDicConsSave);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 534);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(270, 25);
            this.panel12.TabIndex = 0;
            // 
            // btDicConsSave
            // 
            this.btDicConsSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDicConsSave.Location = new System.Drawing.Point(165, 0);
            this.btDicConsSave.Name = "btDicConsSave";
            this.btDicConsSave.Size = new System.Drawing.Size(105, 25);
            this.btDicConsSave.TabIndex = 0;
            this.btDicConsSave.Text = "Сохранить";
            this.btDicConsSave.UseVisualStyleBackColor = true;
            this.btDicConsSave.Click += new System.EventHandler(this.btDicConsSave_Click);
            // 
            // tabArchive
            // 
            this.tabArchive.Location = new System.Drawing.Point(4, 25);
            this.tabArchive.Name = "tabArchive";
            this.tabArchive.Padding = new System.Windows.Forms.Padding(3);
            this.tabArchive.Size = new System.Drawing.Size(1413, 565);
            this.tabArchive.TabIndex = 5;
            this.tabArchive.Text = "Архив";
            this.tabArchive.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "cClientId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Предоплата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Доплата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Расход";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Часы";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ccId";
            this.dataGridViewTextBoxColumn9.HeaderText = "";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 30;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ccPayerId";
            this.dataGridViewTextBoxColumn10.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 30;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ccPayName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ccClientId";
            this.dataGridViewTextBoxColumn12.HeaderText = "";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ccClientName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ccPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ccHours";
            this.dataGridViewTextBoxColumn15.HeaderText = "Часы";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "csNumber";
            this.dataGridViewTextBoxColumn16.HeaderText = "";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "csAmount";
            this.dataGridViewTextBoxColumn17.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "csComment";
            this.dataGridViewTextBoxColumn18.FillWeight = 40F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "csComment";
            this.dataGridViewTextBoxColumn19.FillWeight = 40F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn20.FillWeight = 40F;
            this.dataGridViewTextBoxColumn20.HeaderText = "";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn21.FillWeight = 70F;
            this.dataGridViewTextBoxColumn21.HeaderText = "Название";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 974;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "fPhone";
            this.dataGridViewTextBoxColumn22.FillWeight = 70F;
            this.dataGridViewTextBoxColumn22.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "fEmail";
            this.dataGridViewTextBoxColumn23.FillWeight = 70F;
            this.dataGridViewTextBoxColumn23.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "fNote";
            this.dataGridViewTextBoxColumn24.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn25.HeaderText = "";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn26.FillWeight = 70F;
            this.dataGridViewTextBoxColumn26.HeaderText = "Название";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn27.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn27.FillWeight = 70F;
            this.dataGridViewTextBoxColumn27.HeaderText = "Id";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn28.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn28.FillWeight = 70F;
            this.dataGridViewTextBoxColumn28.HeaderText = "Название";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn29.HeaderText = "Id";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn30.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn30.HeaderText = "Название";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn31.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn31.HeaderText = "Название";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn32.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn32.HeaderText = "Название";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "";
            this.cNumber.Name = "cNumber";
            this.cNumber.ReadOnly = true;
            this.cNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNumber.Width = 40;
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cClientId
            // 
            this.cClientId.HeaderText = "cClientId";
            this.cClientId.Name = "cClientId";
            this.cClientId.Visible = false;
            // 
            // cClient
            // 
            this.cClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cClient.HeaderText = "Клиент";
            this.cClient.Name = "cClient";
            // 
            // cPrepay
            // 
            this.cPrepay.HeaderText = "Предоплата";
            this.cPrepay.Name = "cPrepay";
            // 
            // cExcess
            // 
            this.cExcess.HeaderText = "Доплата";
            this.cExcess.Name = "cExcess";
            // 
            // cCons
            // 
            this.cCons.HeaderText = "Расход";
            this.cCons.Name = "cCons";
            // 
            // cHours
            // 
            this.cHours.HeaderText = "Часы";
            this.cHours.Name = "cHours";
            // 
            // cCertId
            // 
            this.cCertId.DataPropertyName = "cCertId";
            this.cCertId.HeaderText = "CertId";
            this.cCertId.Name = "cCertId";
            this.cCertId.Visible = false;
            // 
            // csId
            // 
            this.csId.DataPropertyName = "csId";
            this.csId.HeaderText = "";
            this.csId.Name = "csId";
            this.csId.ReadOnly = true;
            this.csId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.csId.Visible = false;
            // 
            // csNumber
            // 
            this.csNumber.DataPropertyName = "csNumber";
            this.csNumber.HeaderText = "";
            this.csNumber.Name = "csNumber";
            this.csNumber.ReadOnly = true;
            this.csNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.csNumber.Width = 40;
            // 
            // csAmount
            // 
            this.csAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.csAmount.DataPropertyName = "csAmount";
            this.csAmount.FillWeight = 40F;
            this.csAmount.HeaderText = "Сумма";
            this.csAmount.Name = "csAmount";
            // 
            // csComment
            // 
            this.csComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.csComment.DataPropertyName = "csComment";
            this.csComment.HeaderText = "Комментарий";
            this.csComment.Name = "csComment";
            // 
            // cdpId
            // 
            this.cdpId.DataPropertyName = "fId";
            this.cdpId.HeaderText = "Id";
            this.cdpId.Name = "cdpId";
            this.cdpId.Visible = false;
            // 
            // cdpName
            // 
            this.cdpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdpName.DataPropertyName = "fName";
            this.cdpName.FillWeight = 70F;
            this.cdpName.HeaderText = "Имя";
            this.cdpName.Name = "cdpName";
            // 
            // cdpPhone
            // 
            this.cdpPhone.DataPropertyName = "fPhone";
            this.cdpPhone.HeaderText = "Телефон";
            this.cdpPhone.Name = "cdpPhone";
            // 
            // cdpMail
            // 
            this.cdpMail.DataPropertyName = "fEmail";
            this.cdpMail.HeaderText = "E-mail";
            this.cdpMail.Name = "cdpMail";
            // 
            // cdpNote
            // 
            this.cdpNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdpNote.DataPropertyName = "fNote";
            this.cdpNote.HeaderText = "Примечание";
            this.cdpNote.Name = "cdpNote";
            // 
            // cdsId
            // 
            this.cdsId.DataPropertyName = "fId";
            this.cdsId.HeaderText = "Id";
            this.cdsId.Name = "cdsId";
            this.cdsId.Visible = false;
            // 
            // cdsName
            // 
            this.cdsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdsName.DataPropertyName = "fName";
            this.cdsName.FillWeight = 70F;
            this.cdsName.HeaderText = "Название";
            this.cdsName.Name = "cdsName";
            // 
            // cdwId
            // 
            this.cdwId.DataPropertyName = "fId";
            this.cdwId.HeaderText = "";
            this.cdwId.Name = "cdwId";
            this.cdwId.Visible = false;
            // 
            // cdwName
            // 
            this.cdwName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdwName.DataPropertyName = "fName";
            this.cdwName.HeaderText = "Название";
            this.cdwName.Name = "cdwName";
            // 
            // cdcId
            // 
            this.cdcId.DataPropertyName = "fId";
            this.cdcId.HeaderText = "Id";
            this.cdcId.Name = "cdcId";
            this.cdcId.Visible = false;
            // 
            // cdcName
            // 
            this.cdcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdcName.DataPropertyName = "fName";
            this.cdcName.HeaderText = "Название";
            this.cdcName.Name = "cdcName";
            // 
            // ccNumber
            // 
            this.ccNumber.DataPropertyName = "ccNumber";
            this.ccNumber.HeaderText = "";
            this.ccNumber.Name = "ccNumber";
            this.ccNumber.ReadOnly = true;
            this.ccNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ccNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ccNumber.Width = 30;
            // 
            // ccId
            // 
            this.ccId.DataPropertyName = "ccId";
            this.ccId.HeaderText = "Id";
            this.ccId.Name = "ccId";
            this.ccId.Visible = false;
            // 
            // ccPayerId
            // 
            this.ccPayerId.DataPropertyName = "ccPayerId";
            this.ccPayerId.HeaderText = "PayerId";
            this.ccPayerId.Name = "ccPayerId";
            this.ccPayerId.Visible = false;
            // 
            // ccPayerName
            // 
            this.ccPayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ccPayerName.DataPropertyName = "ccPayerName";
            this.ccPayerName.HeaderText = "Плательщик";
            this.ccPayerName.Name = "ccPayerName";
            // 
            // ccClientId
            // 
            this.ccClientId.DataPropertyName = "ccClientId";
            this.ccClientId.HeaderText = "ClientId";
            this.ccClientId.Name = "ccClientId";
            this.ccClientId.Visible = false;
            // 
            // ccClientName
            // 
            this.ccClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ccClientName.DataPropertyName = "ccClientName";
            this.ccClientName.HeaderText = "Клиент";
            this.ccClientName.Name = "ccClientName";
            // 
            // ccPrice
            // 
            this.ccPrice.DataPropertyName = "ccPrice";
            this.ccPrice.HeaderText = "Сумма";
            this.ccPrice.Name = "ccPrice";
            // 
            // ccCons
            // 
            this.ccCons.DataPropertyName = "ccCons";
            this.ccCons.HeaderText = "Расход";
            this.ccCons.Name = "ccCons";
            // 
            // ccHours
            // 
            this.ccHours.DataPropertyName = "ccHours";
            this.ccHours.HeaderText = "Часы";
            this.ccHours.Name = "ccHours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 594);
            this.Controls.Add(this.tabApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1429, 627);
            this.Name = "Form1";
            this.Text = "Обсчёт заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabApp.ResumeLayout(false);
            this.tabWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grWork)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pHistory.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chYear)).EndInit();
            this.tabSert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabConsum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabGloss.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicClient)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicSource)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicWork)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicCons)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabSert;
        private System.Windows.Forms.TabPage tabConsum;
        private System.Windows.Forms.TabPage tabGloss;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.DataGridView grWork;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btHistory10;
        private System.Windows.Forms.Button btHistory9;
        private System.Windows.Forms.Button btHistory8;
        private System.Windows.Forms.Button btHistory7;
        private System.Windows.Forms.Button btHistory6;
        private System.Windows.Forms.Button btHistory5;
        private System.Windows.Forms.Button btHistory4;
        private System.Windows.Forms.Button btHistory3;
        private System.Windows.Forms.Button btHistory2;
        private System.Windows.Forms.Button btHistory1;
        private System.Windows.Forms.Label lSumC2;
        private System.Windows.Forms.Label lSumL2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lYearL;
        private System.Windows.Forms.Label lYearC;
        private System.Windows.Forms.Label lSumLAll;
        private System.Windows.Forms.Label lSumCAll;
        private System.Windows.Forms.Label lSumL12;
        private System.Windows.Forms.Label lSumC12;
        private System.Windows.Forms.Button btHistory12;
        private System.Windows.Forms.Label lSumL11;
        private System.Windows.Forms.Label lSumC11;
        private System.Windows.Forms.Button btHistory11;
        private System.Windows.Forms.Label lSumL9;
        private System.Windows.Forms.Label lSumC9;
        private System.Windows.Forms.Label lSumL10;
        private System.Windows.Forms.Label lSumC10;
        private System.Windows.Forms.Label lSumL7;
        private System.Windows.Forms.Label lSumC7;
        private System.Windows.Forms.Label lSumL8;
        private System.Windows.Forms.Label lSumC8;
        private System.Windows.Forms.Label lSumL5;
        private System.Windows.Forms.Label lSumC5;
        private System.Windows.Forms.Label lSumL6;
        private System.Windows.Forms.Label lSumC6;
        private System.Windows.Forms.Label lSumL3;
        private System.Windows.Forms.Label lSumC3;
        private System.Windows.Forms.Label lSumL4;
        private System.Windows.Forms.Label lSumC4;
        private System.Windows.Forms.Label lSumL1;
        private System.Windows.Forms.Label lSumC1;
        private System.Windows.Forms.TabPage tabArchive;
        private System.Windows.Forms.Label lProfitC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lConsC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lMonthC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lIncomeYA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lProfitY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lConsY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lHoursC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lIncomeC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lHoursY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lIncomeY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView grCons;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btConsSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btCertSave;
        private System.Windows.Forms.DataGridView grCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btDicWorkSave;
        private System.Windows.Forms.Button btDicConsSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridView grDicWork;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grDicCons;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdwId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdwName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView grDicClient;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btDicClientSave;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grDicSource;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btDicSourceSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn csId;
        private System.Windows.Forms.DataGridViewTextBoxColumn csNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn csAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn csComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClient;
        private System.Windows.Forms.DataGridViewComboBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHours;
        private System.Windows.Forms.DataGridViewComboBoxColumn cSource;
        private System.Windows.Forms.DataGridViewButtonColumn cSert;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCertId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHours;
    }
}

