using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXAppXGBCommTest {
  internal class XGB_SerialComm {

    private string m_Port;
    private string m_Baudrate;
    private string m_DataBits;
    private string m_Parity;
    private string m_StopBits;

    private string settingFile = Path.Combine(Application.StartupPath, "SettingsSerial.ini");

    public Dictionary<string, string> comportSettings;
    public XGB_SerialComm() {
      comportSettings = new Dictionary<string, string>(); /* {
        {"Port", "COM5" },
        {"Baudrate", "115200" },
        {"Data", "8" },
        {"Parity", "None" },
        {"Stop", "1" }
      };*/
  }

  public string SerialPort {
      get => m_Port; set => m_Port = value;
    }
    public string SerialBaudrate {
      get => m_Baudrate; set => m_Baudrate = value;
    }

    public string SerialDatabits {
      get => m_DataBits; set => m_DataBits = value;
    }

    public string SerialParity {
      get => m_Parity; set => m_Parity = value;
    }

    public string SerialStopbits {
      get => m_StopBits; set => m_StopBits = value;
    }

    private void WriteToSerialSettings() {
      try {
        File.WriteAllLines(settingFile,
            comportSettings.Select(x => x.Key + '=' + x.Value).ToArray());
      } catch (Exception err) {
        MessageBox.Show(err.Message);
      }
    }
    public byte chkBcc(string data) {
      int checkSum = 0;

      foreach (char chr in data) {
        checkSum += chr;
        if (checkSum > 255)
          checkSum -= 256;
      }
      return (byte)checkSum;
    }
    public string calcBcc(string cmd) {
      int iBcc = chkBcc(cmd);
      if (iBcc > 255)
        iBcc -= 256;
      return ByteToHexStr((byte)iBcc);
    }
    public static string ByteToHexStr(byte byData) {
      return byData.ToString("X2");
    }

    public void ReadyToSerialPort() {
      try {
        if (File.Exists(settingFile)) {
          //using (StreamReader reader = new StreamReader(settingFile)) {
          StreamReader reader = new StreamReader(settingFile);
          string oneLine;
          if (comportSettings != null) {
            comportSettings.Clear();
          }
          while ((oneLine = reader.ReadLine()) != null) {
            string[] arrStr = oneLine.Split('=');
            int i = 0;
            while (i < arrStr.Length) {
              comportSettings.Add(arrStr[i], arrStr[i + 1]); // comportSettings[arrStr[i]] = arrStr[i + 1];
              if (arrStr[i] == "Port")
                m_Port = arrStr[i + 1];
              else if (arrStr[i] == "Baudrate")
                m_Baudrate = arrStr[i + 1];//int.TryParse(arrStr[i + 1], out m_Baudrate);
              else if (arrStr[i] == "Data")
                m_DataBits = arrStr[i + 1];//int.TryParse(arrStr[i + 1], out m_DataBits);
              else if (arrStr[i] == "Parity")
                m_Parity = arrStr[i + 1];
              else if (arrStr[i] == "Stop")
                m_StopBits = arrStr[i + 1];//int.TryParse(arrStr[i + 1], out m_StopBits);
              i += 2;
            }
          }
        } else {
          //MessageBox.Show("'SettingsSerial.ini' 파일이 없습니다.");
          WriteToSerialSettings();
        }
      } catch (Exception err) {
        MessageBox.Show(err.Message);
      }
    }
  }
}
