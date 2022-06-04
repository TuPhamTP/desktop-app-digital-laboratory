using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using S7.Net.Types;

namespace DataItems
{
    public static class DataItems
    {
        #region DataItemsWritePLCSIMValiIFM
        public static DataItem w0UGTItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 93,
            Value = new object()
        };
        public static DataItem w1UGTItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 95,
            Value = new object()
        };
        public static DataItem w0IFItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 90,
            Value = new object()
        };
        public static DataItem w0TWItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 82,
            Value = new object()
        };
        public static DataItem w1TWItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 84,
            Value = new object()
        };
        public static DataItem w0RBItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 87,
            Value = new object()
        };
        public static DataItem outKTItem = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 4,
            Count = 1,
            StartByteAdr = 68,
            Value = new object()
        };
        public static DataItem outO5CItem = new DataItem()
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

        public static DataItem idConfigItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 24,
            Value = new object()
        };
        public static DataItem disUGTItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 26,
            Value = new object()
        };
        public static DataItem disIFItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 28,
            Value = new object()
        };
        public static DataItem temTWItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 32,
            Value = new object()
        };
        public static DataItem angleRBItem = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 36,
            Value = new object()
        };
        public static DataItem byte65Item = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 65,
            Value = new object()
        };
        public static DataItem byte67Item = new DataItem()
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
        public static DataItem DI = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        public static DataItem AI = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 64,
            Value = new object()

        };
        public static DataItem LS1 = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 1,
            Count = 1,
            StartByteAdr = 1,
            Value = new object()
        };
        public static DataItem LS2 = new DataItem()
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
        public static DataItem setPosSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 72,
            Value = new object()
        };
        public static DataItem setVelSP = new DataItem()
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
        public static DataItem DO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        public static DataItem AO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 80,
            Value = new object()
        };
        public static DataItem velSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 76,
            Value = new object()
        };
        public static DataItem vel = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 84,
            Value = new object()
        };
        public static DataItem posSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 72,
            Value = new object()
        };

        public static DataItem pos = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 80,
            Value = new object()
        };
        public static DataItem posHome = new DataItem()
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
        public static DataItem w0UGT = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 93,
            Value = new object()
        };
        public static DataItem w1UGT = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 95,
            Value = new object()
        };
        public static DataItem w0IF = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 90,
            Value = new object()
        };
        public static DataItem disIF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 28,
            Value = new object()
        };
        public static DataItem w0TW = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 82,
            Value = new object()
        };
        public static DataItem w1TW = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 84,
            Value = new object()
        };
        public static DataItem temTW = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 32,
            Value = new object()
        };
        public static DataItem w0RB = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 87,
            Value = new object()
        };
        public static DataItem angleRB = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.DWord,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 36,
            Value = new object()
        };
        public static DataItem byte65 = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 65,
            Value = new object()
        };
        public static DataItem byte67 = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 67,
            Value = new object()
        };
        public static DataItem byte68 = new DataItem()
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
        public static DataItem SP1SSC1UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        public static DataItem SP2SSC1UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 2,
            Value = new object()
        };
        public static DataItem SP1SSC2UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 4,
            Value = new object()
        };
        public static DataItem SP2SSC2UGT = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 6,
            Value = new object()
        };
        public static DataItem SP1SSC1IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 8,
            Value = new object()
        };
        public static DataItem SP2SSC1IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 10,
            Value = new object()
        };
        public static DataItem SP1SSC2IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 12,
            Value = new object()
        };
        public static DataItem SP2SSC2IF = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 14,
            Value = new object()
        };
        public static DataItem SP1TW2000 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 16,
            Value = new object()
        };
        public static DataItem rP1TW2000 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 18,
            Value = new object()
        };
        public static DataItem rSLTRB3100 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 20,
            Value = new object()
        };
        public static DataItem cDirRB3100 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Byte,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 22,
            Value = new object()
        };
        public static DataItem OUT_ENCRB = new DataItem()
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
        public static DataItem realDI = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        public static DataItem realDO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Byte,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 0,
            Value = new object()
        };
        public static DataItem realAI = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 64,
            Value = new object()
        };
        public static DataItem realAO = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 80,
            Value = new object()
        };
        public static DataItem realVelSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 42,
            Value = new object()
        };
        public static DataItem realVel = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 46,
            Value = new object()
        };
        public static DataItem realPosSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 54,
            Value = new object()
        };
        public static DataItem realPos = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 58,
            Value = new object()
        };
        public static DataItem realVelEnc = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 62,
            Value = new object()
        };
        public static DataItem realPosEnc = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 66,
            Value = new object()
        };
        public static DataItem realLS1 = new DataItem()
        {
            DataType = DataType.Input,
            VarType = VarType.Bit,
            DB = 0,
            BitAdr = 1,
            Count = 1,
            StartByteAdr = 1,
            Value = new object()
        };
        public static DataItem realLS2 = new DataItem()
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
        public static DataItem realOnOff = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 256,
            Value = new object()
        };
        public static DataItem realVelSPG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 96,
            Value = new object()
        };
        public static DataItem realVelG120 = new DataItem()
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
        public static DataItem setRealPosSP = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Real,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 54,
            Value = new object()
        };
        public static DataItem setRealVelSP = new DataItem()
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
        public static DataItem readConfigItem = new DataItem()
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
        public static DataItem setRealVelSPG120 = new DataItem()
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
        public static DataItem setRealOnOffG120 = new DataItem()
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

        // Chinh dia chi tag
        #region DataItemReadPLCSIMInverter
        public static DataItem siOnOffG120 = new DataItem()
        {
            DataType = DataType.Output,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 256,
            Value = new object()
        };
        public static DataItem siVelSPG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 100,
            Value = new object()
        };
        public static DataItem siVelG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 102,
            Value = new object()
        };
        #endregion

        #region DataSetSPItemWritePLCSIMInverter
        public static DataItem setSiVelSPG120 = new DataItem()
        {
            DataType = DataType.DataBlock,
            VarType = VarType.Word,
            DB = 1000,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 100,
            Value = new object()
        };
        #endregion

        #region DataSetOnOffItemWritePLCSIMInverter
        public static DataItem setSiOnOffG120 = new DataItem()
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

        #region DataItemWritePLCSIMInverter
        public static DataItem writeVelG120 = new DataItem()
        {
            DataType = DataType.Memory,
            VarType = VarType.Word,
            DB = 0,
            BitAdr = 0,
            Count = 1,
            StartByteAdr = 258,
            Value = new object()
        };
        #endregion
    }
}
