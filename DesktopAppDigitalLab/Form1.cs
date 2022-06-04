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
using System.Threading;
using DataClass;
using DataItems;
namespace DesktopAppDigitalLab
{
    public partial class Form1 : Form
    {
        public MqttClient desktopAppClient;
        public Plc myPLC;
        public string strID, strIPPC, strIPPLC, strBrokerAddress, strPort, strUsername, strPassword;
        public string jsonSubscribe;
        public string jsonPublish = "NaN";
        public string topicARAppToDA, topicDAToARApp;
        public bool brokerIsConnect, clickBtnPLCSIM, clickBtnPLC;
        public int flagPLCSIM, flagPLC;
        public bool writeSPRealValiPLC, writeSPSimulateValiPLC, writeConfig, writeSPRealInverter, writeOnOffRealInverter, writeSPSiInverter, writeOnOffSiInverter;

        public DataDAToValiIFM DataDAToValiIFMObj = new DataDAToValiIFM();
        public DataDAToValiPLC DataDAToValiPLCObj = new DataDAToValiPLC();
        public DataDAToInverter DataDAToInverterObj = new DataDAToInverter();
        public DataValiIFMToDA DataValiIFMToDAObj = new DataValiIFMToDA();
        public DataValiPLCToDA DataValiPLCToDAObj = new DataValiPLCToDA();

        public DataValueDAToRValiIFM DataValueDAToRValiIFMObj = new DataValueDAToRValiIFM();
        public DataConfParaDAToRValiIFM DataConfParaDAToRValiIFMObj = new DataConfParaDAToRValiIFM();
        public DataDAToRValiPLC DataDAToRValiPLCObj = new DataDAToRValiPLC();
        public DataDAToRInverter DataDAToRInverterObj = new DataDAToRInverter();
        public DataRValiPLCToDA DataRValiPLCToDAObj = new DataRValiPLCToDA();
        public DataInverterToDA DataInverterToDAObj = new DataInverterToDA();

        public DataSetSPValiPLCToDA DataSetSPValiPLCToDAObj = new DataSetSPValiPLCToDA();
        public DataButtonReadConfigValiIFM DataButtonReadConfigValiIFMObj = new DataButtonReadConfigValiIFM();
        public DataSetSPRInverter DataSetSPRInverterObj = new DataSetSPRInverter();
        public DataSetOnOffRInverter DataSetOnOffRInverterObj = new DataSetOnOffRInverter();

        public DataSetSPInverter DataSetSPInverterObj = new DataSetSPInverter();
        public DataSetOnOffInverter DataSetOnOffInverterObj = new DataSetOnOffInverter();

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

            topicDAToARApp = "DAToARApp: ID = " + txtID.Text;
            topicARAppToDA = "ARAppToDA: ID = " + txtID.Text;
            timerConnect.Start();

            //-------------------------------------------------------------Write PLCSIM
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.w0UGTItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.w1UGTItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.w0IFItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.w0TWItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.w1TWItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.w0RBItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.outO5CItem);
            DataItemsWritePLCSIMValiIFM.Add(DataItems.DataItems.outKTItem);

            DataItemsWritePLCSIMValiPLC.Add(DataItems.DataItems.DI);
            DataItemsWritePLCSIMValiPLC.Add(DataItems.DataItems.AI);
            DataItemsWritePLCSIMValiPLC.Add(DataItems.DataItems.LS1);
            DataItemsWritePLCSIMValiPLC.Add(DataItems.DataItems.LS2);

            DataSetSPItemWritePLCSIMValiPLC.Add(DataItems.DataItems.setPosSP);
            DataSetSPItemWritePLCSIMValiPLC.Add(DataItems.DataItems.setVelSP);


            //--------------------------------------------------------------Read PLCSIM
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.idConfigItem);
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.disUGTItem);
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.disIFItem);
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.temTWItem);
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.angleRBItem);
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.byte65Item);
            DataItemsReadPLCSIMValiIFM.Add(DataItems.DataItems.byte67Item);

            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.DO);
            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.AO);
            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.velSP);
            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.vel);
            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.posSP);
            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.pos);
            DataItemsReadPLCSIMValiPLC.Add(DataItems.DataItems.posHome);


            //--------------------------------------------------------------Read PLC
            //Read values ValiIFM
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.w0UGT);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.w1UGT);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.w0IF);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.disIF);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.w0TW);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.w1TW);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.temTW);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.w0RB);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.angleRB);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.byte65);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.byte67);
            DataItemReadPLCValueRValiIFM.Add(DataItems.DataItems.byte68);


            //Read config parameters ValiIFM
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP1SSC1UGT);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP2SSC1UGT);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP1SSC2UGT);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP2SSC2UGT);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP1SSC1IF);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP2SSC1IF);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP1SSC2IF);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP2SSC2IF);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.SP1TW2000);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.rP1TW2000);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.rSLTRB3100);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.cDirRB3100);
            DataItemReadPLCConfParaRValiIFM.Add(DataItems.DataItems.OUT_ENCRB);

            //Read value ValiPLC
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realDI);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realDO);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realAI);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realAO);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realVelSP);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realVel);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realPosSP);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realPos);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realVelEnc);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realPosEnc);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realLS1);
            DataItemReadPLCValiPLC.Add(DataItems.DataItems.realLS2);

            //Read value Inverter
            DataItemReadPLCInverter.Add(DataItems.DataItems.realOnOff);
            DataItemReadPLCInverter.Add(DataItems.DataItems.realVelSPG120);
            DataItemReadPLCInverter.Add(DataItems.DataItems.realVelG120);


            //---------------------------------------------------------------Write PLC
            DataItemWritePLCValiPLC.Add(DataItems.DataItems.setRealPosSP);
            DataItemWritePLCValiPLC.Add(DataItems.DataItems.setRealVelSP);

            DataItemButtonReadConfigValiIFM.Add(DataItems.DataItems.readConfigItem);

            DataSetSPItemWritePLCInverter.Add(DataItems.DataItems.setRealVelSPG120);
            DataSetOnOffItemWritePLCInverter.Add(DataItems.DataItems.setRealOnOffG120);

            DataItemReadPLCSIMInverter.Add(DataItems.DataItems.siOnOffG120);
            DataItemReadPLCSIMInverter.Add(DataItems.DataItems.siVelSPG120);
            DataItemReadPLCSIMInverter.Add(DataItems.DataItems.siVelG120);

            DataSetSPItemWritePLCSIMInverter.Add(DataItems.DataItems.setSiVelSPG120);
            DataSetOnOffItemWritePLCSIMInverter.Add(DataItems.DataItems.setSiOnOffG120);

            DataItemWritePLCSIMInverter.Add(DataItems.DataItems.writeVelG120);


        }

        //List Data

        private static readonly List<DataItem> DataItemsWritePLCSIMValiIFM = new List<DataItem>();
        private static readonly List<DataItem> DataItemsReadPLCSIMValiIFM = new List<DataItem>();
        private static readonly List<DataItem> DataItemsWritePLCSIMValiPLC = new List<DataItem>();
        private static readonly List<DataItem> DataItemsReadPLCSIMValiPLC = new List<DataItem>();

        //private static List<DataItem> dataItemReadPLC = new List<DataItem>();

        private static readonly List<DataItem> DataItemReadPLCValueRValiIFM = new List<DataItem>();
        private static readonly List<DataItem> DataItemReadPLCConfParaRValiIFM = new List<DataItem>();
        private static readonly List<DataItem> DataItemReadPLCValiPLC = new List<DataItem>();
        private static readonly List<DataItem> DataItemWritePLCValiPLC = new List<DataItem>();
        private static readonly List<DataItem> DataSetSPItemWritePLCSIMValiPLC = new List<DataItem>();
        private static readonly List<DataItem> DataItemButtonReadConfigValiIFM = new List<DataItem>();
        private static readonly List<DataItem> DataItemReadPLCInverter = new List<DataItem>();
        private static readonly List<DataItem> DataSetSPItemWritePLCInverter = new List<DataItem>();
        private static readonly List<DataItem> DataSetOnOffItemWritePLCInverter = new List<DataItem>();

        private static readonly List<DataItem> DataItemReadPLCSIMInverter = new List<DataItem>();
        private static readonly List<DataItem> DataSetSPItemWritePLCSIMInverter = new List<DataItem>();
        private static readonly List<DataItem> DataSetOnOffItemWritePLCSIMInverter = new List<DataItem>();
        private static readonly List<DataItem> DataItemWritePLCSIMInverter = new List<DataItem>();


        //Timer
        private async void TimerReadPLCSIM_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                try
                {
                    await myPLC.ReadMultipleVarsAsync(DataItemsReadPLCSIMValiIFM);
                    ushort idConfig = (ushort)DataItemsReadPLCSIMValiIFM[0].Value;
                    DataDAToValiIFMObj.disUGT = (ushort)DataItemsReadPLCSIMValiIFM[1].Value;
                    DataDAToValiIFMObj.disIF = ((uint)DataItemsReadPLCSIMValiIFM[2].Value).ConvertToFloat();
                    DataDAToValiIFMObj.temTW = ((uint)DataItemsReadPLCSIMValiIFM[3].Value).ConvertToFloat();
                    DataDAToValiIFMObj.angleRB = ((uint)DataItemsReadPLCSIMValiIFM[4].Value).ConvertToFloat();
                    DataDAToValiIFMObj.byte65 = ((byte)DataItemsReadPLCSIMValiIFM[5].Value);
                    DataDAToValiIFMObj.byte67 = ((byte)DataItemsReadPLCSIMValiIFM[6].Value);
                    #region IDCONFIG
                    if (idConfig == 1)
                    {
                        DataDAToValiIFMObj.SP1SSC1UGT = ((ushort)await myPLC.ReadAsync("DB1000.DBW0"));
                    }
                    else if (idConfig == 2)
                    {
                        DataDAToValiIFMObj.SP2SSC1UGT = ((ushort)await myPLC.ReadAsync("DB1000.DBW2"));
                    }
                    else if (idConfig == 3)
                    {
                        DataDAToValiIFMObj.SP1SSC2UGT = ((ushort)await myPLC.ReadAsync("DB1000.DBW4"));
                    }
                    else if (idConfig == 4)
                    {
                        DataDAToValiIFMObj.SP2SSC2UGT = ((ushort)await myPLC.ReadAsync("DB1000.DBW6"));
                    }
                    else if (idConfig == 5)
                    {
                        DataDAToValiIFMObj.SP1SSC1IF = ((ushort)await myPLC.ReadAsync("DB1000.DBW8"));
                    }
                    else if (idConfig == 6)
                    {
                        DataDAToValiIFMObj.SP2SSC1IF = ((ushort)await myPLC.ReadAsync("DB1000.DBW10"));
                    }
                    else if (idConfig == 7)
                    {
                        DataDAToValiIFMObj.SP1SSC2IF = ((ushort)await myPLC.ReadAsync("DB1000.DBW12"));
                    }
                    else if (idConfig == 8)
                    {
                        DataDAToValiIFMObj.SP2SSC2IF = ((ushort)await myPLC.ReadAsync("DB1000.DBW14"));
                    }
                    else if (idConfig == 9)
                    {
                        DataDAToValiIFMObj.SP1TW2000 = ((ushort)await myPLC.ReadAsync("DB1000.DBW16"));
                    }
                    else if (idConfig == 10)
                    {
                        DataDAToValiIFMObj.rP1TW2000 = ((ushort)await myPLC.ReadAsync("DB1000.DBW18"));
                    }
                    else if (idConfig == 11)
                    {
                        DataDAToValiIFMObj.rSLTRB3100 = ((ushort)await myPLC.ReadAsync("DB1000.DBW20"));
                    }
                    else if (idConfig == 12)
                    {
                        DataDAToValiIFMObj.cDirRB3100 = ((byte)myPLC.Read("DB1000.DBB22"));
                    }
                    else if (idConfig == 13)
                    {
                        DataDAToValiIFMObj.OUT_ENCRB = ((byte)myPLC.Read("DB1000.DBB23"));

                    }
                    #endregion
                    await myPLC.ReadMultipleVarsAsync(DataItemsReadPLCSIMValiPLC);
                    DataDAToValiPLCObj.DO = (byte)DataItemsReadPLCSIMValiPLC[0].Value;
                    DataDAToValiPLCObj.AO = (ushort)DataItemsReadPLCSIMValiPLC[1].Value;
                    DataDAToValiPLCObj.velSP = (float)DataItemsReadPLCSIMValiPLC[2].Value;
                    DataDAToValiPLCObj.vel = (float)DataItemsReadPLCSIMValiPLC[3].Value;
                    DataDAToValiPLCObj.posSP = (float)DataItemsReadPLCSIMValiPLC[4].Value;
                    DataDAToValiPLCObj.pos = (float)DataItemsReadPLCSIMValiPLC[5].Value;
                    DataDAToValiPLCObj.posHome = (float)DataItemsReadPLCSIMValiPLC[6].Value;

                    await myPLC.ReadMultipleVarsAsync(DataItemReadPLCSIMInverter);
                    DataDAToInverterObj.onOffG120 = (ushort)DataItemReadPLCSIMInverter[0].Value;
                    DataDAToInverterObj.velSPG120 = (ushort)DataItemReadPLCSIMInverter[1].Value;
                    DataDAToInverterObj.velG120 = (ushort)DataItemReadPLCSIMInverter[2].Value;

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }

            }



        }

        private async void TimerWritePLCSIM_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                try
                {
                    DataItems.DataItems.w0UGTItem.Value = (ushort)DataValiIFMToDAObj.w0UGT;
                    DataItems.DataItems.w1UGTItem.Value = (ushort)DataValiIFMToDAObj.w1UGT;
                    DataItems.DataItems.w0IFItem.Value = (ushort)DataValiIFMToDAObj.w0IF;
                    DataItems.DataItems.w0TWItem.Value = (ushort)DataValiIFMToDAObj.w0TW;
                    DataItems.DataItems.w1TWItem.Value = (ushort)DataValiIFMToDAObj.w1TW;
                    DataItems.DataItems.w0RBItem.Value = (ushort)DataValiIFMToDAObj.w0RB;
                    DataItems.DataItems.outKTItem.Value = DataValiIFMToDAObj.outKT;
                    DataItems.DataItems.outO5CItem.Value = DataValiIFMToDAObj.outO5C;

                    await myPLC.WriteAsync(DataItemsWritePLCSIMValiIFM.ToArray());

                    DataItems.DataItems.DI.Value = (byte)DataValiPLCToDAObj.DI;
                    DataItems.DataItems.AI.Value = (ushort)DataValiPLCToDAObj.AI;
                    DataItems.DataItems.LS1.Value = (bool)DataValiPLCToDAObj.LS1;
                    DataItems.DataItems.LS2.Value = (bool)DataValiPLCToDAObj.LS2;
                    await myPLC.WriteAsync(DataItemsWritePLCSIMValiPLC.ToArray());

                    DataItems.DataItems.writeVelG120.Value = (ushort)DataInverterToDAObj.velG120;
                    await myPLC.WriteAsync(DataItemWritePLCSIMInverter.ToArray());

                    if (writeSPSimulateValiPLC == true)
                    {
                        DataItems.DataItems.setPosSP.Value = (float)DataSetSPValiPLCToDAObj.siPosSP;//
                        DataItems.DataItems.setVelSP.Value = (float)DataSetSPValiPLCToDAObj.siVelSP;//
                        await myPLC.WriteAsync(DataSetSPItemWritePLCSIMValiPLC.ToArray());
                        writeSPSimulateValiPLC = false;
                    }

                    if (writeSPSiInverter == true)
                    {
                        DataItems.DataItems.setSiVelSPG120.Value = (ushort)DataSetSPInverterObj.siVelSetSPG120;
                        await myPLC.WriteAsync(DataSetSPItemWritePLCSIMInverter.ToArray());
                        writeSPSiInverter = false;
                    }

                    if (writeOnOffSiInverter == true)
                    {
                        DataItems.DataItems.setSiOnOffG120.Value = (ushort)DataSetOnOffInverterObj.siOnOffSetG120;
                        await myPLC.WriteAsync(DataSetOnOffItemWritePLCSIMInverter.ToArray());
                        writeOnOffSiInverter = false;
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);

                }
            }

        }

        private async void TimerReadPLC_Tick(object sender, EventArgs e)
        {

            if (myPLC.IsConnected)
            {

                try
                {
                    await myPLC.ReadMultipleVarsAsync(DataItemReadPLCValueRValiIFM);
                    await myPLC.ReadMultipleVarsAsync(DataItemReadPLCConfParaRValiIFM);
                    await myPLC.ReadMultipleVarsAsync(DataItemReadPLCValiPLC);
                    await myPLC.ReadMultipleVarsAsync(DataItemReadPLCInverter);

                    DataValueDAToRValiIFMObj.w0UGT = (ushort)DataItemReadPLCValueRValiIFM[0].Value;
                    DataValueDAToRValiIFMObj.w1UGT = (ushort)DataItemReadPLCValueRValiIFM[1].Value;
                    DataValueDAToRValiIFMObj.w0IF = (ushort)DataItemReadPLCValueRValiIFM[2].Value;
                    DataValueDAToRValiIFMObj.disIF = ((uint)DataItemReadPLCValueRValiIFM[3].Value).ConvertToFloat();
                    DataValueDAToRValiIFMObj.w0TW = (ushort)DataItemReadPLCValueRValiIFM[4].Value;
                    DataValueDAToRValiIFMObj.w1TW = (ushort)DataItemReadPLCValueRValiIFM[5].Value;
                    DataValueDAToRValiIFMObj.temTW = ((uint)DataItemReadPLCValueRValiIFM[6].Value).ConvertToFloat();
                    DataValueDAToRValiIFMObj.w0RB = (ushort)DataItemReadPLCValueRValiIFM[7].Value;
                    DataValueDAToRValiIFMObj.angleRB = ((uint)DataItemReadPLCValueRValiIFM[8].Value).ConvertToFloat();
                    DataValueDAToRValiIFMObj.byte65 = (byte)DataItemReadPLCValueRValiIFM[9].Value;
                    DataValueDAToRValiIFMObj.byte67 = (byte)DataItemReadPLCValueRValiIFM[10].Value;
                    DataValueDAToRValiIFMObj.byte68 = (byte)DataItemReadPLCValueRValiIFM[11].Value;
                    //Lệnh Read nhiều biến chỉ đọc được thêm khoảng 3 Word nữa, nhiều hơn sẽ báo lỗi


                    DataConfParaDAToRValiIFMObj.SP1SSC1UGT = (ushort)DataItemReadPLCConfParaRValiIFM[0].Value;
                    DataConfParaDAToRValiIFMObj.SP2SSC1UGT = (ushort)DataItemReadPLCConfParaRValiIFM[1].Value;
                    DataConfParaDAToRValiIFMObj.SP1SSC2UGT = (ushort)DataItemReadPLCConfParaRValiIFM[2].Value;
                    DataConfParaDAToRValiIFMObj.SP2SSC2UGT = (ushort)DataItemReadPLCConfParaRValiIFM[3].Value;
                    DataConfParaDAToRValiIFMObj.SP1SSC1IF = (ushort)DataItemReadPLCConfParaRValiIFM[4].Value;
                    DataConfParaDAToRValiIFMObj.SP2SSC1IF = (ushort)DataItemReadPLCConfParaRValiIFM[5].Value;
                    DataConfParaDAToRValiIFMObj.SP1SSC2IF = (ushort)DataItemReadPLCConfParaRValiIFM[6].Value;
                    DataConfParaDAToRValiIFMObj.SP2SSC2IF = (ushort)DataItemReadPLCConfParaRValiIFM[7].Value;
                    DataConfParaDAToRValiIFMObj.SP1TW2000 = (ushort)DataItemReadPLCConfParaRValiIFM[8].Value;
                    DataConfParaDAToRValiIFMObj.rP1TW2000 = (ushort)DataItemReadPLCConfParaRValiIFM[9].Value;
                    DataConfParaDAToRValiIFMObj.rSLTRB3100 = (ushort)DataItemReadPLCConfParaRValiIFM[10].Value;
                    DataConfParaDAToRValiIFMObj.cDirRB3100 = (byte)DataItemReadPLCConfParaRValiIFM[11].Value;
                    DataConfParaDAToRValiIFMObj.OUT_ENCRB = (byte)DataItemReadPLCConfParaRValiIFM[12].Value;


                    DataDAToRValiPLCObj.DI = (byte)DataItemReadPLCValiPLC[0].Value;
                    DataDAToRValiPLCObj.DO = (byte)DataItemReadPLCValiPLC[1].Value;
                    DataDAToRValiPLCObj.AI = (ushort)DataItemReadPLCValiPLC[2].Value;
                    DataDAToRValiPLCObj.AO = (ushort)DataItemReadPLCValiPLC[3].Value;
                    DataDAToRValiPLCObj.velSP = (float)DataItemReadPLCValiPLC[4].Value;
                    DataDAToRValiPLCObj.vel = (float)DataItemReadPLCValiPLC[5].Value;
                    DataDAToRValiPLCObj.posSP = (float)DataItemReadPLCValiPLC[6].Value;
                    DataDAToRValiPLCObj.pos = (float)DataItemReadPLCValiPLC[7].Value;
                    DataDAToRValiPLCObj.velEnc = (float)DataItemReadPLCValiPLC[8].Value;
                    DataDAToRValiPLCObj.posEnc = (float)DataItemReadPLCValiPLC[9].Value;
                    DataDAToRValiPLCObj.LS1 = (bool)DataItemReadPLCValiPLC[10].Value;
                    DataDAToRValiPLCObj.LS2 = (bool)DataItemReadPLCValiPLC[11].Value;

                    DataDAToRInverterObj.onOffG120 = (ushort)DataItemReadPLCInverter[0].Value;
                    DataDAToRInverterObj.velSPG120 = (ushort)DataItemReadPLCInverter[1].Value;
                    DataDAToRInverterObj.velG120 = (ushort)DataItemReadPLCInverter[2].Value;

                }
                catch (Exception ex3)
                {
                    MessageBox.Show(ex3.Message);
                }

            }
        }

        private async void TimerWritePLC_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                try
                {
                    DataItems.DataItems.w0UGTItem.Value = (ushort)DataValiIFMToDAObj.w0UGT;
                    DataItems.DataItems.w1UGTItem.Value = (ushort)DataValiIFMToDAObj.w1UGT;
                    DataItems.DataItems.w0IFItem.Value = (ushort)DataValiIFMToDAObj.w0IF;
                    DataItems.DataItems.w0TWItem.Value = (ushort)DataValiIFMToDAObj.w0TW;
                    DataItems.DataItems.w1TWItem.Value = (ushort)DataValiIFMToDAObj.w1TW;
                    DataItems.DataItems.w0RBItem.Value = (ushort)DataValiIFMToDAObj.w0RB;
                    DataItems.DataItems.outKTItem.Value = DataValiIFMToDAObj.outKT;
                    DataItems.DataItems.outO5CItem.Value = DataValiIFMToDAObj.outO5C;

                    await myPLC.WriteAsync(DataItemsWritePLCSIMValiIFM.ToArray());


                    //Write vào ValiPLC thật
                    if (writeSPRealValiPLC == true)
                    {
                        DataItems.DataItems.setRealPosSP.Value = (float)DataRValiPLCToDAObj.posSP;
                        DataItems.DataItems.setRealVelSP.Value = (float)DataRValiPLCToDAObj.velSP;
                        await myPLC.WriteAsync(DataItemWritePLCValiPLC.ToArray());
                        writeSPRealValiPLC = false;
                    }
                    if (writeConfig == true)
                    {
                        DataItems.DataItems.readConfigItem.Value = (bool)DataButtonReadConfigValiIFMObj.readConfig;
                        await myPLC.WriteAsync(DataItemButtonReadConfigValiIFM.ToArray());
                        writeConfig = false;
                    }
                    if (writeSPRealInverter == true)
                    {
                        DataItems.DataItems.setRealVelSPG120.Value = (ushort)DataSetSPRInverterObj.velSetSPG120;
                        await myPLC.WriteAsync(DataSetSPItemWritePLCInverter.ToArray());
                        writeSPRealInverter = false;
                    }
                    if (writeOnOffRealInverter == true)
                    {
                        DataItems.DataItems.setRealOnOffG120.Value = (ushort)DataSetOnOffRInverterObj.onOffSetG120;
                        await myPLC.WriteAsync(DataSetOnOffItemWritePLCInverter.ToArray());
                        writeOnOffRealInverter = false;
                    }
                }
                catch (Exception ex4)
                {
                    MessageBox.Show(ex4.Message);
                }
            }
        }

        private void TimerMQTT_Tick(object sender, EventArgs e)
        {
            if (desktopAppClient.IsConnected)
            {
                if (clickBtnPLCSIM == true)
                {
                    jsonPublish = JsonConvert.SerializeObject(DataDAToValiIFMObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToValiPLCObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToInverterObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                }
                else if (clickBtnPLC == true)
                {
                    jsonPublish = JsonConvert.SerializeObject(DataValueDAToRValiIFMObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataConfParaDAToRValiIFMObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToRValiPLCObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToRInverterObj);
                    desktopAppClient.Publish(topicDAToARApp, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
            }

        }

        private void TimerConnect_Tick(object sender, EventArgs e)
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
        private async void BtnConnectPLCSIM_Click(object sender, EventArgs e)
        {
            //timerReadPLCSIM.Start();
            //timerWritePLCSIM.Start();
            if (clickBtnPLCSIM == false)
            {
                timerReadPLCSIM.Start();
                timerWritePLCSIM.Start();//Sua
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
                timerReadPLCSIM.Stop();
                timerWritePLCSIM.Stop();
                clickBtnPLCSIM = false;
                flagPLCSIM = 2;
                btnConnectPLC.Visible = true;
                btnConnectPLCSIM.Text = "KẾT NỐI";
                myPLC.Close();

            }
        }

        private async void BtnConnectPLC_Click(object sender, EventArgs e)
        {

            //timerReadPLC.Start();
            //timerWritePLC.Start();

            if (clickBtnPLC == false)
            {
                timerReadPLC.Start();
                timerWritePLC.Start();//Sua
                clickBtnPLC = true;
                flagPLCSIM = 0;
                btnConnectPLCSIM.Visible = false;
                btnConnectPLC.Text = "HỦY";
                myPLC = new Plc(CpuType.S71200, "192.168.0.1", 0, 1);
                try
                {
                    await myPLC.OpenAsync();
                    //timerReadPLC.Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                flagPLC = 1;
            }
            else
            {

                clickBtnPLC = false;
                flagPLC = 2;
                btnConnectPLCSIM.Visible = true;
                btnConnectPLC.Text = "KẾT NỐI";
                myPLC.Close();
                timerReadPLC.Stop();
                timerWritePLC.Stop();

            }

        }

        private void BtnConnectBroker_Click(object sender, EventArgs e)
        {
            strBrokerAddress = txtBrokerAddress.Text;
            strPort = txtPort.Text;
            strUsername = txtUsername.Text;
            strPassword = txtPassword.Text;

            if (brokerIsConnect == false)
            {
                desktopAppClient = new MqttClient(strBrokerAddress);
                string clientId = Guid.NewGuid().ToString();
                try
                {
                    desktopAppClient.Connect(clientId, strUsername, strPassword);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (desktopAppClient.IsConnected)
                {
                    desktopAppClient.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                    //desktopAppClient.Subscribe(new string[] { topicARAppToDA }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    SubscribeTopic();
                    brokerIsConnect = true;
                    lblNotifyConnectBroker.Text = "   Kết nối thành công!";
                    picConnectBrokerON.Visible = true;
                    picConnectBrokerOFF.Visible = false;
                    btnConnectBroker.Text = "HỦY";
                    timerMQTT.Start();
                }
            }
            else
            {
                brokerIsConnect = false;
                desktopAppClient.Disconnect();
                lblNotifyConnectBroker.Text = "Kết nối không thành công!";
                picConnectBrokerON.Visible = false;
                picConnectBrokerOFF.Visible = true;
                btnConnectBroker.Text = "KẾT NỐI";
                timerMQTT.Stop();//Sua
            }

        }

        private void BtnSubmitID_Click(object sender, EventArgs e)
        {
            strID = txtID.Text;
            lblID.Text = strID;
            topicDAToARApp = "DAToARApp: ID = " + txtID.Text;
            topicARAppToDA = "ARAppToDA: ID = " + txtID.Text;
            SubscribeTopic();
        }

        private void PicEyeOff_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picEyeOff.Visible = false;
            picEyeOn.Visible = true;
        }

        private void PicEyeOn_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picEyeOff.Visible = true;
            picEyeOn.Visible = false;
        }



        //Function
        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            jsonSubscribe = Encoding.UTF8.GetString(e.Message);
            if (jsonSubscribe != null)
            {
                if (jsonSubscribe.Contains("idV4"))
                {
                    DataValiIFMToDAObj = JsonConvert.DeserializeObject<DataValiIFMToDA>(jsonSubscribe);
                }
                else if (jsonSubscribe.Contains("idV5"))
                {
                    DataValiPLCToDAObj = JsonConvert.DeserializeObject<DataValiPLCToDA>(jsonSubscribe);
                }
                else if (jsonSubscribe.Contains("idV6"))
                {
                    DataSetSPValiPLCToDAObj = JsonConvert.DeserializeObject<DataSetSPValiPLCToDA>(jsonSubscribe);
                    writeSPSimulateValiPLC = true;
                }
                else if (jsonSubscribe.Contains("idV7"))
                {
                    DataSetSPInverterObj = JsonConvert.DeserializeObject<DataSetSPInverter>(jsonSubscribe);
                    writeSPSiInverter = true;
                }
                else if (jsonSubscribe.Contains("idV8"))
                {
                    DataSetOnOffInverterObj = JsonConvert.DeserializeObject<DataSetOnOffInverter>(jsonSubscribe);
                    writeOnOffSiInverter = true;
                }
                else if (jsonSubscribe.Contains("idV9"))
                {
                    DataInverterToDAObj = JsonConvert.DeserializeObject<DataInverterToDA>(jsonSubscribe);
                }
                else if (jsonSubscribe.Contains("idR5"))
                {
                    DataRValiPLCToDAObj = JsonConvert.DeserializeObject<DataRValiPLCToDA>(jsonSubscribe);
                    writeSPRealValiPLC = true;
                }
                else if (jsonSubscribe.Contains("idR6"))
                {
                    DataButtonReadConfigValiIFMObj = JsonConvert.DeserializeObject<DataButtonReadConfigValiIFM>(jsonSubscribe);
                    writeConfig = true;
                }
                else if (jsonSubscribe.Contains("idR7"))
                {
                    DataSetSPRInverterObj = JsonConvert.DeserializeObject<DataSetSPRInverter>(jsonSubscribe);
                    writeSPRealInverter = true;
                }
                else if (jsonSubscribe.Contains("idR8"))
                {
                    DataSetOnOffRInverterObj = JsonConvert.DeserializeObject<DataSetOnOffRInverter>(jsonSubscribe);
                    writeOnOffRealInverter = true;
                }

                //Chưa có truyền từ AR App xuống Vali thật
            }
        }

        public void SubscribeTopic()
        {
            desktopAppClient.Subscribe(new string[] { topicARAppToDA }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        private string GetIPAddress()
        {
            string IPAddress = string.Empty;
            string Hostname = Environment.MachineName;
            IPHostEntry Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }
    }
}
