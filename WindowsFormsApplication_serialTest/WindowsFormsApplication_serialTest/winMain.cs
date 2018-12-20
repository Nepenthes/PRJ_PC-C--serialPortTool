using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication_serialTest
{

    public partial class Form_main : Form
    {
        /************************自定义相关************************/

        string[] itemsSerialBaud_Text = new string[6]{

            "1200", "4800", "9600", "19200", "38400", "115200"
        };

        string[] itemsCheckBit_Text = new string[3]{

           "无校验", "奇校验", "偶校验"
        };

        string[] itemsStopBit_Text = new string[3]{

           "1.0", "1.5", "2.0"
        };

        string[] itemsDataBit_Text = new string[2]{

           "7", "8"
        };

        private void serialCom_Init() //串口属性参数初始化
        {
            try
            {
                UInt16 loopInsert_Temp = 0;

                serialPort_A.PortName = comboBox_serialNum.Text.Trim();
                serialPort_A.BaudRate = Convert.ToInt32(comboBox_baud.Text.Trim());
                serialPort_A.DataBits = Convert.ToInt16(comboBox_dataBit.Text.ToString().Trim());
                for (loopInsert_Temp = 0; loopInsert_Temp < 3; loopInsert_Temp++)
                {
                    if (comboBox_checkBit.Text.Trim() == itemsCheckBit_Text[loopInsert_Temp].Trim()) break;
                }
                switch (loopInsert_Temp)
                {
                    case 0:
                    {
                        serialPort_A.Parity = Parity.None;
                    }
                    break;

                    case 1:
                    {
                        serialPort_A.Parity = Parity.Odd;
                    }
                    break;

                    case 2:
                    {
                        serialPort_A.Parity = Parity.Even;
                    }
                    break;

                    default:
                    {
                        serialPort_A.Parity = Parity.None;
                    }
                    break;
                }

                for (loopInsert_Temp = 0; loopInsert_Temp < 3; loopInsert_Temp++)
                {
                    if (comboBox_stopBit.Text.Trim() == itemsStopBit_Text[loopInsert_Temp].Trim()) break;
                }
                switch (loopInsert_Temp)
                {
                    case 0:
                        {
                            serialPort_A.StopBits = StopBits.One;
                        }
                        break;

                    case 1:
                        {
                            serialPort_A.StopBits = StopBits.OnePointFive;
                        }
                        break;

                    case 2:
                        {
                            serialPort_A.StopBits = StopBits.Two;
                        }
                        break;

                    default:
                        {
                            serialPort_A.StopBits = StopBits.One;
                        }
                        break;
                }

                serialPort_A.Encoding = Encoding.UTF8;

                Console.WriteLine("串口控件属性参数：\n  串口号：{0}\n  波特率：{1}\n  校验位：{2}\n  停止位：{3}\n  数据位：{4}\n", 
                                    serialPort_A.PortName, 
                                    serialPort_A.BaudRate,
                                    serialPort_A.Parity,
                                    serialPort_A.StopBits,
                                    serialPort_A.DataBits);
            }
            catch (Exception ex)
            {
                radioButton_dataSendDispByHEX.Select();
                MessageBox.Show("串口初始化失败！" + ex.Message, "错误提示");
            }
        }

        private string usrMethod_HEX2ASCII(string str) //自定义方法：hex转ascii
        {
            try
            {
                string[] strConvTemp = str.Trim().Split(' ');
                byte[] dataConvTemp = new byte[strConvTemp.Length];
                for(int loop = 0; loop < dataConvTemp.Length; loop++)
                {
                    dataConvTemp[loop] = Convert.ToByte(strConvTemp[loop], 16);
                }
                return Encoding.UTF8.GetString(dataConvTemp);
            }
            catch(Exception ex)
            {
                radioButton_dataSendDispByHEX.Select();
                MessageBox.Show("转换失败！" + ex.Message, "错误提示");
                return str;
            }
        }

        private string usrMethod_ASCII2HEX(string str) //自定义方法：ascii转hex
        {
            try
            {
                byte[] dataConvTemp = Encoding.UTF8.GetBytes(str.Trim());
                string strConvTemp = "";
                for (int loop = 0; loop < dataConvTemp.Length; loop++)
                {
                    strConvTemp += dataConvTemp[loop].ToString("X2") + " ";
                }
                return strConvTemp;
            }
            catch (Exception ex)
            {
                radioButton_dataSendDispByHEX.Select();
                MessageBox.Show("转换失败！" + ex.Message, "错误提示");
                return str;
            }
        }

        private void funCB_serialCom_dataRcv(object sender, SerialDataReceivedEventArgs e) //串口数据接收回调
        {
            byte[,] specialReq_TAB= { 
                
                {0xfe, 0x01, 0x02, 0x03, 0x04},
                {0xfe, 0x01, 0x02, 0x03, 0x05}
            };

            Thread.Sleep(100);
            this.Invoke((EventHandler)(delegate
            {
                try
                {
                    string tipsString = "[接收]" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff:");
                    byte[] dataRcv = new byte[serialPort_A.BytesToRead];
                    serialPort_A.Read(dataRcv, 0, dataRcv.Length);
                    string dataRcv_showTemp = Encoding.UTF8.GetString(dataRcv);
                    string dataRcv_show = "";
                    bool specialReq_catch_FLG = false;

                    //数据处理，指定数据帧识别
                    if(dataRcv.Length == 5)
                    {
                        for (int loopA = 0; loopA < 2; loopA++)
                        {
                            specialReq_catch_FLG = true;
                            for (int loopB = 0; loopB < 5; loopB++) //单帧全比较
                            {
                                if (dataRcv[loopB] != specialReq_TAB[loopA, loopB])
                                {
                                    specialReq_catch_FLG = false;
                                    break;
                                }
                            }
                            if (specialReq_catch_FLG == true)
                            {
                                Console.WriteLine("specialReq-{0} catched!!!", loopA);
                                break;
                            }
                        }
                    }

                    //数据显示
                    if (radioButton_dataRcvDispByHEX.Checked)
                    {
                        dataRcv_show = usrMethod_ASCII2HEX(dataRcv_showTemp);
                    }
                    else
                    {
                        dataRcv_show = dataRcv_showTemp;
                    }

                    textBox_dataRcv.Text += tipsString + dataRcv_show + "\r\n";

                    //使文本永远显示最后一行
                    this.textBox_dataRcv.Focus();
                    this.textBox_dataRcv.Select(this.textBox_dataRcv.TextLength, 0);
                    this.textBox_dataRcv.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    radioButton_dataSendDispByHEX.Select();
                    MessageBox.Show("串口接收数据处理失败！" + ex.Message, "错误提示");
                }
            }));
        }

        /************************控件相关************************/

        public Form_main()
        {
            InitializeComponent();
        }
    
        private void Form_main_Load(object sender, EventArgs e)
        {

            //枚举按钮初始化
            radioButton_dataRcvDispByASCII.Checked = true;
            radioButton_dataSendDispByASCII.Checked = true;

            //多选框初始化
            comboBox_serialNum.Items.Clear();
            string[] text_serialPortList = SerialPort.GetPortNames();
            foreach(var itemTemp in text_serialPortList)
            {
                comboBox_serialNum.Items.Add(itemTemp);
            }
            comboBox_serialNum.SelectedIndex = 0; //初始化insert

            comboBox_baud.Items.Clear();
            foreach (var itemTemp in itemsSerialBaud_Text)
            {
                comboBox_baud.Items.Add(itemTemp);
            }
            comboBox_baud.SelectedIndex = 5; //初始化insert

            comboBox_checkBit.Items.Clear();
            foreach (var itemTemp in itemsCheckBit_Text)
            {
                comboBox_checkBit.Items.Add(itemTemp);
            }
            comboBox_checkBit.SelectedIndex = 0; //初始化insert

            comboBox_stopBit.Items.Clear();
            foreach (var itemTemp in itemsStopBit_Text)
            {
                comboBox_stopBit.Items.Add(itemTemp);
            }
            comboBox_stopBit.SelectedIndex = 0; //初始化insert

            comboBox_dataBit.Items.Clear();
            foreach (var itemTemp in itemsDataBit_Text)
            {
                comboBox_dataBit.Items.Add(itemTemp);
            }
            comboBox_dataBit.SelectedIndex = 1; //初始化insert
        }
       
        private void textBox_dataRcv_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox_dataSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_dataRcvDispByASCII_CheckedChanged(object sender, EventArgs e)
        {
            //接收回调函数中已写入本按钮逻辑
        }

        private void radioButton_dataRcvDispByHEX_CheckedChanged(object sender, EventArgs e)
        {
            //接收回调函数中已写入本按钮逻辑
        }

        private void radioButton_dataSendDispByASCII_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dataSendDispByASCII.Checked)
            {
                if(textBox_dataSend.Text != "") textBox_dataSend.Text = usrMethod_HEX2ASCII(textBox_dataSend.Text);
            }
        }

        private void radioButton_dataSendDispByHEX_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dataSendDispByHEX.Checked)
            {
                if(textBox_dataSend.Text != "") textBox_dataSend.Text = usrMethod_ASCII2HEX(textBox_dataSend.Text.ToString());
            }
        }

        private void button_serialOpenIF_Click(object sender, EventArgs e)
        {
            if (button_serialOpenIF.Text == "打开串口")
            {
                serialCom_Init();
                if (serialPort_A.IsOpen)
                {

                }
                else
                {
                    try
                    {
                        //serialPort_A.PortName = "COM4";
                        //serialPort_A.Parity = Parity.None;
                        //serialPort_A.BaudRate = 115200;
                        //serialPort_A.StopBits = StopBits.One;
                        //serialPort_A.DataBits = 8;

                        serialPort_A.Open();
                        comboBox_serialNum.Enabled = false;
                        comboBox_dataBit.Enabled = false;
                        comboBox_stopBit.Enabled = false;
                        comboBox_checkBit.Enabled = false;
                        comboBox_baud.Enabled = false;
                        button_serialOpenIF.Text = "关闭串口";
                        serialPort_A.DataReceived += new SerialDataReceivedEventHandler(funCB_serialCom_dataRcv);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("串口" + comboBox_serialNum.Text + "打开失败，失败原因:" + ex.Message, "错误提示");
                    }
                }
            }
            else
            {
                if (serialPort_A.IsOpen)
                {
                    try
                    {
                        serialPort_A.Close();
                        comboBox_serialNum.Enabled = true;
                        comboBox_dataBit.Enabled = true;
                        comboBox_stopBit.Enabled = true;
                        comboBox_checkBit.Enabled = true;
                        comboBox_baud.Enabled = true;
                        button_serialOpenIF.Text = "打开串口";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("串口" + comboBox_serialNum.Text + "关闭失败，失败原因:" + ex.Message, "错误提示");
                    }
                }
                else
                {
                    comboBox_serialNum.Enabled = true;
                    comboBox_dataBit.Enabled = true;
                    comboBox_stopBit.Enabled = true;
                    comboBox_checkBit.Enabled = true;
                    comboBox_baud.Enabled = true;
                    button_serialOpenIF.Text = "打开串口";
                    MessageBox.Show("串口未打开，关闭不存在！", "错误提示");
                }
            }
        }

        private void button_dataSend_Click(object sender, EventArgs e)
        {
            try
            {
                string dataSend_Temp = textBox_dataSend.Text;
                if (radioButton_dataSendDispByHEX.Checked)
                {
                    dataSend_Temp = usrMethod_ASCII2HEX(textBox_dataSend.Text);
                    MatchCollection dataSendText_matchTemp = Regex.Matches(dataSend_Temp, @"\b[\da-fA-F]{2}");
                    List<byte> byteSend_Temp = new List<byte>();
                    foreach (Match loop in dataSendText_matchTemp)
                    {
                        byteSend_Temp.Add(byte.Parse(loop.Value, System.Globalization.NumberStyles.HexNumber));
                    }
                    serialPort_A.Write(byteSend_Temp.ToArray(), 0, byteSend_Temp.Count);
                    textBox_dataRcv.Text += "[发送]" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff:") + " " + textBox_dataSend.Text + "\r\n";
                }
                else
                {
                    byte[] byteSend = Encoding.UTF8.GetBytes(dataSend_Temp);
                    string dataSend = Encoding.UTF8.GetString(byteSend);
                    serialPort_A.Write(dataSend);
                    textBox_dataRcv.Text += "[发送]" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff:") + " " + textBox_dataSend.Text + "\r\n";
                }

                //使文本永远显示最后一行
                this.textBox_dataRcv.Focus();
                this.textBox_dataRcv.Select(this.textBox_dataRcv.TextLength, 0);
                this.textBox_dataRcv.ScrollToCaret();
            }
            catch
            {

            }
        }
        private void comboBox_serialNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_checkBit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_stopBit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_dataBit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_dataRcvBuffer_clear_Click(object sender, EventArgs e)
        {
            textBox_dataRcv.Text = "";
        }

        private void button_dataSendBuffer_clear_Click(object sender, EventArgs e)
        {
            textBox_dataSend.Text = "";
        }
    }
}
