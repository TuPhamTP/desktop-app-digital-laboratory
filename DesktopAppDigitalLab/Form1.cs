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
using System.Net; //Read IP PC
using Newtonsoft.Json;

namespace DesktopAppDigitalLab
{
    public partial class Form1 : Form
    {
        public MqttClient desktopAppClient;
        public Plc myPLC;
        public string strID, strIPPC, strIPPLC, strBrokerAddress, strPort, strUsername, strPassword;
        public string msgValiIFMToDA;
        public string topicValiIFMtoDA, topicDAToValiIFM;
        public bool clickBtnBroker, clickBtnPLCSIM, clickBtnPLC;
        public int flagPLCSIM, flagPLC;
        public DataDAToValiIFM DataDesktopAppObj = new DataDAToValiIFM();
        public DataValiIFMToDA DataValiIFMToDAObj = new DataValiIFMToDA();
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

            topicDAToValiIFM = "DAToValiIFM: ID = " + txtID.Text;
            topicValiIFMtoDA = "ValiIFMToDA: ID = " + txtID.Text;
            timerConnect.Start();
            

            
        }

        //Class
        public class DataDAToValiIFM
        {
            public ushort SP1SSC1UGT = 300;
            public ushort SP2SSC1UGT = 40;
            public ushort SP1SSC2UGT = 300;
            public ushort SP2SSC2UGT = 40;

            public ushort SP1SSC1IF = 3800;
            public ushort SP2SSC1IF = 388;
            public ushort SP1SSC2IF = 3800;
            public ushort SP2SSC2IF = 388;

            public ushort SP1TW2000 = 2500;
            public ushort rP1TW2000 = 2300;

            public ushort rSLTRB3100 = 1024;
            public byte cDirRB3100 = 0;
            public byte OUT_ENCRB = 1;
        }
        public class DataValiIFMToDA
        {
            public short w0UGT, w1UGT, w0IF, w0TW, w1TW, w0RB;
            public bool outKT, outO5C;
        }

        //Timer
        private void timerTSample_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                ushort idConfig = ((ushort)myPLC.Read("DB1000.DBW24"));
                #region IDCONFIG
                if (idConfig == 1)
                {
                    DataDesktopAppObj.SP1SSC1UGT = ((ushort)myPLC.Read("DB1000.DBW0"));
                }
                else if (idConfig == 2)
                {
                    DataDesktopAppObj.SP2SSC1UGT = ((ushort)myPLC.Read("DB1000.DBW2"));
                }
                else if (idConfig == 3)
                {
                    DataDesktopAppObj.SP1SSC2UGT = ((ushort)myPLC.Read("DB1000.DBW4"));
                }
                else if (idConfig == 4)
                {
                    DataDesktopAppObj.SP2SSC2UGT = ((ushort)myPLC.Read("DB1000.DBW6"));
                }
                else if (idConfig == 5)
                {
                    DataDesktopAppObj.SP1SSC1IF = ((ushort)myPLC.Read("DB1000.DBW8"));
                }
                else if (idConfig == 6)
                {
                    DataDesktopAppObj.SP2SSC1IF = ((ushort)myPLC.Read("DB1000.DBW10"));
                }
                else if (idConfig == 7)
                {
                    DataDesktopAppObj.SP1SSC2IF = ((ushort)myPLC.Read("DB1000.DBW12"));
                }
                else if (idConfig == 8)
                {
                    DataDesktopAppObj.SP2SSC2IF = ((ushort)myPLC.Read("DB1000.DBW14"));
                }
                else if (idConfig == 9)
                {
                    DataDesktopAppObj.SP1TW2000 = ((ushort)myPLC.Read("DB1000.DBW16"));
                }
                else if (idConfig == 10)
                {
                    DataDesktopAppObj.rP1TW2000 = ((ushort)myPLC.Read("DB1000.DBW18"));
                }
                else if (idConfig == 11)
                {
                    DataDesktopAppObj.rSLTRB3100 = ((ushort)myPLC.Read("DB1000.DBW20"));
                }
                else if (idConfig == 12)
                {
                    DataDesktopAppObj.cDirRB3100 = ((byte)myPLC.Read("DB1000.DBB22"));
                }
                else if (idConfig == 13)
                {
                    DataDesktopAppObj.OUT_ENCRB = ((byte)myPLC.Read("DB1000.DBB23"));

                }
                #endregion

                myPLC.Write("MW93", DataValiIFMToDAObj.w0UGT.ConvertToUshort());
                myPLC.Write("MW95", DataValiIFMToDAObj.w1UGT.ConvertToUshort());
                myPLC.Write("MW90", DataValiIFMToDAObj.w0IF.ConvertToUshort());
                myPLC.Write("MW82", DataValiIFMToDAObj.w0TW.ConvertToUshort());
                myPLC.Write("MW84", DataValiIFMToDAObj.w1TW.ConvertToUshort());
                myPLC.Write("MW87", DataValiIFMToDAObj.w0RB.ConvertToUshort());
                myPLC.Write("M68.4", DataValiIFMToDAObj.outKT);
                myPLC.Write("M68.5", DataValiIFMToDAObj.outO5C);


            }



        }

        private void timerMQTT_Tick(object sender, EventArgs e)
        {
            jsonPublish = JsonConvert.SerializeObject(DataDesktopAppObj);
            if (desktopAppClient.IsConnected)
            {
                desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                if (msgValiIFMToDA != null)
                {
                    DataValiIFMToDAObj = Newtonsoft.Json.JsonConvert.DeserializeObject<DataValiIFMToDA>(msgValiIFMToDA);
                }    
                
            }
        }

        private void timerConnect_Tick(object sender, EventArgs e)
        {
            if (flagPLCSIM == 1 || flagPLCSIM == 2)
            {
                if (myPLC.IsConnected)
                {
                    lblNotifyConnectPLCSIM.Text = "   Kết nối thành công!";
                    picConnectPLCSIMOFF.Visible = false;
                    picConnectPLCSIMON.Visible = true;
                }
                else
                {
                    lblNotifyConnectPLCSIM.Text = "Kết nối không thành công!";
                    picConnectPLCSIMOFF.Visible = true;
                    picConnectPLCSIMON.Visible = false;
                }
            }

            if (flagPLC == 1 || flagPLC == 2)
            {
                if (myPLC.IsConnected)
                {
                    lblNotifyConnectPLC.Text = "   Kết nối thành công!";
                    picConnectPLCON.Visible = true;
                    picConnectPLCOFF.Visible = false;
                }
                else
                {
                    lblNotifyConnectPLC.Text = "Kết nối không thành công!";
                    picConnectPLCON.Visible = false;
                    picConnectPLCOFF.Visible = true;
                }
            }

        }

        //Button 
        private async void btnConnectPLCSIM_Click(object sender, EventArgs e)
        {
            timerTSample.Start();
            if (clickBtnPLCSIM == false)
            {
                clickBtnPLCSIM = true;
                flagPLC = 0;
                btnConnectPLC.Visible = false;
                btnConnectPLCSIM.Text = "HỦY";
                strIPPC = txtIPPC.Text;
                myPLC = new Plc(CpuType.S71200, strIPPC, 0, 1);
                try
                {
                    await myPLC.OpenAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                flagPLCSIM = 1;
            }
            else
            {
                timerTSample.Stop();
                clickBtnPLCSIM = false;
                flagPLCSIM = 2;
                btnConnectPLC.Visible = true;
                btnConnectPLCSIM.Text = "KẾT NỐI";
                myPLC.Close();

            }
        }

        private async void btnConnectPLC_Click(object sender, EventArgs e)
        {
            
                timerTSample.Start();
                if (clickBtnPLC == false)
                {
                    clickBtnPLC = true;
                    flagPLCSIM = 0;
                    btnConnectPLCSIM.Visible = false;
                    btnConnectPLC.Text = "HỦY";
                    myPLC = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
                try
                {
                    await myPLC.OpenAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                    
                    flagPLC = 1;
                }
                else
                {
                    timerTSample.Stop();
                    clickBtnPLC = false;
                    flagPLC = 2;
                    btnConnectPLCSIM.Visible = true;
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
                try
                {
                    desktopAppClient.Connect(clientId, strUsername, strPassword);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                if (desktopAppClient.IsConnected)
                {
                    desktopAppClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    desktopAppClient.Subscribe(new string[] { topicValiIFMtoDA }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    clickBtnBroker = true;
                    lblNotifyConnectBroker.Text = "   Kết nối thành công!";
                    picConnectBrokerON.Visible = true;
                    picConnectBrokerOFF.Visible = false;
                    btnConnectBroker.Text = "HỦY";
                    timerMQTT.Start();
                }    
            }    
            else
            {
                clickBtnBroker = false;
                desktopAppClient.Disconnect();
                lblNotifyConnectBroker.Text = "Kết nối không thành công!";
                picConnectBrokerON.Visible = false;
                picConnectBrokerOFF.Visible = true;
                btnConnectBroker.Text = "KẾT NỐI";
            }    
            
        }

        private void btnSubmitID_Click(object sender, EventArgs e)
        {
            strID = txtID.Text;
            lblID.Text = strID;
            topicDAToValiIFM = "DAToValiIFM: ID = " + txtID.Text;
            topicValiIFMtoDA = "ValiIFMToDA: ID = " + txtID.Text;
        }

        //Function
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            msgValiIFMToDA = Encoding.UTF8.GetString(e.Message);
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

        //Not use
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtErrorCode_TextChanged(object sender, EventArgs e)
        {

        }



        private void lblNotifyConnectBroker_Click(object sender, EventArgs e)
        {

        }
    }
}
