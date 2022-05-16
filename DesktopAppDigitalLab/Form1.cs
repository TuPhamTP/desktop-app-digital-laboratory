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
        public string jsonSubscribe;
        public string jsonPublish = "NaN";
        public string topicValiIFMtoDA, topicDAToValiIFM;
        public bool clickBtnBroker, clickBtnPLCSIM, clickBtnPLC;
        public int flagPLCSIM, flagPLC;
        public bool writeSPRealValiPLC, writeSPSimulateValiPLC, writeConfig, writeSPRealInverter, writeOnOffRealInverter;

        public DataDAToValiIFM DataDAToValiIFMObj = new DataDAToValiIFM();
        public DataDAToValiPLC DataDAToValiPLCObj = new DataDAToValiPLC();
        //
        public DataValiIFMToDA DataValiIFMToDAObj = new DataValiIFMToDA();
        public DataValiPLCToDA DataValiPLCToDAObj = new DataValiPLCToDA();
        
        //


        public DataValueDAToRValiIFM DataValueDAToRValiIFMObj = new DataValueDAToRValiIFM();
        public DataConfParaDAToRValiIFM DataConfParaDAToRValiIFMObj = new DataConfParaDAToRValiIFM();
        public DataDAToRValiPLC DataDAToRValiPLCObj = new DataDAToRValiPLC();
        public DataDAToRInverter DataDAToRInverterObj = new DataDAToRInverter();
        public DataRValiPLCToDA DataRValiPLCToDAObj = new DataRValiPLCToDA();
        //

        public DataSetSPValiPLCToDA DataSetSPValiPLCToDAObj = new DataSetSPValiPLCToDA();
        public DataButtonReadConfigValiIFM DataButtonReadConfigValiIFMObj = new DataButtonReadConfigValiIFM();
        public DataSetSPRInverter DataSetSPRInverterObj = new DataSetSPRInverter();
        public DataSetOnOffRInverter DataSetOnOffRInverterObj = new DataSetOnOffRInverter();

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

            topicDAToValiIFM = "DAToARApp: ID = " + txtID.Text;
            topicValiIFMtoDA = "ARAppToDA: ID = " + txtID.Text;
            timerConnect.Start();

            //-------------------------------------------------------------Write PLCSIM
            DataItemsWritePLCSIMValiIFM.Add(w0UGTItem);
            DataItemsWritePLCSIMValiIFM.Add(w1UGTItem);
            DataItemsWritePLCSIMValiIFM.Add(w0IFItem);
            DataItemsWritePLCSIMValiIFM.Add(w0TWItem);
            DataItemsWritePLCSIMValiIFM.Add(w1TWItem);
            DataItemsWritePLCSIMValiIFM.Add(w0RBItem);
            DataItemsWritePLCSIMValiIFM.Add(outO5CItem);
            DataItemsWritePLCSIMValiIFM.Add(outKTItem);

            DataItemsWritePLCSIMValiPLC.Add(DI);
            DataItemsWritePLCSIMValiPLC.Add(AI);
            DataItemsWritePLCSIMValiPLC.Add(LS1);
            DataItemsWritePLCSIMValiPLC.Add(LS2);

            DataSetSPItemWritePLCSIMValiPLC.Add(setPosSP);
            DataSetSPItemWritePLCSIMValiPLC.Add(setVelSP);


            //--------------------------------------------------------------Read PLCSIM
            DataItemsReadPLCSIMValiIFM.Add(idConfigItem);
            DataItemsReadPLCSIMValiIFM.Add(disUGTItem);
            DataItemsReadPLCSIMValiIFM.Add(disIFItem);
            DataItemsReadPLCSIMValiIFM.Add(temTWItem);
            DataItemsReadPLCSIMValiIFM.Add(angleRBItem);
            DataItemsReadPLCSIMValiIFM.Add(byte65Item);
            DataItemsReadPLCSIMValiIFM.Add(byte67Item);

            DataItemsReadPLCSIMValiPLC.Add(DO);
            DataItemsReadPLCSIMValiPLC.Add(AO);
            DataItemsReadPLCSIMValiPLC.Add(velSP);
            DataItemsReadPLCSIMValiPLC.Add(vel);
            DataItemsReadPLCSIMValiPLC.Add(posSP);
            DataItemsReadPLCSIMValiPLC.Add(pos);
            DataItemsReadPLCSIMValiPLC.Add(posHome);


            //--------------------------------------------------------------Read PLC
            //Read values ValiIFM
            DataItemReadPLCValueRValiIFM.Add(w0UGT);
            DataItemReadPLCValueRValiIFM.Add(w1UGT);
            DataItemReadPLCValueRValiIFM.Add(w0IF);
            DataItemReadPLCValueRValiIFM.Add(disIF);
            DataItemReadPLCValueRValiIFM.Add(w0TW);
            DataItemReadPLCValueRValiIFM.Add(w1TW);
            DataItemReadPLCValueRValiIFM.Add(temTW);
            DataItemReadPLCValueRValiIFM.Add(w0RB);
            DataItemReadPLCValueRValiIFM.Add(angleRB);
            DataItemReadPLCValueRValiIFM.Add(byte65);
            DataItemReadPLCValueRValiIFM.Add(byte67);
            DataItemReadPLCValueRValiIFM.Add(byte68);


            //Read config parameters ValiIFM
            DataItemReadPLCConfParaRValiIFM.Add(SP1SSC1UGT);
            DataItemReadPLCConfParaRValiIFM.Add(SP2SSC1UGT);
            DataItemReadPLCConfParaRValiIFM.Add(SP1SSC2UGT);
            DataItemReadPLCConfParaRValiIFM.Add(SP2SSC2UGT);
            DataItemReadPLCConfParaRValiIFM.Add(SP1SSC1IF);
            DataItemReadPLCConfParaRValiIFM.Add(SP2SSC1IF);
            DataItemReadPLCConfParaRValiIFM.Add(SP1SSC2IF);
            DataItemReadPLCConfParaRValiIFM.Add(SP2SSC2IF);
            DataItemReadPLCConfParaRValiIFM.Add(SP1TW2000);
            DataItemReadPLCConfParaRValiIFM.Add(rP1TW2000);
            DataItemReadPLCConfParaRValiIFM.Add(rSLTRB3100);
            DataItemReadPLCConfParaRValiIFM.Add(cDirRB3100);
            DataItemReadPLCConfParaRValiIFM.Add(OUT_ENCRB);

            //Read value ValiPLC
            DataItemReadPLCValiPLC.Add(realDI);
            DataItemReadPLCValiPLC.Add(realDO);
            DataItemReadPLCValiPLC.Add(realAI);
            DataItemReadPLCValiPLC.Add(realAO);
            DataItemReadPLCValiPLC.Add(realVelSP);
            DataItemReadPLCValiPLC.Add(realVel);
            DataItemReadPLCValiPLC.Add(realPosSP);
            DataItemReadPLCValiPLC.Add(realPos);
            DataItemReadPLCValiPLC.Add(realVelEnc);
            DataItemReadPLCValiPLC.Add(realPosEnc);
            DataItemReadPLCValiPLC.Add(realLS1);
            DataItemReadPLCValiPLC.Add(realLS2);

            //Read value Inverter
            DataItemReadPLCInverter.Add(realOnOff);
            DataItemReadPLCInverter.Add(realVelSPG120);
            DataItemReadPLCInverter.Add(realVelG120);


            //---------------------------------------------------------------Write PLC
            DataItemWritePLCValiPLC.Add(setRealPosSP);
            DataItemWritePLCValiPLC.Add(setRealVelSP);

            DataItemButtonReadConfigValiIFM.Add(readConfigItem);

            DataSetSPItemWritePLCInverter.Add(setRealVelSPG120);
            DataSetOnOffItemWritePLCInverter.Add(setRealOnOffG120);
        }

        //Class
        #region ClassData
        //----------------------------------------------------------------------
        public class DataDAToValiIFM    //PLCSIM --> DA --> ValiIFM ảo
        {
            public byte idV1;
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

            public ushort disUGT;
            public float disIF;
            public float temTW;
            public float angleRB;
            public byte byte65, byte67;
        }
        public class DataDAToValiPLC    //PLCSIM --> DA --> ValiPLC ảo
        {
            public byte idV2;
            public byte DI, DO;
            public ushort AI, AO;
            public float velSP, vel, posSP, pos, posHome;
        }
        public class DataDAToInverter   //PLCSIM --> DA --> Inverter ảo
        {

        }
        public class DataValiIFMToDA
        {
            public byte idV4;
            public short w0UGT, w1UGT, w0IF, w0TW, w1TW, w0RB;
            public bool outKT, outO5C;

        }
        public class DataValiPLCToDA
        {
            public byte idV5;
            public byte DI;
            public ushort AI;
            public bool LS1;
            public bool LS2;
            //Stepper Motor
        }
        public class DataSetSPValiPLCToDA
        {
            public byte idV6;
            public float siPosSP, siVelSP;
        }
        //
        
        //----------------------------------------------------------------------
        public class DataValueDAToRValiIFM      //Giá trị cảm biến từ ValiIFM thật --> DA --> AR cho ValiIFM thật
        {
            public  byte idR1;
            public ushort w0UGT;
            public ushort w1UGT;
            public ushort w0IF;
            public float disIF;
            public ushort w0TW;
            public ushort w1TW;
            public float temTW;
            public ushort w0RB;
            public float angleRB;
            public byte byte65, byte67, byte68;
        }
        public class DataConfParaDAToRValiIFM   //Cấu hình cảm biến từ ValiIFM thật --> DA --> AR cho ValiIFM thật
        {
            public byte idR2;
            public ushort SP1SSC1UGT;
            public ushort SP2SSC1UGT;
            public ushort SP1SSC2UGT;
            public ushort SP2SSC2UGT;
            public ushort SP1SSC1IF;
            public ushort SP2SSC1IF;
            public ushort SP1SSC2IF;
            public ushort SP2SSC2IF;
            public ushort SP1TW2000;
            public ushort rP1TW2000;
            public ushort rSLTRB3100;
            public byte cDirRB3100 = 2;
            public byte OUT_ENCRB = 2;
        }
        public class DataDAToRValiPLC           //Giá trị từ ValiPLC thật --> DA --> AR cho ValiPLC thật
        {
            public byte idR3;
            public byte DI, DO;
            public ushort AI, AO;
            public float velSP, vel, posSP, pos, velEnc, posEnc;
            public bool LS1, LS2;

        }
        public class DataDAToRInverter          //Giá trị từ Inverter thật --> DA --> AR cho Inverter thật 
        {
            public byte idR4;
            public ushort onOffG120;
            public ushort velSPG120, velG120;
        }
        public class DataRValiPLCToDA
        {
            public byte idR5;
            public float velSP, posSP;
            //public float velSP = 0, vel = 0, posSP = 0, pos = 0;

        }
        public class DataButtonReadConfigValiIFM
        {
            public byte idR6;
            public bool readConfig;
        }

        public class DataSetSPRInverter
        {
            public byte idR7;
            public ushort velSetSPG120;
        }
        public class DataSetOnOffRInverter
        {
            public byte idR8;
            public ushort onOffSetG120;
        }
        //
        #endregion

        //List Data

        private static List<DataItem> DataItemsWritePLCSIMValiIFM = new List<DataItem>();
        private static List<DataItem> DataItemsReadPLCSIMValiIFM = new List<DataItem>();
        private static List<DataItem> DataItemsWritePLCSIMValiPLC = new List<DataItem>();
        private static List<DataItem> DataItemsReadPLCSIMValiPLC = new List<DataItem>();

        //private static List<DataItem> dataItemReadPLC = new List<DataItem>();

        private static List<DataItem> DataItemReadPLCValueRValiIFM = new List<DataItem>();
        private static List<DataItem> DataItemReadPLCConfParaRValiIFM = new List<DataItem>();
        private static List<DataItem> DataItemReadPLCValiPLC = new List<DataItem>();
        private static List<DataItem> DataItemWritePLCValiPLC = new List<DataItem>();
        private static List<DataItem> DataSetSPItemWritePLCSIMValiPLC = new List<DataItem>();
        private static List<DataItem> DataItemButtonReadConfigValiIFM = new List<DataItem>();
        private static List<DataItem> DataItemReadPLCInverter = new List<DataItem>();
        private static List<DataItem> DataSetSPItemWritePLCInverter = new List<DataItem>();
        private static List<DataItem> DataSetOnOffItemWritePLCInverter = new List<DataItem>();

        #region DataItemsWritePLCSIMValiIFM
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

        #region DataItemsReadPLCValiIFM

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

        #region DataItemsWritePLCSIMValiPLC
        private static DataItem DI = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        private static DataItem AI = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 64,
            Value = new object()

        };
        private static DataItem LS1 = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 1,
            Count = 1,
            StartByteAdr = 1,
            Value = new object()
        };
        private static DataItem LS2 = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 1,
            Value = new object()
        };
        // //////////////////
        private static DataItem setPosSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 72,
            Value = new object()
        };
        private static DataItem setVelSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 76,
            Value = new object()
        };
        
        #endregion

        #region DataItemsReadPLCSIMValiPLC
        private static DataItem DO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        private static DataItem AO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 80,
            Value = new object()
        };
        private static DataItem velSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 76,
            Value = new object()
        };
        private static DataItem vel = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 84,
            Value = new object()
        };
        private static DataItem posSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 72,
            Value = new object()
        };
        
        private static DataItem pos = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 80,
            Value = new object()
        };
        private static DataItem posHome = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 88,
            Value = new object()
        };
        #endregion


        #region DataItemReadPLCValueRValiIFM
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
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 65,
            Value = new object()
        };
        private static DataItem byte67 = new DataItem()
        {
            DataType = DataType.Output,
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
        #endregion

        #region DataItemReadPLCConfParaRValiIFM
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

        #region DataItemReadPLCValiPLC
        private static DataItem realDI = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        private static DataItem realDO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        private static DataItem realAI = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 64,
            Value = new object()
        };
        private static DataItem realAO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 80,
            Value = new object()
        };
        private static DataItem realVelSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 42,
            Value = new object()
        };
        private static DataItem realVel = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 46,
            Value = new object()
        };
        private static DataItem realPosSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 54,
            Value = new object()
        };
        private static DataItem realPos = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 58,
            Value = new object()
        };
        private static DataItem realVelEnc = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 62,
            Value = new object()
        };
        private static DataItem realPosEnc = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 66,
            Value = new object()
        };
        private static DataItem realLS1 = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 1,
            Count = 1,
            StartByteAdr = 1,
            Value = new object()
        };
        private static DataItem realLS2 = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 1,
            Value = new object()
        };


        #endregion

        #region DataItemReadPLCInverter
        private static DataItem realOnOff = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 256,
            Value = new object()
        };
        private static DataItem realVelSPG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 96,
            Value = new object()
        };
        private static DataItem realVelG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 98,
            Value = new object()
        };

        #endregion

        #region DataSetSPItemWritePLCSIMValiPLC
        private static DataItem setRealPosSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 54,
            Value = new object()
        };
        private static DataItem setRealVelSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 42,
            Value = new object()
        };

        #endregion

        #region DataItemButtonReadConfigValiIFM
        private static DataItem readConfigItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Bit,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 40,
            Value = new object()
        };
        #endregion

        #region DataSetSPItemWritePLCInverter
        private static DataItem setRealVelSPG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 96,
            Value = new object()
        };
        #endregion

        #region DataSetOnOffItemWritePLCInverter
        private static DataItem setRealOnOffG120 = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 256,
            Value = new object()
        };
        #endregion

        //Timer
        private async void timerReadPLCSIM_Tick(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                ushort idConfig = 0;
                try
                {
                    await myPLC.ReadMultipleVarsAsync(DataItemsReadPLCSIMValiIFM);
                    idConfig = (ushort)DataItemsReadPLCSIMValiIFM[0].Value;
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

                    await myPLC.WriteAsync(DataItemsWritePLCSIMValiIFM.ToArray());

                    DI.Value = (byte)DataValiPLCToDAObj.DI;
                    AI.Value = (ushort)DataValiPLCToDAObj.AI;
                    LS1.Value = (bool)DataValiPLCToDAObj.LS1;
                    LS2.Value = (bool)DataValiPLCToDAObj.LS2;
                    await myPLC.WriteAsync(DataItemsWritePLCSIMValiPLC.ToArray());

                    
                    if (writeSPSimulateValiPLC == true)
                    {
                        setPosSP.Value = (float)DataSetSPValiPLCToDAObj.siPosSP;//
                        setVelSP.Value = (float)DataSetSPValiPLCToDAObj.siVelSP;//
                        await myPLC.WriteAsync(DataSetSPItemWritePLCSIMValiPLC.ToArray());
                        writeSPSimulateValiPLC = false;
                    }
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
                    //MessageBox.Show(ex3.Message);
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

                    await myPLC.WriteAsync(DataItemsWritePLCSIMValiIFM.ToArray());
                    

                    //Write vào ValiPLC thật
                    if (writeSPRealValiPLC == true)
                    {
                        setRealPosSP.Value = (float)DataRValiPLCToDAObj.posSP;
                        setRealVelSP.Value = (float)DataRValiPLCToDAObj.velSP;
                        await myPLC.WriteAsync(DataItemWritePLCValiPLC.ToArray());
                        writeSPRealValiPLC = false;
                    }    
                    if (writeConfig == true)
                    {
                        readConfigItem.Value = (bool)DataButtonReadConfigValiIFMObj.readConfig;
                        await myPLC.WriteAsync(DataItemButtonReadConfigValiIFM.ToArray());
                        writeConfig = false;
                    }    
                    if (writeSPRealInverter == true)
                    {
                        setRealVelSPG120.Value = (ushort)DataSetSPRInverterObj.velSetSPG120;
                        await myPLC.WriteAsync(DataSetSPItemWritePLCInverter.ToArray());
                        writeSPRealInverter = false;
                    }    
                    if (writeOnOffRealInverter == true)
                    {
                        setRealOnOffG120.Value = (ushort)DataSetOnOffRInverterObj.onOffSetG120;
                        await myPLC.WriteAsync(DataSetOnOffItemWritePLCInverter.ToArray());
                        writeOnOffRealInverter = false;
                    }    
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
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToValiPLCObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                }
                else if (clickBtnPLC == true)
                {
                    jsonPublish = JsonConvert.SerializeObject(DataValueDAToRValiIFMObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                    
                    jsonPublish = JsonConvert.SerializeObject(DataConfParaDAToRValiIFMObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToRValiPLCObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

                    jsonPublish = JsonConvert.SerializeObject(DataDAToRInverterObj);
                    desktopAppClient.Publish(topicDAToValiIFM, Encoding.UTF8.GetBytes(jsonPublish), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
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

        private async void btnConnectPLC_Click(object sender, EventArgs e)
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
                    //desktopAppClient.Subscribe(new string[] { topicValiIFMtoDA }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    SubscribeTopic();
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
                timerMQTT.Stop();//Sua
            }    
            
        }

        private void btnSubmitID_Click(object sender, EventArgs e)
        {
            strID = txtID.Text;
            lblID.Text = strID;
            topicDAToValiIFM = "DAToARApp: ID = " + txtID.Text;
            topicValiIFMtoDA = "ARAppToDA: ID = " + txtID.Text;
            SubscribeTopic();
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
            desktopAppClient.Subscribe(new string[] { topicValiIFMtoDA }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
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
