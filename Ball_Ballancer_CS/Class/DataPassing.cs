using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Ballancer_CS.Class
{
    public class DataPassing
    {
        public static readonly byte
        P  = 0,
        I = 1,
        D   = 2;

        List<byte> recvData = new List<byte>();
        byte[] buff = new byte[1024];
        byte[] buff_pass = new byte[64];
        int cnt = 0;
        byte checksum = 0xff;

        float[] pid = new float[3];

        public DataPassing()
        {

        }

        public DataPassing(List<byte> recvData, byte checksum)
        {
            this.recvData = recvData;
            this.checksum = checksum;
        }

        public float[] dataRecive(byte[] data, int size)
        {
            Array.Copy(data, buff, size);
            for (int i = 0; i < size; i++)
            {
                switch (cnt)
                {
                    case 0:
                        if (buff[i] == 0x47)
                        {
                            buff_pass[cnt] = buff[i];
                            cnt++;
                        }
                        break;

                    case 1:
                        if (buff[i] == 0x53)
                        {
                            buff_pass[cnt] = buff[i];
                            cnt++;
                        }
                        else
                        {
                            cnt = 0;
                        }
                        break;

                    case 19:
                        buff_pass[cnt] = buff[i];
                        cnt = 0;
                        break;

                    default:
                        buff_pass[cnt] = buff[i];
                        cnt++;
                        break;
                }
            }
            return Passing();
        }

        public float[] Passing()
        {
            pid[P] = BitConverter.ToInt16(buff_pass, 3) / 100;
            pid[I] = BitConverter.ToInt16(buff_pass, 5) / 100;
            pid[D] = BitConverter.ToInt16(buff_pass, 7) / 100;
            return pid;
        }

        ~DataPassing()
        {

        }
    }
}
