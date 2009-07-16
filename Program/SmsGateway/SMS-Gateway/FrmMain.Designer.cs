namespace SMS_Gateway
{
    partial class FrmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDiagnostic = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboFlowControl = new System.Windows.Forms.ComboBox();
            this.cboStopBit = new System.Windows.Forms.ComboBox();
            this.cboDataBit = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.gridInbox = new System.Windows.Forms.DataGridView();
            this.cmbInboxFilter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInboxLog = new System.Windows.Forms.TextBox();
            this.btnInboxClearLog = new System.Windows.Forms.Button();
            this.cmbInboxTimeInterval = new System.Windows.Forms.ComboBox();
            this.chkInboxTimeInterval = new System.Windows.Forms.CheckBox();
            this.tabOutbox = new System.Windows.Forms.TabPage();
            this.gridOutbox = new System.Windows.Forms.DataGridView();
            this.cmbOutBoxFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOutBoxLog = new System.Windows.Forms.TextBox();
            this.btnOutboxClearLog = new System.Windows.Forms.Button();
            this.cmbOutboxTimeInterval = new System.Windows.Forms.ComboBox();
            this.chkOutboxTimeInterval = new System.Windows.Forms.CheckBox();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReportDetail = new System.Windows.Forms.TextBox();
            this.gridReport = new System.Windows.Forms.DataGridView();
            this.dtReportFilter = new System.Windows.Forms.DateTimePicker();
            this.cmbReportFilter = new System.Windows.Forms.ComboBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gridComands = new System.Windows.Forms.DataGridView();
            this.Btn_Add_Cmd = new System.Windows.Forms.Button();
            this.gridBroadcastSchedule = new System.Windows.Forms.DataGridView();
            this.Btn_Add_Broadcast = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.InboxTimer = new System.Windows.Forms.Timer(this.components);
            this.OutboxTimer = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInbox)).BeginInit();
            this.tabOutbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutbox)).BeginInit();
            this.tabReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBroadcastSchedule)).BeginInit();
            this.statusBarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabGeneral);
            this.tabMain.Controls.Add(this.tabInbox);
            this.tabMain.Controls.Add(this.tabOutbox);
            this.tabMain.Controls.Add(this.tabReport);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Location = new System.Drawing.Point(8, 17);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(677, 385);
            this.tabMain.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.button1);
            this.tabGeneral.Controls.Add(this.label8);
            this.tabGeneral.Controls.Add(this.label6);
            this.tabGeneral.Controls.Add(this.btnDiagnostic);
            this.tabGeneral.Controls.Add(this.btnDisconnect);
            this.tabGeneral.Controls.Add(this.btnConnect);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Controls.Add(this.label7);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(669, 359);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(392, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send Test Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "SMS-Gateway";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "IJGC";
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiagnostic.Location = new System.Drawing.Point(256, 278);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Size = new System.Drawing.Size(89, 23);
            this.btnDiagnostic.TabIndex = 3;
            this.btnDiagnostic.Text = "Di&agnostic";
            this.btnDiagnostic.UseVisualStyleBackColor = true;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Location = new System.Drawing.Point(140, 278);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(110, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "&Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Location = new System.Drawing.Point(23, 278);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboFlowControl);
            this.groupBox1.Controls.Add(this.cboStopBit);
            this.groupBox1.Controls.Add(this.cboDataBit);
            this.groupBox1.Controls.Add(this.cboBaudRate);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.cboComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // cboFlowControl
            // 
            this.cboFlowControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlowControl.FormattingEnabled = true;
            this.cboFlowControl.Items.AddRange(new object[] {
            "None",
            "Hardware",
            "Xon/Xoff"});
            this.cboFlowControl.Location = new System.Drawing.Point(106, 139);
            this.cboFlowControl.Name = "cboFlowControl";
            this.cboFlowControl.Size = new System.Drawing.Size(121, 21);
            this.cboFlowControl.TabIndex = 17;
            // 
            // cboStopBit
            // 
            this.cboStopBit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBit.FormattingEnabled = true;
            this.cboStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBit.Location = new System.Drawing.Point(106, 112);
            this.cboStopBit.Name = "cboStopBit";
            this.cboStopBit.Size = new System.Drawing.Size(121, 21);
            this.cboStopBit.TabIndex = 16;
            // 
            // cboDataBit
            // 
            this.cboDataBit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBit.FormattingEnabled = true;
            this.cboDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboDataBit.Location = new System.Drawing.Point(106, 85);
            this.cboDataBit.Name = "cboDataBit";
            this.cboDataBit.Size = new System.Drawing.Size(121, 21);
            this.cboDataBit.TabIndex = 15;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(106, 58);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 14;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(26, 141);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 13);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Flow Control:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(26, 112);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Stop Bit:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Data Bit:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Baud Rate:";
            // 
            // cboComPort
            // 
            this.cboComPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.cboComPort.Location = new System.Drawing.Point(106, 31);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 21);
            this.cboComPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "___________________________";
            // 
            // tabInbox
            // 
            this.tabInbox.Controls.Add(this.gridInbox);
            this.tabInbox.Controls.Add(this.cmbInboxFilter);
            this.tabInbox.Controls.Add(this.label9);
            this.tabInbox.Controls.Add(this.txtInboxLog);
            this.tabInbox.Controls.Add(this.btnInboxClearLog);
            this.tabInbox.Controls.Add(this.cmbInboxTimeInterval);
            this.tabInbox.Controls.Add(this.chkInboxTimeInterval);
            this.tabInbox.Location = new System.Drawing.Point(4, 22);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabInbox.Size = new System.Drawing.Size(669, 359);
            this.tabInbox.TabIndex = 1;
            this.tabInbox.Text = "Inbox";
            this.tabInbox.UseVisualStyleBackColor = true;
            // 
            // gridInbox
            // 
            this.gridInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInbox.Location = new System.Drawing.Point(22, 192);
            this.gridInbox.Name = "gridInbox";
            this.gridInbox.Size = new System.Drawing.Size(627, 150);
            this.gridInbox.TabIndex = 6;
            // 
            // cmbInboxFilter
            // 
            this.cmbInboxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInboxFilter.FormattingEnabled = true;
            this.cmbInboxFilter.Items.AddRange(new object[] {
            "All",
            "Processed",
            "Not Processed"});
            this.cmbInboxFilter.Location = new System.Drawing.Point(23, 165);
            this.cmbInboxFilter.Name = "cmbInboxFilter";
            this.cmbInboxFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbInboxFilter.TabIndex = 5;
            this.cmbInboxFilter.SelectedIndexChanged += new System.EventHandler(this.cmbInboxFilter_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(625, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "_________________________________________________________________________________" +
                "______________________";
            // 
            // txtInboxLog
            // 
            this.txtInboxLog.Location = new System.Drawing.Point(22, 44);
            this.txtInboxLog.Multiline = true;
            this.txtInboxLog.Name = "txtInboxLog";
            this.txtInboxLog.ReadOnly = true;
            this.txtInboxLog.Size = new System.Drawing.Size(627, 87);
            this.txtInboxLog.TabIndex = 3;
            // 
            // btnInboxClearLog
            // 
            this.btnInboxClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInboxClearLog.Location = new System.Drawing.Point(559, 15);
            this.btnInboxClearLog.Name = "btnInboxClearLog";
            this.btnInboxClearLog.Size = new System.Drawing.Size(90, 23);
            this.btnInboxClearLog.TabIndex = 2;
            this.btnInboxClearLog.Text = "Clear &Now";
            this.btnInboxClearLog.UseVisualStyleBackColor = true;
            this.btnInboxClearLog.Click += new System.EventHandler(this.btnInboxClearLog_Click);
            // 
            // cmbInboxTimeInterval
            // 
            this.cmbInboxTimeInterval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInboxTimeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInboxTimeInterval.FormattingEnabled = true;
            this.cmbInboxTimeInterval.Items.AddRange(new object[] {
            "1  Minutes",
            "5  Minutes",
            "15 Minutes",
            "30 Minutes",
            "60 Minutes"});
            this.cmbInboxTimeInterval.Location = new System.Drawing.Point(108, 17);
            this.cmbInboxTimeInterval.Name = "cmbInboxTimeInterval";
            this.cmbInboxTimeInterval.Size = new System.Drawing.Size(120, 21);
            this.cmbInboxTimeInterval.TabIndex = 1;
            this.cmbInboxTimeInterval.SelectedIndexChanged += new System.EventHandler(this.cmbInboxTimeInterval_SelectedIndexChanged);
            // 
            // chkInboxTimeInterval
            // 
            this.chkInboxTimeInterval.AutoSize = true;
            this.chkInboxTimeInterval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInboxTimeInterval.Location = new System.Drawing.Point(22, 21);
            this.chkInboxTimeInterval.Name = "chkInboxTimeInterval";
            this.chkInboxTimeInterval.Size = new System.Drawing.Size(80, 17);
            this.chkInboxTimeInterval.TabIndex = 0;
            this.chkInboxTimeInterval.Text = "Clear Every";
            this.chkInboxTimeInterval.UseVisualStyleBackColor = true;
            this.chkInboxTimeInterval.CheckedChanged += new System.EventHandler(this.chkInboxTimeInterval_CheckedChanged);
            // 
            // tabOutbox
            // 
            this.tabOutbox.Controls.Add(this.gridOutbox);
            this.tabOutbox.Controls.Add(this.cmbOutBoxFilter);
            this.tabOutbox.Controls.Add(this.label10);
            this.tabOutbox.Controls.Add(this.txtOutBoxLog);
            this.tabOutbox.Controls.Add(this.btnOutboxClearLog);
            this.tabOutbox.Controls.Add(this.cmbOutboxTimeInterval);
            this.tabOutbox.Controls.Add(this.chkOutboxTimeInterval);
            this.tabOutbox.Location = new System.Drawing.Point(4, 22);
            this.tabOutbox.Name = "tabOutbox";
            this.tabOutbox.Size = new System.Drawing.Size(669, 359);
            this.tabOutbox.TabIndex = 2;
            this.tabOutbox.Text = "Outbox";
            this.tabOutbox.UseVisualStyleBackColor = true;
            // 
            // gridOutbox
            // 
            this.gridOutbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutbox.Location = new System.Drawing.Point(22, 192);
            this.gridOutbox.Name = "gridOutbox";
            this.gridOutbox.Size = new System.Drawing.Size(627, 150);
            this.gridOutbox.TabIndex = 13;
            // 
            // cmbOutBoxFilter
            // 
            this.cmbOutBoxFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOutBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutBoxFilter.FormattingEnabled = true;
            this.cmbOutBoxFilter.Items.AddRange(new object[] {
            "All",
            "Send",
            "Not Send"});
            this.cmbOutBoxFilter.Location = new System.Drawing.Point(23, 165);
            this.cmbOutBoxFilter.Name = "cmbOutBoxFilter";
            this.cmbOutBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbOutBoxFilter.TabIndex = 12;
            this.cmbOutBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cmbOutBoxFilter_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(637, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "_________________________________________________________________________________" +
                "________________________";
            // 
            // txtOutBoxLog
            // 
            this.txtOutBoxLog.Location = new System.Drawing.Point(22, 44);
            this.txtOutBoxLog.Multiline = true;
            this.txtOutBoxLog.Name = "txtOutBoxLog";
            this.txtOutBoxLog.ReadOnly = true;
            this.txtOutBoxLog.Size = new System.Drawing.Size(627, 87);
            this.txtOutBoxLog.TabIndex = 10;
            // 
            // btnOutboxClearLog
            // 
            this.btnOutboxClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutboxClearLog.Location = new System.Drawing.Point(559, 15);
            this.btnOutboxClearLog.Name = "btnOutboxClearLog";
            this.btnOutboxClearLog.Size = new System.Drawing.Size(90, 23);
            this.btnOutboxClearLog.TabIndex = 9;
            this.btnOutboxClearLog.Text = "Clear &Now";
            this.btnOutboxClearLog.UseVisualStyleBackColor = true;
            this.btnOutboxClearLog.Click += new System.EventHandler(this.btnOutboxClearLog_Click);
            // 
            // cmbOutboxTimeInterval
            // 
            this.cmbOutboxTimeInterval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOutboxTimeInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutboxTimeInterval.FormattingEnabled = true;
            this.cmbOutboxTimeInterval.Items.AddRange(new object[] {
            "1  Minutes",
            "5  Minutes",
            "15 Minutes",
            "30 Minutes",
            "60 Minutes"});
            this.cmbOutboxTimeInterval.Location = new System.Drawing.Point(108, 17);
            this.cmbOutboxTimeInterval.Name = "cmbOutboxTimeInterval";
            this.cmbOutboxTimeInterval.Size = new System.Drawing.Size(120, 21);
            this.cmbOutboxTimeInterval.TabIndex = 8;
            this.cmbOutboxTimeInterval.SelectedIndexChanged += new System.EventHandler(this.cmbOutboxTimeInterval_SelectedIndexChanged);
            // 
            // chkOutboxTimeInterval
            // 
            this.chkOutboxTimeInterval.AutoSize = true;
            this.chkOutboxTimeInterval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOutboxTimeInterval.Location = new System.Drawing.Point(22, 21);
            this.chkOutboxTimeInterval.Name = "chkOutboxTimeInterval";
            this.chkOutboxTimeInterval.Size = new System.Drawing.Size(80, 17);
            this.chkOutboxTimeInterval.TabIndex = 7;
            this.chkOutboxTimeInterval.Text = "Clear Every";
            this.chkOutboxTimeInterval.UseVisualStyleBackColor = true;
            this.chkOutboxTimeInterval.CheckedChanged += new System.EventHandler(this.chkOutboxTimeInterval_CheckedChanged);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.groupBox2);
            this.tabReport.Controls.Add(this.gridReport);
            this.tabReport.Controls.Add(this.dtReportFilter);
            this.tabReport.Controls.Add(this.cmbReportFilter);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(669, 359);
            this.tabReport.TabIndex = 3;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReportDetail);
            this.groupBox2.Location = new System.Drawing.Point(21, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Info";
            // 
            // txtReportDetail
            // 
            this.txtReportDetail.Location = new System.Drawing.Point(6, 19);
            this.txtReportDetail.Multiline = true;
            this.txtReportDetail.Name = "txtReportDetail";
            this.txtReportDetail.Size = new System.Drawing.Size(620, 138);
            this.txtReportDetail.TabIndex = 0;
            // 
            // gridReport
            // 
            this.gridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReport.Location = new System.Drawing.Point(21, 48);
            this.gridReport.Name = "gridReport";
            this.gridReport.Size = new System.Drawing.Size(632, 125);
            this.gridReport.TabIndex = 2;
            // 
            // dtReportFilter
            // 
            this.dtReportFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtReportFilter.CustomFormat = "dd-MM-yyyy";
            this.dtReportFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReportFilter.Location = new System.Drawing.Point(148, 22);
            this.dtReportFilter.Name = "dtReportFilter";
            this.dtReportFilter.Size = new System.Drawing.Size(113, 20);
            this.dtReportFilter.TabIndex = 1;
            // 
            // cmbReportFilter
            // 
            this.cmbReportFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReportFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportFilter.FormattingEnabled = true;
            this.cmbReportFilter.Location = new System.Drawing.Point(21, 21);
            this.cmbReportFilter.Name = "cmbReportFilter";
            this.cmbReportFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbReportFilter.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.gridComands);
            this.tabSettings.Controls.Add(this.Btn_Add_Cmd);
            this.tabSettings.Controls.Add(this.gridBroadcastSchedule);
            this.tabSettings.Controls.Add(this.Btn_Add_Broadcast);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(669, 359);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // gridComands
            // 
            this.gridComands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComands.Location = new System.Drawing.Point(19, 228);
            this.gridComands.Name = "gridComands";
            this.gridComands.Size = new System.Drawing.Size(634, 121);
            this.gridComands.TabIndex = 3;
            this.gridComands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComands_CellContentClick);
            // 
            // Btn_Add_Cmd
            // 
            this.Btn_Add_Cmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add_Cmd.Location = new System.Drawing.Point(19, 199);
            this.Btn_Add_Cmd.Name = "Btn_Add_Cmd";
            this.Btn_Add_Cmd.Size = new System.Drawing.Size(198, 23);
            this.Btn_Add_Cmd.TabIndex = 2;
            this.Btn_Add_Cmd.Text = "Add Command Request / Broadcast";
            this.Btn_Add_Cmd.UseVisualStyleBackColor = true;
            this.Btn_Add_Cmd.Click += new System.EventHandler(this.Btn_Add_Cmd_Click);
            // 
            // gridBroadcastSchedule
            // 
            this.gridBroadcastSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBroadcastSchedule.Location = new System.Drawing.Point(19, 51);
            this.gridBroadcastSchedule.Name = "gridBroadcastSchedule";
            this.gridBroadcastSchedule.Size = new System.Drawing.Size(634, 122);
            this.gridBroadcastSchedule.TabIndex = 1;
            // 
            // Btn_Add_Broadcast
            // 
            this.Btn_Add_Broadcast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add_Broadcast.Location = new System.Drawing.Point(19, 22);
            this.Btn_Add_Broadcast.Name = "Btn_Add_Broadcast";
            this.Btn_Add_Broadcast.Size = new System.Drawing.Size(137, 23);
            this.Btn_Add_Broadcast.TabIndex = 0;
            this.Btn_Add_Broadcast.Text = "Add Broadcast Schedule";
            this.Btn_Add_Broadcast.UseVisualStyleBackColor = true;
            this.Btn_Add_Broadcast.Click += new System.EventHandler(this.Btn_Add_Broadcast_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.Location = new System.Drawing.Point(571, 408);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(94, 23);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "&Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // statusBarMain
            // 
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBarMain.Location = new System.Drawing.Point(0, 438);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(697, 22);
            this.statusBarMain.TabIndex = 2;
            this.statusBarMain.Text = "Not Connected";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // InboxTimer
            // 
            this.InboxTimer.Tick += new System.EventHandler(this.InboxTimer_Tick);
            // 
            // OutboxTimer
            // 
            this.OutboxTimer.Tick += new System.EventHandler(this.OutboxTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 460);
            this.Controls.Add(this.statusBarMain);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Gateway";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainClose);
            this.tabMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabInbox.ResumeLayout(false);
            this.tabInbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInbox)).EndInit();
            this.tabOutbox.ResumeLayout(false);
            this.tabOutbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutbox)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.tabSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBroadcastSchedule)).EndInit();
            this.statusBarMain.ResumeLayout(false);
            this.statusBarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabOutbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiagnostic;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.ComboBox cboFlowControl;
        internal System.Windows.Forms.ComboBox cboStopBit;
        internal System.Windows.Forms.ComboBox cboDataBit;
        internal System.Windows.Forms.ComboBox cboBaudRate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.ComboBox cmbInboxTimeInterval;
        private System.Windows.Forms.CheckBox chkInboxTimeInterval;
        private System.Windows.Forms.Button btnInboxClearLog;
        private System.Windows.Forms.TextBox txtInboxLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridInbox;
        private System.Windows.Forms.ComboBox cmbInboxFilter;
        private System.Windows.Forms.DataGridView gridOutbox;
        private System.Windows.Forms.ComboBox cmbOutBoxFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOutBoxLog;
        private System.Windows.Forms.Button btnOutboxClearLog;
        private System.Windows.Forms.ComboBox cmbOutboxTimeInterval;
        private System.Windows.Forms.CheckBox chkOutboxTimeInterval;
        private System.Windows.Forms.DateTimePicker dtReportFilter;
        private System.Windows.Forms.ComboBox cmbReportFilter;
        private System.Windows.Forms.DataGridView gridReport;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReportDetail;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer InboxTimer;
        private System.Windows.Forms.Timer OutboxTimer;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button Btn_Add_Broadcast;
        private System.Windows.Forms.Button Btn_Add_Cmd;
        private System.Windows.Forms.DataGridView gridBroadcastSchedule;
        private System.Windows.Forms.DataGridView gridComands;
    }
}

