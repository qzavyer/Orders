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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.grWork = new System.Windows.Forms.DataGridView();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitIncome = new System.Windows.Forms.SplitContainer();
            this.chMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.splitCons = new System.Windows.Forms.SplitContainer();
            this.chCMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chCYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.tabCert = new System.Windows.Forms.TabPage();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.grDicSource = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.grDicWork = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grDicCons = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btDicSave = new System.Windows.Forms.Button();
            this.tabArchive = new System.Windows.Forms.TabPage();
            this.cType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cSource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cSert = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cbArchYear = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.lHourAr1 = new System.Windows.Forms.Label();
            this.lConsAr1 = new System.Windows.Forms.Label();
            this.lIncAr1 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btArchEdit01 = new System.Windows.Forms.Button();
            this.btArchEdit02 = new System.Windows.Forms.Button();
            this.lHourAr2 = new System.Windows.Forms.Label();
            this.lConsAr2 = new System.Windows.Forms.Label();
            this.lIncAr2 = new System.Windows.Forms.Label();
            this.lHourAr3 = new System.Windows.Forms.Label();
            this.lConsAr3 = new System.Windows.Forms.Label();
            this.lIncAr3 = new System.Windows.Forms.Label();
            this.btArchEdit03 = new System.Windows.Forms.Button();
            this.lHourAr4 = new System.Windows.Forms.Label();
            this.lConsAr4 = new System.Windows.Forms.Label();
            this.lIncAr4 = new System.Windows.Forms.Label();
            this.btArchEdit04 = new System.Windows.Forms.Button();
            this.lHourAr5 = new System.Windows.Forms.Label();
            this.lConsAr5 = new System.Windows.Forms.Label();
            this.lIncAr5 = new System.Windows.Forms.Label();
            this.btArchEdit05 = new System.Windows.Forms.Button();
            this.lHourAr6 = new System.Windows.Forms.Label();
            this.lConsAr6 = new System.Windows.Forms.Label();
            this.lIncAr6 = new System.Windows.Forms.Label();
            this.btArchEdit06 = new System.Windows.Forms.Button();
            this.lHourAr7 = new System.Windows.Forms.Label();
            this.lConsAr7 = new System.Windows.Forms.Label();
            this.lIncAr7 = new System.Windows.Forms.Label();
            this.btArchEdit07 = new System.Windows.Forms.Button();
            this.lHourAr8 = new System.Windows.Forms.Label();
            this.lConsAr8 = new System.Windows.Forms.Label();
            this.lIncAr8 = new System.Windows.Forms.Label();
            this.btArchEdit08 = new System.Windows.Forms.Button();
            this.lHourAr9 = new System.Windows.Forms.Label();
            this.lConsAr9 = new System.Windows.Forms.Label();
            this.lIncAr9 = new System.Windows.Forms.Label();
            this.btArchEdit09 = new System.Windows.Forms.Button();
            this.lHourAr10 = new System.Windows.Forms.Label();
            this.lConsAr10 = new System.Windows.Forms.Label();
            this.lIncAr10 = new System.Windows.Forms.Label();
            this.btArchEdit10 = new System.Windows.Forms.Button();
            this.lHourAr11 = new System.Windows.Forms.Label();
            this.lConsAr11 = new System.Windows.Forms.Label();
            this.lIncAr11 = new System.Windows.Forms.Label();
            this.btArchEdit11 = new System.Windows.Forms.Button();
            this.lHourAr12 = new System.Windows.Forms.Label();
            this.lConsAr12 = new System.Windows.Forms.Label();
            this.lIncAr12 = new System.Windows.Forms.Label();
            this.btArchEdit12 = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCertId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabApp.SuspendLayout();
            this.tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grWork)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pHistory.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitIncome)).BeginInit();
            this.splitIncome.Panel1.SuspendLayout();
            this.splitIncome.Panel2.SuspendLayout();
            this.splitIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chYear)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCons)).BeginInit();
            this.splitCons.Panel1.SuspendLayout();
            this.splitCons.Panel2.SuspendLayout();
            this.splitCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCYear)).BeginInit();
            this.panel20.SuspendLayout();
            this.tabCert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabConsum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabGloss.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicClient)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicSource)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicWork)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDicCons)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabArchive.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.tabWork);
            this.tabApp.Controls.Add(this.tabGraph);
            this.tabApp.Controls.Add(this.tabCert);
            this.tabApp.Controls.Add(this.tabConsum);
            this.tabApp.Controls.Add(this.tabGloss);
            this.tabApp.Controls.Add(this.tabArchive);
            this.tabApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApp.Location = new System.Drawing.Point(0, 0);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(1599, 668);
            this.tabApp.TabIndex = 0;
            // 
            // tabWork
            // 
            this.tabWork.Controls.Add(this.grWork);
            this.tabWork.Controls.Add(this.panel3);
            this.tabWork.Controls.Add(this.panel2);
            this.tabWork.Controls.Add(this.pHistory);
            this.tabWork.Location = new System.Drawing.Point(4, 27);
            this.tabWork.Name = "tabWork";
            this.tabWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabWork.Size = new System.Drawing.Size(1591, 637);
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
            this.grWork.Location = new System.Drawing.Point(3, 43);
            this.grWork.Name = "grWork";
            this.grWork.RowHeadersVisible = false;
            this.grWork.RowTemplate.Height = 24;
            this.grWork.Size = new System.Drawing.Size(1306, 551);
            this.grWork.TabIndex = 5;
            this.grWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grWork_CellClick);
            this.grWork.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grWork_CellValueChanged);
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
            this.panel3.Location = new System.Drawing.Point(3, 594);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 40);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Часы:";
            // 
            // lHoursC
            // 
            this.lHoursC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHoursC.Location = new System.Drawing.Point(636, 1);
            this.lHoursC.Name = "lHoursC";
            this.lHoursC.Size = new System.Drawing.Size(88, 34);
            this.lHoursC.TabIndex = 46;
            this.lHoursC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lIncomeC);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1104, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 40);
            this.panel4.TabIndex = 34;
            // 
            // lIncomeC
            // 
            this.lIncomeC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncomeC.Location = new System.Drawing.Point(70, 1);
            this.lIncomeC.Name = "lIncomeC";
            this.lIncomeC.Size = new System.Drawing.Size(122, 34);
            this.lIncomeC.TabIndex = 31;
            this.lIncomeC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Доход:";
            // 
            // lProfitC
            // 
            this.lProfitC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lProfitC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProfitC.Location = new System.Drawing.Point(428, 1);
            this.lProfitC.Name = "lProfitC";
            this.lProfitC.Size = new System.Drawing.Size(88, 34);
            this.lProfitC.TabIndex = 33;
            this.lProfitC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Прибыль";
            // 
            // lConsC
            // 
            this.lConsC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsC.Location = new System.Drawing.Point(219, 1);
            this.lConsC.Name = "lConsC";
            this.lConsC.Size = new System.Drawing.Size(88, 34);
            this.lConsC.TabIndex = 31;
            this.lConsC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Расход:";
            // 
            // lMonthC
            // 
            this.lMonthC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMonthC.Location = new System.Drawing.Point(6, 2);
            this.lMonthC.Name = "lMonthC";
            this.lMonthC.Size = new System.Drawing.Size(135, 34);
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
            this.panel2.Size = new System.Drawing.Size(1306, 40);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Часы:";
            // 
            // lHoursY
            // 
            this.lHoursY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHoursY.Location = new System.Drawing.Point(636, 1);
            this.lHoursY.Name = "lHoursY";
            this.lHoursY.Size = new System.Drawing.Size(88, 34);
            this.lHoursY.TabIndex = 44;
            this.lHoursY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lIncomeY);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1104, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 40);
            this.panel1.TabIndex = 43;
            // 
            // lIncomeY
            // 
            this.lIncomeY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncomeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lIncomeY.Location = new System.Drawing.Point(70, 1);
            this.lIncomeY.Name = "lIncomeY";
            this.lIncomeY.Size = new System.Drawing.Size(122, 34);
            this.lIncomeY.TabIndex = 37;
            this.lIncomeY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 36;
            this.label12.Text = "Доход:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(3, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 32);
            this.label15.TabIndex = 42;
            this.label15.Text = "За год:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lIncomeYA
            // 
            this.lIncomeYA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncomeYA.Location = new System.Drawing.Point(844, 1);
            this.lIncomeYA.Name = "lIncomeYA";
            this.lIncomeYA.Size = new System.Drawing.Size(88, 34);
            this.lIncomeYA.TabIndex = 41;
            this.lIncomeYA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(757, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 40;
            this.label14.Text = "Ср.доход:";
            // 
            // lProfitY
            // 
            this.lProfitY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lProfitY.Location = new System.Drawing.Point(428, 1);
            this.lProfitY.Name = "lProfitY";
            this.lProfitY.Size = new System.Drawing.Size(88, 34);
            this.lProfitY.TabIndex = 39;
            this.lProfitY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Прибыль";
            // 
            // lConsY
            // 
            this.lConsY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsY.Location = new System.Drawing.Point(219, 1);
            this.lConsY.Name = "lConsY";
            this.lConsY.Size = new System.Drawing.Size(88, 34);
            this.lConsY.TabIndex = 37;
            this.lConsY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
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
            this.pHistory.Location = new System.Drawing.Point(1309, 3);
            this.pHistory.Name = "pHistory";
            this.pHistory.Size = new System.Drawing.Size(279, 631);
            this.pHistory.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSave.Location = new System.Drawing.Point(0, 594);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(279, 37);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(7, 537);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 34);
            this.label18.TabIndex = 46;
            this.label18.Text = "Итого:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lYearL
            // 
            this.lYearL.Location = new System.Drawing.Point(189, 7);
            this.lYearL.Name = "lYearL";
            this.lYearL.Size = new System.Drawing.Size(88, 34);
            this.lYearL.TabIndex = 45;
            this.lYearL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lYearC
            // 
            this.lYearC.Location = new System.Drawing.Point(99, 7);
            this.lYearC.Name = "lYearC";
            this.lYearC.Size = new System.Drawing.Size(88, 34);
            this.lYearC.TabIndex = 44;
            this.lYearC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lSumLAll
            // 
            this.lSumLAll.Location = new System.Drawing.Point(189, 537);
            this.lSumLAll.Name = "lSumLAll";
            this.lSumLAll.Size = new System.Drawing.Size(88, 34);
            this.lSumLAll.TabIndex = 43;
            this.lSumLAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumCAll
            // 
            this.lSumCAll.Location = new System.Drawing.Point(99, 537);
            this.lSumCAll.Name = "lSumCAll";
            this.lSumCAll.Size = new System.Drawing.Size(88, 34);
            this.lSumCAll.TabIndex = 42;
            this.lSumCAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL12
            // 
            this.lSumL12.Location = new System.Drawing.Point(189, 487);
            this.lSumL12.Name = "lSumL12";
            this.lSumL12.Size = new System.Drawing.Size(88, 34);
            this.lSumL12.TabIndex = 41;
            this.lSumL12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC12
            // 
            this.lSumC12.Location = new System.Drawing.Point(99, 487);
            this.lSumC12.Name = "lSumC12";
            this.lSumC12.Size = new System.Drawing.Size(88, 34);
            this.lSumC12.TabIndex = 40;
            this.lSumC12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btHistory12
            // 
            this.btHistory12.Location = new System.Drawing.Point(7, 487);
            this.btHistory12.Name = "btHistory12";
            this.btHistory12.Size = new System.Drawing.Size(92, 34);
            this.btHistory12.TabIndex = 39;
            this.btHistory12.Tag = "12";
            this.btHistory12.Text = "Декабрь";
            this.btHistory12.UseVisualStyleBackColor = true;
            this.btHistory12.Click += new System.EventHandler(this.History_Click);
            // 
            // lSumL11
            // 
            this.lSumL11.Location = new System.Drawing.Point(189, 447);
            this.lSumL11.Name = "lSumL11";
            this.lSumL11.Size = new System.Drawing.Size(88, 34);
            this.lSumL11.TabIndex = 38;
            this.lSumL11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC11
            // 
            this.lSumC11.Location = new System.Drawing.Point(99, 447);
            this.lSumC11.Name = "lSumC11";
            this.lSumC11.Size = new System.Drawing.Size(88, 34);
            this.lSumC11.TabIndex = 37;
            this.lSumC11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btHistory11
            // 
            this.btHistory11.Location = new System.Drawing.Point(7, 447);
            this.btHistory11.Name = "btHistory11";
            this.btHistory11.Size = new System.Drawing.Size(92, 34);
            this.btHistory11.TabIndex = 36;
            this.btHistory11.Tag = "11";
            this.btHistory11.Text = "Ноябрь";
            this.btHistory11.UseVisualStyleBackColor = true;
            this.btHistory11.Click += new System.EventHandler(this.History_Click);
            // 
            // lSumL9
            // 
            this.lSumL9.Location = new System.Drawing.Point(189, 366);
            this.lSumL9.Name = "lSumL9";
            this.lSumL9.Size = new System.Drawing.Size(88, 34);
            this.lSumL9.TabIndex = 35;
            this.lSumL9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC9
            // 
            this.lSumC9.Location = new System.Drawing.Point(99, 366);
            this.lSumC9.Name = "lSumC9";
            this.lSumC9.Size = new System.Drawing.Size(88, 34);
            this.lSumC9.TabIndex = 34;
            this.lSumC9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL10
            // 
            this.lSumL10.Location = new System.Drawing.Point(189, 406);
            this.lSumL10.Name = "lSumL10";
            this.lSumL10.Size = new System.Drawing.Size(88, 34);
            this.lSumL10.TabIndex = 33;
            this.lSumL10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC10
            // 
            this.lSumC10.Location = new System.Drawing.Point(99, 406);
            this.lSumC10.Name = "lSumC10";
            this.lSumC10.Size = new System.Drawing.Size(88, 34);
            this.lSumC10.TabIndex = 32;
            this.lSumC10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL7
            // 
            this.lSumL7.Location = new System.Drawing.Point(189, 285);
            this.lSumL7.Name = "lSumL7";
            this.lSumL7.Size = new System.Drawing.Size(88, 34);
            this.lSumL7.TabIndex = 31;
            this.lSumL7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC7
            // 
            this.lSumC7.Location = new System.Drawing.Point(99, 285);
            this.lSumC7.Name = "lSumC7";
            this.lSumC7.Size = new System.Drawing.Size(88, 34);
            this.lSumC7.TabIndex = 30;
            this.lSumC7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL8
            // 
            this.lSumL8.Location = new System.Drawing.Point(189, 325);
            this.lSumL8.Name = "lSumL8";
            this.lSumL8.Size = new System.Drawing.Size(88, 34);
            this.lSumL8.TabIndex = 29;
            this.lSumL8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC8
            // 
            this.lSumC8.Location = new System.Drawing.Point(99, 325);
            this.lSumC8.Name = "lSumC8";
            this.lSumC8.Size = new System.Drawing.Size(88, 34);
            this.lSumC8.TabIndex = 28;
            this.lSumC8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL5
            // 
            this.lSumL5.Location = new System.Drawing.Point(189, 204);
            this.lSumL5.Name = "lSumL5";
            this.lSumL5.Size = new System.Drawing.Size(88, 34);
            this.lSumL5.TabIndex = 27;
            this.lSumL5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC5
            // 
            this.lSumC5.Location = new System.Drawing.Point(99, 204);
            this.lSumC5.Name = "lSumC5";
            this.lSumC5.Size = new System.Drawing.Size(88, 34);
            this.lSumC5.TabIndex = 26;
            this.lSumC5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL6
            // 
            this.lSumL6.Location = new System.Drawing.Point(189, 244);
            this.lSumL6.Name = "lSumL6";
            this.lSumL6.Size = new System.Drawing.Size(88, 34);
            this.lSumL6.TabIndex = 25;
            this.lSumL6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC6
            // 
            this.lSumC6.Location = new System.Drawing.Point(99, 244);
            this.lSumC6.Name = "lSumC6";
            this.lSumC6.Size = new System.Drawing.Size(88, 34);
            this.lSumC6.TabIndex = 24;
            this.lSumC6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL3
            // 
            this.lSumL3.Location = new System.Drawing.Point(189, 123);
            this.lSumL3.Name = "lSumL3";
            this.lSumL3.Size = new System.Drawing.Size(88, 34);
            this.lSumL3.TabIndex = 23;
            this.lSumL3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC3
            // 
            this.lSumC3.Location = new System.Drawing.Point(99, 123);
            this.lSumC3.Name = "lSumC3";
            this.lSumC3.Size = new System.Drawing.Size(88, 34);
            this.lSumC3.TabIndex = 22;
            this.lSumC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL4
            // 
            this.lSumL4.Location = new System.Drawing.Point(189, 163);
            this.lSumL4.Name = "lSumL4";
            this.lSumL4.Size = new System.Drawing.Size(88, 34);
            this.lSumL4.TabIndex = 21;
            this.lSumL4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC4
            // 
            this.lSumC4.Location = new System.Drawing.Point(99, 163);
            this.lSumC4.Name = "lSumC4";
            this.lSumC4.Size = new System.Drawing.Size(88, 34);
            this.lSumC4.TabIndex = 20;
            this.lSumC4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL1
            // 
            this.lSumL1.Location = new System.Drawing.Point(189, 42);
            this.lSumL1.Name = "lSumL1";
            this.lSumL1.Size = new System.Drawing.Size(88, 34);
            this.lSumL1.TabIndex = 19;
            this.lSumL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC1
            // 
            this.lSumC1.Location = new System.Drawing.Point(99, 42);
            this.lSumC1.Name = "lSumC1";
            this.lSumC1.Size = new System.Drawing.Size(88, 34);
            this.lSumC1.TabIndex = 18;
            this.lSumC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumL2
            // 
            this.lSumL2.Location = new System.Drawing.Point(189, 82);
            this.lSumL2.Name = "lSumL2";
            this.lSumL2.Size = new System.Drawing.Size(88, 34);
            this.lSumL2.TabIndex = 17;
            this.lSumL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSumC2
            // 
            this.lSumC2.Location = new System.Drawing.Point(99, 82);
            this.lSumC2.Name = "lSumC2";
            this.lSumC2.Size = new System.Drawing.Size(88, 34);
            this.lSumC2.TabIndex = 14;
            this.lSumC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btHistory10
            // 
            this.btHistory10.Location = new System.Drawing.Point(7, 406);
            this.btHistory10.Name = "btHistory10";
            this.btHistory10.Size = new System.Drawing.Size(92, 34);
            this.btHistory10.TabIndex = 10;
            this.btHistory10.Tag = "10";
            this.btHistory10.Text = "Октябрь";
            this.btHistory10.UseVisualStyleBackColor = true;
            this.btHistory10.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory9
            // 
            this.btHistory9.Location = new System.Drawing.Point(7, 366);
            this.btHistory9.Name = "btHistory9";
            this.btHistory9.Size = new System.Drawing.Size(92, 34);
            this.btHistory9.TabIndex = 9;
            this.btHistory9.Tag = "9";
            this.btHistory9.Text = "Сентябрь";
            this.btHistory9.UseVisualStyleBackColor = true;
            this.btHistory9.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory8
            // 
            this.btHistory8.Location = new System.Drawing.Point(7, 325);
            this.btHistory8.Name = "btHistory8";
            this.btHistory8.Size = new System.Drawing.Size(92, 34);
            this.btHistory8.TabIndex = 8;
            this.btHistory8.Tag = "8";
            this.btHistory8.Text = "Август";
            this.btHistory8.UseVisualStyleBackColor = true;
            this.btHistory8.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory7
            // 
            this.btHistory7.Location = new System.Drawing.Point(7, 285);
            this.btHistory7.Name = "btHistory7";
            this.btHistory7.Size = new System.Drawing.Size(92, 34);
            this.btHistory7.TabIndex = 7;
            this.btHistory7.Tag = "7";
            this.btHistory7.Text = "Июль";
            this.btHistory7.UseVisualStyleBackColor = true;
            this.btHistory7.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory6
            // 
            this.btHistory6.Location = new System.Drawing.Point(7, 244);
            this.btHistory6.Name = "btHistory6";
            this.btHistory6.Size = new System.Drawing.Size(92, 34);
            this.btHistory6.TabIndex = 6;
            this.btHistory6.Tag = "6";
            this.btHistory6.Text = "Июнь";
            this.btHistory6.UseVisualStyleBackColor = true;
            this.btHistory6.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory5
            // 
            this.btHistory5.Location = new System.Drawing.Point(7, 204);
            this.btHistory5.Name = "btHistory5";
            this.btHistory5.Size = new System.Drawing.Size(92, 34);
            this.btHistory5.TabIndex = 5;
            this.btHistory5.Tag = "5";
            this.btHistory5.Text = "Май";
            this.btHistory5.UseVisualStyleBackColor = true;
            this.btHistory5.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory4
            // 
            this.btHistory4.Location = new System.Drawing.Point(7, 163);
            this.btHistory4.Name = "btHistory4";
            this.btHistory4.Size = new System.Drawing.Size(92, 34);
            this.btHistory4.TabIndex = 4;
            this.btHistory4.Tag = "4";
            this.btHistory4.Text = "Апрель";
            this.btHistory4.UseVisualStyleBackColor = true;
            this.btHistory4.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory3
            // 
            this.btHistory3.Location = new System.Drawing.Point(7, 123);
            this.btHistory3.Name = "btHistory3";
            this.btHistory3.Size = new System.Drawing.Size(92, 34);
            this.btHistory3.TabIndex = 3;
            this.btHistory3.Tag = "3";
            this.btHistory3.Text = "Март";
            this.btHistory3.UseVisualStyleBackColor = true;
            this.btHistory3.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory2
            // 
            this.btHistory2.Location = new System.Drawing.Point(7, 82);
            this.btHistory2.Name = "btHistory2";
            this.btHistory2.Size = new System.Drawing.Size(92, 34);
            this.btHistory2.TabIndex = 2;
            this.btHistory2.Tag = "2";
            this.btHistory2.Text = "Февраль";
            this.btHistory2.UseVisualStyleBackColor = true;
            this.btHistory2.Click += new System.EventHandler(this.History_Click);
            // 
            // btHistory1
            // 
            this.btHistory1.Location = new System.Drawing.Point(7, 42);
            this.btHistory1.Name = "btHistory1";
            this.btHistory1.Size = new System.Drawing.Size(92, 34);
            this.btHistory1.TabIndex = 0;
            this.btHistory1.Tag = "1";
            this.btHistory1.Text = "Январь";
            this.btHistory1.UseVisualStyleBackColor = true;
            this.btHistory1.Click += new System.EventHandler(this.History_Click);
            // 
            // tabGraph
            // 
            this.tabGraph.Controls.Add(this.splitContainer2);
            this.tabGraph.Location = new System.Drawing.Point(4, 27);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1591, 637);
            this.tabGraph.TabIndex = 4;
            this.tabGraph.Text = "Графики";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitIncome);
            this.splitContainer2.Panel1.Controls.Add(this.panel19);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitCons);
            this.splitContainer2.Panel2.Controls.Add(this.panel20);
            this.splitContainer2.Size = new System.Drawing.Size(1585, 631);
            this.splitContainer2.SplitterDistance = 334;
            this.splitContainer2.TabIndex = 4;
            // 
            // splitIncome
            // 
            this.splitIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitIncome.IsSplitterFixed = true;
            this.splitIncome.Location = new System.Drawing.Point(0, 28);
            this.splitIncome.Name = "splitIncome";
            // 
            // splitIncome.Panel1
            // 
            this.splitIncome.Panel1.Controls.Add(this.chMonth);
            // 
            // splitIncome.Panel2
            // 
            this.splitIncome.Panel2.Controls.Add(this.chYear);
            this.splitIncome.Size = new System.Drawing.Size(1585, 306);
            this.splitIncome.SplitterDistance = 790;
            this.splitIncome.TabIndex = 6;
            // 
            // chMonth
            // 
            this.chMonth.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            chartArea1.AxisY.Title = "Сумма (тыс.руб.)";
            chartArea1.Name = "ChartArea2";
            chartArea2.AxisY.Title = "Количество";
            chartArea2.Name = "ChartArea1";
            this.chMonth.ChartAreas.Add(chartArea1);
            this.chMonth.ChartAreas.Add(chartArea2);
            this.chMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chMonth.Location = new System.Drawing.Point(0, 0);
            this.chMonth.Name = "chMonth";
            this.chMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea2";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.Name = "income";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.Name = "count";
            series2.YValuesPerPoint = 2;
            this.chMonth.Series.Add(series1);
            this.chMonth.Series.Add(series2);
            this.chMonth.Size = new System.Drawing.Size(790, 306);
            this.chMonth.TabIndex = 1;
            this.chMonth.Text = "Месячный график";
            title1.Name = "Title1";
            title1.Text = "Месячный график";
            this.chMonth.Titles.Add(title1);
            this.chMonth.Click += new System.EventHandler(this.chMonth_Click);
            // 
            // chYear
            // 
            chartArea3.AxisY.Title = "Сумма (тыс.руб.)";
            chartArea3.Name = "ChartArea2";
            chartArea4.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.MaximumAutoSize = 50F;
            chartArea4.AxisY.Title = "Количество";
            chartArea4.Name = "ChartArea1";
            this.chYear.ChartAreas.Add(chartArea3);
            this.chYear.ChartAreas.Add(chartArea4);
            this.chYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chYear.Location = new System.Drawing.Point(0, 0);
            this.chYear.Name = "chYear";
            this.chYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "count";
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.IsValueShownAsLabel = true;
            series4.Name = "income";
            this.chYear.Series.Add(series3);
            this.chYear.Series.Add(series4);
            this.chYear.Size = new System.Drawing.Size(791, 306);
            this.chYear.TabIndex = 3;
            this.chYear.Text = "Доход за год";
            title2.Name = "Title1";
            title2.Text = "Доход за год";
            this.chYear.Titles.Add(title2);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label13);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1585, 28);
            this.panel19.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1585, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "Доход";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitCons
            // 
            this.splitCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCons.IsSplitterFixed = true;
            this.splitCons.Location = new System.Drawing.Point(0, 28);
            this.splitCons.Name = "splitCons";
            // 
            // splitCons.Panel1
            // 
            this.splitCons.Panel1.Controls.Add(this.chCMonth);
            // 
            // splitCons.Panel2
            // 
            this.splitCons.Panel2.Controls.Add(this.chCYear);
            this.splitCons.Size = new System.Drawing.Size(1585, 265);
            this.splitCons.SplitterDistance = 790;
            this.splitCons.TabIndex = 7;
            // 
            // chCMonth
            // 
            this.chCMonth.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            chartArea5.AxisY.Title = "Сумма (тыс.руб.)";
            chartArea5.Name = "ChartArea2";
            chartArea6.AxisY.Title = "Количество";
            chartArea6.Name = "ChartArea1";
            this.chCMonth.ChartAreas.Add(chartArea5);
            this.chCMonth.ChartAreas.Add(chartArea6);
            this.chCMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chCMonth.Location = new System.Drawing.Point(0, 0);
            this.chCMonth.Name = "chCMonth";
            this.chCMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series5.IsValueShownAsLabel = true;
            series5.Name = "count";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.IsValueShownAsLabel = true;
            series6.Name = "cons";
            this.chCMonth.Series.Add(series5);
            this.chCMonth.Series.Add(series6);
            this.chCMonth.Size = new System.Drawing.Size(790, 265);
            this.chCMonth.TabIndex = 1;
            this.chCMonth.Text = "Месячный график";
            title3.Name = "Title1";
            title3.Text = "Месячный график";
            this.chCMonth.Titles.Add(title3);
            // 
            // chCYear
            // 
            chartArea7.Name = "ChartArea2";
            chartArea8.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea8.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisY.MaximumAutoSize = 50F;
            chartArea8.Name = "ChartArea1";
            this.chCYear.ChartAreas.Add(chartArea7);
            this.chCYear.ChartAreas.Add(chartArea8);
            this.chCYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chCYear.Location = new System.Drawing.Point(0, 0);
            this.chCYear.Name = "chCYear";
            this.chCYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series7.IsValueShownAsLabel = true;
            series7.Name = "count";
            series7.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond;
            series8.ChartArea = "ChartArea2";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series8.IsValueShownAsLabel = true;
            series8.Name = "cons";
            this.chCYear.Series.Add(series7);
            this.chCYear.Series.Add(series8);
            this.chCYear.Size = new System.Drawing.Size(791, 265);
            this.chCYear.TabIndex = 3;
            this.chCYear.Text = "Годовой график";
            title4.Name = "Title1";
            title4.Text = "Расход за год";
            this.chCYear.Titles.Add(title4);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label16);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1585, 28);
            this.panel20.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1585, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Расход";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCert
            // 
            this.tabCert.Controls.Add(this.grCert);
            this.tabCert.Controls.Add(this.panel6);
            this.tabCert.Location = new System.Drawing.Point(4, 27);
            this.tabCert.Name = "tabCert";
            this.tabCert.Padding = new System.Windows.Forms.Padding(3);
            this.tabCert.Size = new System.Drawing.Size(1591, 637);
            this.tabCert.TabIndex = 1;
            this.tabCert.Text = "Сертификаты";
            this.tabCert.UseVisualStyleBackColor = true;
            // 
            // grCert
            // 
            this.grCert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccId,
            this.ccPayerId,
            this.ccClientId,
            this.ccNumber,
            this.ccPayerName,
            this.ccClientName,
            this.ccPrice,
            this.ccCons,
            this.ccHours});
            this.grCert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCert.Location = new System.Drawing.Point(3, 3);
            this.grCert.Name = "grCert";
            this.grCert.RowHeadersVisible = false;
            this.grCert.RowTemplate.Height = 24;
            this.grCert.Size = new System.Drawing.Size(1585, 603);
            this.grCert.TabIndex = 1;
            this.grCert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCert_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btCertSave);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 606);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1585, 28);
            this.panel6.TabIndex = 0;
            // 
            // btCertSave
            // 
            this.btCertSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCertSave.Location = new System.Drawing.Point(1467, 0);
            this.btCertSave.Name = "btCertSave";
            this.btCertSave.Size = new System.Drawing.Size(118, 28);
            this.btCertSave.TabIndex = 0;
            this.btCertSave.Text = "Сохранить";
            this.btCertSave.UseVisualStyleBackColor = true;
            this.btCertSave.Click += new System.EventHandler(this.btCertSave_Click);
            // 
            // tabConsum
            // 
            this.tabConsum.Controls.Add(this.grCons);
            this.tabConsum.Controls.Add(this.panel5);
            this.tabConsum.Location = new System.Drawing.Point(4, 27);
            this.tabConsum.Name = "tabConsum";
            this.tabConsum.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsum.Size = new System.Drawing.Size(1591, 637);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grCons.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grCons.RowHeadersVisible = false;
            this.grCons.RowTemplate.Height = 24;
            this.grCons.Size = new System.Drawing.Size(1585, 603);
            this.grCons.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btConsSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 606);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1585, 28);
            this.panel5.TabIndex = 0;
            // 
            // btConsSave
            // 
            this.btConsSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btConsSave.Location = new System.Drawing.Point(1467, 0);
            this.btConsSave.Name = "btConsSave";
            this.btConsSave.Size = new System.Drawing.Size(118, 28);
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
            this.tabGloss.Controls.Add(this.panel12);
            this.tabGloss.Location = new System.Drawing.Point(4, 27);
            this.tabGloss.Name = "tabGloss";
            this.tabGloss.Padding = new System.Windows.Forms.Padding(3);
            this.tabGloss.Size = new System.Drawing.Size(1591, 637);
            this.tabGloss.TabIndex = 3;
            this.tabGloss.Text = "Справочники";
            this.tabGloss.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.grDicClient);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(673, 603);
            this.panel16.TabIndex = 12;
            // 
            // grDicClient
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grDicClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdpId,
            this.cdpName,
            this.cdpPhone,
            this.cdpMail,
            this.cdpNote});
            this.grDicClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicClient.Location = new System.Drawing.Point(0, 28);
            this.grDicClient.Name = "grDicClient";
            this.grDicClient.RowHeadersVisible = false;
            this.grDicClient.RowTemplate.Height = 24;
            this.grDicClient.Size = new System.Drawing.Size(673, 575);
            this.grDicClient.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label11);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(673, 28);
            this.panel17.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(673, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Клинеты";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grDicSource);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(676, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(304, 603);
            this.panel7.TabIndex = 11;
            // 
            // grDicSource
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grDicSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdsId,
            this.cdsName});
            this.grDicSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicSource.Location = new System.Drawing.Point(0, 28);
            this.grDicSource.Name = "grDicSource";
            this.grDicSource.RowHeadersVisible = false;
            this.grDicSource.RowTemplate.Height = 24;
            this.grDicSource.Size = new System.Drawing.Size(304, 575);
            this.grDicSource.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label9);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(304, 28);
            this.panel13.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Источники";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.grDicWork);
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(980, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(304, 603);
            this.panel9.TabIndex = 10;
            // 
            // grDicWork
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grDicWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdwId,
            this.cdwName});
            this.grDicWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicWork.Location = new System.Drawing.Point(0, 28);
            this.grDicWork.Name = "grDicWork";
            this.grDicWork.RowHeadersVisible = false;
            this.grDicWork.RowTemplate.Height = 24;
            this.grDicWork.Size = new System.Drawing.Size(304, 575);
            this.grDicWork.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label7);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(304, 28);
            this.panel14.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Тип работы";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.grDicCons);
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1284, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(304, 603);
            this.panel8.TabIndex = 7;
            // 
            // grDicCons
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicCons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grDicCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdcId,
            this.cdcName});
            this.grDicCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicCons.Location = new System.Drawing.Point(0, 28);
            this.grDicCons.Name = "grDicCons";
            this.grDicCons.RowHeadersVisible = false;
            this.grDicCons.RowTemplate.Height = 24;
            this.grDicCons.Size = new System.Drawing.Size(304, 575);
            this.grDicCons.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label5);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(304, 28);
            this.panel15.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тип расхода";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btDicSave);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 606);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1585, 28);
            this.panel12.TabIndex = 6;
            // 
            // btDicSave
            // 
            this.btDicSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDicSave.Location = new System.Drawing.Point(1467, 0);
            this.btDicSave.Name = "btDicSave";
            this.btDicSave.Size = new System.Drawing.Size(118, 28);
            this.btDicSave.TabIndex = 0;
            this.btDicSave.Text = "Сохранить";
            this.btDicSave.UseVisualStyleBackColor = true;
            this.btDicSave.Click += new System.EventHandler(this.btDicSave_Click);
            // 
            // tabArchive
            // 
            this.tabArchive.Controls.Add(this.panel26);
            this.tabArchive.Controls.Add(this.panel27);
            this.tabArchive.Controls.Add(this.panel28);
            this.tabArchive.Controls.Add(this.panel29);
            this.tabArchive.Controls.Add(this.panel30);
            this.tabArchive.Controls.Add(this.panel25);
            this.tabArchive.Controls.Add(this.panel24);
            this.tabArchive.Controls.Add(this.panel23);
            this.tabArchive.Controls.Add(this.panel22);
            this.tabArchive.Controls.Add(this.panel21);
            this.tabArchive.Controls.Add(this.panel18);
            this.tabArchive.Controls.Add(this.panel11);
            this.tabArchive.Controls.Add(this.panel10);
            this.tabArchive.Location = new System.Drawing.Point(4, 27);
            this.tabArchive.Name = "tabArchive";
            this.tabArchive.Padding = new System.Windows.Forms.Padding(3);
            this.tabArchive.Size = new System.Drawing.Size(1591, 637);
            this.tabArchive.TabIndex = 5;
            this.tabArchive.Text = "Архив";
            this.tabArchive.UseVisualStyleBackColor = true;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.label34);
            this.panel10.Controls.Add(this.label35);
            this.panel10.Controls.Add(this.label36);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.cbArchYear);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1585, 86);
            this.panel10.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Год";
            // 
            // cbArchYear
            // 
            this.cbArchYear.FormattingEnabled = true;
            this.cbArchYear.Location = new System.Drawing.Point(3, 30);
            this.cbArchYear.Name = "cbArchYear";
            this.cbArchYear.Size = new System.Drawing.Size(121, 26);
            this.cbArchYear.TabIndex = 2;
            this.cbArchYear.SelectedIndexChanged += new System.EventHandler(this.cbArchYear_SelectedIndexChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btArchEdit01);
            this.panel11.Controls.Add(this.lHourAr1);
            this.panel11.Controls.Add(this.lConsAr1);
            this.panel11.Controls.Add(this.lIncAr1);
            this.panel11.Controls.Add(this.label19);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 89);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1585, 40);
            this.panel11.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 40);
            this.label19.TabIndex = 0;
            this.label19.Text = "Январь";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.lHourAr2);
            this.panel18.Controls.Add(this.lConsAr2);
            this.panel18.Controls.Add(this.lIncAr2);
            this.panel18.Controls.Add(this.btArchEdit02);
            this.panel18.Controls.Add(this.label20);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(3, 129);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1585, 40);
            this.panel18.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 40);
            this.label20.TabIndex = 0;
            this.label20.Text = "Февраль";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.lHourAr3);
            this.panel21.Controls.Add(this.lConsAr3);
            this.panel21.Controls.Add(this.lIncAr3);
            this.panel21.Controls.Add(this.btArchEdit03);
            this.panel21.Controls.Add(this.label21);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(3, 169);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1585, 40);
            this.panel21.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 40);
            this.label21.TabIndex = 0;
            this.label21.Text = "Март";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.lHourAr4);
            this.panel22.Controls.Add(this.lConsAr4);
            this.panel22.Controls.Add(this.lIncAr4);
            this.panel22.Controls.Add(this.btArchEdit04);
            this.panel22.Controls.Add(this.label22);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(3, 209);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1585, 40);
            this.panel22.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Left;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 40);
            this.label22.TabIndex = 0;
            this.label22.Text = "Апрель";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.lHourAr5);
            this.panel23.Controls.Add(this.lConsAr5);
            this.panel23.Controls.Add(this.lIncAr5);
            this.panel23.Controls.Add(this.btArchEdit05);
            this.panel23.Controls.Add(this.label23);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(3, 249);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(1585, 40);
            this.panel23.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Left;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 40);
            this.label23.TabIndex = 0;
            this.label23.Text = "Май";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.lHourAr6);
            this.panel24.Controls.Add(this.lConsAr6);
            this.panel24.Controls.Add(this.lIncAr6);
            this.panel24.Controls.Add(this.btArchEdit06);
            this.panel24.Controls.Add(this.label24);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(3, 289);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1585, 40);
            this.panel24.TabIndex = 8;
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(160, 40);
            this.label24.TabIndex = 0;
            this.label24.Text = "Июнь";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.lHourAr7);
            this.panel25.Controls.Add(this.lConsAr7);
            this.panel25.Controls.Add(this.lIncAr7);
            this.panel25.Controls.Add(this.btArchEdit07);
            this.panel25.Controls.Add(this.label25);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(3, 329);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1585, 40);
            this.panel25.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Left;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(160, 40);
            this.label25.TabIndex = 0;
            this.label25.Text = "Июль";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.lHourAr12);
            this.panel26.Controls.Add(this.lConsAr12);
            this.panel26.Controls.Add(this.lIncAr12);
            this.panel26.Controls.Add(this.btArchEdit12);
            this.panel26.Controls.Add(this.label26);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(3, 529);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(1585, 40);
            this.panel26.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Left;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(160, 40);
            this.label26.TabIndex = 0;
            this.label26.Text = "Декабрь";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.lHourAr11);
            this.panel27.Controls.Add(this.lConsAr11);
            this.panel27.Controls.Add(this.lIncAr11);
            this.panel27.Controls.Add(this.btArchEdit11);
            this.panel27.Controls.Add(this.label27);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(3, 489);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(1585, 40);
            this.panel27.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Left;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(160, 40);
            this.label27.TabIndex = 0;
            this.label27.Text = "Ноябрь";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.lHourAr10);
            this.panel28.Controls.Add(this.lConsAr10);
            this.panel28.Controls.Add(this.lIncAr10);
            this.panel28.Controls.Add(this.btArchEdit10);
            this.panel28.Controls.Add(this.label28);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(3, 449);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(1585, 40);
            this.panel28.TabIndex = 12;
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Left;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(160, 40);
            this.label28.TabIndex = 0;
            this.label28.Text = "Октябрь";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.lHourAr9);
            this.panel29.Controls.Add(this.lConsAr9);
            this.panel29.Controls.Add(this.lIncAr9);
            this.panel29.Controls.Add(this.btArchEdit09);
            this.panel29.Controls.Add(this.label29);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(3, 409);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(1585, 40);
            this.panel29.TabIndex = 11;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Left;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(160, 40);
            this.label29.TabIndex = 0;
            this.label29.Text = "Сентябрь";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.lHourAr8);
            this.panel30.Controls.Add(this.lConsAr8);
            this.panel30.Controls.Add(this.lIncAr8);
            this.panel30.Controls.Add(this.btArchEdit08);
            this.panel30.Controls.Add(this.label30);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel30.Location = new System.Drawing.Point(3, 369);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1585, 40);
            this.panel30.TabIndex = 10;
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Left;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(160, 40);
            this.label30.TabIndex = 0;
            this.label30.Text = "Август";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lHourAr1
            // 
            this.lHourAr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr1.Location = new System.Drawing.Point(648, 3);
            this.lHourAr1.Name = "lHourAr1";
            this.lHourAr1.Size = new System.Drawing.Size(88, 34);
            this.lHourAr1.TabIndex = 47;
            this.lHourAr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr1
            // 
            this.lConsAr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr1.Location = new System.Drawing.Point(440, 3);
            this.lConsAr1.Name = "lConsAr1";
            this.lConsAr1.Size = new System.Drawing.Size(88, 34);
            this.lConsAr1.TabIndex = 46;
            this.lConsAr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr1
            // 
            this.lIncAr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr1.Location = new System.Drawing.Point(231, 3);
            this.lIncAr1.Name = "lIncAr1";
            this.lIncAr1.Size = new System.Drawing.Size(88, 34);
            this.lIncAr1.TabIndex = 45;
            this.lIncAr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(667, 65);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 18);
            this.label34.TabIndex = 48;
            this.label34.Text = "Часы:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(455, 65);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 18);
            this.label35.TabIndex = 47;
            this.label35.Text = "Расход";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(243, 65);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 18);
            this.label36.TabIndex = 46;
            this.label36.Text = "Доход:";
            // 
            // btArchEdit01
            // 
            this.btArchEdit01.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit01.Name = "btArchEdit01";
            this.btArchEdit01.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit01.TabIndex = 48;
            this.btArchEdit01.Tag = "1";
            this.btArchEdit01.Text = "Править";
            this.btArchEdit01.UseVisualStyleBackColor = true;
            this.btArchEdit01.Click += new System.EventHandler(this.Archive_Click);
            // 
            // btArchEdit02
            // 
            this.btArchEdit02.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit02.Name = "btArchEdit02";
            this.btArchEdit02.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit02.TabIndex = 49;
            this.btArchEdit02.Tag = "2";
            this.btArchEdit02.Text = "Править";
            this.btArchEdit02.UseVisualStyleBackColor = true;
            this.btArchEdit02.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr2
            // 
            this.lHourAr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr2.Location = new System.Drawing.Point(648, 3);
            this.lHourAr2.Name = "lHourAr2";
            this.lHourAr2.Size = new System.Drawing.Size(88, 34);
            this.lHourAr2.TabIndex = 52;
            this.lHourAr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr2
            // 
            this.lConsAr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr2.Location = new System.Drawing.Point(440, 3);
            this.lConsAr2.Name = "lConsAr2";
            this.lConsAr2.Size = new System.Drawing.Size(88, 34);
            this.lConsAr2.TabIndex = 51;
            this.lConsAr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr2
            // 
            this.lIncAr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr2.Location = new System.Drawing.Point(231, 3);
            this.lIncAr2.Name = "lIncAr2";
            this.lIncAr2.Size = new System.Drawing.Size(88, 34);
            this.lIncAr2.TabIndex = 50;
            this.lIncAr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lHourAr3
            // 
            this.lHourAr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr3.Location = new System.Drawing.Point(648, 3);
            this.lHourAr3.Name = "lHourAr3";
            this.lHourAr3.Size = new System.Drawing.Size(88, 34);
            this.lHourAr3.TabIndex = 56;
            this.lHourAr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr3
            // 
            this.lConsAr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr3.Location = new System.Drawing.Point(440, 3);
            this.lConsAr3.Name = "lConsAr3";
            this.lConsAr3.Size = new System.Drawing.Size(88, 34);
            this.lConsAr3.TabIndex = 55;
            this.lConsAr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr3
            // 
            this.lIncAr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr3.Location = new System.Drawing.Point(231, 3);
            this.lIncAr3.Name = "lIncAr3";
            this.lIncAr3.Size = new System.Drawing.Size(88, 34);
            this.lIncAr3.TabIndex = 54;
            this.lIncAr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit03
            // 
            this.btArchEdit03.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit03.Name = "btArchEdit03";
            this.btArchEdit03.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit03.TabIndex = 53;
            this.btArchEdit03.Tag = "3";
            this.btArchEdit03.Text = "Править";
            this.btArchEdit03.UseVisualStyleBackColor = true;
            this.btArchEdit03.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr4
            // 
            this.lHourAr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr4.Location = new System.Drawing.Point(648, 3);
            this.lHourAr4.Name = "lHourAr4";
            this.lHourAr4.Size = new System.Drawing.Size(88, 34);
            this.lHourAr4.TabIndex = 56;
            this.lHourAr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr4
            // 
            this.lConsAr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr4.Location = new System.Drawing.Point(440, 3);
            this.lConsAr4.Name = "lConsAr4";
            this.lConsAr4.Size = new System.Drawing.Size(88, 34);
            this.lConsAr4.TabIndex = 55;
            this.lConsAr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr4
            // 
            this.lIncAr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr4.Location = new System.Drawing.Point(231, 3);
            this.lIncAr4.Name = "lIncAr4";
            this.lIncAr4.Size = new System.Drawing.Size(88, 34);
            this.lIncAr4.TabIndex = 54;
            this.lIncAr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit04
            // 
            this.btArchEdit04.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit04.Name = "btArchEdit04";
            this.btArchEdit04.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit04.TabIndex = 53;
            this.btArchEdit04.Tag = "4";
            this.btArchEdit04.Text = "Править";
            this.btArchEdit04.UseVisualStyleBackColor = true;
            this.btArchEdit04.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr5
            // 
            this.lHourAr5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr5.Location = new System.Drawing.Point(648, 3);
            this.lHourAr5.Name = "lHourAr5";
            this.lHourAr5.Size = new System.Drawing.Size(88, 34);
            this.lHourAr5.TabIndex = 56;
            this.lHourAr5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr5
            // 
            this.lConsAr5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr5.Location = new System.Drawing.Point(440, 3);
            this.lConsAr5.Name = "lConsAr5";
            this.lConsAr5.Size = new System.Drawing.Size(88, 34);
            this.lConsAr5.TabIndex = 55;
            this.lConsAr5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr5
            // 
            this.lIncAr5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr5.Location = new System.Drawing.Point(231, 3);
            this.lIncAr5.Name = "lIncAr5";
            this.lIncAr5.Size = new System.Drawing.Size(88, 34);
            this.lIncAr5.TabIndex = 54;
            this.lIncAr5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit05
            // 
            this.btArchEdit05.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit05.Name = "btArchEdit05";
            this.btArchEdit05.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit05.TabIndex = 53;
            this.btArchEdit05.Tag = "5";
            this.btArchEdit05.Text = "Править";
            this.btArchEdit05.UseVisualStyleBackColor = true;
            this.btArchEdit05.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr6
            // 
            this.lHourAr6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr6.Location = new System.Drawing.Point(648, 3);
            this.lHourAr6.Name = "lHourAr6";
            this.lHourAr6.Size = new System.Drawing.Size(88, 34);
            this.lHourAr6.TabIndex = 56;
            this.lHourAr6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr6
            // 
            this.lConsAr6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr6.Location = new System.Drawing.Point(440, 3);
            this.lConsAr6.Name = "lConsAr6";
            this.lConsAr6.Size = new System.Drawing.Size(88, 34);
            this.lConsAr6.TabIndex = 55;
            this.lConsAr6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr6
            // 
            this.lIncAr6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr6.Location = new System.Drawing.Point(231, 3);
            this.lIncAr6.Name = "lIncAr6";
            this.lIncAr6.Size = new System.Drawing.Size(88, 34);
            this.lIncAr6.TabIndex = 54;
            this.lIncAr6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit06
            // 
            this.btArchEdit06.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit06.Name = "btArchEdit06";
            this.btArchEdit06.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit06.TabIndex = 53;
            this.btArchEdit06.Tag = "6";
            this.btArchEdit06.Text = "Править";
            this.btArchEdit06.UseVisualStyleBackColor = true;
            this.btArchEdit06.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr7
            // 
            this.lHourAr7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr7.Location = new System.Drawing.Point(648, 3);
            this.lHourAr7.Name = "lHourAr7";
            this.lHourAr7.Size = new System.Drawing.Size(88, 34);
            this.lHourAr7.TabIndex = 56;
            this.lHourAr7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr7
            // 
            this.lConsAr7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr7.Location = new System.Drawing.Point(440, 3);
            this.lConsAr7.Name = "lConsAr7";
            this.lConsAr7.Size = new System.Drawing.Size(88, 34);
            this.lConsAr7.TabIndex = 55;
            this.lConsAr7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr7
            // 
            this.lIncAr7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr7.Location = new System.Drawing.Point(231, 3);
            this.lIncAr7.Name = "lIncAr7";
            this.lIncAr7.Size = new System.Drawing.Size(88, 34);
            this.lIncAr7.TabIndex = 54;
            this.lIncAr7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit07
            // 
            this.btArchEdit07.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit07.Name = "btArchEdit07";
            this.btArchEdit07.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit07.TabIndex = 53;
            this.btArchEdit07.Tag = "7";
            this.btArchEdit07.Text = "Править";
            this.btArchEdit07.UseVisualStyleBackColor = true;
            this.btArchEdit07.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr8
            // 
            this.lHourAr8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr8.Location = new System.Drawing.Point(648, 3);
            this.lHourAr8.Name = "lHourAr8";
            this.lHourAr8.Size = new System.Drawing.Size(88, 34);
            this.lHourAr8.TabIndex = 56;
            this.lHourAr8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr8
            // 
            this.lConsAr8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr8.Location = new System.Drawing.Point(440, 3);
            this.lConsAr8.Name = "lConsAr8";
            this.lConsAr8.Size = new System.Drawing.Size(88, 34);
            this.lConsAr8.TabIndex = 55;
            this.lConsAr8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr8
            // 
            this.lIncAr8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr8.Location = new System.Drawing.Point(231, 3);
            this.lIncAr8.Name = "lIncAr8";
            this.lIncAr8.Size = new System.Drawing.Size(88, 34);
            this.lIncAr8.TabIndex = 54;
            this.lIncAr8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit08
            // 
            this.btArchEdit08.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit08.Name = "btArchEdit08";
            this.btArchEdit08.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit08.TabIndex = 53;
            this.btArchEdit08.Tag = "8";
            this.btArchEdit08.Text = "Править";
            this.btArchEdit08.UseVisualStyleBackColor = true;
            this.btArchEdit08.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr9
            // 
            this.lHourAr9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr9.Location = new System.Drawing.Point(648, 3);
            this.lHourAr9.Name = "lHourAr9";
            this.lHourAr9.Size = new System.Drawing.Size(88, 34);
            this.lHourAr9.TabIndex = 56;
            this.lHourAr9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr9
            // 
            this.lConsAr9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr9.Location = new System.Drawing.Point(440, 3);
            this.lConsAr9.Name = "lConsAr9";
            this.lConsAr9.Size = new System.Drawing.Size(88, 34);
            this.lConsAr9.TabIndex = 55;
            this.lConsAr9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr9
            // 
            this.lIncAr9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr9.Location = new System.Drawing.Point(231, 3);
            this.lIncAr9.Name = "lIncAr9";
            this.lIncAr9.Size = new System.Drawing.Size(88, 34);
            this.lIncAr9.TabIndex = 54;
            this.lIncAr9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit09
            // 
            this.btArchEdit09.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit09.Name = "btArchEdit09";
            this.btArchEdit09.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit09.TabIndex = 53;
            this.btArchEdit09.Tag = "9";
            this.btArchEdit09.Text = "Править";
            this.btArchEdit09.UseVisualStyleBackColor = true;
            this.btArchEdit09.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr10
            // 
            this.lHourAr10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr10.Location = new System.Drawing.Point(648, 3);
            this.lHourAr10.Name = "lHourAr10";
            this.lHourAr10.Size = new System.Drawing.Size(88, 34);
            this.lHourAr10.TabIndex = 56;
            this.lHourAr10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lHourAr10.Click += new System.EventHandler(this.label61_Click);
            // 
            // lConsAr10
            // 
            this.lConsAr10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr10.Location = new System.Drawing.Point(440, 3);
            this.lConsAr10.Name = "lConsAr10";
            this.lConsAr10.Size = new System.Drawing.Size(88, 34);
            this.lConsAr10.TabIndex = 55;
            this.lConsAr10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr10
            // 
            this.lIncAr10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr10.Location = new System.Drawing.Point(231, 3);
            this.lIncAr10.Name = "lIncAr10";
            this.lIncAr10.Size = new System.Drawing.Size(88, 34);
            this.lIncAr10.TabIndex = 54;
            this.lIncAr10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit10
            // 
            this.btArchEdit10.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit10.Name = "btArchEdit10";
            this.btArchEdit10.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit10.TabIndex = 53;
            this.btArchEdit10.Tag = "10";
            this.btArchEdit10.Text = "Править";
            this.btArchEdit10.UseVisualStyleBackColor = true;
            this.btArchEdit10.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr11
            // 
            this.lHourAr11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr11.Location = new System.Drawing.Point(648, 3);
            this.lHourAr11.Name = "lHourAr11";
            this.lHourAr11.Size = new System.Drawing.Size(88, 34);
            this.lHourAr11.TabIndex = 56;
            this.lHourAr11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr11
            // 
            this.lConsAr11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr11.Location = new System.Drawing.Point(440, 3);
            this.lConsAr11.Name = "lConsAr11";
            this.lConsAr11.Size = new System.Drawing.Size(88, 34);
            this.lConsAr11.TabIndex = 55;
            this.lConsAr11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr11
            // 
            this.lIncAr11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr11.Location = new System.Drawing.Point(231, 3);
            this.lIncAr11.Name = "lIncAr11";
            this.lIncAr11.Size = new System.Drawing.Size(88, 34);
            this.lIncAr11.TabIndex = 54;
            this.lIncAr11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit11
            // 
            this.btArchEdit11.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit11.Name = "btArchEdit11";
            this.btArchEdit11.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit11.TabIndex = 53;
            this.btArchEdit11.Tag = "11";
            this.btArchEdit11.Text = "Править";
            this.btArchEdit11.UseVisualStyleBackColor = true;
            this.btArchEdit11.Click += new System.EventHandler(this.Archive_Click);
            // 
            // lHourAr12
            // 
            this.lHourAr12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHourAr12.Location = new System.Drawing.Point(648, 3);
            this.lHourAr12.Name = "lHourAr12";
            this.lHourAr12.Size = new System.Drawing.Size(88, 34);
            this.lHourAr12.TabIndex = 56;
            this.lHourAr12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lConsAr12
            // 
            this.lConsAr12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lConsAr12.Location = new System.Drawing.Point(440, 3);
            this.lConsAr12.Name = "lConsAr12";
            this.lConsAr12.Size = new System.Drawing.Size(88, 34);
            this.lConsAr12.TabIndex = 55;
            this.lConsAr12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIncAr12
            // 
            this.lIncAr12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lIncAr12.Location = new System.Drawing.Point(231, 3);
            this.lIncAr12.Name = "lIncAr12";
            this.lIncAr12.Size = new System.Drawing.Size(88, 34);
            this.lIncAr12.TabIndex = 54;
            this.lIncAr12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArchEdit12
            // 
            this.btArchEdit12.Location = new System.Drawing.Point(891, 8);
            this.btArchEdit12.Name = "btArchEdit12";
            this.btArchEdit12.Size = new System.Drawing.Size(105, 25);
            this.btArchEdit12.TabIndex = 53;
            this.btArchEdit12.Tag = "12";
            this.btArchEdit12.Text = "Править";
            this.btArchEdit12.UseVisualStyleBackColor = true;
            this.btArchEdit12.Click += new System.EventHandler(this.Archive_Click);
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
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Предоплата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 30;
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
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ccPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ccHours";
            this.dataGridViewTextBoxColumn15.HeaderText = "Часы";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 50;
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
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn20.FillWeight = 40F;
            this.dataGridViewTextBoxColumn20.HeaderText = "";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.dataGridViewTextBoxColumn21.Width = 441;
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
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "fNote";
            this.dataGridViewTextBoxColumn24.FillWeight = 70F;
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
            this.dataGridViewTextBoxColumn29.FillWeight = 70F;
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
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn33.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn33.HeaderText = "Название";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
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
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.cPrepay.DefaultCellStyle = dataGridViewCellStyle1;
            this.cPrepay.HeaderText = "Предоплата";
            this.cPrepay.Name = "cPrepay";
            // 
            // cExcess
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.cExcess.DefaultCellStyle = dataGridViewCellStyle2;
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
            // ccClientId
            // 
            this.ccClientId.DataPropertyName = "ccClientId";
            this.ccClientId.HeaderText = "ClientId";
            this.ccClientId.Name = "ccClientId";
            this.ccClientId.Visible = false;
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
            // ccPayerName
            // 
            this.ccPayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ccPayerName.DataPropertyName = "ccPayerName";
            this.ccPayerName.HeaderText = "Плательщик";
            this.ccPayerName.MinimumWidth = 50;
            this.ccPayerName.Name = "ccPayerName";
            // 
            // ccClientName
            // 
            this.ccClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ccClientName.DataPropertyName = "ccClientName";
            this.ccClientName.HeaderText = "Клиент";
            this.ccClientName.MinimumWidth = 50;
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
            // csId
            // 
            this.csId.DataPropertyName = "csId";
            this.csId.HeaderText = "Id";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 668);
            this.Controls.Add(this.tabApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1607, 701);
            this.Name = "Form1";
            this.Text = "Обсчёт заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitIncome.Panel1.ResumeLayout(false);
            this.splitIncome.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitIncome)).EndInit();
            this.splitIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chYear)).EndInit();
            this.panel19.ResumeLayout(false);
            this.splitCons.Panel1.ResumeLayout(false);
            this.splitCons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCons)).EndInit();
            this.splitCons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chCMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCYear)).EndInit();
            this.panel20.ResumeLayout(false);
            this.tabCert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabConsum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabGloss.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicClient)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicSource)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicWork)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDicCons)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.tabArchive.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabCert;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn csId;
        private System.Windows.Forms.DataGridViewTextBoxColumn csNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn csAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn csComment;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chYear;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SplitContainer splitCons;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCYear;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView grDicClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpNote;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grDicSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdsName;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView grDicWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdwId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdwName;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView grDicCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcName;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btDicSave;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHours;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbArchYear;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lHourAr12;
        private System.Windows.Forms.Label lConsAr12;
        private System.Windows.Forms.Label lIncAr12;
        private System.Windows.Forms.Button btArchEdit12;
        private System.Windows.Forms.Label lHourAr11;
        private System.Windows.Forms.Label lConsAr11;
        private System.Windows.Forms.Label lIncAr11;
        private System.Windows.Forms.Button btArchEdit11;
        private System.Windows.Forms.Label lHourAr10;
        private System.Windows.Forms.Label lConsAr10;
        private System.Windows.Forms.Label lIncAr10;
        private System.Windows.Forms.Button btArchEdit10;
        private System.Windows.Forms.Label lHourAr9;
        private System.Windows.Forms.Label lConsAr9;
        private System.Windows.Forms.Label lIncAr9;
        private System.Windows.Forms.Button btArchEdit09;
        private System.Windows.Forms.Label lHourAr8;
        private System.Windows.Forms.Label lConsAr8;
        private System.Windows.Forms.Label lIncAr8;
        private System.Windows.Forms.Button btArchEdit08;
        private System.Windows.Forms.Label lHourAr7;
        private System.Windows.Forms.Label lConsAr7;
        private System.Windows.Forms.Label lIncAr7;
        private System.Windows.Forms.Button btArchEdit07;
        private System.Windows.Forms.Label lHourAr6;
        private System.Windows.Forms.Label lConsAr6;
        private System.Windows.Forms.Label lIncAr6;
        private System.Windows.Forms.Button btArchEdit06;
        private System.Windows.Forms.Label lHourAr5;
        private System.Windows.Forms.Label lConsAr5;
        private System.Windows.Forms.Label lIncAr5;
        private System.Windows.Forms.Button btArchEdit05;
        private System.Windows.Forms.Label lHourAr4;
        private System.Windows.Forms.Label lConsAr4;
        private System.Windows.Forms.Label lIncAr4;
        private System.Windows.Forms.Button btArchEdit04;
        private System.Windows.Forms.Label lHourAr3;
        private System.Windows.Forms.Label lConsAr3;
        private System.Windows.Forms.Label lIncAr3;
        private System.Windows.Forms.Button btArchEdit03;
        private System.Windows.Forms.Label lHourAr2;
        private System.Windows.Forms.Label lConsAr2;
        private System.Windows.Forms.Label lIncAr2;
        private System.Windows.Forms.Button btArchEdit02;
        private System.Windows.Forms.Button btArchEdit01;
        private System.Windows.Forms.Label lHourAr1;
        private System.Windows.Forms.Label lConsAr1;
        private System.Windows.Forms.Label lIncAr1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
    }
}

