using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTU_SERIAL_RECV
{
    class DevData
    {
        public byte head1;
        public byte head2;
        public byte type;
        public byte datalen;
        public byte[] data;
        public byte[] verify;

        public DevData()
        {
            data = new byte[25];
            verify = new byte[2];
        }
        public DevData(int len)
        {
            data = new byte[len];
            verify = new byte[2];
        }
    }
    
}
