using DevExpress.XtraBars;
using DevExpress.XtraEditors.TextEditController.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using static DXAppXGBCommTest.DataSet;
using System.Runtime.CompilerServices;
using DevExpress.Internal.WinApi;
using System.Diagnostics.Eventing.Reader;

namespace DXAppXGBCommTest {
  public partial class FormMain : DevExpress.XtraBars.TabForm {
    private XGB_SerialComm xGB_SerialComm;
    private Object thisLock = new Object(); //동시에 들어오는 데이터들이 충돌나지 않도록 Object로 lock 걸어주는 thisLock
    /*
     * ENQ : 0x05, Enquire, Request frame의 시작 코드
     * ACK : 0x06, Acknowledge, ACK response frame의 시작 코드
     * NAK : 0x15, Not Acknowledge, NAC response frame의 시작 코드
     * EOT : 0x04, End of Text, 요구용 프레임의 마감 ASCII 코드
     * ETX : 0x03, End Text, 응답용 프레임의 마감 ASCII 코드
     */
    private const char _ENQ = (char)0x05;
    private const char _ACK = (char)0x06;
    private const char _NAK = (char)0x15;
    private const char _EOT = (char)0x04;
    private const char _ETX = (char)0x03;
    private string inStream = ""; //내용이 막 끊어져서 들어오더라도 조합해서 제대로된 데이터로 저장할 변수
    private string outStream = "";
    private string dataType = "B"; //Default Byte
    private string commandType = "SS"; //Defaut 직접 변수
    private DataSet dataSet;
    private Dictionary<STATUSCMD, string> cmdStringPair;
    private STATUSCMD statusCmd = STATUSCMD.READ;
    private CLEARSTATUS clrStatus = CLEARSTATUS.SERIALPORT;
    private int clrDelaySecs = 3; //기본 3초
    private int clrCounter = 0; //clrDelaySecs 에 도달할 때까지 증가시킴.
    private string strDataCouter = "01";
    private string strData = "0001";
    private int dataCount = 1;

    enum STATUSCMD {
      READ = 0,
      WRITE
    }

    enum CLEARSTATUS {
      SERIALPORT = 0,
      PROTOCOL,
      ERROR,
      WARNING,
      MESSAGE
    }


    public FormMain() {
      InitializeComponent();
      DateTime buildDate = Convert.ToDateTime("2024-05-02");
      Version version = Assembly.GetEntryAssembly().GetName().Version;
      this.Text = String.Format("{0} Ver {1}.{2} / Built of ({3})", "XGB서버 PC시리얼 통신 검증 앱", version.Major, version.Minor, buildDate.ToString("yyyy-MM-dd"));
      xGB_SerialComm = new XGB_SerialComm();
      xGB_SerialComm.ReadyToSerialPort();
      setupUi();
      if (openSerial())
        buttonConnect.BackColor = System.Drawing.Color.Cyan;
      else
        buttonConnect.BackColor = System.Drawing.Color.DarkGray;
      dataSet = new DataSet();
      cmdStringPair = new Dictionary<STATUSCMD, string>();
      timerUiUpdate = new Timer();
      timerUiUpdate.Interval = 1000; //UI 자동 갱신 1초

      textEditData.Text = ""; //데이터 비우기
      textEditData.Enabled = false; //데이터 수정 불가
      textEditDataCounter.Text = "";
      textEditDataCounter.Enabled = false;
      textEditSendCmd.Enabled = false; //명령어 수정 불가

      InitSystemData();
    }
    void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e) {
      FormMain form = new FormMain();
      form.TabFormControl.Pages.Clear();
      e.Form = form;
      OpenFormCount++;
    }

    void InitSystemData() {
      dataSet.sys_TEST_MODE = DataSet.TEST_MODE.MODE_UNKNOWN;
      dataSet.sys_STD = DataSet.SYS_STD.STD_UNKNOWN;
      cmdStringPair.Add(STATUSCMD.READ, "r");
      cmdStringPair.Add(STATUSCMD.WRITE, "w");
    }
    bool openSerial() {
      serialPortXGT.PortName = xGB_SerialComm.SerialPort;
      serialPortXGT.BaudRate = Convert.ToInt32(xGB_SerialComm.SerialBaudrate);
      serialPortXGT.DataBits = Convert.ToInt16(xGB_SerialComm.SerialDatabits);

      if (xGB_SerialComm.SerialParity == "Even")
        serialPortXGT.Parity = System.IO.Ports.Parity.Even;
      else if (xGB_SerialComm.SerialParity == "Odd")
        serialPortXGT.Parity = System.IO.Ports.Parity.Odd;
      else
        serialPortXGT.Parity = System.IO.Ports.Parity.None;

      if (xGB_SerialComm.SerialStopbits == "1.5")
        serialPortXGT.StopBits = System.IO.Ports.StopBits.OnePointFive;
      else if (xGB_SerialComm.SerialStopbits == "2")
        serialPortXGT.StopBits = System.IO.Ports.StopBits.Two;
      else
        serialPortXGT.StopBits = System.IO.Ports.StopBits.One;

      if (!serialPortXGT.IsOpen) { //열려있지 않으면,
        try {
          serialPortXGT.Open(); //연다.
          checkButtonSerialPort.Text = "통신포트열림";
          checkButtonSerialPort.Checked = true;
          statusLabel.Text = "통신을 위한 시리얼포트를 열었습니다.";

          clrStatus = CLEARSTATUS.SERIALPORT;
          autoRefreshUI(5);

          return true;
        } catch (Exception ex) {
          MessageBox.Show(ex.Message);
        }
      }
      statusLabel.Text = "시리얼포트가 열리지 않았습니다.!";
      clrStatus = CLEARSTATUS.SERIALPORT;
      autoRefreshUI(5);

      return false;
    }
    void setupUi() {
      try {
        List<string> portNames = new List<string>();
        string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();
        if (comPorts.Length > 0) {
          foreach (string comPort in comPorts) {
            portNames.Add(comPort);
          }
          portNames.Sort();
          if (!portNames.Contains(xGB_SerialComm.SerialPort)) {
            xGB_SerialComm.SerialPort = portNames.First();
          }
          foreach (string comPort in portNames) {
            comboBoxPort.Items.Add(comPort);
          }
          comboBoxPort.SelectedItem = xGB_SerialComm.SerialPort;
          comboBoxBaudrate.SelectedItem = xGB_SerialComm.SerialBaudrate;
          comboBoxDatabits.SelectedItem = xGB_SerialComm.SerialDatabits;
          comboBoxParity.SelectedItem = xGB_SerialComm.SerialParity;
          comboBoxStopbits.SelectedItem = xGB_SerialComm.SerialStopbits;
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }
    }

    static int OpenFormCount = 1;
    
    private void buttonSend_Click(object sender, EventArgs e) {
      SendSerialData();
    }

    private void serialPortXGT_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
      //Event-Driven 방식이므로 속성창의 Event로 포트 이벤트를 감지하여 코드로 넘겨줄 수 있다.
      try {
        lock (thisLock) {
          this.Invoke(new EventHandler(SerialPort_DataReceived_InMainThread));
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }
    }

    private void SerialPort_DataReceived_InMainThread(object s, EventArgs e) {
      string inData = serialPortXGT.ReadExisting(); //포트단에 있는 모든 데이터를 가져온다.
      string _inData = inData;
      char[] arrCh = inData.ToCharArray(); //문자배열로 변환해서

      if (arrCh.Length <= 0) {
        return;
      }
      if (arrCh[0] == _ACK) {
        inStream = inData;
      } else {
        inStream += inData;
      }

      string[] splited = inStream.Split(_ACK);
      foreach (string str in splited) {
        char[] arrCh2 = str.ToCharArray();
        if (arrCh2.Length <= 0) {
          continue;
        }
        int etxIndex = Array.IndexOf(arrCh2, _ETX);
        if (etxIndex <= 0) {
          continue;
        }
        var arrCh3 = arrCh2.SubArray(0, etxIndex);
        string ReceivedData = new string(arrCh3);
        SerialReceived(ReceivedData);
      }
    }

    private void InitDGV() {
      DataTable dt = new DataTable();
      dt.Columns.Add("01");
      dt.Columns.Add("02");
      dt.Columns.Add("03");
      dt.Columns.Add("04");
      dt.Columns.Add("05");
      dt.Columns.Add("06");
      dt.Columns.Add("07");
      dt.Columns.Add("08");
      dt.Columns.Add("09");
      dt.Columns.Add("10");
      dgvData.DataSource = dt;
    }

    
    private void SerialReceived(string strDataFrame) {
      textEditReceived.Text = "";
      textEditReceived.Text = strDataFrame;
      dgvData.Rows.Clear();
      lblAddr.Text = strDataFrame.Substring(0, 2); //국번
      lblCmd.Text = strDataFrame.Substring(2, 1); //명렁어
      lblCmdType.Text = strDataFrame.Substring(3, 2); //명령어타입
      if (lblCmd.Text.Equals("r")) {
        dataType = "B";
        lblBlkCnt.Text = strDataFrame.Substring(5, 2); //블록수
        lblDataCnt.Text = strDataFrame.Substring(7, 2); //데이터개수
        int lenStr = Int32.Parse(lblDataCnt.Text, System.Globalization.NumberStyles.HexNumber);
        System.Diagnostics.Debug.WriteLine($"읽은 데이터의 개수는 {lenStr}개 이다.");
        int splitLength = 0;
        if (dataType.Equals("B")) {
          splitLength = 1 * 2;
        } else if (dataType.Equals("W")) {
          splitLength = 2 * 2;
        } else if (dataType.Equals("D")) {
          splitLength = 4 * 2;
        } else {
          splitLength = 8 * 2;
        }
        string strData = strDataFrame.Substring(9, lenStr * splitLength);

        int finDataCnt = 0;
        for (int row = 0; row <= lenStr / 10; row++) {
          dgvData.Rows.Add();
          for (int col = 0; col < 10; col++) {
            dgvData[col, row].Value = strData.Substring((col + row * 10) * splitLength, splitLength);
            finDataCnt++;
            if (finDataCnt >= lenStr) return;
          }
        }
      }
      statusLabel.Text = "정상적으로 데이터를 수신하였습니다.";
      clrStatus = CLEARSTATUS.PROTOCOL;
      autoRefreshUI(2);
    }

    private void SendSerialData() {
      string strOutputData = textEditSendCmd.Text;
      if (string.IsNullOrEmpty(strOutputData)) {
        return; 
      }
      if (serialPortXGT.IsOpen) {
        serialPortXGT.Write(strOutputData);
      } else {
        try {
          serialPortXGT.Open();
          serialPortXGT.Write(strOutputData);
        } catch (Exception ex) {
          MessageBox.Show(ex.Message);
        }
      }
    }

    private void SendSerialData(string sendingCommand) {
      if (string.IsNullOrEmpty(sendingCommand)) {
        return;
      }
      if (serialPortXGT.IsOpen) {
        serialPortXGT.Write(sendingCommand);
      } else {
        try {
          serialPortXGT.Open();
          serialPortXGT.Write(sendingCommand);
        } catch (Exception ex) {
          MessageBox.Show(ex.Message);
        }
      }
    }

    private void buttonAssyData_Click(object sender, EventArgs e) {
      textEditSendCmd.Text = "";
      outStream = "";
      //string strOutputData = _ENQ + textEditSendCmd.Text + _EOT;
      //strOutputData += xGB_SerialComm.calcBcc(textEditSendCmd.Text);
      //00wSB04%MW0010000F3

      if (radioButtonRead.Checked) { //읽기
        if (commandType.Equals("SS")) { //개별 읽기
          outStream = _ENQ + textEditUid.Text/*국번*/ +
                             textEditCommand.Text/*명령어*/ +
                             commandType /*명령어 타입*/ +
                             textEditBlocks.Text + /*블록수*/
                             textEditVarLen.Text /*변수 길이*/ +
                             "%" + textEditDevice.Text + dataType + textEditAddr.Text/*변수이름*/ + _EOT;
        } else { /*SB 연속 읽기*/ 
          outStream = _ENQ + textEditUid.Text/*국번*/ +
                             textEditCommand.Text/*명령어*/ +
                             commandType /*명령어 타입*/ +
                             textEditVarLen.Text /*변수 길이*/ +
                             "%" + textEditDevice.Text + dataType + textEditAddr.Text/*변수이름*/ +
                             textEditDataCounter.Text /*데이터개수*/ + _EOT;
        }
      } else {
        if (commandType.Equals("SS")) { //개별 쓰기
          outStream = _ENQ + textEditUid.Text/*국번*/ +
                             textEditCommand.Text/*명령어*/ +
                             commandType /*명령어 타입*/ +
                             textEditBlocks.Text + /*블록수*/
                             textEditVarLen.Text /*변수 길이*/ +
                             "%" + textEditDevice.Text + dataType + textEditAddr.Text/*변수이름*/ +
                             textEditData.Text /*데이터*/ + _EOT;
        } else { /*SB 연속 쓰기*/
          outStream = _ENQ + textEditUid.Text/*국번*/ +
                             textEditCommand.Text/*명령어*/ +
                             commandType /*명령어 타입*/ +
                             textEditVarLen.Text /*변수 길이*/ +
                             "%" + textEditDevice.Text + dataType + textEditAddr.Text/*변수이름*/ +
                             textEditDataCounter.Text /*데이터개수*/ +
                             textEditData.Text /*데이터*/ + _EOT;
        }
      }
      
      textEditSendCmd.Text = outStream + checkBCC(outStream);
      statusLabel.Text = "명령어를 새로 만들었습니다.";
      clrStatus = CLEARSTATUS.MESSAGE;
      autoRefreshUI(2);
    }

    private string checkBCC(string strFrame) {
      Byte[] byteStream = System.Text.Encoding.UTF8.GetBytes(strFrame);
      int ChkSum = 0;
      foreach (Byte byteElem in byteStream) {
        ChkSum += byteElem;
      }
      ChkSum = ChkSum & 0x000000FF;

      string strBCC = ChkSum.ToString("X");

      return strBCC;
    }

    private void radioButtonReadWrite_CheckedChanged(object sender, EventArgs e) {
      if (radioButtonRead.Checked) {
        statusCmd = STATUSCMD.READ;
        /* 데이터 백업 */
        strData = textEditData.Text;
        strDataCouter = textEditDataCounter.Text;
        /* 비우기 */
        textEditData.Text = "";
        textEditDataCounter.Text = "";

        textEditData.Enabled = false;
        textEditDataCounter.Enabled = false;
      } else {
        statusCmd = STATUSCMD.WRITE;
        /* 데이터 원복*/
        textEditData.Text = strData;
        textEditDataCounter.Text = strDataCouter;

        textEditData.Enabled = true;
        if(commandType.Equals("SB"))
          textEditDataCounter.Enabled = true;
      }
      //textEditCommand.Text = $"{cmdStringPair[statusCmd]}{dataType}";
    }

    private void radioButtonCommandType_CheckedChanged(object sender, EventArgs e) {
      if (radioButtonSS.Checked) {
        commandType = "SS";
        //if (statusCmd == STATUSCMD.READ) {
          textEditDataCounter.Enabled = false;
        //}
      } else { //SB
        commandType = "SB";
        textEditDataCounter.Enabled = true;
        if (statusCmd == STATUSCMD.READ) {
          textEditDataCounter.Text = strDataCouter;
        }
      }
    }

    private void radioButtonDataType_CheckedChanged(object sender, EventArgs e) {
      if (radioButtonByte.Checked) {
        dataType = "B";
      } else if (radioButtonWord.Checked) {
        dataType = "W";
      } else if (radioButtonDword.Checked) {
        dataType = "D";
      } else {
        dataType = "L";
      }
      //textEditCommand.Text = $"{cmdStringPair[statusCmd]}{dataType}";
    }

    private void textEditCommandString_EditValueChanged(object sender, EventArgs e) {
      textEditVarLen.Text = String.Format("{0:D2}", textEditAddr.Text.Length + 3);
    }

    private void rbctrlTestStartEnd_CheckedChanged(object sender, EventArgs e) {
      if (rbctrlTestStart.Checked) {
        SendSerialData(_ENQ + "00wSB06%MW114010001" + _EOT + "5C"); //Reset Encoder
        if (dataSet.sys_STD == SYS_STD.STD_2L) {
          SendSerialData(_ENQ + "00wSB06%MW135010000" + _EOT + "5E"); //소형 기준기
        } else {
          SendSerialData(_ENQ + "00wSB06%MW135010001" + _EOT + "5F"); //대형 기준기
        }
      }
    }

    private void rbctrlTestMode_CheckedChanged(object sender, EventArgs e) {
      DataSet.TEST_MODE emTestMode = DataSet.TEST_MODE.MODE_UNKNOWN;
      if (rbctrlModePhotoSensor.Checked) {
        emTestMode = DataSet.TEST_MODE.PHOTO_SENSOR;
      } else if (rbctrlModeEncoder.Checked) {
        emTestMode = DataSet.TEST_MODE.ENCODER;
      } else {
        emTestMode = DataSet.TEST_MODE.ELECMETER;
      }
      dataSet.sys_TEST_MODE = emTestMode;
    }

    private void rbctrlSelectStd_CheckedChanged(object sender, EventArgs e) {
      DataSet.SYS_STD emSysStd = DataSet.SYS_STD.STD_UNKNOWN;
      if (rbctrl2Lstd.Checked) {
        emSysStd = SYS_STD.STD_2L;
      } else {
        emSysStd = SYS_STD.STD_20L;
      }
      dataSet.sys_STD = emSysStd;
    }

    private void timerUiUpdate_Tick(object sender, EventArgs e) {
      if (clrCounter++ >= clrDelaySecs) {
        /*
        switch(clrStatus) {
          case CLEARSTATUS.SERIALPORT:
            statusLabel.Text = "";
            break;
          default:
            statusLabel.Text = "";
            break;
        }
        */
        clrCounter = 0;
        timerUiUpdate.Enabled = false;
      }
    }

    private void textEdit_TextChanged(object sender, EventArgs e) {
      DevExpress.XtraEditors.TextEdit textEdit = sender as DevExpress.XtraEditors.TextEdit;
      if (textEdit.Text.Length > 0) {
        int result = int.Parse(textEdit.Text, System.Globalization.NumberStyles.HexNumber);
        if (textEdit.Name.Equals("textEditUid") || textEdit.Name.Equals("textEditBlocks") || textEdit.Name.Equals("textEditVarLen") || textEdit.Name.Equals("textEditDataCounter"))
        {
          textEdit.Text = result.ToString("X2");
        }
        if (textEdit.Name.Equals("textEditDataCounter") && statusCmd == STATUSCMD.WRITE) {
          dataCount = int.Parse(textEditDataCounter.Text, System.Globalization.NumberStyles.HexNumber);
          int value = int.Parse(textEditData.Text, System.Globalization.NumberStyles.HexNumber);
          textEditData.Text = value.ToString($"X{4 * dataCount}");
        }
        if (textEdit.Name.Equals("textEditData")) {
          textEdit.Text = result.ToString($"X{4*dataCount}");
        }
      }
    }

    private void textEdit_Leave(object sender, EventArgs e) {
      DevExpress.XtraEditors.TextEdit textEdit = sender as DevExpress.XtraEditors.TextEdit;
      if (textEdit.Text.Length == 0 || (textEdit.Name != "textEditData" && textEdit.Text.Length > 10)) {
        MessageBox.Show("입력값에 문제가 있습니다.", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textEdit.Focus();
      } else {
        if(textEdit.Name == "textEditDataCounter") {
          strDataCouter = textEdit.Text;
        } else if(textEdit.Name == "textEditData") {
          strData = textEdit.Text;
        }
      }
    }

    private void verifyDataFrame() {
      string strDataFrame = textEditSendCmd.Text;
      int startIdx = 0;
      int dataLength = 0;
      /*국번*/
      textEditUid.Text = strDataFrame.Substring(startIdx = 1, dataLength = 2);
      /*명령어*/
      textEditCommand.Text = strDataFrame.Substring(startIdx += dataLength, dataLength = 1);
      if (textEditCommand.Text.Equals("r")) {
        statusCmd = STATUSCMD.READ;
        radioButtonRead.Checked = true;
      } else { //"w"
        statusCmd = STATUSCMD.WRITE;
        radioButtonWrite.Checked = true;
      }
      /*명령어 타입*/
      commandType = strDataFrame.Substring(startIdx += dataLength, dataLength = 2);
      if (commandType.Equals("SS")) {
        radioButtonSS.Checked = true;
        /*블록수*/
        textEditBlocks.Text = strDataFrame.Substring(startIdx += dataLength, dataLength = 2);
      } else {
        radioButtonSB.Checked = true;
      }
      /*변수길이*/
      textEditVarLen.Text = strDataFrame.Substring(startIdx += dataLength, dataLength = 2);
      int varLength = int.Parse(textEditVarLen.Text, System.Globalization.NumberStyles.HexNumber); //변수 길이 16진수를 10진수로 변환
      string varNameBlock = strDataFrame.Substring(startIdx += dataLength, dataLength = varLength);
      textEditDevice.Text = varNameBlock.Substring(1, 1);
      dataType = varNameBlock.Substring(2, 1);
      if (dataType.Equals("B"))
        radioButtonByte.Checked = true;
      else if (dataType.Equals("W"))
        radioButtonWord.Checked = true;
      else if (dataType.Equals("D"))
        radioButtonDword.Checked = true;
      else //Lword
        radioButtonLword.Checked = true;
      /*변수이름*/
      textEditAddr.Text = varNameBlock.Substring(3, varLength - 3);

      if (commandType.Equals("SB")) {
        if (statusCmd == STATUSCMD.WRITE) {
          /*데이터 개수*/
          strDataCouter = textEditDataCounter.Text = strDataFrame.Substring(8 + varLength, 2);
          dataCount = int.Parse(strDataCouter, System.Globalization.NumberStyles.HexNumber);
          /*데이터*/
          strData = textEditData.Text = strDataFrame.Substring(8 + varLength + 2, 4 * dataCount);
        }
      } else { //SS
        /*데이터*/
        if (statusCmd == STATUSCMD.WRITE) {
          strData = textEditData.Text = strDataFrame.Substring(10 + varLength, 4);
          dataCount = 1;
          int value = int.Parse(textEditData.Text, System.Globalization.NumberStyles.HexNumber);
          textEditData.Text = value.ToString($"X{4 * dataCount}");
        }
      }
      /*BCC*/
      string strCheckBcc = strDataFrame.Substring(0, strDataFrame.Length - 2);
      textEditSendCmd.Text = strCheckBcc + checkBCC(strCheckBcc);
    }

    private void checkButtonEditCmd_CheckedChanged(object sender, EventArgs e) {
      DevExpress.XtraEditors.CheckButton checkButton = sender as DevExpress.XtraEditors.CheckButton;
      if (checkButton.Checked)
      {
        textEditSendCmd.Enabled = true;
        checkButton.Text = "명령수정완료";
      } else {
        verifyDataFrame();
        textEditSendCmd.Enabled = false;
        checkButton.Text = "명령수정";
      }
    }

    private void checkButtonSerialPort_CheckedChanged(object sender, EventArgs e) {
      DevExpress.XtraEditors.CheckButton checkButton = sender as DevExpress.XtraEditors.CheckButton;
      if (checkButton.Checked) { //열기
        if (!serialPortXGT.IsOpen) {
          if (openSerial())
            buttonConnect.BackColor = System.Drawing.Color.Cyan;
          else
            buttonConnect.BackColor = System.Drawing.Color.DimGray;
        }
        checkButton.Text = "통신포트열림";
      } else { //닫기
        if (serialPortXGT.IsOpen) {
          serialPortXGT.Close();
          statusLabel.Text = "시리얼포트를 닫았습니다. 더 이상 통신이 되지 않습니다!";
          clrStatus = CLEARSTATUS.SERIALPORT;
          autoRefreshUI(5);
          buttonConnect.BackColor = System.Drawing.Color.DimGray;
        }
        checkButton.Text = "통신포트닫힘";
      }
    }

    private void autoRefreshUI(int DelaySecs) {
      timerUiUpdate.Enabled = true;
      clrDelaySecs = DelaySecs;
    }

  }
}
