using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTU_SERIAL_RECV
{
    class SerialData
    {
        public byte[] UartData;

        public string Date;
        public int ID;
        public int[] DevInfo;

        public SerialData(int bufflen)
        {
            UartData = new byte[bufflen];
            UartData[0] = 0xEB;
            UartData[1] = 0x90;
        }
        public byte GetDataType()
        {
            return UartData[2];
        }
        public byte GetDataLen()
        {
            return UartData[3];
        }
        public byte[] GetData()
        {
            byte[] tmp = new byte[GetDataLen()];
            Array.Copy(UartData,4,tmp,0,GetDataLen());
            return tmp;
        }
        public void LoadDevInfo()
        {
            int len = GetDataLen() - 8;
            DevInfo = new int[len / 2];
            UInt16[] tmpdata = new UInt16[len / 2];
            UInt16 tmp = 0;
            byte[] gdata = GetData();

            // Load Date
            Date = gdata[0].ToString()+"-"+ gdata[1].ToString() + "-" + gdata[2].ToString()+" "+gdata[3].ToString()+":"+ gdata[4].ToString() + ":" + gdata[5].ToString();

            // Load ID
            tmp = gdata[6];
            ID = gdata[7];
            ID <<= 8;
            ID |= tmp;


            for (int i = 0, j = 8; i < len / 2; i++, j++)
            {
                tmp = gdata[j];
                DevInfo[i] = gdata[++j];
                DevInfo[i] <<= 8;
                DevInfo[i] |= tmp;
            }
        }
        public string GetDate()
        {
            return Date;
        }
        public int GetID()
        {
            return ID;
        }
        public int[] GetDevInfo()
        {
            return DevInfo;
        }
        public int GetDevInfo(int location)
        {
            return DevInfo[location];
        }
        public ushort GetVerify()
        {
            ushort[] ver = new ushort[] { UartData[UartData.Length - 2] , UartData[UartData.Length - 1]};
            ver[1] &= 0xFF;
            ver[1] <<= 8;
            ver[0] &= 0xFF;
            ver[1] |= ver[0];
            return ver[1];
        }
        public void Clean()
        {
            Array.Clear(UartData, 0, UartData.Length);
        }
        public Boolean Verify()
        {
            byte a;
            UInt16 CRC16 = 0xa001; //密钥
            UInt16 crc = 0xffff;
            for (int i = 0; i < UartData.Length; i++)
            {
                crc ^= UartData[i];
                for (int j = 0; j < 8; j++)
                {
                    a = (byte)(crc & 0x0001);
                    crc >>= 1;
                    if (Convert.ToBoolean(a))
                    {
                        crc ^= CRC16;
                    }
                }
            }
            if(crc == 0x0000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
