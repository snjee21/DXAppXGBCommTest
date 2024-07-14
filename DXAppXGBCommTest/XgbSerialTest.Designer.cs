namespace DXAppXGBCommTest {
  partial class FormMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      bool isDesignMode = DesignMode;
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
      if (--OpenFormCount == 0 && !isDesignMode) {
        System.Windows.Forms.Application.Exit();
      }
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
      this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
      this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.tabFormPageDashBoard = new DevExpress.XtraBars.TabFormPage();
      this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
      this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
      this.groupControl10 = new DevExpress.XtraEditors.GroupControl();
      this.dgvData = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
      this.lblDataCnt = new DevExpress.XtraEditors.LabelControl();
      this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
      this.lblBlkCnt = new DevExpress.XtraEditors.LabelControl();
      this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
      this.lblCmdType = new DevExpress.XtraEditors.LabelControl();
      this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
      this.lblCmd = new DevExpress.XtraEditors.LabelControl();
      this.textEditReceived = new DevExpress.XtraEditors.TextEdit();
      this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
      this.lblAddr = new DevExpress.XtraEditors.LabelControl();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupControl11 = new DevExpress.XtraEditors.GroupControl();
      this.textEditSendCmd = new DevExpress.XtraEditors.TextEdit();
      this.checkButtonEditCmd = new DevExpress.XtraEditors.CheckButton();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.label10 = new System.Windows.Forms.Label();
      this.textEditUid = new DevExpress.XtraEditors.TextEdit();
      this.label11 = new System.Windows.Forms.Label();
      this.textEditCommand = new DevExpress.XtraEditors.TextEdit();
      this.label16 = new System.Windows.Forms.Label();
      this.textEditBlocks = new DevExpress.XtraEditors.TextEdit();
      this.buttonSend = new DevExpress.XtraEditors.SimpleButton();
      this.buttonAssyData = new DevExpress.XtraEditors.SimpleButton();
      this.label14 = new System.Windows.Forms.Label();
      this.textEditDataCounter = new DevExpress.XtraEditors.TextEdit();
      this.textEditData = new DevExpress.XtraEditors.TextEdit();
      this.label6 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.textEditAddr = new DevExpress.XtraEditors.TextEdit();
      this.textEditVarLen = new DevExpress.XtraEditors.TextEdit();
      this.label13 = new System.Windows.Forms.Label();
      this.textEditDevice = new DevExpress.XtraEditors.TextEdit();
      this.label15 = new System.Windows.Forms.Label();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.radioButtonSS = new System.Windows.Forms.RadioButton();
      this.radioButtonSB = new System.Windows.Forms.RadioButton();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.radioButtonDword = new System.Windows.Forms.RadioButton();
      this.radioButtonLword = new System.Windows.Forms.RadioButton();
      this.radioButtonByte = new System.Windows.Forms.RadioButton();
      this.radioButtonWord = new System.Windows.Forms.RadioButton();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.checkButtonSerialPort = new DevExpress.XtraEditors.CheckButton();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.buttonError = new System.Windows.Forms.Button();
      this.buttonConnect = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButtonWrite = new System.Windows.Forms.RadioButton();
      this.radioButtonRead = new System.Windows.Forms.RadioButton();
      this.tabFormPageSettings = new DevExpress.XtraBars.TabFormPage();
      this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
      this.comboBoxStopbits = new System.Windows.Forms.ComboBox();
      this.comboBoxParity = new System.Windows.Forms.ComboBox();
      this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
      this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
      this.comboBoxPort = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tabFormTest = new DevExpress.XtraBars.TabFormPage();
      this.tabFormContentContainer3 = new DevExpress.XtraBars.TabFormContentContainer();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.rbctrl20Lstd = new System.Windows.Forms.RadioButton();
      this.rbctrl2Lstd = new System.Windows.Forms.RadioButton();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.rbctrlModeElecMeter = new System.Windows.Forms.RadioButton();
      this.rbctrlModeEncoder = new System.Windows.Forms.RadioButton();
      this.rbctrlModePhotoSensor = new System.Windows.Forms.RadioButton();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.radioButtonCont = new System.Windows.Forms.RadioButton();
      this.radioButtonSeq = new System.Windows.Forms.RadioButton();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.rbctrlTestEnd = new System.Windows.Forms.RadioButton();
      this.rbctrlTestStart = new System.Windows.Forms.RadioButton();
      this.serialPortXGT = new System.IO.Ports.SerialPort(this.components);
      this.timerUiUpdate = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
      this.tabFormContentContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
      this.groupControl4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).BeginInit();
      this.groupControl10.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
      this.groupControl9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
      this.groupControl8.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
      this.groupControl7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
      this.groupControl6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textEditReceived.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
      this.groupControl5.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).BeginInit();
      this.groupControl11.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textEditSendCmd.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textEditUid.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditCommand.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditBlocks.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditDataCounter.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditData.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditAddr.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditVarLen.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditDevice.Properties)).BeginInit();
      this.groupBox9.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabFormContentContainer2.SuspendLayout();
      this.tabFormContentContainer3.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabFormControl1
      // 
      this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1});
      this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
      this.tabFormControl1.Manager = this.tabFormDefaultManager1;
      this.tabFormControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.tabFormControl1.Name = "tabFormControl1";
      this.tabFormControl1.Pages.Add(this.tabFormPageDashBoard);
      this.tabFormControl1.Pages.Add(this.tabFormPageSettings);
      this.tabFormControl1.Pages.Add(this.tabFormTest);
      this.tabFormControl1.SelectedPage = this.tabFormPageDashBoard;
      this.tabFormControl1.ShowAddPageButton = false;
      this.tabFormControl1.ShowTabCloseButtons = false;
      this.tabFormControl1.Size = new System.Drawing.Size(1311, 78);
      this.tabFormControl1.TabForm = this;
      this.tabFormControl1.TabIndex = 0;
      this.tabFormControl1.TabRightItemLinks.Add(this.skinDropDownButtonItem1);
      this.tabFormControl1.TabStop = false;
      this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
      // 
      // skinDropDownButtonItem1
      // 
      this.skinDropDownButtonItem1.Id = 0;
      this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
      // 
      // tabFormDefaultManager1
      // 
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
      this.tabFormDefaultManager1.DockingEnabled = false;
      this.tabFormDefaultManager1.Form = this;
      this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1});
      this.tabFormDefaultManager1.MaxItemId = 1;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 78);
      this.barDockControlTop.Manager = null;
      this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.barDockControlTop.Size = new System.Drawing.Size(1311, 0);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 672);
      this.barDockControlBottom.Manager = null;
      this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.barDockControlBottom.Size = new System.Drawing.Size(1311, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 78);
      this.barDockControlLeft.Manager = null;
      this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 594);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(1311, 78);
      this.barDockControlRight.Manager = null;
      this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 594);
      // 
      // tabFormPageDashBoard
      // 
      this.tabFormPageDashBoard.ContentContainer = this.tabFormContentContainer1;
      this.tabFormPageDashBoard.Name = "tabFormPageDashBoard";
      this.tabFormPageDashBoard.Text = "Dashboard";
      // 
      // tabFormContentContainer1
      // 
      this.tabFormContentContainer1.Controls.Add(this.groupControl4);
      this.tabFormContentContainer1.Controls.Add(this.statusStrip);
      this.tabFormContentContainer1.Controls.Add(this.groupBox2);
      this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 78);
      this.tabFormContentContainer1.Margin = new System.Windows.Forms.Padding(4);
      this.tabFormContentContainer1.Name = "tabFormContentContainer1";
      this.tabFormContentContainer1.Size = new System.Drawing.Size(1311, 594);
      this.tabFormContentContainer1.TabIndex = 1;
      // 
      // groupControl4
      // 
      this.groupControl4.Controls.Add(this.groupControl10);
      this.groupControl4.Controls.Add(this.groupControl9);
      this.groupControl4.Controls.Add(this.groupControl8);
      this.groupControl4.Controls.Add(this.groupControl7);
      this.groupControl4.Controls.Add(this.groupControl6);
      this.groupControl4.Controls.Add(this.textEditReceived);
      this.groupControl4.Controls.Add(this.groupControl5);
      this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl4.Location = new System.Drawing.Point(661, 8);
      this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
      this.groupControl4.Name = "groupControl4";
      this.groupControl4.Size = new System.Drawing.Size(638, 548);
      this.groupControl4.TabIndex = 1;
      this.groupControl4.Text = "수신";
      // 
      // groupControl10
      // 
      this.groupControl10.Controls.Add(this.dgvData);
      this.groupControl10.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl10.Location = new System.Drawing.Point(18, 129);
      this.groupControl10.Name = "groupControl10";
      this.groupControl10.Size = new System.Drawing.Size(604, 406);
      this.groupControl10.TabIndex = 6;
      this.groupControl10.Text = "Parsing Data";
      // 
      // dgvData
      // 
      this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
      this.dgvData.Cursor = System.Windows.Forms.Cursors.Default;
      this.dgvData.Location = new System.Drawing.Point(16, 27);
      this.dgvData.Margin = new System.Windows.Forms.Padding(4);
      this.dgvData.Name = "dgvData";
      this.dgvData.RowTemplate.Height = 23;
      this.dgvData.Size = new System.Drawing.Size(561, 365);
      this.dgvData.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "01";
      this.Column1.Name = "Column1";
      this.Column1.Width = 50;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "02";
      this.Column2.Name = "Column2";
      this.Column2.Width = 50;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "03";
      this.Column3.Name = "Column3";
      this.Column3.Width = 50;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "04";
      this.Column4.Name = "Column4";
      this.Column4.Width = 50;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "05";
      this.Column5.Name = "Column5";
      this.Column5.Width = 50;
      // 
      // Column6
      // 
      this.Column6.HeaderText = "06";
      this.Column6.Name = "Column6";
      this.Column6.Width = 50;
      // 
      // Column7
      // 
      this.Column7.HeaderText = "07";
      this.Column7.Name = "Column7";
      this.Column7.Width = 50;
      // 
      // Column8
      // 
      this.Column8.HeaderText = "08";
      this.Column8.Name = "Column8";
      this.Column8.Width = 50;
      // 
      // Column9
      // 
      this.Column9.HeaderText = "09";
      this.Column9.Name = "Column9";
      this.Column9.Width = 50;
      // 
      // Column10
      // 
      this.Column10.HeaderText = "10";
      this.Column10.Name = "Column10";
      this.Column10.Width = 50;
      // 
      // groupControl9
      // 
      this.groupControl9.Controls.Add(this.lblDataCnt);
      this.groupControl9.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl9.Location = new System.Drawing.Point(514, 59);
      this.groupControl9.Name = "groupControl9";
      this.groupControl9.Size = new System.Drawing.Size(107, 64);
      this.groupControl9.TabIndex = 5;
      this.groupControl9.Text = "데이터개수";
      // 
      // lblDataCnt
      // 
      this.lblDataCnt.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblDataCnt.Appearance.Options.UseFont = true;
      this.lblDataCnt.Location = new System.Drawing.Point(6, 27);
      this.lblDataCnt.Margin = new System.Windows.Forms.Padding(4);
      this.lblDataCnt.Name = "lblDataCnt";
      this.lblDataCnt.Size = new System.Drawing.Size(75, 20);
      this.lblDataCnt.TabIndex = 0;
      this.lblDataCnt.Text = "데이터개수";
      this.lblDataCnt.ToolTip = "16진수";
      // 
      // groupControl8
      // 
      this.groupControl8.Controls.Add(this.lblBlkCnt);
      this.groupControl8.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl8.Location = new System.Drawing.Point(377, 59);
      this.groupControl8.Name = "groupControl8";
      this.groupControl8.Size = new System.Drawing.Size(107, 64);
      this.groupControl8.TabIndex = 4;
      this.groupControl8.Text = "블록수";
      // 
      // lblBlkCnt
      // 
      this.lblBlkCnt.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblBlkCnt.Appearance.Options.UseFont = true;
      this.lblBlkCnt.Location = new System.Drawing.Point(6, 27);
      this.lblBlkCnt.Margin = new System.Windows.Forms.Padding(4);
      this.lblBlkCnt.Name = "lblBlkCnt";
      this.lblBlkCnt.Size = new System.Drawing.Size(45, 20);
      this.lblBlkCnt.TabIndex = 0;
      this.lblBlkCnt.Text = "블록수";
      // 
      // groupControl7
      // 
      this.groupControl7.Controls.Add(this.lblCmdType);
      this.groupControl7.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl7.Location = new System.Drawing.Point(240, 59);
      this.groupControl7.Name = "groupControl7";
      this.groupControl7.Size = new System.Drawing.Size(107, 64);
      this.groupControl7.TabIndex = 3;
      this.groupControl7.Text = "명령어타입";
      // 
      // lblCmdType
      // 
      this.lblCmdType.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblCmdType.Appearance.Options.UseFont = true;
      this.lblCmdType.Location = new System.Drawing.Point(6, 27);
      this.lblCmdType.Margin = new System.Windows.Forms.Padding(4);
      this.lblCmdType.Name = "lblCmdType";
      this.lblCmdType.Size = new System.Drawing.Size(75, 20);
      this.lblCmdType.TabIndex = 0;
      this.lblCmdType.Text = "명령어타입";
      // 
      // groupControl6
      // 
      this.groupControl6.Controls.Add(this.lblCmd);
      this.groupControl6.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl6.Location = new System.Drawing.Point(126, 59);
      this.groupControl6.Name = "groupControl6";
      this.groupControl6.Size = new System.Drawing.Size(84, 64);
      this.groupControl6.TabIndex = 2;
      this.groupControl6.Text = "명령어";
      // 
      // lblCmd
      // 
      this.lblCmd.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblCmd.Appearance.Options.UseFont = true;
      this.lblCmd.Location = new System.Drawing.Point(6, 27);
      this.lblCmd.Margin = new System.Windows.Forms.Padding(4);
      this.lblCmd.Name = "lblCmd";
      this.lblCmd.Size = new System.Drawing.Size(45, 20);
      this.lblCmd.TabIndex = 0;
      this.lblCmd.Text = "명령어";
      // 
      // textEditReceived
      // 
      this.textEditReceived.Location = new System.Drawing.Point(18, 26);
      this.textEditReceived.Margin = new System.Windows.Forms.Padding(4);
      this.textEditReceived.Name = "textEditReceived";
      this.textEditReceived.Size = new System.Drawing.Size(604, 26);
      this.textEditReceived.TabIndex = 0;
      // 
      // groupControl5
      // 
      this.groupControl5.Controls.Add(this.lblAddr);
      this.groupControl5.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl5.Location = new System.Drawing.Point(18, 59);
      this.groupControl5.Name = "groupControl5";
      this.groupControl5.Size = new System.Drawing.Size(78, 64);
      this.groupControl5.TabIndex = 1;
      this.groupControl5.Text = "국번";
      // 
      // lblAddr
      // 
      this.lblAddr.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblAddr.Appearance.Options.UseFont = true;
      this.lblAddr.Location = new System.Drawing.Point(6, 27);
      this.lblAddr.Margin = new System.Windows.Forms.Padding(4);
      this.lblAddr.Name = "lblAddr";
      this.lblAddr.Size = new System.Drawing.Size(30, 20);
      this.lblAddr.TabIndex = 0;
      this.lblAddr.Text = "국번";
      // 
      // statusStrip
      // 
      this.statusStrip.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 572);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
      this.statusStrip.Size = new System.Drawing.Size(1311, 22);
      this.statusStrip.TabIndex = 8;
      this.statusStrip.Text = "statusStrip1";
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.groupControl11);
      this.groupBox2.Controls.Add(this.checkButtonEditCmd);
      this.groupBox2.Controls.Add(this.groupControl1);
      this.groupBox2.Controls.Add(this.buttonSend);
      this.groupBox2.Controls.Add(this.buttonAssyData);
      this.groupBox2.Controls.Add(this.groupBox9);
      this.groupBox2.Controls.Add(this.groupBox4);
      this.groupBox2.Controls.Add(this.groupBox3);
      this.groupBox2.Controls.Add(this.groupBox1);
      this.groupBox2.Location = new System.Drawing.Point(15, 8);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox2.Size = new System.Drawing.Size(638, 548);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "전송 명령어 생성";
      // 
      // groupControl11
      // 
      this.groupControl11.Controls.Add(this.textEditSendCmd);
      this.groupControl11.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl11.Location = new System.Drawing.Point(18, 313);
      this.groupControl11.Name = "groupControl11";
      this.groupControl11.Size = new System.Drawing.Size(598, 66);
      this.groupControl11.TabIndex = 4;
      this.groupControl11.Text = "전송 명렁";
      // 
      // textEditSendCmd
      // 
      this.textEditSendCmd.Enabled = false;
      this.textEditSendCmd.Location = new System.Drawing.Point(13, 27);
      this.textEditSendCmd.Margin = new System.Windows.Forms.Padding(4);
      this.textEditSendCmd.MenuManager = this.tabFormDefaultManager1;
      this.textEditSendCmd.Name = "textEditSendCmd";
      this.textEditSendCmd.Size = new System.Drawing.Size(564, 26);
      this.textEditSendCmd.TabIndex = 0;
      // 
      // checkButtonEditCmd
      // 
      this.checkButtonEditCmd.Location = new System.Drawing.Point(470, 425);
      this.checkButtonEditCmd.Name = "checkButtonEditCmd";
      this.checkButtonEditCmd.Size = new System.Drawing.Size(146, 33);
      this.checkButtonEditCmd.TabIndex = 7;
      this.checkButtonEditCmd.Text = "명령수정";
      this.checkButtonEditCmd.CheckedChanged += new System.EventHandler(this.checkButtonEditCmd_CheckedChanged);
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.textEditDataCounter);
      this.groupControl1.Controls.Add(this.label14);
      this.groupControl1.Controls.Add(this.label6);
      this.groupControl1.Controls.Add(this.textEditAddr);
      this.groupControl1.Controls.Add(this.textEditData);
      this.groupControl1.Controls.Add(this.label15);
      this.groupControl1.Controls.Add(this.label12);
      this.groupControl1.Controls.Add(this.label13);
      this.groupControl1.Controls.Add(this.textEditDevice);
      this.groupControl1.Controls.Add(this.label10);
      this.groupControl1.Controls.Add(this.textEditVarLen);
      this.groupControl1.Controls.Add(this.textEditUid);
      this.groupControl1.Controls.Add(this.label11);
      this.groupControl1.Controls.Add(this.textEditCommand);
      this.groupControl1.Controls.Add(this.label16);
      this.groupControl1.Controls.Add(this.textEditBlocks);
      this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
      this.groupControl1.Location = new System.Drawing.Point(18, 131);
      this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(598, 175);
      this.groupControl1.TabIndex = 3;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(16, 28);
      this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(60, 20);
      this.label10.TabIndex = 0;
      this.label10.Text = "국번(H)";
      // 
      // textEditUid
      // 
      this.textEditUid.EditValue = "00";
      this.textEditUid.Location = new System.Drawing.Point(95, 25);
      this.textEditUid.Margin = new System.Windows.Forms.Padding(4);
      this.textEditUid.MenuManager = this.tabFormDefaultManager1;
      this.textEditUid.Name = "textEditUid";
      this.textEditUid.Size = new System.Drawing.Size(48, 26);
      this.textEditUid.TabIndex = 1;
      this.textEditUid.ToolTip = "16진수로 입력하세요.";
      this.textEditUid.TextChanged += new System.EventHandler(this.textEdit_TextChanged);
      this.textEditUid.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(16, 62);
      this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(54, 20);
      this.label11.TabIndex = 6;
      this.label11.Text = "명령어";
      // 
      // textEditCommand
      // 
      this.textEditCommand.EditValue = "r";
      this.textEditCommand.Location = new System.Drawing.Point(95, 59);
      this.textEditCommand.Margin = new System.Windows.Forms.Padding(4);
      this.textEditCommand.Name = "textEditCommand";
      this.textEditCommand.Size = new System.Drawing.Size(48, 26);
      this.textEditCommand.TabIndex = 7;
      this.textEditCommand.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(216, 28);
      this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(75, 20);
      this.label16.TabIndex = 2;
      this.label16.Text = "블록수(H)";
      // 
      // textEditBlocks
      // 
      this.textEditBlocks.EditValue = "01";
      this.textEditBlocks.Location = new System.Drawing.Point(314, 25);
      this.textEditBlocks.Margin = new System.Windows.Forms.Padding(4);
      this.textEditBlocks.Name = "textEditBlocks";
      this.textEditBlocks.Size = new System.Drawing.Size(48, 26);
      this.textEditBlocks.TabIndex = 3;
      this.textEditBlocks.ToolTip = "16진수로 입력하세요.";
      this.textEditBlocks.TextChanged += new System.EventHandler(this.textEdit_TextChanged);
      this.textEditBlocks.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // buttonSend
      // 
      this.buttonSend.Location = new System.Drawing.Point(470, 484);
      this.buttonSend.Name = "buttonSend";
      this.buttonSend.Size = new System.Drawing.Size(146, 33);
      this.buttonSend.TabIndex = 8;
      this.buttonSend.Text = "명령전송";
      this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
      // 
      // buttonAssyData
      // 
      this.buttonAssyData.Location = new System.Drawing.Point(470, 386);
      this.buttonAssyData.Name = "buttonAssyData";
      this.buttonAssyData.Size = new System.Drawing.Size(146, 33);
      this.buttonAssyData.TabIndex = 6;
      this.buttonAssyData.Text = "명령만들기";
      this.buttonAssyData.Click += new System.EventHandler(this.buttonAssyData_Click);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(17, 144);
      this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(75, 20);
      this.label14.TabIndex = 14;
      this.label14.Text = "데이터(H)";
      // 
      // textEditDataCounter
      // 
      this.textEditDataCounter.EditValue = "01";
      this.textEditDataCounter.Location = new System.Drawing.Point(139, 104);
      this.textEditDataCounter.Margin = new System.Windows.Forms.Padding(4);
      this.textEditDataCounter.Name = "textEditDataCounter";
      this.textEditDataCounter.Size = new System.Drawing.Size(48, 26);
      this.textEditDataCounter.TabIndex = 13;
      this.textEditDataCounter.ToolTip = "16진수로 입력하세요.";
      this.textEditDataCounter.EditValueChanged += new System.EventHandler(this.textEditCommandString_EditValueChanged);
      this.textEditDataCounter.TextChanged += new System.EventHandler(this.textEdit_TextChanged);
      this.textEditDataCounter.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // textEditData
      // 
      this.textEditData.EditValue = "0001";
      this.textEditData.Location = new System.Drawing.Point(139, 140);
      this.textEditData.Margin = new System.Windows.Forms.Padding(4);
      this.textEditData.Name = "textEditData";
      this.textEditData.Size = new System.Drawing.Size(438, 26);
      this.textEditData.TabIndex = 15;
      this.textEditData.ToolTip = "16진수로 입력하세요.";
      this.textEditData.TextChanged += new System.EventHandler(this.textEdit_TextChanged);
      this.textEditData.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(17, 108);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(105, 20);
      this.label6.TabIndex = 12;
      this.label6.Text = "데이터개수(H)";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(216, 62);
      this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(90, 20);
      this.label12.TabIndex = 8;
      this.label12.Text = "변수길이(H)";
      // 
      // textEditAddr
      // 
      this.textEditAddr.EditValue = "0";
      this.textEditAddr.Location = new System.Drawing.Point(501, 59);
      this.textEditAddr.Margin = new System.Windows.Forms.Padding(4);
      this.textEditAddr.Name = "textEditAddr";
      this.textEditAddr.Size = new System.Drawing.Size(48, 26);
      this.textEditAddr.TabIndex = 11;
      this.textEditAddr.EditValueChanged += new System.EventHandler(this.textEditCommandString_EditValueChanged);
      this.textEditAddr.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // textEditVarLen
      // 
      this.textEditVarLen.EditValue = "04";
      this.textEditVarLen.Location = new System.Drawing.Point(314, 59);
      this.textEditVarLen.Margin = new System.Windows.Forms.Padding(4);
      this.textEditVarLen.Name = "textEditVarLen";
      this.textEditVarLen.Size = new System.Drawing.Size(48, 26);
      this.textEditVarLen.TabIndex = 9;
      this.textEditVarLen.ToolTip = "16진수로 입력하세요.";
      this.textEditVarLen.TextChanged += new System.EventHandler(this.textEdit_TextChanged);
      this.textEditVarLen.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(431, 28);
      this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(39, 20);
      this.label13.TabIndex = 4;
      this.label13.Text = "장치";
      // 
      // textEditDevice
      // 
      this.textEditDevice.EditValue = "M";
      this.textEditDevice.Location = new System.Drawing.Point(501, 25);
      this.textEditDevice.Margin = new System.Windows.Forms.Padding(4);
      this.textEditDevice.Name = "textEditDevice";
      this.textEditDevice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.textEditDevice.Size = new System.Drawing.Size(48, 26);
      this.textEditDevice.TabIndex = 5;
      this.textEditDevice.Leave += new System.EventHandler(this.textEdit_Leave);
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(431, 62);
      this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(39, 20);
      this.label15.TabIndex = 10;
      this.label15.Text = "주소";
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.radioButtonSS);
      this.groupBox9.Controls.Add(this.radioButtonSB);
      this.groupBox9.Location = new System.Drawing.Point(145, 29);
      this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox9.Size = new System.Drawing.Size(195, 94);
      this.groupBox9.TabIndex = 1;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "명령어 타입";
      // 
      // radioButtonSS
      // 
      this.radioButtonSS.AutoSize = true;
      this.radioButtonSS.Checked = true;
      this.radioButtonSS.Location = new System.Drawing.Point(21, 28);
      this.radioButtonSS.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonSS.Name = "radioButtonSS";
      this.radioButtonSS.Size = new System.Drawing.Size(88, 24);
      this.radioButtonSS.TabIndex = 0;
      this.radioButtonSS.TabStop = true;
      this.radioButtonSS.Text = "SS (개별)";
      this.radioButtonSS.UseVisualStyleBackColor = true;
      this.radioButtonSS.CheckedChanged += new System.EventHandler(this.radioButtonCommandType_CheckedChanged);
      // 
      // radioButtonSB
      // 
      this.radioButtonSB.AutoSize = true;
      this.radioButtonSB.Location = new System.Drawing.Point(21, 56);
      this.radioButtonSB.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonSB.Name = "radioButtonSB";
      this.radioButtonSB.Size = new System.Drawing.Size(89, 24);
      this.radioButtonSB.TabIndex = 1;
      this.radioButtonSB.Text = "SB (연속)";
      this.radioButtonSB.UseVisualStyleBackColor = true;
      this.radioButtonSB.CheckedChanged += new System.EventHandler(this.radioButtonCommandType_CheckedChanged);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.radioButtonDword);
      this.groupBox4.Controls.Add(this.radioButtonLword);
      this.groupBox4.Controls.Add(this.radioButtonByte);
      this.groupBox4.Controls.Add(this.radioButtonWord);
      this.groupBox4.Location = new System.Drawing.Point(369, 29);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox4.Size = new System.Drawing.Size(247, 94);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "데이터 타입";
      // 
      // radioButtonDword
      // 
      this.radioButtonDword.AutoSize = true;
      this.radioButtonDword.Location = new System.Drawing.Point(21, 56);
      this.radioButtonDword.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonDword.Name = "radioButtonDword";
      this.radioButtonDword.Size = new System.Drawing.Size(72, 24);
      this.radioButtonDword.TabIndex = 2;
      this.radioButtonDword.Text = "Dword";
      this.radioButtonDword.UseVisualStyleBackColor = true;
      this.radioButtonDword.CheckedChanged += new System.EventHandler(this.radioButtonDataType_CheckedChanged);
      // 
      // radioButtonLword
      // 
      this.radioButtonLword.AutoSize = true;
      this.radioButtonLword.Location = new System.Drawing.Point(144, 56);
      this.radioButtonLword.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonLword.Name = "radioButtonLword";
      this.radioButtonLword.Size = new System.Drawing.Size(68, 24);
      this.radioButtonLword.TabIndex = 3;
      this.radioButtonLword.Text = "Lword";
      this.radioButtonLword.UseVisualStyleBackColor = true;
      this.radioButtonLword.CheckedChanged += new System.EventHandler(this.radioButtonDataType_CheckedChanged);
      // 
      // radioButtonByte
      // 
      this.radioButtonByte.AutoSize = true;
      this.radioButtonByte.Checked = true;
      this.radioButtonByte.Location = new System.Drawing.Point(21, 28);
      this.radioButtonByte.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonByte.Name = "radioButtonByte";
      this.radioButtonByte.Size = new System.Drawing.Size(56, 24);
      this.radioButtonByte.TabIndex = 0;
      this.radioButtonByte.TabStop = true;
      this.radioButtonByte.Text = "Byte";
      this.radioButtonByte.UseVisualStyleBackColor = true;
      this.radioButtonByte.CheckedChanged += new System.EventHandler(this.radioButtonDataType_CheckedChanged);
      // 
      // radioButtonWord
      // 
      this.radioButtonWord.AutoSize = true;
      this.radioButtonWord.Location = new System.Drawing.Point(144, 28);
      this.radioButtonWord.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonWord.Name = "radioButtonWord";
      this.radioButtonWord.Size = new System.Drawing.Size(64, 24);
      this.radioButtonWord.TabIndex = 1;
      this.radioButtonWord.Text = "Word";
      this.radioButtonWord.UseVisualStyleBackColor = true;
      this.radioButtonWord.CheckedChanged += new System.EventHandler(this.radioButtonDataType_CheckedChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.checkButtonSerialPort);
      this.groupBox3.Controls.Add(this.label9);
      this.groupBox3.Controls.Add(this.label8);
      this.groupBox3.Controls.Add(this.buttonError);
      this.groupBox3.Controls.Add(this.buttonConnect);
      this.groupBox3.Location = new System.Drawing.Point(18, 386);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox3.Size = new System.Drawing.Size(174, 149);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "통신포트제어";
      // 
      // checkButtonSerialPort
      // 
      this.checkButtonSerialPort.Location = new System.Drawing.Point(13, 98);
      this.checkButtonSerialPort.Name = "checkButtonSerialPort";
      this.checkButtonSerialPort.Size = new System.Drawing.Size(146, 33);
      this.checkButtonSerialPort.TabIndex = 4;
      this.checkButtonSerialPort.Text = "통신포트닫힘";
      this.checkButtonSerialPort.CheckedChanged += new System.EventHandler(this.checkButtonSerialPort_CheckedChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(97, 66);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(39, 20);
      this.label9.TabIndex = 3;
      this.label9.Text = "오류";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(39, 66);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(39, 20);
      this.label8.TabIndex = 2;
      this.label8.Text = "접속";
      // 
      // buttonError
      // 
      this.buttonError.BackColor = System.Drawing.Color.DimGray;
      this.buttonError.Enabled = false;
      this.buttonError.Location = new System.Drawing.Point(101, 28);
      this.buttonError.Margin = new System.Windows.Forms.Padding(4);
      this.buttonError.Name = "buttonError";
      this.buttonError.Size = new System.Drawing.Size(30, 33);
      this.buttonError.TabIndex = 1;
      this.buttonError.UseVisualStyleBackColor = false;
      // 
      // buttonConnect
      // 
      this.buttonConnect.BackColor = System.Drawing.Color.DimGray;
      this.buttonConnect.Enabled = false;
      this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.buttonConnect.Location = new System.Drawing.Point(45, 28);
      this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(30, 33);
      this.buttonConnect.TabIndex = 0;
      this.buttonConnect.UseVisualStyleBackColor = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButtonWrite);
      this.groupBox1.Controls.Add(this.radioButtonRead);
      this.groupBox1.Location = new System.Drawing.Point(18, 29);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(107, 94);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "읽기/쓰기";
      // 
      // radioButtonWrite
      // 
      this.radioButtonWrite.AutoSize = true;
      this.radioButtonWrite.Location = new System.Drawing.Point(21, 56);
      this.radioButtonWrite.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonWrite.Name = "radioButtonWrite";
      this.radioButtonWrite.Size = new System.Drawing.Size(57, 24);
      this.radioButtonWrite.TabIndex = 1;
      this.radioButtonWrite.Text = "쓰기";
      this.radioButtonWrite.UseVisualStyleBackColor = true;
      // 
      // radioButtonRead
      // 
      this.radioButtonRead.AutoSize = true;
      this.radioButtonRead.Checked = true;
      this.radioButtonRead.Location = new System.Drawing.Point(21, 28);
      this.radioButtonRead.Margin = new System.Windows.Forms.Padding(4);
      this.radioButtonRead.Name = "radioButtonRead";
      this.radioButtonRead.Size = new System.Drawing.Size(57, 24);
      this.radioButtonRead.TabIndex = 0;
      this.radioButtonRead.TabStop = true;
      this.radioButtonRead.Text = "읽기";
      this.radioButtonRead.UseVisualStyleBackColor = true;
      this.radioButtonRead.CheckedChanged += new System.EventHandler(this.radioButtonReadWrite_CheckedChanged);
      // 
      // tabFormPageSettings
      // 
      this.tabFormPageSettings.ContentContainer = this.tabFormContentContainer2;
      this.tabFormPageSettings.Name = "tabFormPageSettings";
      this.tabFormPageSettings.Text = "Settings";
      // 
      // tabFormContentContainer2
      // 
      this.tabFormContentContainer2.Controls.Add(this.comboBoxStopbits);
      this.tabFormContentContainer2.Controls.Add(this.comboBoxParity);
      this.tabFormContentContainer2.Controls.Add(this.comboBoxDatabits);
      this.tabFormContentContainer2.Controls.Add(this.comboBoxBaudrate);
      this.tabFormContentContainer2.Controls.Add(this.comboBoxPort);
      this.tabFormContentContainer2.Controls.Add(this.label5);
      this.tabFormContentContainer2.Controls.Add(this.label4);
      this.tabFormContentContainer2.Controls.Add(this.label3);
      this.tabFormContentContainer2.Controls.Add(this.label2);
      this.tabFormContentContainer2.Controls.Add(this.label1);
      this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 78);
      this.tabFormContentContainer2.Name = "tabFormContentContainer2";
      this.tabFormContentContainer2.Size = new System.Drawing.Size(1533, 1093);
      this.tabFormContentContainer2.TabIndex = 4;
      // 
      // comboBoxStopbits
      // 
      this.comboBoxStopbits.FormattingEnabled = true;
      this.comboBoxStopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
      this.comboBoxStopbits.Location = new System.Drawing.Point(156, 153);
      this.comboBoxStopbits.Name = "comboBoxStopbits";
      this.comboBoxStopbits.Size = new System.Drawing.Size(121, 20);
      this.comboBoxStopbits.TabIndex = 1;
      // 
      // comboBoxParity
      // 
      this.comboBoxParity.FormattingEnabled = true;
      this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
      this.comboBoxParity.Location = new System.Drawing.Point(156, 122);
      this.comboBoxParity.Name = "comboBoxParity";
      this.comboBoxParity.Size = new System.Drawing.Size(121, 20);
      this.comboBoxParity.TabIndex = 1;
      // 
      // comboBoxDatabits
      // 
      this.comboBoxDatabits.FormattingEnabled = true;
      this.comboBoxDatabits.Items.AddRange(new object[] {
            "7",
            "8"});
      this.comboBoxDatabits.Location = new System.Drawing.Point(156, 91);
      this.comboBoxDatabits.Name = "comboBoxDatabits";
      this.comboBoxDatabits.Size = new System.Drawing.Size(121, 20);
      this.comboBoxDatabits.TabIndex = 1;
      // 
      // comboBoxBaudrate
      // 
      this.comboBoxBaudrate.FormattingEnabled = true;
      this.comboBoxBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
      this.comboBoxBaudrate.Location = new System.Drawing.Point(156, 60);
      this.comboBoxBaudrate.Name = "comboBoxBaudrate";
      this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 20);
      this.comboBoxBaudrate.TabIndex = 1;
      // 
      // comboBoxPort
      // 
      this.comboBoxPort.FormattingEnabled = true;
      this.comboBoxPort.Location = new System.Drawing.Point(156, 29);
      this.comboBoxPort.Name = "comboBoxPort";
      this.comboBoxPort.Size = new System.Drawing.Size(121, 20);
      this.comboBoxPort.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label5.Location = new System.Drawing.Point(61, 158);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(71, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "정지 비트 :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(61, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "패리티 비트 :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.Location = new System.Drawing.Point(61, 96);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(84, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "데이터 비트 :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(61, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "통신 속도 :";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(61, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "시리얼 포트 :";
      // 
      // tabFormTest
      // 
      this.tabFormTest.ContentContainer = this.tabFormContentContainer3;
      this.tabFormTest.Name = "tabFormTest";
      this.tabFormTest.Text = "Test";
      // 
      // tabFormContentContainer3
      // 
      this.tabFormContentContainer3.Controls.Add(this.groupBox8);
      this.tabFormContentContainer3.Controls.Add(this.groupBox7);
      this.tabFormContentContainer3.Controls.Add(this.groupBox6);
      this.tabFormContentContainer3.Controls.Add(this.groupBox5);
      this.tabFormContentContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabFormContentContainer3.Location = new System.Drawing.Point(0, 72);
      this.tabFormContentContainer3.Name = "tabFormContentContainer3";
      this.tabFormContentContainer3.Size = new System.Drawing.Size(621, 698);
      this.tabFormContentContainer3.TabIndex = 4;
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.rbctrl20Lstd);
      this.groupBox8.Controls.Add(this.rbctrl2Lstd);
      this.groupBox8.Location = new System.Drawing.Point(31, 185);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(289, 54);
      this.groupBox8.TabIndex = 3;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "기준기 선택";
      // 
      // rbctrl20Lstd
      // 
      this.rbctrl20Lstd.AutoSize = true;
      this.rbctrl20Lstd.Checked = true;
      this.rbctrl20Lstd.Location = new System.Drawing.Point(162, 21);
      this.rbctrl20Lstd.Name = "rbctrl20Lstd";
      this.rbctrl20Lstd.Size = new System.Drawing.Size(116, 16);
      this.rbctrl20Lstd.TabIndex = 0;
      this.rbctrl20Lstd.TabStop = true;
      this.rbctrl20Lstd.Text = "대형(20L) 기준기";
      this.rbctrl20Lstd.UseVisualStyleBackColor = true;
      this.rbctrl20Lstd.CheckedChanged += new System.EventHandler(this.rbctrlSelectStd_CheckedChanged);
      // 
      // rbctrl2Lstd
      // 
      this.rbctrl2Lstd.AutoSize = true;
      this.rbctrl2Lstd.Location = new System.Drawing.Point(21, 21);
      this.rbctrl2Lstd.Name = "rbctrl2Lstd";
      this.rbctrl2Lstd.Size = new System.Drawing.Size(110, 16);
      this.rbctrl2Lstd.TabIndex = 0;
      this.rbctrl2Lstd.Text = "소형(2L) 기준기";
      this.rbctrl2Lstd.UseVisualStyleBackColor = true;
      this.rbctrl2Lstd.CheckedChanged += new System.EventHandler(this.rbctrlSelectStd_CheckedChanged);
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.rbctrlModeElecMeter);
      this.groupBox7.Controls.Add(this.rbctrlModeEncoder);
      this.groupBox7.Controls.Add(this.rbctrlModePhotoSensor);
      this.groupBox7.Location = new System.Drawing.Point(31, 107);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(289, 71);
      this.groupBox7.TabIndex = 2;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "시험모드";
      // 
      // rbctrlModeElecMeter
      // 
      this.rbctrlModeElecMeter.AutoSize = true;
      this.rbctrlModeElecMeter.Location = new System.Drawing.Point(196, 21);
      this.rbctrlModeElecMeter.Name = "rbctrlModeElecMeter";
      this.rbctrlModeElecMeter.Size = new System.Drawing.Size(83, 16);
      this.rbctrlModeElecMeter.TabIndex = 0;
      this.rbctrlModeElecMeter.Text = "전자식미터";
      this.rbctrlModeElecMeter.UseVisualStyleBackColor = true;
      this.rbctrlModeElecMeter.CheckedChanged += new System.EventHandler(this.rbctrlTestMode_CheckedChanged);
      // 
      // rbctrlModeEncoder
      // 
      this.rbctrlModeEncoder.AutoSize = true;
      this.rbctrlModeEncoder.Checked = true;
      this.rbctrlModeEncoder.Location = new System.Drawing.Point(109, 21);
      this.rbctrlModeEncoder.Name = "rbctrlModeEncoder";
      this.rbctrlModeEncoder.Size = new System.Drawing.Size(71, 16);
      this.rbctrlModeEncoder.TabIndex = 0;
      this.rbctrlModeEncoder.TabStop = true;
      this.rbctrlModeEncoder.Text = "기어선정";
      this.rbctrlModeEncoder.UseVisualStyleBackColor = true;
      this.rbctrlModeEncoder.CheckedChanged += new System.EventHandler(this.rbctrlTestMode_CheckedChanged);
      // 
      // rbctrlModePhotoSensor
      // 
      this.rbctrlModePhotoSensor.AutoSize = true;
      this.rbctrlModePhotoSensor.Location = new System.Drawing.Point(24, 21);
      this.rbctrlModePhotoSensor.Name = "rbctrlModePhotoSensor";
      this.rbctrlModePhotoSensor.Size = new System.Drawing.Size(59, 16);
      this.rbctrlModePhotoSensor.TabIndex = 0;
      this.rbctrlModePhotoSensor.TabStop = true;
      this.rbctrlModePhotoSensor.Text = "광센서";
      this.rbctrlModePhotoSensor.UseVisualStyleBackColor = true;
      this.rbctrlModePhotoSensor.CheckedChanged += new System.EventHandler(this.rbctrlTestMode_CheckedChanged);
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.radioButtonCont);
      this.groupBox6.Controls.Add(this.radioButtonSeq);
      this.groupBox6.Location = new System.Drawing.Point(180, 25);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(140, 76);
      this.groupBox6.TabIndex = 1;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "연속시험여부";
      // 
      // radioButtonCont
      // 
      this.radioButtonCont.AutoSize = true;
      this.radioButtonCont.Location = new System.Drawing.Point(28, 45);
      this.radioButtonCont.Name = "radioButtonCont";
      this.radioButtonCont.Size = new System.Drawing.Size(71, 16);
      this.radioButtonCont.TabIndex = 0;
      this.radioButtonCont.Text = "연속시험";
      this.radioButtonCont.UseVisualStyleBackColor = true;
      // 
      // radioButtonSeq
      // 
      this.radioButtonSeq.AutoSize = true;
      this.radioButtonSeq.Checked = true;
      this.radioButtonSeq.Location = new System.Drawing.Point(28, 21);
      this.radioButtonSeq.Name = "radioButtonSeq";
      this.radioButtonSeq.Size = new System.Drawing.Size(71, 16);
      this.radioButtonSeq.TabIndex = 0;
      this.radioButtonSeq.TabStop = true;
      this.radioButtonSeq.Text = "일반시험";
      this.radioButtonSeq.UseVisualStyleBackColor = true;
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.rbctrlTestEnd);
      this.groupBox5.Controls.Add(this.rbctrlTestStart);
      this.groupBox5.Location = new System.Drawing.Point(31, 25);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(132, 76);
      this.groupBox5.TabIndex = 0;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "검사시작/종료";
      // 
      // rbctrlTestEnd
      // 
      this.rbctrlTestEnd.AutoSize = true;
      this.rbctrlTestEnd.Checked = true;
      this.rbctrlTestEnd.Location = new System.Drawing.Point(24, 45);
      this.rbctrlTestEnd.Name = "rbctrlTestEnd";
      this.rbctrlTestEnd.Size = new System.Drawing.Size(71, 16);
      this.rbctrlTestEnd.TabIndex = 1;
      this.rbctrlTestEnd.TabStop = true;
      this.rbctrlTestEnd.Text = "검사종료";
      this.rbctrlTestEnd.UseVisualStyleBackColor = true;
      this.rbctrlTestEnd.CheckedChanged += new System.EventHandler(this.rbctrlTestStartEnd_CheckedChanged);
      // 
      // rbctrlTestStart
      // 
      this.rbctrlTestStart.AutoSize = true;
      this.rbctrlTestStart.Location = new System.Drawing.Point(24, 21);
      this.rbctrlTestStart.Name = "rbctrlTestStart";
      this.rbctrlTestStart.Size = new System.Drawing.Size(71, 16);
      this.rbctrlTestStart.TabIndex = 0;
      this.rbctrlTestStart.Text = "검사시작";
      this.rbctrlTestStart.UseVisualStyleBackColor = true;
      this.rbctrlTestStart.CheckedChanged += new System.EventHandler(this.rbctrlTestStartEnd_CheckedChanged);
      // 
      // serialPortXGT
      // 
      this.serialPortXGT.BaudRate = 115200;
      this.serialPortXGT.PortName = "COM5";
      this.serialPortXGT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortXGT_DataReceived);
      // 
      // timerUiUpdate
      // 
      this.timerUiUpdate.Interval = 1000;
      this.timerUiUpdate.Tick += new System.EventHandler(this.timerUiUpdate_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1311, 672);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Controls.Add(this.tabFormContentContainer1);
      this.Controls.Add(this.tabFormControl1);
      this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.Name = "FormMain";
      this.TabFormControl = this.tabFormControl1;
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
      this.tabFormContentContainer1.ResumeLayout(false);
      this.tabFormContentContainer1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
      this.groupControl4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.groupControl10)).EndInit();
      this.groupControl10.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
      this.groupControl9.ResumeLayout(false);
      this.groupControl9.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
      this.groupControl8.ResumeLayout(false);
      this.groupControl8.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
      this.groupControl7.ResumeLayout(false);
      this.groupControl7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
      this.groupControl6.ResumeLayout(false);
      this.groupControl6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textEditReceived.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
      this.groupControl5.ResumeLayout(false);
      this.groupControl5.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).EndInit();
      this.groupControl11.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.textEditSendCmd.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textEditUid.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditCommand.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditBlocks.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditDataCounter.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditData.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditAddr.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditVarLen.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEditDevice.Properties)).EndInit();
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabFormContentContainer2.ResumeLayout(false);
      this.tabFormContentContainer2.PerformLayout();
      this.tabFormContentContainer3.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.TabFormControl tabFormControl1;
    private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.TabFormPage tabFormPageDashBoard;
    private System.IO.Ports.SerialPort serialPortXGT;
    private DevExpress.XtraBars.TabFormPage tabFormPageSettings;
    private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
    private System.Windows.Forms.ComboBox comboBoxStopbits;
    private System.Windows.Forms.ComboBox comboBoxParity;
    private System.Windows.Forms.ComboBox comboBoxDatabits;
    private System.Windows.Forms.ComboBox comboBoxBaudrate;
    private System.Windows.Forms.ComboBox comboBoxPort;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer3;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.RadioButton rbctrlTestStart;
    private DevExpress.XtraBars.TabFormPage tabFormTest;
    private System.Windows.Forms.RadioButton rbctrlTestEnd;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.RadioButton radioButtonSeq;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.RadioButton rbctrlModeEncoder;
    private System.Windows.Forms.RadioButton rbctrlModePhotoSensor;
    private System.Windows.Forms.RadioButton radioButtonCont;
    private System.Windows.Forms.RadioButton rbctrlModeElecMeter;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.RadioButton rbctrl20Lstd;
    private System.Windows.Forms.RadioButton rbctrl2Lstd;
    private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
    private System.Windows.Forms.Timer timerUiUpdate;
    private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
    private System.Windows.Forms.DataGridView dgvData;
    private DevExpress.XtraEditors.LabelControl lblDataCnt;
    private DevExpress.XtraEditors.LabelControl lblBlkCnt;
    private DevExpress.XtraEditors.LabelControl lblCmdType;
    private DevExpress.XtraEditors.LabelControl lblCmd;
    private DevExpress.XtraEditors.LabelControl lblAddr;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button buttonError;
    private System.Windows.Forms.Button buttonConnect;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.RadioButton radioButtonDword;
    private System.Windows.Forms.RadioButton radioButtonLword;
    private System.Windows.Forms.RadioButton radioButtonByte;
    private System.Windows.Forms.RadioButton radioButtonWord;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label11;
    private DevExpress.XtraEditors.TextEdit textEditDevice;
    private System.Windows.Forms.Label label10;
    private DevExpress.XtraEditors.TextEdit textEditVarLen;
    private DevExpress.XtraEditors.TextEdit textEditData;
    private DevExpress.XtraEditors.TextEdit textEditDataCounter;
    private DevExpress.XtraEditors.TextEdit textEditAddr;
    private DevExpress.XtraEditors.TextEdit textEditCommand;
    private DevExpress.XtraEditors.TextEdit textEditUid;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButtonWrite;
    private System.Windows.Forms.RadioButton radioButtonRead;
    private DevExpress.XtraEditors.TextEdit textEditSendCmd;
    private DevExpress.XtraEditors.TextEdit textEditReceived;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.RadioButton radioButtonSS;
    private System.Windows.Forms.RadioButton radioButtonSB;
    private System.Windows.Forms.Label label16;
    private DevExpress.XtraEditors.TextEdit textEditBlocks;
    private DevExpress.XtraEditors.GroupControl groupControl1;
    private DevExpress.XtraEditors.GroupControl groupControl4;
    private DevExpress.XtraEditors.GroupControl groupControl10;
    private DevExpress.XtraEditors.GroupControl groupControl9;
    private DevExpress.XtraEditors.GroupControl groupControl8;
    private DevExpress.XtraEditors.GroupControl groupControl7;
    private DevExpress.XtraEditors.GroupControl groupControl6;
    private DevExpress.XtraEditors.GroupControl groupControl5;
    private DevExpress.XtraEditors.CheckButton checkButtonEditCmd;
    private DevExpress.XtraEditors.SimpleButton buttonSend;
    private DevExpress.XtraEditors.SimpleButton buttonAssyData;
    private DevExpress.XtraEditors.CheckButton checkButtonSerialPort;
    private DevExpress.XtraEditors.GroupControl groupControl11;
  }
}

