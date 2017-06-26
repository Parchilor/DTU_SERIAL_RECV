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
            SP.DataReceived += new SerialDataReceivedEventHandler(ReceiveHander);

            ////串口设置默认选择项  
            PortSelect.SelectedIndex = i;
            //BaudSelect.SelectedIndex = 0;
            //StopBitSelect.SelectedIndex = 0;
            //ParitySelect.SelectedIndex = 0;
            //DataSizeSelect.SelectedIndex = 0;
        }

        string RecvData;
        private void ReceiveHander(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);
            
            string RecvChar = SP.ReadExisting();
            RecvData += RecvChar;
        }
        private void GetData_Click(object sender, EventArgs e)
        {
            
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
