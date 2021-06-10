using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRECLoadTestCallGeneratorTool.Helpers
{
    public class PacketUDP
    {
        public static PACKET_UDP PUdp;

        public PacketUDP()
        {
            //
            // 
            //
        }
        public static PACKET_UDP Parser(byte[] PacketData, ref int Index)
        {
            string Tmp = "";

            if ((Index + Const.LENGTH_OF_UDP) > PacketData.Length)
            {
                Tmp = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
                PUdp.Error = true;
                PUdp.ErrorDescription = Tmp;
                return PUdp;
            }

            try
            {
                PUdp.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PUdp.DestinationPort = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PUdp.Length = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PUdp.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
            }

            catch
            {
                PUdp.Error = true;
                PUdp.ErrorDescription = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
                return PUdp;
            }

            return PUdp;

        }   
    }
    public struct PACKET_UDP
    {
        public ushort SourcePort;
        public ushort DestinationPort;
        public ushort Length;
        public ushort Checksum;

        public Boolean Error;
        public string ErrorDescription;

    }
}
