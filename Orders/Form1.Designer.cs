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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabArchive = new System.Windows.Forms.TabPage();
            this.lArcHourAvg = new System.Windows.Forms.Label();
            this.lArcHourAll = new System.Windows.Forms.Label();
            this.lArcHour12 = new System.Windows.Forms.Label();
            this.lArcHour11 = new System.Windows.Forms.Label();
            this.lArcHour10 = new System.Windows.Forms.Label();
            this.lArcHour9 = new System.Windows.Forms.Label();
            this.lArcHour8 = new System.Windows.Forms.Label();
            this.lArcHour7 = new System.Windows.Forms.Label();
            this.lArcHour6 = new System.Windows.Forms.Label();
            this.lArcHour5 = new System.Windows.Forms.Label();
            this.lArcHour4 = new System.Windows.Forms.Label();
            this.lArcHour3 = new System.Windows.Forms.Label();
            this.lArcHour2 = new System.Windows.Forms.Label();
            this.lArcHour1 = new System.Windows.Forms.Label();
            this.lArcProfAvg = new System.Windows.Forms.Label();
            this.lArcProfAll = new System.Windows.Forms.Label();
            this.lArcProf12 = new System.Windows.Forms.Label();
            this.lArcProf11 = new System.Windows.Forms.Label();
            this.lArcProf10 = new System.Windows.Forms.Label();
            this.lArcProf9 = new System.Windows.Forms.Label();
            this.lArcProf8 = new System.Windows.Forms.Label();
            this.lArcProf7 = new System.Windows.Forms.Label();
            this.lArcProf6 = new System.Windows.Forms.Label();
            this.lArcProf5 = new System.Windows.Forms.Label();
            this.lArcProf4 = new System.Windows.Forms.Label();
            this.lArcProf3 = new System.Windows.Forms.Label();
            this.lArcProf2 = new System.Windows.Forms.Label();
            this.lArcProf1 = new System.Windows.Forms.Label();
            this.lArcConsAvg = new System.Windows.Forms.Label();
            this.lArcConsAll = new System.Windows.Forms.Label();
            this.lArcCons12 = new System.Windows.Forms.Label();
            this.lArcCons11 = new System.Windows.Forms.Label();
            this.lArcCons10 = new System.Windows.Forms.Label();
            this.lArcCons9 = new System.Windows.Forms.Label();
            this.lArcCons8 = new System.Windows.Forms.Label();
            this.lArcCons7 = new System.Windows.Forms.Label();
            this.lArcCons6 = new System.Windows.Forms.Label();
            this.lArcCons5 = new System.Windows.Forms.Label();
            this.lArcCons4 = new System.Windows.Forms.Label();
            this.lArcCons3 = new System.Windows.Forms.Label();
            this.lArcCons2 = new System.Windows.Forms.Label();
            this.lArcCons1 = new System.Windows.Forms.Label();
            this.lArcIncAvg = new System.Windows.Forms.Label();
            this.lArcIncAll = new System.Windows.Forms.Label();
            this.lArcInc12 = new System.Windows.Forms.Label();
            this.lArcInc11 = new System.Windows.Forms.Label();
            this.lArcInc10 = new System.Windows.Forms.Label();
            this.lArcInc9 = new System.Windows.Forms.Label();
            this.lArcInc8 = new System.Windows.Forms.Label();
            this.lArcInc7 = new System.Windows.Forms.Label();
            this.lArcInc6 = new System.Windows.Forms.Label();
            this.lArcInc5 = new System.Windows.Forms.Label();
            this.lArcInc4 = new System.Windows.Forms.Label();
            this.lArcInc3 = new System.Windows.Forms.Label();
            this.lArcInc2 = new System.Windows.Forms.Label();
            this.lArcInc1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btArcHistory12 = new System.Windows.Forms.Button();
            this.btArcHistory11 = new System.Windows.Forms.Button();
            this.btArcHistory10 = new System.Windows.Forms.Button();
            this.btArcHistory9 = new System.Windows.Forms.Button();
            this.btArcHistory8 = new System.Windows.Forms.Button();
            this.btArcHistory7 = new System.Windows.Forms.Button();
            this.btArcHistory6 = new System.Windows.Forms.Button();
            this.btArcHistory5 = new System.Windows.Forms.Button();
            this.btArcHistory4 = new System.Windows.Forms.Button();
            this.btArcHistory3 = new System.Windows.Forms.Button();
            this.btArcHistory2 = new System.Windows.Forms.Button();
            this.btArcHistory1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cbArchYear = new System.Windows.Forms.ComboBox();
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
            this.tabConsum = new System.Windows.Forms.TabPage();
            this.grCons = new System.Windows.Forms.DataGridView();
            this.csDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chShowAll = new System.Windows.Forms.CheckBox();
            this.btConsSave = new System.Windows.Forms.Button();
            this.tabSert = new System.Windows.Forms.TabPage();
            this.grCert = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btCertSave = new System.Windows.Forms.Button();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.chrtSourceSum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.grWork = new System.Windows.Forms.DataGridView();
            this.cwSert = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cwDelete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.tabApp = new System.Windows.Forms.TabControl();
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
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwPrepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwExcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwCertId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.csTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csWorkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabArchive.SuspendLayout();
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
            this.tabConsum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabSert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSourceSum)).BeginInit();
            this.tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grWork)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pHistory.SuspendLayout();
            this.tabApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabArchive
            // 
            this.tabArchive.Controls.Add(this.lArcHourAvg);
            this.tabArchive.Controls.Add(this.lArcHourAll);
            this.tabArchive.Controls.Add(this.lArcHour12);
            this.tabArchive.Controls.Add(this.lArcHour11);
            this.tabArchive.Controls.Add(this.lArcHour10);
            this.tabArchive.Controls.Add(this.lArcHour9);
            this.tabArchive.Controls.Add(this.lArcHour8);
            this.tabArchive.Controls.Add(this.lArcHour7);
            this.tabArchive.Controls.Add(this.lArcHour6);
            this.tabArchive.Controls.Add(this.lArcHour5);
            this.tabArchive.Controls.Add(this.lArcHour4);
            this.tabArchive.Controls.Add(this.lArcHour3);
            this.tabArchive.Controls.Add(this.lArcHour2);
            this.tabArchive.Controls.Add(this.lArcHour1);
            this.tabArchive.Controls.Add(this.lArcProfAvg);
            this.tabArchive.Controls.Add(this.lArcProfAll);
            this.tabArchive.Controls.Add(this.lArcProf12);
            this.tabArchive.Controls.Add(this.lArcProf11);
            this.tabArchive.Controls.Add(this.lArcProf10);
            this.tabArchive.Controls.Add(this.lArcProf9);
            this.tabArchive.Controls.Add(this.lArcProf8);
            this.tabArchive.Controls.Add(this.lArcProf7);
            this.tabArchive.Controls.Add(this.lArcProf6);
            this.tabArchive.Controls.Add(this.lArcProf5);
            this.tabArchive.Controls.Add(this.lArcProf4);
            this.tabArchive.Controls.Add(this.lArcProf3);
            this.tabArchive.Controls.Add(this.lArcProf2);
            this.tabArchive.Controls.Add(this.lArcProf1);
            this.tabArchive.Controls.Add(this.lArcConsAvg);
            this.tabArchive.Controls.Add(this.lArcConsAll);
            this.tabArchive.Controls.Add(this.lArcCons12);
            this.tabArchive.Controls.Add(this.lArcCons11);
            this.tabArchive.Controls.Add(this.lArcCons10);
            this.tabArchive.Controls.Add(this.lArcCons9);
            this.tabArchive.Controls.Add(this.lArcCons8);
            this.tabArchive.Controls.Add(this.lArcCons7);
            this.tabArchive.Controls.Add(this.lArcCons6);
            this.tabArchive.Controls.Add(this.lArcCons5);
            this.tabArchive.Controls.Add(this.lArcCons4);
            this.tabArchive.Controls.Add(this.lArcCons3);
            this.tabArchive.Controls.Add(this.lArcCons2);
            this.tabArchive.Controls.Add(this.lArcCons1);
            this.tabArchive.Controls.Add(this.lArcIncAvg);
            this.tabArchive.Controls.Add(this.lArcIncAll);
            this.tabArchive.Controls.Add(this.lArcInc12);
            this.tabArchive.Controls.Add(this.lArcInc11);
            this.tabArchive.Controls.Add(this.lArcInc10);
            this.tabArchive.Controls.Add(this.lArcInc9);
            this.tabArchive.Controls.Add(this.lArcInc8);
            this.tabArchive.Controls.Add(this.lArcInc7);
            this.tabArchive.Controls.Add(this.lArcInc6);
            this.tabArchive.Controls.Add(this.lArcInc5);
            this.tabArchive.Controls.Add(this.lArcInc4);
            this.tabArchive.Controls.Add(this.lArcInc3);
            this.tabArchive.Controls.Add(this.lArcInc2);
            this.tabArchive.Controls.Add(this.lArcInc1);
            this.tabArchive.Controls.Add(this.label24);
            this.tabArchive.Controls.Add(this.label23);
            this.tabArchive.Controls.Add(this.label22);
            this.tabArchive.Controls.Add(this.label21);
            this.tabArchive.Controls.Add(this.label20);
            this.tabArchive.Controls.Add(this.label19);
            this.tabArchive.Controls.Add(this.btArcHistory12);
            this.tabArchive.Controls.Add(this.btArcHistory11);
            this.tabArchive.Controls.Add(this.btArcHistory10);
            this.tabArchive.Controls.Add(this.btArcHistory9);
            this.tabArchive.Controls.Add(this.btArcHistory8);
            this.tabArchive.Controls.Add(this.btArcHistory7);
            this.tabArchive.Controls.Add(this.btArcHistory6);
            this.tabArchive.Controls.Add(this.btArcHistory5);
            this.tabArchive.Controls.Add(this.btArcHistory4);
            this.tabArchive.Controls.Add(this.btArcHistory3);
            this.tabArchive.Controls.Add(this.btArcHistory2);
            this.tabArchive.Controls.Add(this.btArcHistory1);
            this.tabArchive.Controls.Add(this.label17);
            this.tabArchive.Controls.Add(this.cbArchYear);
            this.tabArchive.Location = new System.Drawing.Point(4, 24);
            this.tabArchive.Name = "tabArchive";
            this.tabArchive.Padding = new System.Windows.Forms.Padding(3);
            this.tabArchive.Size = new System.Drawing.Size(1591, 646);
            this.tabArchive.TabIndex = 5;
            this.tabArchive.Text = "Архив";
            this.tabArchive.UseVisualStyleBackColor = true;
            // 
            // lArcHourAvg
            // 
            this.lArcHourAvg.Location = new System.Drawing.Point(734, 583);
            this.lArcHourAvg.Name = "lArcHourAvg";
            this.lArcHourAvg.Size = new System.Drawing.Size(88, 34);
            this.lArcHourAvg.TabIndex = 113;
            this.lArcHourAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHourAll
            // 
            this.lArcHourAll.Location = new System.Drawing.Point(734, 550);
            this.lArcHourAll.Name = "lArcHourAll";
            this.lArcHourAll.Size = new System.Drawing.Size(88, 34);
            this.lArcHourAll.TabIndex = 112;
            this.lArcHourAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour12
            // 
            this.lArcHour12.Location = new System.Drawing.Point(734, 498);
            this.lArcHour12.Name = "lArcHour12";
            this.lArcHour12.Size = new System.Drawing.Size(88, 34);
            this.lArcHour12.TabIndex = 111;
            this.lArcHour12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour11
            // 
            this.lArcHour11.Location = new System.Drawing.Point(734, 458);
            this.lArcHour11.Name = "lArcHour11";
            this.lArcHour11.Size = new System.Drawing.Size(88, 34);
            this.lArcHour11.TabIndex = 110;
            this.lArcHour11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour10
            // 
            this.lArcHour10.Location = new System.Drawing.Point(734, 417);
            this.lArcHour10.Name = "lArcHour10";
            this.lArcHour10.Size = new System.Drawing.Size(88, 34);
            this.lArcHour10.TabIndex = 109;
            this.lArcHour10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour9
            // 
            this.lArcHour9.Location = new System.Drawing.Point(734, 377);
            this.lArcHour9.Name = "lArcHour9";
            this.lArcHour9.Size = new System.Drawing.Size(88, 34);
            this.lArcHour9.TabIndex = 108;
            this.lArcHour9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour8
            // 
            this.lArcHour8.Location = new System.Drawing.Point(734, 336);
            this.lArcHour8.Name = "lArcHour8";
            this.lArcHour8.Size = new System.Drawing.Size(88, 34);
            this.lArcHour8.TabIndex = 107;
            this.lArcHour8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour7
            // 
            this.lArcHour7.Location = new System.Drawing.Point(734, 296);
            this.lArcHour7.Name = "lArcHour7";
            this.lArcHour7.Size = new System.Drawing.Size(88, 34);
            this.lArcHour7.TabIndex = 106;
            this.lArcHour7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour6
            // 
            this.lArcHour6.Location = new System.Drawing.Point(734, 255);
            this.lArcHour6.Name = "lArcHour6";
            this.lArcHour6.Size = new System.Drawing.Size(88, 34);
            this.lArcHour6.TabIndex = 105;
            this.lArcHour6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour5
            // 
            this.lArcHour5.Location = new System.Drawing.Point(734, 215);
            this.lArcHour5.Name = "lArcHour5";
            this.lArcHour5.Size = new System.Drawing.Size(88, 34);
            this.lArcHour5.TabIndex = 104;
            this.lArcHour5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour4
            // 
            this.lArcHour4.Location = new System.Drawing.Point(734, 174);
            this.lArcHour4.Name = "lArcHour4";
            this.lArcHour4.Size = new System.Drawing.Size(88, 34);
            this.lArcHour4.TabIndex = 103;
            this.lArcHour4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour3
            // 
            this.lArcHour3.Location = new System.Drawing.Point(734, 134);
            this.lArcHour3.Name = "lArcHour3";
            this.lArcHour3.Size = new System.Drawing.Size(88, 34);
            this.lArcHour3.TabIndex = 102;
            this.lArcHour3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour2
            // 
            this.lArcHour2.Location = new System.Drawing.Point(734, 93);
            this.lArcHour2.Name = "lArcHour2";
            this.lArcHour2.Size = new System.Drawing.Size(88, 34);
            this.lArcHour2.TabIndex = 101;
            this.lArcHour2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcHour1
            // 
            this.lArcHour1.Location = new System.Drawing.Point(734, 53);
            this.lArcHour1.Name = "lArcHour1";
            this.lArcHour1.Size = new System.Drawing.Size(88, 34);
            this.lArcHour1.TabIndex = 100;
            this.lArcHour1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProfAvg
            // 
            this.lArcProfAvg.Location = new System.Drawing.Point(569, 583);
            this.lArcProfAvg.Name = "lArcProfAvg";
            this.lArcProfAvg.Size = new System.Drawing.Size(88, 34);
            this.lArcProfAvg.TabIndex = 99;
            this.lArcProfAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProfAll
            // 
            this.lArcProfAll.Location = new System.Drawing.Point(569, 550);
            this.lArcProfAll.Name = "lArcProfAll";
            this.lArcProfAll.Size = new System.Drawing.Size(88, 34);
            this.lArcProfAll.TabIndex = 98;
            this.lArcProfAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf12
            // 
            this.lArcProf12.Location = new System.Drawing.Point(569, 498);
            this.lArcProf12.Name = "lArcProf12";
            this.lArcProf12.Size = new System.Drawing.Size(88, 34);
            this.lArcProf12.TabIndex = 97;
            this.lArcProf12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf11
            // 
            this.lArcProf11.Location = new System.Drawing.Point(569, 458);
            this.lArcProf11.Name = "lArcProf11";
            this.lArcProf11.Size = new System.Drawing.Size(88, 34);
            this.lArcProf11.TabIndex = 96;
            this.lArcProf11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf10
            // 
            this.lArcProf10.Location = new System.Drawing.Point(569, 417);
            this.lArcProf10.Name = "lArcProf10";
            this.lArcProf10.Size = new System.Drawing.Size(88, 34);
            this.lArcProf10.TabIndex = 95;
            this.lArcProf10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf9
            // 
            this.lArcProf9.Location = new System.Drawing.Point(569, 377);
            this.lArcProf9.Name = "lArcProf9";
            this.lArcProf9.Size = new System.Drawing.Size(88, 34);
            this.lArcProf9.TabIndex = 94;
            this.lArcProf9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf8
            // 
            this.lArcProf8.Location = new System.Drawing.Point(569, 336);
            this.lArcProf8.Name = "lArcProf8";
            this.lArcProf8.Size = new System.Drawing.Size(88, 34);
            this.lArcProf8.TabIndex = 93;
            this.lArcProf8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf7
            // 
            this.lArcProf7.Location = new System.Drawing.Point(569, 296);
            this.lArcProf7.Name = "lArcProf7";
            this.lArcProf7.Size = new System.Drawing.Size(88, 34);
            this.lArcProf7.TabIndex = 92;
            this.lArcProf7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf6
            // 
            this.lArcProf6.Location = new System.Drawing.Point(569, 255);
            this.lArcProf6.Name = "lArcProf6";
            this.lArcProf6.Size = new System.Drawing.Size(88, 34);
            this.lArcProf6.TabIndex = 91;
            this.lArcProf6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf5
            // 
            this.lArcProf5.Location = new System.Drawing.Point(569, 215);
            this.lArcProf5.Name = "lArcProf5";
            this.lArcProf5.Size = new System.Drawing.Size(88, 34);
            this.lArcProf5.TabIndex = 90;
            this.lArcProf5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf4
            // 
            this.lArcProf4.Location = new System.Drawing.Point(569, 174);
            this.lArcProf4.Name = "lArcProf4";
            this.lArcProf4.Size = new System.Drawing.Size(88, 34);
            this.lArcProf4.TabIndex = 89;
            this.lArcProf4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf3
            // 
            this.lArcProf3.Location = new System.Drawing.Point(569, 134);
            this.lArcProf3.Name = "lArcProf3";
            this.lArcProf3.Size = new System.Drawing.Size(88, 34);
            this.lArcProf3.TabIndex = 88;
            this.lArcProf3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf2
            // 
            this.lArcProf2.Location = new System.Drawing.Point(569, 93);
            this.lArcProf2.Name = "lArcProf2";
            this.lArcProf2.Size = new System.Drawing.Size(88, 34);
            this.lArcProf2.TabIndex = 87;
            this.lArcProf2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcProf1
            // 
            this.lArcProf1.Location = new System.Drawing.Point(569, 53);
            this.lArcProf1.Name = "lArcProf1";
            this.lArcProf1.Size = new System.Drawing.Size(88, 34);
            this.lArcProf1.TabIndex = 86;
            this.lArcProf1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcConsAvg
            // 
            this.lArcConsAvg.Location = new System.Drawing.Point(404, 583);
            this.lArcConsAvg.Name = "lArcConsAvg";
            this.lArcConsAvg.Size = new System.Drawing.Size(88, 34);
            this.lArcConsAvg.TabIndex = 85;
            this.lArcConsAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcConsAll
            // 
            this.lArcConsAll.Location = new System.Drawing.Point(404, 550);
            this.lArcConsAll.Name = "lArcConsAll";
            this.lArcConsAll.Size = new System.Drawing.Size(88, 34);
            this.lArcConsAll.TabIndex = 84;
            this.lArcConsAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons12
            // 
            this.lArcCons12.Location = new System.Drawing.Point(404, 498);
            this.lArcCons12.Name = "lArcCons12";
            this.lArcCons12.Size = new System.Drawing.Size(88, 34);
            this.lArcCons12.TabIndex = 83;
            this.lArcCons12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons11
            // 
            this.lArcCons11.Location = new System.Drawing.Point(404, 458);
            this.lArcCons11.Name = "lArcCons11";
            this.lArcCons11.Size = new System.Drawing.Size(88, 34);
            this.lArcCons11.TabIndex = 82;
            this.lArcCons11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons10
            // 
            this.lArcCons10.Location = new System.Drawing.Point(404, 417);
            this.lArcCons10.Name = "lArcCons10";
            this.lArcCons10.Size = new System.Drawing.Size(88, 34);
            this.lArcCons10.TabIndex = 81;
            this.lArcCons10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons9
            // 
            this.lArcCons9.Location = new System.Drawing.Point(404, 377);
            this.lArcCons9.Name = "lArcCons9";
            this.lArcCons9.Size = new System.Drawing.Size(88, 34);
            this.lArcCons9.TabIndex = 80;
            this.lArcCons9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons8
            // 
            this.lArcCons8.Location = new System.Drawing.Point(404, 336);
            this.lArcCons8.Name = "lArcCons8";
            this.lArcCons8.Size = new System.Drawing.Size(88, 34);
            this.lArcCons8.TabIndex = 79;
            this.lArcCons8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons7
            // 
            this.lArcCons7.Location = new System.Drawing.Point(404, 296);
            this.lArcCons7.Name = "lArcCons7";
            this.lArcCons7.Size = new System.Drawing.Size(88, 34);
            this.lArcCons7.TabIndex = 78;
            this.lArcCons7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons6
            // 
            this.lArcCons6.Location = new System.Drawing.Point(404, 255);
            this.lArcCons6.Name = "lArcCons6";
            this.lArcCons6.Size = new System.Drawing.Size(88, 34);
            this.lArcCons6.TabIndex = 77;
            this.lArcCons6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons5
            // 
            this.lArcCons5.Location = new System.Drawing.Point(404, 215);
            this.lArcCons5.Name = "lArcCons5";
            this.lArcCons5.Size = new System.Drawing.Size(88, 34);
            this.lArcCons5.TabIndex = 76;
            this.lArcCons5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons4
            // 
            this.lArcCons4.Location = new System.Drawing.Point(404, 174);
            this.lArcCons4.Name = "lArcCons4";
            this.lArcCons4.Size = new System.Drawing.Size(88, 34);
            this.lArcCons4.TabIndex = 75;
            this.lArcCons4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons3
            // 
            this.lArcCons3.Location = new System.Drawing.Point(404, 134);
            this.lArcCons3.Name = "lArcCons3";
            this.lArcCons3.Size = new System.Drawing.Size(88, 34);
            this.lArcCons3.TabIndex = 74;
            this.lArcCons3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons2
            // 
            this.lArcCons2.Location = new System.Drawing.Point(404, 93);
            this.lArcCons2.Name = "lArcCons2";
            this.lArcCons2.Size = new System.Drawing.Size(88, 34);
            this.lArcCons2.TabIndex = 73;
            this.lArcCons2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcCons1
            // 
            this.lArcCons1.Location = new System.Drawing.Point(404, 53);
            this.lArcCons1.Name = "lArcCons1";
            this.lArcCons1.Size = new System.Drawing.Size(88, 34);
            this.lArcCons1.TabIndex = 72;
            this.lArcCons1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcIncAvg
            // 
            this.lArcIncAvg.Location = new System.Drawing.Point(239, 583);
            this.lArcIncAvg.Name = "lArcIncAvg";
            this.lArcIncAvg.Size = new System.Drawing.Size(88, 34);
            this.lArcIncAvg.TabIndex = 71;
            this.lArcIncAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcIncAll
            // 
            this.lArcIncAll.Location = new System.Drawing.Point(239, 550);
            this.lArcIncAll.Name = "lArcIncAll";
            this.lArcIncAll.Size = new System.Drawing.Size(88, 34);
            this.lArcIncAll.TabIndex = 70;
            this.lArcIncAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc12
            // 
            this.lArcInc12.Location = new System.Drawing.Point(239, 498);
            this.lArcInc12.Name = "lArcInc12";
            this.lArcInc12.Size = new System.Drawing.Size(88, 34);
            this.lArcInc12.TabIndex = 69;
            this.lArcInc12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc11
            // 
            this.lArcInc11.Location = new System.Drawing.Point(239, 458);
            this.lArcInc11.Name = "lArcInc11";
            this.lArcInc11.Size = new System.Drawing.Size(88, 34);
            this.lArcInc11.TabIndex = 68;
            this.lArcInc11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc10
            // 
            this.lArcInc10.Location = new System.Drawing.Point(239, 417);
            this.lArcInc10.Name = "lArcInc10";
            this.lArcInc10.Size = new System.Drawing.Size(88, 34);
            this.lArcInc10.TabIndex = 67;
            this.lArcInc10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc9
            // 
            this.lArcInc9.Location = new System.Drawing.Point(239, 377);
            this.lArcInc9.Name = "lArcInc9";
            this.lArcInc9.Size = new System.Drawing.Size(88, 34);
            this.lArcInc9.TabIndex = 66;
            this.lArcInc9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc8
            // 
            this.lArcInc8.Location = new System.Drawing.Point(239, 336);
            this.lArcInc8.Name = "lArcInc8";
            this.lArcInc8.Size = new System.Drawing.Size(88, 34);
            this.lArcInc8.TabIndex = 65;
            this.lArcInc8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc7
            // 
            this.lArcInc7.Location = new System.Drawing.Point(239, 296);
            this.lArcInc7.Name = "lArcInc7";
            this.lArcInc7.Size = new System.Drawing.Size(88, 34);
            this.lArcInc7.TabIndex = 64;
            this.lArcInc7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc6
            // 
            this.lArcInc6.Location = new System.Drawing.Point(239, 255);
            this.lArcInc6.Name = "lArcInc6";
            this.lArcInc6.Size = new System.Drawing.Size(88, 34);
            this.lArcInc6.TabIndex = 63;
            this.lArcInc6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc5
            // 
            this.lArcInc5.Location = new System.Drawing.Point(239, 215);
            this.lArcInc5.Name = "lArcInc5";
            this.lArcInc5.Size = new System.Drawing.Size(88, 34);
            this.lArcInc5.TabIndex = 62;
            this.lArcInc5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc4
            // 
            this.lArcInc4.Location = new System.Drawing.Point(239, 174);
            this.lArcInc4.Name = "lArcInc4";
            this.lArcInc4.Size = new System.Drawing.Size(88, 34);
            this.lArcInc4.TabIndex = 61;
            this.lArcInc4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc3
            // 
            this.lArcInc3.Location = new System.Drawing.Point(239, 134);
            this.lArcInc3.Name = "lArcInc3";
            this.lArcInc3.Size = new System.Drawing.Size(88, 34);
            this.lArcInc3.TabIndex = 60;
            this.lArcInc3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc2
            // 
            this.lArcInc2.Location = new System.Drawing.Point(239, 93);
            this.lArcInc2.Name = "lArcInc2";
            this.lArcInc2.Size = new System.Drawing.Size(88, 34);
            this.lArcInc2.TabIndex = 59;
            this.lArcInc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lArcInc1
            // 
            this.lArcInc1.Location = new System.Drawing.Point(239, 53);
            this.lArcInc1.Name = "lArcInc1";
            this.lArcInc1.Size = new System.Drawing.Size(88, 34);
            this.lArcInc1.TabIndex = 58;
            this.lArcInc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(73, 588);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 25);
            this.label24.TabIndex = 57;
            this.label24.Text = "Среднее:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(73, 555);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 25);
            this.label23.TabIndex = 56;
            this.label23.Text = "Всего:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(750, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 25);
            this.label22.TabIndex = 55;
            this.label22.Text = "Часов";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(585, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 25);
            this.label21.TabIndex = 54;
            this.label21.Text = "Прибыль";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(420, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 25);
            this.label20.TabIndex = 53;
            this.label20.Text = "Расход";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(255, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 25);
            this.label19.TabIndex = 52;
            this.label19.Text = "Доход";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArcHistory12
            // 
            this.btArcHistory12.Location = new System.Drawing.Point(53, 498);
            this.btArcHistory12.Name = "btArcHistory12";
            this.btArcHistory12.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory12.TabIndex = 51;
            this.btArcHistory12.Tag = "12";
            this.btArcHistory12.Text = "Декабрь";
            this.btArcHistory12.UseVisualStyleBackColor = true;
            this.btArcHistory12.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory11
            // 
            this.btArcHistory11.Location = new System.Drawing.Point(53, 458);
            this.btArcHistory11.Name = "btArcHistory11";
            this.btArcHistory11.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory11.TabIndex = 50;
            this.btArcHistory11.Tag = "11";
            this.btArcHistory11.Text = "Ноябрь";
            this.btArcHistory11.UseVisualStyleBackColor = true;
            this.btArcHistory11.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory10
            // 
            this.btArcHistory10.Location = new System.Drawing.Point(53, 417);
            this.btArcHistory10.Name = "btArcHistory10";
            this.btArcHistory10.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory10.TabIndex = 49;
            this.btArcHistory10.Tag = "10";
            this.btArcHistory10.Text = "Октябрь";
            this.btArcHistory10.UseVisualStyleBackColor = true;
            this.btArcHistory10.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory9
            // 
            this.btArcHistory9.Location = new System.Drawing.Point(53, 377);
            this.btArcHistory9.Name = "btArcHistory9";
            this.btArcHistory9.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory9.TabIndex = 48;
            this.btArcHistory9.Tag = "9";
            this.btArcHistory9.Text = "Сентябрь";
            this.btArcHistory9.UseVisualStyleBackColor = true;
            this.btArcHistory9.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory8
            // 
            this.btArcHistory8.Location = new System.Drawing.Point(53, 336);
            this.btArcHistory8.Name = "btArcHistory8";
            this.btArcHistory8.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory8.TabIndex = 47;
            this.btArcHistory8.Tag = "8";
            this.btArcHistory8.Text = "Август";
            this.btArcHistory8.UseVisualStyleBackColor = true;
            this.btArcHistory8.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory7
            // 
            this.btArcHistory7.Location = new System.Drawing.Point(53, 296);
            this.btArcHistory7.Name = "btArcHistory7";
            this.btArcHistory7.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory7.TabIndex = 46;
            this.btArcHistory7.Tag = "7";
            this.btArcHistory7.Text = "Июль";
            this.btArcHistory7.UseVisualStyleBackColor = true;
            this.btArcHistory7.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory6
            // 
            this.btArcHistory6.Location = new System.Drawing.Point(53, 255);
            this.btArcHistory6.Name = "btArcHistory6";
            this.btArcHistory6.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory6.TabIndex = 45;
            this.btArcHistory6.Tag = "6";
            this.btArcHistory6.Text = "Июнь";
            this.btArcHistory6.UseVisualStyleBackColor = true;
            this.btArcHistory6.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory5
            // 
            this.btArcHistory5.Location = new System.Drawing.Point(53, 215);
            this.btArcHistory5.Name = "btArcHistory5";
            this.btArcHistory5.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory5.TabIndex = 44;
            this.btArcHistory5.Tag = "5";
            this.btArcHistory5.Text = "Май";
            this.btArcHistory5.UseVisualStyleBackColor = true;
            this.btArcHistory5.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory4
            // 
            this.btArcHistory4.Location = new System.Drawing.Point(53, 174);
            this.btArcHistory4.Name = "btArcHistory4";
            this.btArcHistory4.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory4.TabIndex = 43;
            this.btArcHistory4.Tag = "4";
            this.btArcHistory4.Text = "Апрель";
            this.btArcHistory4.UseVisualStyleBackColor = true;
            this.btArcHistory4.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory3
            // 
            this.btArcHistory3.Location = new System.Drawing.Point(53, 134);
            this.btArcHistory3.Name = "btArcHistory3";
            this.btArcHistory3.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory3.TabIndex = 42;
            this.btArcHistory3.Tag = "3";
            this.btArcHistory3.Text = "Март";
            this.btArcHistory3.UseVisualStyleBackColor = true;
            this.btArcHistory3.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory2
            // 
            this.btArcHistory2.Location = new System.Drawing.Point(53, 93);
            this.btArcHistory2.Name = "btArcHistory2";
            this.btArcHistory2.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory2.TabIndex = 41;
            this.btArcHistory2.Tag = "2";
            this.btArcHistory2.Text = "Февраль";
            this.btArcHistory2.UseVisualStyleBackColor = true;
            this.btArcHistory2.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // btArcHistory1
            // 
            this.btArcHistory1.Location = new System.Drawing.Point(53, 53);
            this.btArcHistory1.Name = "btArcHistory1";
            this.btArcHistory1.Size = new System.Drawing.Size(92, 34);
            this.btArcHistory1.TabIndex = 40;
            this.btArcHistory1.Tag = "1";
            this.btArcHistory1.Text = "Январь";
            this.btArcHistory1.UseVisualStyleBackColor = true;
            this.btArcHistory1.Click += new System.EventHandler(this.ArcHistory_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Год:";
            // 
            // cbArchYear
            // 
            this.cbArchYear.FormattingEnabled = true;
            this.cbArchYear.Location = new System.Drawing.Point(53, 6);
            this.cbArchYear.Name = "cbArchYear";
            this.cbArchYear.Size = new System.Drawing.Size(127, 23);
            this.cbArchYear.TabIndex = 0;
            this.cbArchYear.SelectedIndexChanged += new System.EventHandler(this.cbArchYear_SelectedIndexChanged);
            // 
            // tabGloss
            // 
            this.tabGloss.Controls.Add(this.panel16);
            this.tabGloss.Controls.Add(this.panel7);
            this.tabGloss.Controls.Add(this.panel9);
            this.tabGloss.Controls.Add(this.panel8);
            this.tabGloss.Controls.Add(this.panel12);
            this.tabGloss.Location = new System.Drawing.Point(4, 24);
            this.tabGloss.Name = "tabGloss";
            this.tabGloss.Padding = new System.Windows.Forms.Padding(3);
            this.tabGloss.Size = new System.Drawing.Size(1591, 646);
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
            this.panel16.Size = new System.Drawing.Size(673, 614);
            this.panel16.TabIndex = 12;
            // 
            // grDicClient
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.grDicClient.Size = new System.Drawing.Size(673, 586);
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
            this.panel7.Size = new System.Drawing.Size(304, 614);
            this.panel7.TabIndex = 11;
            // 
            // grDicSource
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grDicSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdsId,
            this.cdsName});
            this.grDicSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicSource.Location = new System.Drawing.Point(0, 28);
            this.grDicSource.Name = "grDicSource";
            this.grDicSource.RowHeadersVisible = false;
            this.grDicSource.RowTemplate.Height = 24;
            this.grDicSource.Size = new System.Drawing.Size(304, 586);
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
            this.panel9.Size = new System.Drawing.Size(304, 614);
            this.panel9.TabIndex = 10;
            // 
            // grDicWork
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grDicWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdwId,
            this.cdwName});
            this.grDicWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicWork.Location = new System.Drawing.Point(0, 28);
            this.grDicWork.Name = "grDicWork";
            this.grDicWork.RowHeadersVisible = false;
            this.grDicWork.RowTemplate.Height = 24;
            this.grDicWork.Size = new System.Drawing.Size(304, 586);
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
            this.panel8.Size = new System.Drawing.Size(304, 614);
            this.panel8.TabIndex = 7;
            // 
            // grDicCons
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grDicCons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grDicCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDicCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdcId,
            this.cdcName});
            this.grDicCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDicCons.Location = new System.Drawing.Point(0, 28);
            this.grDicCons.Name = "grDicCons";
            this.grDicCons.RowHeadersVisible = false;
            this.grDicCons.RowTemplate.Height = 24;
            this.grDicCons.Size = new System.Drawing.Size(304, 586);
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
            this.panel12.Location = new System.Drawing.Point(3, 617);
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
            // 
            // tabConsum
            // 
            this.tabConsum.Controls.Add(this.grCons);
            this.tabConsum.Controls.Add(this.panel5);
            this.tabConsum.Location = new System.Drawing.Point(4, 24);
            this.tabConsum.Name = "tabConsum";
            this.tabConsum.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsum.Size = new System.Drawing.Size(1591, 646);
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
            this.csTypeId,
            this.csType,
            this.csAmount,
            this.csComment,
            this.csWorkId,
            this.csDelete});
            this.grCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCons.Location = new System.Drawing.Point(3, 3);
            this.grCons.Name = "grCons";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grCons.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grCons.RowHeadersVisible = false;
            this.grCons.RowTemplate.Height = 24;
            this.grCons.Size = new System.Drawing.Size(1585, 614);
            this.grCons.TabIndex = 1;
            this.grCons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCons_CellClick);
            this.grCons.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCons_CellValueChanged);
            // 
            // csDelete
            // 
            this.csDelete.HeaderText = "X";
            this.csDelete.Name = "csDelete";
            this.csDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.csDelete.Text = "X";
            this.csDelete.ToolTipText = "Удалить запись";
            this.csDelete.UseColumnTextForButtonValue = true;
            this.csDelete.Width = 25;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chShowAll);
            this.panel5.Controls.Add(this.btConsSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 617);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1585, 28);
            this.panel5.TabIndex = 0;
            // 
            // chShowAll
            // 
            this.chShowAll.AutoSize = true;
            this.chShowAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.chShowAll.Location = new System.Drawing.Point(0, 0);
            this.chShowAll.Name = "chShowAll";
            this.chShowAll.Size = new System.Drawing.Size(105, 28);
            this.chShowAll.TabIndex = 1;
            this.chShowAll.Text = "Показать все";
            this.chShowAll.UseVisualStyleBackColor = true;
            this.chShowAll.CheckedChanged += new System.EventHandler(this.chShowAll_CheckedChanged);
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
            // tabSert
            // 
            this.tabSert.Controls.Add(this.grCert);
            this.tabSert.Controls.Add(this.panel6);
            this.tabSert.Location = new System.Drawing.Point(4, 24);
            this.tabSert.Name = "tabSert";
            this.tabSert.Padding = new System.Windows.Forms.Padding(3);
            this.tabSert.Size = new System.Drawing.Size(1591, 646);
            this.tabSert.TabIndex = 1;
            this.tabSert.Text = "Сертификаты";
            this.tabSert.UseVisualStyleBackColor = true;
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
            this.grCert.Size = new System.Drawing.Size(1585, 614);
            this.grCert.TabIndex = 1;
            this.grCert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCert_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btCertSave);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 617);
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
            // 
            // tabGraph
            // 
            this.tabGraph.AutoScroll = true;
            this.tabGraph.Controls.Add(this.chrtSourceSum);
            this.tabGraph.Location = new System.Drawing.Point(4, 24);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(1591, 646);
            this.tabGraph.TabIndex = 4;
            this.tabGraph.Text = "Графики";
            this.tabGraph.UseVisualStyleBackColor = true;
            // 
            // chrtSourceSum
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LawnGreen;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LawnGreen;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea1.Name = "arIncSum";
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.Name = "arIncCount";
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.Name = "arConsWork";
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.Name = "arConsType";
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.Name = "arSourceSum";
            chartArea6.AxisX.Interval = 1D;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.Name = "arSourceCount";
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.Name = "arMonth";
            this.chrtSourceSum.ChartAreas.Add(chartArea1);
            this.chrtSourceSum.ChartAreas.Add(chartArea2);
            this.chrtSourceSum.ChartAreas.Add(chartArea3);
            this.chrtSourceSum.ChartAreas.Add(chartArea4);
            this.chrtSourceSum.ChartAreas.Add(chartArea5);
            this.chrtSourceSum.ChartAreas.Add(chartArea6);
            this.chrtSourceSum.ChartAreas.Add(chartArea7);
            this.chrtSourceSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtSourceSum.Location = new System.Drawing.Point(3, 3);
            this.chrtSourceSum.Name = "chrtSourceSum";
            this.chrtSourceSum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "arIncSum";
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.IsValueShownAsLabel = true;
            series1.LabelToolTip = "#VAL";
            series1.Legend = "Legend1";
            series1.Name = "serIncSum";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.ChartArea = "arIncSum";
            series2.CustomProperties = "DrawingStyle=Cylinder";
            series2.IsValueShownAsLabel = true;
            series2.LabelToolTip = "#VAL";
            series2.Legend = "Legend1";
            series2.Name = "serIncCount";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.ChartArea = "arConsWork";
            series3.CustomProperties = "DrawingStyle=Cylinder";
            series3.IsValueShownAsLabel = true;
            series3.LabelToolTip = "#VAL";
            series3.Legend = "Legend1";
            series3.Name = "serConsWork";
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series4.ChartArea = "arConsType";
            series4.CustomProperties = "DrawingStyle=Cylinder";
            series4.IsValueShownAsLabel = true;
            series4.LabelToolTip = "#VAL";
            series4.Legend = "Legend1";
            series4.Name = "serConsType";
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series5.ChartArea = "arSourceSum";
            series5.CustomProperties = "DrawingStyle=Cylinder";
            series5.IsValueShownAsLabel = true;
            series5.LabelToolTip = "#VAL";
            series5.Legend = "Legend1";
            series5.Name = "serSourceSum";
            series5.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series6.ChartArea = "arSourceCount";
            series6.CustomProperties = "DrawingStyle=Cylinder";
            series6.IsValueShownAsLabel = true;
            series6.LabelToolTip = "#VAL";
            series6.Legend = "Legend1";
            series6.Name = "serSourceCount";
            series6.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series7.ChartArea = "arMonth";
            series7.CustomProperties = "DrawingStyle=Cylinder";
            series7.IsValueShownAsLabel = true;
            series7.LabelToolTip = "#VAL";
            series7.Legend = "Legend1";
            series7.Name = "serMonth";
            series7.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.chrtSourceSum.Series.Add(series1);
            this.chrtSourceSum.Series.Add(series2);
            this.chrtSourceSum.Series.Add(series3);
            this.chrtSourceSum.Series.Add(series4);
            this.chrtSourceSum.Series.Add(series5);
            this.chrtSourceSum.Series.Add(series6);
            this.chrtSourceSum.Series.Add(series7);
            this.chrtSourceSum.Size = new System.Drawing.Size(1585, 640);
            this.chrtSourceSum.TabIndex = 0;
            this.chrtSourceSum.MouseEnter += new System.EventHandler(this.chrtSourceSum_MouseEnter);
            this.chrtSourceSum.MouseLeave += new System.EventHandler(this.chrtSourceSum_MouseLeave);
            // 
            // tabWork
            // 
            this.tabWork.Controls.Add(this.grWork);
            this.tabWork.Controls.Add(this.panel3);
            this.tabWork.Controls.Add(this.panel2);
            this.tabWork.Controls.Add(this.pHistory);
            this.tabWork.Location = new System.Drawing.Point(4, 24);
            this.tabWork.Name = "tabWork";
            this.tabWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabWork.Size = new System.Drawing.Size(1591, 646);
            this.tabWork.TabIndex = 0;
            this.tabWork.Text = "Работа";
            this.tabWork.UseVisualStyleBackColor = true;
            // 
            // grWork
            // 
            this.grWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cwNumber,
            this.cwId,
            this.cwClientId,
            this.cwClient,
            this.cwTypeId,
            this.cwType,
            this.cwPrepay,
            this.cwExcess,
            this.cwCons,
            this.cwHours,
            this.cwSourceId,
            this.cwSource,
            this.cwCertId,
            this.cwSert,
            this.cwDelete});
            this.grWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grWork.Location = new System.Drawing.Point(3, 43);
            this.grWork.Name = "grWork";
            this.grWork.RowHeadersVisible = false;
            this.grWork.RowTemplate.Height = 24;
            this.grWork.Size = new System.Drawing.Size(1306, 560);
            this.grWork.TabIndex = 5;
            this.grWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grWork_CellClick);
            this.grWork.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grWork_CellValueChanged);
            // 
            // cwSert
            // 
            this.cwSert.HeaderText = "Сертификат";
            this.cwSert.Name = "cwSert";
            this.cwSert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cwDelete
            // 
            this.cwDelete.HeaderText = "X";
            this.cwDelete.Name = "cwDelete";
            this.cwDelete.Text = "X";
            this.cwDelete.ToolTipText = "Удалить запись";
            this.cwDelete.UseColumnTextForButtonValue = true;
            this.cwDelete.Width = 25;
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
            this.panel3.Location = new System.Drawing.Point(3, 603);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 40);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
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
            this.label1.Size = new System.Drawing.Size(46, 15);
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
            this.label6.Size = new System.Drawing.Size(60, 15);
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
            this.label4.Size = new System.Drawing.Size(51, 15);
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
            this.label3.Size = new System.Drawing.Size(40, 15);
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
            this.label12.Size = new System.Drawing.Size(46, 15);
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
            this.label14.Size = new System.Drawing.Size(62, 15);
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
            this.label8.Size = new System.Drawing.Size(60, 15);
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
            this.label10.Size = new System.Drawing.Size(51, 15);
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
            this.pHistory.Size = new System.Drawing.Size(279, 640);
            this.pHistory.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSave.Location = new System.Drawing.Point(0, 603);
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
            this.tabApp.Size = new System.Drawing.Size(1599, 674);
            this.tabApp.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Доплата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
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
            this.dataGridViewTextBoxColumn12.Width = 120;
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
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ccHours";
            this.dataGridViewTextBoxColumn15.HeaderText = "Часы";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "csNumber";
            this.dataGridViewTextBoxColumn16.HeaderText = "";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "csAmount";
            this.dataGridViewTextBoxColumn17.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Width = 30;
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
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "fNote";
            this.dataGridViewTextBoxColumn24.FillWeight = 70F;
            this.dataGridViewTextBoxColumn24.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn25.FillWeight = 40F;
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
            this.dataGridViewTextBoxColumn31.FillWeight = 70F;
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
            this.dataGridViewTextBoxColumn33.FillWeight = 70F;
            this.dataGridViewTextBoxColumn33.HeaderText = "Название";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn34.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn34.HeaderText = "";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn35.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn35.HeaderText = "Название";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn36.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn36.FillWeight = 70F;
            this.dataGridViewTextBoxColumn36.HeaderText = "Id";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Visible = false;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn37.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn37.HeaderText = "Название";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Visible = false;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn38.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn38.HeaderText = "Название";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "fId";
            this.dataGridViewTextBoxColumn39.HeaderText = "Id";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Visible = false;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn40.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn40.HeaderText = "Название";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // cwNumber
            // 
            this.cwNumber.HeaderText = "";
            this.cwNumber.Name = "cwNumber";
            this.cwNumber.ReadOnly = true;
            this.cwNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cwNumber.Width = 40;
            // 
            // cwId
            // 
            this.cwId.HeaderText = "Id";
            this.cwId.Name = "cwId";
            this.cwId.ReadOnly = true;
            this.cwId.Visible = false;
            // 
            // cwClientId
            // 
            this.cwClientId.HeaderText = "ClientId";
            this.cwClientId.Name = "cwClientId";
            this.cwClientId.Visible = false;
            // 
            // cwClient
            // 
            this.cwClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cwClient.HeaderText = "Клиент";
            this.cwClient.Name = "cwClient";
            // 
            // cwTypeId
            // 
            this.cwTypeId.HeaderText = "TypeId";
            this.cwTypeId.Name = "cwTypeId";
            this.cwTypeId.Visible = false;
            // 
            // cwType
            // 
            this.cwType.HeaderText = "Вид работы";
            this.cwType.Name = "cwType";
            this.cwType.Width = 120;
            // 
            // cwPrepay
            // 
            this.cwPrepay.HeaderText = "Предоплата";
            this.cwPrepay.Name = "cwPrepay";
            // 
            // cwExcess
            // 
            this.cwExcess.HeaderText = "Доплата";
            this.cwExcess.Name = "cwExcess";
            // 
            // cwCons
            // 
            this.cwCons.HeaderText = "Расход";
            this.cwCons.Name = "cwCons";
            // 
            // cwHours
            // 
            this.cwHours.HeaderText = "Часы";
            this.cwHours.Name = "cwHours";
            // 
            // cwSourceId
            // 
            this.cwSourceId.HeaderText = "SourceId";
            this.cwSourceId.Name = "cwSourceId";
            this.cwSourceId.Visible = false;
            // 
            // cwSource
            // 
            this.cwSource.HeaderText = "Источник";
            this.cwSource.Name = "cwSource";
            this.cwSource.Width = 120;
            // 
            // cwCertId
            // 
            this.cwCertId.DataPropertyName = "cCertId";
            this.cwCertId.HeaderText = "CertId";
            this.cwCertId.Name = "cwCertId";
            this.cwCertId.Visible = false;
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
            this.ccPayerName.Name = "ccPayerName";
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
            // csTypeId
            // 
            this.csTypeId.HeaderText = "TypeId";
            this.csTypeId.Name = "csTypeId";
            this.csTypeId.Visible = false;
            // 
            // csType
            // 
            this.csType.HeaderText = "Вид расхода";
            this.csType.Name = "csType";
            this.csType.Width = 140;
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
            // csWorkId
            // 
            this.csWorkId.HeaderText = "Работа";
            this.csWorkId.Name = "csWorkId";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 674);
            this.Controls.Add(this.tabApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1607, 701);
            this.Name = "Form1";
            this.Text = "Обсчёт заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.tabArchive.ResumeLayout(false);
            this.tabArchive.PerformLayout();
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
            this.tabConsum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCons)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabSert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCert)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtSourceSum)).EndInit();
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
            this.tabApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.TabPage tabArchive;
        private System.Windows.Forms.Label lArcHourAvg;
        private System.Windows.Forms.Label lArcHourAll;
        private System.Windows.Forms.Label lArcHour12;
        private System.Windows.Forms.Label lArcHour11;
        private System.Windows.Forms.Label lArcHour10;
        private System.Windows.Forms.Label lArcHour9;
        private System.Windows.Forms.Label lArcHour8;
        private System.Windows.Forms.Label lArcHour7;
        private System.Windows.Forms.Label lArcHour6;
        private System.Windows.Forms.Label lArcHour5;
        private System.Windows.Forms.Label lArcHour4;
        private System.Windows.Forms.Label lArcHour3;
        private System.Windows.Forms.Label lArcHour2;
        private System.Windows.Forms.Label lArcHour1;
        private System.Windows.Forms.Label lArcProfAvg;
        private System.Windows.Forms.Label lArcProfAll;
        private System.Windows.Forms.Label lArcProf12;
        private System.Windows.Forms.Label lArcProf11;
        private System.Windows.Forms.Label lArcProf10;
        private System.Windows.Forms.Label lArcProf9;
        private System.Windows.Forms.Label lArcProf8;
        private System.Windows.Forms.Label lArcProf7;
        private System.Windows.Forms.Label lArcProf6;
        private System.Windows.Forms.Label lArcProf5;
        private System.Windows.Forms.Label lArcProf4;
        private System.Windows.Forms.Label lArcProf3;
        private System.Windows.Forms.Label lArcProf2;
        private System.Windows.Forms.Label lArcProf1;
        private System.Windows.Forms.Label lArcConsAvg;
        private System.Windows.Forms.Label lArcConsAll;
        private System.Windows.Forms.Label lArcCons12;
        private System.Windows.Forms.Label lArcCons11;
        private System.Windows.Forms.Label lArcCons10;
        private System.Windows.Forms.Label lArcCons9;
        private System.Windows.Forms.Label lArcCons8;
        private System.Windows.Forms.Label lArcCons7;
        private System.Windows.Forms.Label lArcCons6;
        private System.Windows.Forms.Label lArcCons5;
        private System.Windows.Forms.Label lArcCons4;
        private System.Windows.Forms.Label lArcCons3;
        private System.Windows.Forms.Label lArcCons2;
        private System.Windows.Forms.Label lArcCons1;
        private System.Windows.Forms.Label lArcIncAvg;
        private System.Windows.Forms.Label lArcIncAll;
        private System.Windows.Forms.Label lArcInc12;
        private System.Windows.Forms.Label lArcInc11;
        private System.Windows.Forms.Label lArcInc10;
        private System.Windows.Forms.Label lArcInc9;
        private System.Windows.Forms.Label lArcInc8;
        private System.Windows.Forms.Label lArcInc7;
        private System.Windows.Forms.Label lArcInc6;
        private System.Windows.Forms.Label lArcInc5;
        private System.Windows.Forms.Label lArcInc4;
        private System.Windows.Forms.Label lArcInc3;
        private System.Windows.Forms.Label lArcInc2;
        private System.Windows.Forms.Label lArcInc1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btArcHistory12;
        private System.Windows.Forms.Button btArcHistory11;
        private System.Windows.Forms.Button btArcHistory10;
        private System.Windows.Forms.Button btArcHistory9;
        private System.Windows.Forms.Button btArcHistory8;
        private System.Windows.Forms.Button btArcHistory7;
        private System.Windows.Forms.Button btArcHistory6;
        private System.Windows.Forms.Button btArcHistory5;
        private System.Windows.Forms.Button btArcHistory4;
        private System.Windows.Forms.Button btArcHistory3;
        private System.Windows.Forms.Button btArcHistory2;
        private System.Windows.Forms.Button btArcHistory1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbArchYear;
        private System.Windows.Forms.TabPage tabGloss;
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
        private System.Windows.Forms.TabPage tabConsum;
        private System.Windows.Forms.DataGridView grCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn csId;
        private System.Windows.Forms.DataGridViewTextBoxColumn csNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn csTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn csType;
        private System.Windows.Forms.DataGridViewTextBoxColumn csAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn csComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn csWorkId;
        private System.Windows.Forms.DataGridViewButtonColumn csDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chShowAll;
        private System.Windows.Forms.Button btConsSave;
        private System.Windows.Forms.TabPage tabSert;
        private System.Windows.Forms.DataGridView grCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccHours;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btCertSave;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.DataGridView grWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwPrepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwExcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwCertId;
        private System.Windows.Forms.DataGridViewButtonColumn cwSert;
        private System.Windows.Forms.DataGridViewButtonColumn cwDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lHoursC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lIncomeC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lProfitC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lConsC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lMonthC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lHoursY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lIncomeY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lIncomeYA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lProfitY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lConsY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.Button btSave;
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
        private System.Windows.Forms.Label lSumL2;
        private System.Windows.Forms.Label lSumC2;
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
        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSourceSum;
    }
}

