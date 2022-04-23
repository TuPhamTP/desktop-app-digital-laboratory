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

        public DataDAToValiIFM DataDAToValiIFMObj = new DataDAToValiIFM();
        public DataValiIFMToDA DataValiIFMToDAObj = new DataValiIFMToDA();

        //Write PLC
        public DataDAToValiReal DataDAToValiRealObj = new DataDAToValiReal();
        //Read PLC
        public DataValueRValiIFMToDA DataValueRValiIFMToDAObj = new DataValueRValiIFMToDA();
        public DataConfParaRValiIFMToDA DataConfParaRValiIFMToDAObj = new DataConfParaRValiIFMToDA();

        public string jsonPublish = "NaN";


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

            //Write PLCSIM
            dataItemsWritePLCSIM.Add(w0UGTItem);
            dataItemsWritePLCSIM.Add(w1UGTItem);
            dataItemsWritePLCSIM.Add(w0IFItem);
            dataItemsWritePLCSIM.Add(w0TWItem);
            dataItemsWritePLCSIM.Add(w1TWItem);
            dataItemsWritePLCSIM.Add(w0RBItem);
            dataItemsWritePLCSIM.Add(outO5CItem);
            dataItemsWritePLCSIM.Add(outKTItem);
            //Read PLCSIM
            dataItemsReadPLCSIM.Add(idConfigItem);
            dataItemsReadPLCSIM.Add(disUGTItem);
            dataItemsReadPLCSIM.Add(disIFItem);
            dataItemsReadPLCSIM.Add(temTWItem);
            dataItemsReadPLCSIM.Add(angleRBItem);
            dataItemsReadPLCSIM.Add(byte65Item);
            dataItemsReadPLCSIM.Add(byte67Item);

            //Read PLC
            //Read values ValiIFM
            DataItemReadValueRValiIFM.Add(w0UGT);
            DataItemReadValueRValiIFM.Add(w1UGT);
            DataItemReadValueRValiIFM.Add(w0IF);
            DataItemReadValueRValiIFM.Add(disIF);
            DataItemReadValueRValiIFM.Add(w0TW);
            DataItemReadValueRValiIFM.Add(w1TW);
            DataItemReadValueRValiIFM.Add(temTW);
            DataItemReadValueRValiIFM.Add(w0RB);
            DataItemReadValueRValiIFM.Add(angleRB);
            DataItemReadValueRValiIFM.Add(byte65);
            DataItemReadValueRValiIFM.Add(byte67);
            DataItemReadValueRValiIFM.Add(byte68);//
            DataItemReadValueRValiIFM.Add(byteSwitch);
            DataItemReadValueRValiIFM.Add(byteLight);

            //Read config parameters ValiIFM
            DataItemReadConfParaRValiIFM.Add(SP1SSC1UGT);
            DataItemReadConfParaRValiIFM.Add(SP2SSC1UGT);
            DataItemReadConfParaRValiIFM.Add(SP1SSC2UGT);
            DataItemReadConfParaRValiIFM.Add(SP2SSC2UGT);
            DataItemReadConfParaRValiIFM.Add(SP1SSC1IF);
            DataItemReadConfParaRValiIFM.Add(SP2SSC1IF);
            DataItemReadConfParaRValiIFM.Add(SP1SSC2IF);
            DataItemReadConfParaRValiIFM.Add(SP2SSC2IF);
            DataItemReadConfParaRValiIFM.Add(SP1TW2000);
            DataItemReadConfParaRValiIFM.Add(rP1TW2000);
            DataItemReadConfParaRValiIFM.Add(rSLTRB3100);
            DataItemReadConfParaRValiIFM.Add(cDirRB3100);
            DataItemReadConfParaRValiIFM.Add(OUT_ENCRB);
            //*/
            //Write PLC */

        }

        //Class & List Data
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

            public ushort disUGT = 0;
            public float disIF = 0;
            public float temTW = 0;
            public float angleRB = 0;
            public byte byte65 = 0, byte67 = 0;
        }
        public class DataValiIFMToDA
        {
            public short w0UGT, w1UGT, w0IF, w0TW, w1TW, w0RB;
            public bool outKT, outO5C;

        }

        public class DataValueRValiIFMToDA
        {
            public  byte id = 1;
            public ushort w0UGT = 0;
            public ushort w1UGT = 0;
            public ushort w0IF = 0;
            public float disIF = 0;
            public ushort w0TW = 0;
            public ushort w1TW = 0;
            public float temTW = 0;
            public ushort w0RB = 0;
            public float angleRB = 0;
            public byte byte65 = 0, byte67 = 5, byte68 = 0,byteSwitch = 0, byteLight = 0;

            //Analog input/output 
        }
        public class DataConfParaRValiIFMToDA
        {
            public byte id = 2;
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
            //*/
        }
        public class DataRValiPLCToDA
        {
            public byte id = 3;
            public byte DI = 0, DO = 0;
            public ushort AI = 0, AO = 0;
            public float velSP = 0, vel = 0, posSP = 0, pos = 0;

        }
        public class DataDAToValiReal
        {
            
        }


        private static List<DataItem> dataItemsWritePLCSIM = new List<DataItem>();

        //private static List<DataItem> dataItemReadPLC = new List<DataItem>();
        private static List<DataItem> DataItemReadValueRValiIFM = new List<DataItem>();
        private static List<DataItem> DataItemReadConfParaRValiIFM = new List<DataItem>();
        private static List<DataItem> dataItemWritePLC = new List<DataItem>();

        #region DataItemWritePLCSIM
        private static DataItem w0UGTItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 93,
            Value = new object()
        };
        private static DataItem w1UGTItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 95,
            Value = new object()
        };
        private static DataItem w0IFItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 90,
            Value = new object()
        };
        private static DataItem w0TWItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 82,
            Value = new object()
        };
        private static DataItem w1TWItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 84,
            Value = new object()
        };
        private static DataItem w0RBItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 87,
            Value = new object()
        };
        private static DataItem outKTItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 4,
            Count = 1,
            StartByteAdr = 68,
            Value = new object()
        };
        private static DataItem outO5CItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 5,
            Count = 1,
            StartByteAdr = 68,
            Value = new object()
        };
        #endregion

        #region DataItemReadPLCSIM
        private static List<DataItem> dataItemsReadPLCSIM = new List<DataItem>();
        private static DataItem idConfigItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 24,
            Value = new object()
        };
        private static DataItem disUGTItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 26,
            Value = new object()
        };
        private static DataItem disIFItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 28,
            Value = new object()
        };
        private static DataItem temTWItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 32,
            Value = new object()
        };
        private static DataItem angleRBItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 36,
            Value = new object()
        };
        private static DataItem byte65Item = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 65,
            Value = new object()
        };
        private static DataItem byte67Item = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 67,
            Value = new object()
        };
        #endregion

        #region DataItemWritePLC

        #endregion

        #region DataItemReadPLC

            #region ConfigParaRValiIFM
        private static DataItem SP1SSC1UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        private static DataItem SP2SSC1UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 2,
            Value = new object()
        };
        private static DataItem SP1SSC2UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 4,
            Value = new object()
        };
        private static DataItem SP2SSC2UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 6,
            Value = new object()
        };
        private static DataItem SP1SSC1IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 8,
            Value = new object()
        };
        private static DataItem SP2SSC1IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 10,
            Value = new object()
        };
        private static DataItem SP1SSC2IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 12,
            Value = new object()
        };
        private static DataItem SP2SSC2IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 14,
            Value = new object()
        };
        private static DataItem SP1TW2000 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 16,
            Value = new object()
        };
        private static DataItem rP1TW2000 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 18,
            Value = new object()
        };
        private static DataItem rSLTRB3100 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 20,
            Value = new object()
        };
        private static DataItem cDirRB3100 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Byte,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 22,
            Value = new object()
        };
        private static DataItem OUT_ENCRB = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Byte,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 23,
            Value = new object()
        };
        #endregion

            #region ValueRValiIFM
        private static DataItem w0UGT = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 93,
            Value = new object()
        };
        private static DataItem w1UGT = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 95,
            Value = new object()
        };
        private static DataItem w0IF = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 90,
            Value = new object()
        };
        private static DataItem disIF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 28,
            Value = new object()
        };
        private static DataItem w0TW = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 82,
            Value = new object()
        };
        private static DataItem w1TW = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 84,
            Value = new object()
        };
        private static DataItem temTW = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 32,
            Value = new object()
        };
        private static DataItem w0RB = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 87,
            Value = new object()
        };
        private static DataItem angleRB = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 36,
            Value = new object()
        };
        private static DataItem byte65 = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 65,
            Value = new object()
        };
        private static DataItem byte67 = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 67,
            Value = new object()
        };
        private static DataItem byte68 = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 68,
            Value = new object()
        };
        private static DataItem byteSwitch = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        private static DataItem byteLight = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        #endregion

        #endregion
        //Timer
        private async void timerReadPLCSIM_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                ushort idConfig = 0;
                try
                {
                    //myPLC.ReadMultipleVars(dataItemsReadPLCSIM);
                    await myPLC.ReadMultipleVarsAsync(dataItemsReadPLCSIM);
                    idConfig = (ushort)dataItemsReadPLCSIM[0].Value;
                    DataDAToValiIFMObj.disUGT = (ushort)dataItemsReadPLCSIM[1].Value;
                    DataDAToValiIFMObj.disIF = ((uint)dataItemsReadPLCSIM[2].Value).ConvertToFloat();
                    DataDAToValiIFMObj.temTW = ((uint)dataItemsReadPLCSIM[3].Value).ConvertToFloat();
                    DataDAToValiIFMObj.angleRB = ((uint)dataItemsReadPLCSIM[4].Value).ConvertToFloat();
                    DataDAToValiIFMObj.byte65 = ((byte)dataItemsReadPLCSIM[5].Value);
                    DataDAToValiIFMObj.byte67 = ((byte)dataItemsReadPLCSIM[6].Value);

                    //idConfig = ((ushort)await myPLC.ReadAsync("DB1000.DBW24"));

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
                }
                catch (Exception ex1)
                {
                    //MessageBox.Show(ex1.Message);
                }
                
            }



        }

        private async  void timerWritePLCSIM_Tick(object sender, EventArgs e)
        {
            if(myPLC.IsConnected)
            {
                try
                {
                    w0UGTItem.Value = (ushort)DataValiIFMToDAObj.w0UGT;
                    w1UGTItem.Value = (ushort)DataValiIFMToDAObj.w1UGT;
                    w0IFItem.Value = (ushort)DataValiIFMToDAObj.w0IF;
                    w0TWItem.Value = (ushort)DataValiIFMToDAObj.w0TW;
                    w1TWItem.Value = (ushort)DataValiIFMToDAObj.w1TW;
                    w0RBItem.Value = (ushort)DataValiIFMToDAObj.w0RB;
                    outKTItem.Value = DataValiIFMToDAObj.outKT;
                    outO5CItem.Value = DataValiIFMToDAObj.outO5C;

                    await myPLC.WriteAsync(dataItemsWritePLCSIM.ToArray());
                }
                catch (Exception ex2)
                {
                    //MessageBox.Show(ex2.Message);

                }
            }    
            
        }

        private async void timerReadPLC_Tick(object sender, EventArgs e)
        {
            
            if (myPLC.IsConnected)
            {
               
                try
                {
                    textBox1.Text = "Debug2";
                    await myPLC.ReadMultipleVarsAsync(DataItemReadValueRValiIFM);
                    await myPLC.ReadMultipleVarsAsync(DataItemReadConfParaRValiIFM);

                    DataValueRValiIFMToDAObj.w0UGT = (ushort)DataItemReadValueRValiIFM[0].Value;
                    DataValueRValiIFMToDAObj.w1UGT = (ushort)DataItemReadValueRValiIFM[1].Value;
                    DataValueRValiIFMToDAObj.w0IF = (ushort)DataItemReadValueRValiIFM[2].Value;
                    DataValueRValiIFMToDAObj.disIF = ((uint)DataItemReadValueRValiIFM[3].Value).ConvertToFloat();
                    DataValueRValiIFMToDAObj.w0TW = (ushort)DataItemReadValueRValiIFM[4].Value;
                    DataValueRValiIFMToDAObj.w1TW = (ushort)DataItemReadValueRValiIFM[5].Value;
                    DataValueRValiIFMToDAObj.temTW = ((uint)DataItemReadValueRValiIFM[6].Value).ConvertToFloat();
                    DataValueRValiIFMToDAObj.w0RB = (ushort)DataItemReadValueRValiIFM[7].Value;
                    DataValueRValiIFMToDAObj.angleRB = ((uint)DataItemReadValueRValiIFM[8].Value).ConvertToFloat();
                    DataValueRValiIFMToDAObj.byte65 = (byte)DataItemReadValueRValiIFM[9].Value;
                    DataValueRValiIFMToDAObj.byte67 = (byte)DataItemReadValueRValiIFM[10].Value;
                    DataValueRValiIFMToDAObj.byte67 = (byte)DataItemReadValueRValiIFM[11].Value;
                    DataValueRValiIFMToDAObj.byteSwitch = (byte)DataItemReadValueRValiIFM[12].Value;
                    DataValueRValiIFMToDAObj.byteLight = (byte)DataItemReadValueRValiIFM[13].Value;    
                    //Lệnh Read n' biến chỉ đọc được thêm khoảng 3 Word nữa, nhiều hơn sẽ báo lỗi

                    
                    DataConfParaRValiIFMToDAObj.SP1SSC1UGT = (ushort)DataItemReadConfParaRValiIFM[0].Value;
                    DataConfParaRValiIFMToDAObj.SP2SSC1UGT = (ushort)DataItemReadConfParaRValiIFM[1].Value;
                    DataConfParaRValiIFMToDAObj.SP1SSC2UGT = (ushort)DataItemReadConfParaRValiIFM[2].Value;
                    DataConfParaRValiIFMToDAObj.SP2SSC2UGT = (ushort)DataItemReadConfParaRValiIFM[3].Value;
                    DataConfParaRValiIFMToDAObj.SP1SSC1IF = (ushort)DataItemReadConfParaRValiIFM[4].Value;
                    DataConfParaRValiIFMToDAObj.SP2SSC1IF = (ushort)DataItemReadConfParaRValiIFM[5].Value;
                    DataConfParaRValiIFMToDAObj.SP1SSC2IF = (ushort)DataItemReadConfParaRValiIFM[6].Value;
                    DataConfParaRValiIFMToDAObj.SP2SSC2IF = (ushort)DataItemReadConfParaRValiIFM[7].Value;
                    DataConfParaRValiIFMToDAObj.SP1TW2000 = (ushort)DataItemReadConfParaRValiIFM[8].Value;
                    DataConfParaRValiIFMToDAObj.rP1TW2000 = (ushort)DataItemReadConfParaRValiIFM[9].Value;
                    DataConfParaRValiIFMToDAObj.rSLTRB3100 = (ushort)DataItemReadConfParaRValiIFM[10].Value;
                    DataConfParaRValiIFMToDAObj.cDirRB3100 = (byte)DataItemReadConfParaRValiIFM[11].Value;
                    DataConfParaRValiIFMToDAObj.OUT_ENCRB = (byte)DataItemReadConfParaRValiIFM[12].Value; 
                    
                }
                catch (Exception ex3)
                {
                    //MessageBox.Show(ex3.Message);
                    textBox1.Text = "Loi";
                }

            }
        }

        private async void timerWritePLC_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                try
                {
                    w0UGTItem.Value = (ushort)DataValiIFMToDAObj.w0UGT;
                    w1UGTItem.Value = (ushort)DataValiIFMToDAObj.w1UGT;
                    w0IFItem.Value = (ushort)DataValiIFMToDAObj.w0IF;
                    w0TWItem.Value = (ushort)DataValiIFMToDAObj.w0TW;
                    w1TWItem.Value = (ushort)DataValiIFMToDAObj.w1TW;
                    w0RBItem.Value = (ushort)DataValiIFMToDAObj.w0RB;
                    outKTItem.Value = DataValiIFMToDAObj.outKT;
                    outO5CItem.Value = DataValiIFMToDAObj.outO5C;

                    await myPLC.WriteAsync(dataItemsWritePLCSIM.ToArray());
                }
                catch (Exception ex4)
                {
                    //MessageBox.Show(ex4.Message);
                }
            }
        }

        private void timerMQTT_Tick(object sender, EventArgs e)
        {
            if (desktopAppClient.IsConnected)
            {
                if (clickBtnPLCSIM == true)
                {
                    jsonPublish = JsonConvert.SerializeObject(DataDAToValiIFMObj);
                }
                else if (clickBtnPLC == true)
                {
                    jsonPublish = JsonConvert.SerializeObject(DataValueRValiIFMToDAObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                    jsonPublish = JsonConvert.SerializeObject(DataConfParaRValiIFMToDAObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
            }    
                
            


            if (desktopAppClient.IsConnected)
            {
                //desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

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
            timerReadPLCSIM.Start();
            timerWritePLCSIM.Start();
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
                timerReadPLCSIM.Stop();
                timerWritePLCSIM.Stop();
                clickBtnPLCSIM = false;
                flagPLCSIM = 2;
                btnConnectPLC.Visible = true;
                btnConnectPLCSIM.Text = "KẾT NỐI";
                myPLC.Close();

            }
        }

        private async void btnConnectPLC_Click(object sender, EventArgs e)
        {
            
                timerReadPLC.Start();
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

        private void picEyeOff_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picEyeOff.Visible = false;
            picEyeOn.Visible = true;
        }

        private void picEyeOn_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picEyeOff.Visible = true;
            picEyeOn.Visible = false;
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
        #region NotUse
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

        #endregion
    }
}
