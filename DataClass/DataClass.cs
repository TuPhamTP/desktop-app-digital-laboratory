using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
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
        public byte panelSwitchIn, panelSwitchOut;
    }
    public class DataDAToInverter   //PLCSIM --> DA --> Inverter ảo
    {
        public byte idV3;
        public ushort onOffG120;
        public ushort velSPG120, velG120;
    }
    public class DataInverterToDA   //Inverter PLCSIM
    {
        public byte idV9;
        public ushort velG120;
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
        public byte DI, paneSwitchIn;
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
    public class DataSetSPInverter
    {
        public byte idV7;
        public ushort siVelSetSPG120;

    }
    public class DataSetOnOffInverter
    {
        public byte idV8;
        public ushort siOnOffSetG120;
    }
    //----------------------------------------------------------------------
    public class DataValueDAToRValiIFM      //Giá trị cảm biến từ ValiIFM thật --> DA --> AR cho ValiIFM thật
    {
        public byte idR1;
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
        public byte DI, DO, panelSwitchIn, panelSwitchOut;
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
}
