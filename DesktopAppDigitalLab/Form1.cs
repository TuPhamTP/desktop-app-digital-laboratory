using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using S7.Net;
using S7.Net.Types;
using System.Net; //Sd đọc địa chỉ IP
using Newtonsoft.Json;

namespace DesktopAppDigitalLab
{
    public partial class Form1 : Form
    {
        public MqttClient desktopAppClient;
        public Plc myPLC;
        public string strID, strIPPC, strIPPLC, strBrokerAddress, strPort, strUsername, strPassword;
        public string msgReceive;
        public bool clickBtnBroker, clickBtnPLCSIM, clickBtnPLC;
        public int flagPLCSIM, flagPLC;
        public DataDesktopAppPublish DataDesktopApp = new DataDesktopAppPublish();
        public string jsonPublish;


        public Form1()
        {
            InitializeComponent();
            txtIPPC.Text = GetIPAddress();
            txtIPPLC.Text = "192.168.0.1";

            txtBrokerAddress.Text = "40.76.54.39";
            txtPort.Text = "1883";
            txtUsername.Text = "mqtt2";
            txtPassword.Text = "passwordmqtt2";
            txtID.Text = "0";
            timerConnect.Start();
            

            
        }

        private void timerTSample_Tick(object sender, EventArgs e)
        {
            ushort UGT524_SP1 = ((ushort)myPLC.Read("MW100"));
            txtSP1.Text = UGT524_SP1.ToString();
        }

        public class DataDesktopAppPublish
            {
            public Int16 valSP1SSC1UGT = 1001;
            }

        private void timerMQTT_Tick(object sender, EventArgs e)
        {

            jsonPublish = JsonConvert.SerializeObject(DataDesktopApp);
            if (desktopAppClient.IsConnected)
            {
                desktopAppClient.Publish("DA_Pub_Mos", Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }    
        }

        private void btnConnectPLCSIM_Click(object sender, EventArgs e)
        {
            timerTSample.Start();
            if (clickBtnPLCSIM == false)
            {
                clickBtnPLCSIM = true;
                flagPLC = 0;
                btnConnectPLC.Enabled = false;
                btnConnectPLCSIM.Text = "HỦY KẾT NỐI";
                strIPPC = txtIPPC.Text;
                myPLC = new Plc(CpuType.S71200, strIPPC, 0, 1);
                myPLC.Open();
                flagPLCSIM = 1;
            }
            else
            {
                timerTSample.Stop();
                clickBtnPLCSIM = false;
                flagPLCSIM = 2;
                btnConnectPLC.Enabled = true;
                btnConnectPLCSIM.Text = "KẾT NỐI";
                myPLC.Close();

            }
        }

        private void btnConnectPLC_Click(object sender, EventArgs e)
        {
            
                timerTSample.Start();
                if (clickBtnPLC == false)
                {
                    clickBtnPLC = true;
                    flagPLCSIM = 0;
                    btnConnectPLCSIM.Enabled = false;
                    btnConnectPLC.Text = "HỦY KẾT NỐI";
                    myPLC = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
                    myPLC.Open();
                    txtErrorCode.Text = myPLC.Open().ToString();
                    flagPLC = 1;
                }
                else
                {
                    timerTSample.Stop();
                    clickBtnPLC = false;
                    flagPLC = 2;
                    btnConnectPLCSIM.Enabled = true;
                    btnConnectPLC.Text = "KẾT NỐI";
                    myPLC.Close();

                }
            
        }

        private void btnConnectBroker_Click(object sender, EventArgs e)
        {
            strBrokerAddress = txtBrokerAddress.Text;
            strPort = txtPort.Text;
            strUsername = txtUsername.Text;
            strPassword = txtPassword.Text;

            if (clickBtnBroker == false)
            {
                desktopAppClient = new MqttClient(strBrokerAddress);
                string clientId = Guid.NewGuid().ToString();
                desktopAppClient.Connect(clientId, strUsername, strPassword);//Cần kiểm tra đã kết nối đc chưa mới làm các bước sau
                if (desktopAppClient.IsConnected)
                {
                    desktopAppClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    desktopAppClient.Subscribe(new string[] { "ARAPP_VPS" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    clickBtnBroker = true;
                    lblNotifyConnectBroker.Text = "Kết nối thành công!";
                    btnConnectBroker.Text = "HỦY KẾT NỐI";
                    timerMQTT.Start();
                }    
            }    
            else
            {
                clickBtnBroker = false;
                desktopAppClient.Disconnect();
                lblNotifyConnectBroker.Text = "Kết nối không thành công!";
                btnConnectBroker.Text = "KẾT NỐI";
            }    
            
        }

        private void btnSubmitID_Click(object sender, EventArgs e)
        {
            strID = txtID.Text;
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            //string[] msg_receive = Encoding.UTF8.GetString(e.Message).Split(':');
            msgReceive = Encoding.UTF8.GetString(e.Message);
            //msg_split = msg_receive[1];
            //textBox_Rev.Invoke((MethodInvoker)(() => textBox_Rev.Text = UGT524str)); // hiển thị message tự động lên textbox
            
            //textBox_Rev.Invoke((MethodInvoker)(() => textBox_Rev.Text = msg_receive));
        }

        //private void btn_mos_pub_Click(object sender, EventArgs e)
        //{
        //    DA_Client.Publish("DA_Pub_Mos", Encoding.UTF8.GetBytes("DA_GUI_DU_LIEU"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        //}

        private void timerConnect_Tick(object sender, EventArgs e)
        {
            if (flagPLCSIM == 1 || flagPLCSIM == 2)
            {
                if (myPLC.IsConnected)
                {
                    prgConnectPLCSIM.Value = 100;
                }
                else
                {
                    prgConnectPLCSIM.Value = 0;
                }
            }

            if (flagPLC == 1 || flagPLC == 2)
            {
                if (myPLC.IsConnected)
                {
                    prgConnectPLC.Value = 100;
                }
                else
                {
                    prgConnectPLC.Value = 0;
                }
            }
        }
        private string GetIPAddress()
        {
            string IPAddress = string.Empty;
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
