using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DTU_SERIAL_RECV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort SP = new SerialPort();
        int i = -1;
        private void SettingLoad(object sender, EventArgs e)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口  
                PortSelect.Items.Add(s);
                i++;
            }

            // 添加接收事件
            // 这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            Control.CheckForIllegalCrossThreadCalls = false;
            SP.DataReceived += new SerialDataReceivedEventHandler(ReceiveHandler);

            ////串口设置默认选择项  
            PortSelect.SelectedIndex = i;
            //BaudSelect.SelectedIndex = 0;
            //StopBitSelect.SelectedIndex = 0;
            //ParitySelect.SelectedIndex = 0;
            //DataSizeSelect.SelectedIndex = 0;
        }

        enum Decode_STA
        {
            SOP_STATE,
            TYPE_STATE,
            LEN_STATE,
            CFG_STATE,
            DATA_STATE,
            VERIFY_STATE,
            EXE_STATE
        };
        SerialData Recv;// = new SerialData(43);
        //DevData Dev;
        Decode_STA state = Decode_STA.SOP_STATE;
        int bufflen = 0;
        private void ReceiveHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int i = bufflen, _tmp = 0, res = 0;
            byte RecvByte;
            bufflen += SP.BytesToRead;
            for (; i < bufflen; i++)
            {
                if (SP.IsOpen)
                {
                    RecvByte = (byte)SP.ReadByte();
                    //Recv.Data[i] = RecvByte;
                    //ShowLabel.AppendText(Recv.Data[i].ToString("X2") + " ");
                    switch (state)
                    {
                        case Decode_STA.SOP_STATE:
                            if(RecvByte == 0xEB)
                            {
                                //Recv.Data[i] = RecvByte;
                            }
                            else if(RecvByte == 0x90)
                            {
                                //Recv.Data[i] = RecvByte;
                                state = Decode_STA.TYPE_STATE;
                            }
                            else
                            {
                                // Do nothing
                            }
                            break;
                        case Decode_STA.TYPE_STATE:
                            if((RecvByte == 0x00) | (RecvByte == 0x01))
                            {
                                Recv = new SerialData(62);
                            }
                            else if(RecvByte == 0x04)
                            {
                                Recv = new SerialData(43);
                            }
                            Recv.UartData[i] = RecvByte;
                            state = Decode_STA.LEN_STATE;
                            break;
                        case Decode_STA.LEN_STATE:
                            Recv.UartData[i] = RecvByte;
                            state = Decode_STA.DATA_STATE;
                            break;
                        case Decode_STA.CFG_STATE:
                            break;
                        case Decode_STA.DATA_STATE:
                            if(i < Recv.GetDataLen() + 4)
                            {
                                Recv.UartData[i] = RecvByte;
                            }
                            else if(i == Recv.GetDataLen() + 4)
                            {
                                Recv.UartData[i] = RecvByte; // Is first Verify bit
                                state = Decode_STA.VERIFY_STATE;
                            }
                            else
                            {
                                // Do nothing
                            }
                            break;
                        case Decode_STA.VERIFY_STATE:

                            DAD.Items.Clear();
                            RawData.Clear();

                            Recv.UartData[i] = RecvByte; // Is second Verify bit
                            byte[] tmp = Recv.GetData();
                            if (Recv.Verify())
                            {
                                Recv.LoadDevInfo();
                                // -----------------------------------------------------------------
                                // Show Raw Data
                                for (int index = 0; index < Recv.UartData.Length; index++)
                                {
                                    RawData.AppendText(Recv.UartData[index].ToString("X2") + " ");
                                }
                                // -----------------------------------------------------------------
                                //
                                DAD.Items.Add("Date:  " + Recv.GetDate());
                                DAD.Items.Add("  ID:  " + Recv.GetID());

                                //ST1.Text = Recv.GetDevInfo(0).ToString(); // 土壤温度1 x10 .2
                                res = Recv.GetDevInfo(0) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                ST1.Text = _tmp.ToString() + "." + res.ToString();

                                //SH1.Text = Recv.GetDevInfo(1).ToString(); // 土壤湿度1 x10 .2
                                res = Recv.GetDevInfo(1) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                SH1.Text = _tmp.ToString() + "." + res.ToString();


                                //ST2.Text = Recv.GetDevInfo(2).ToString(); // 土壤温度2 x10 .2
                                res = Recv.GetDevInfo(2) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                ST2.Text = _tmp.ToString() + "." + res.ToString();

                                //SH2.Text = Recv.GetDevInfo(3).ToString(); // 土壤湿度2 x10 .2
                                res = Recv.GetDevInfo(3) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                SH2.Text = _tmp.ToString() + "." + res.ToString();

                                //TMP1.Text = Recv.GetDevInfo(4).ToString(); // 空气温度1 x10 .2
                                res = Recv.GetDevInfo(4) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                TMP1.Text = _tmp.ToString() + "." + res.ToString();

                                //HUM1.Text = Recv.GetDevInfo(5).ToString(); // 空气湿度1 x10 .2
                                res = Recv.GetDevInfo(5) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                HUM1.Text = _tmp.ToString() + "." + res.ToString();

                                //ILL1.Text = Recv.GetDevInfo(6).ToString(); // 照度1 /10 .2
                                res = Recv.GetDevInfo(6) / 10;
                                _tmp = res / 100;
                                res = res % 100;
                                ILL1.Text = _tmp.ToString() + "." + res.ToString();

                                CDC1.Text = Recv.GetDevInfo(7).ToString(); // CO2 1 x1

                                //TMP2.Text = Recv.GetDevInfo(8).ToString(); // 空气温度2
                                res = Recv.GetDevInfo(8) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                TMP2.Text = _tmp.ToString() + "." + res.ToString();

                                //HUM2.Text = Recv.GetDevInfo(9).ToString(); // 空气湿度2
                                res = Recv.GetDevInfo(9) * 10;
                                _tmp = res / 100;
                                res = res % 100;
                                HUM2.Text = _tmp.ToString() + "." + res.ToString();

                                //ILL2.Text = Recv.GetDevInfo(10).ToString(); // 照度2
                                res = Recv.GetDevInfo(10) / 10;
                                _tmp = res / 100;
                                res = res % 100;
                                ILL2.Text = _tmp.ToString() + "." + res.ToString();

                                CDC2.Text = Recv.GetDevInfo(11).ToString(); // CO2 2

                                // -----------------------------------------------------------------
                                bufflen = 0;
                                _tmp = 0;
                                res = 0;
                                Recv.Clean();
                            }
                            else
                            {
                                bufflen = 0;
                                Recv.Clean();
                            }
                            state = Decode_STA.SOP_STATE;
                            break;
                        //case Decode_STA.EXE_STATE:
                        //    for(int index = 0; index < Recv.Data.Length; index++)
                        //    {
                        //        ShowLabel.AppendText(Recv.Data[index].ToString("X2") + " ");
                        //    }
                        //    bufflen = 0;
                        //    Recv.Clean();
                        //    state = Decode_STA.SOP_STATE;
                        //    break;
                    }
                }
            }
        }
        private void GetData_Click(object sender, EventArgs e)
        {
            if (SP.IsOpen)
            {
                SP.Write("GETSECDATA");
            }
        }

        private void reloadPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PortSelect.Enabled == true)
            {
                int i = -1;
                PortSelect.Items.Clear();
                foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                {//获取有多少个COM口  
                    PortSelect.Items.Add(s);
                    i++;
                }
                PortSelect.SelectedIndex = i;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SP.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SP.IsOpen)
            {
                try
                {
                    SP.PortName = PortSelect.Text;
                    SP.BaudRate = 9600;

                    SP.StopBits = StopBits.One;

                    SP.Parity = System.IO.Ports.Parity.None;

                    SP.DataBits = 8;

                    SP.RtsEnable = false;
                    SP.DtrEnable = false;

                    if (SP.IsOpen == true)
                    {
                        SP.Close();
                    }

                    PortSelect.Enabled = false;

                    SP.Open();
                    button1.Text = "Disconnect";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Caution");
                    //tmSend.Enabled = false;
                    SP.Close();
                    button1.Text = "Connect";
                    PortSelect.Enabled = true;
                    return;
                }
            }
            else
            {
                SP.Close();
                button1.Text = "Connect";
                PortSelect.Enabled = true;
                //tmSend.Enabled = false;
            }
        }
    }
}
