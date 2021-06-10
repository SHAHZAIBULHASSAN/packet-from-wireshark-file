using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRECLoadTestCallGeneratorTool.Helpers
{
    # region struct PACKET_RTP
    public struct PACKET_RTP
    {
        public int version;

        public uint Codec;

        public uint sourceidentifiers;
        public bool marker;

        public int SequenceNumber;
        public uint TimeStamp;

        public uint SynchronisationSourceIdentifier;

        public uint LastFrame;

        public byte[] Contents;
    }
    #endregion struct PACKET_RTP

    public class PacketRTP
    {
        public static PACKET_RTP PRtp;

        public const int RTPHEADERLENGTH = 12;

        # region PACKETRTP
        public PacketRTP()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        # endregion PACKETRTP

        # region PACKET_RTP  Parser
        public static PACKET_RTP Parser(byte[] PacketData, ref int Index)
        {
            int Size = 0;
            int i = 0;

            Size = PacketData.GetLength(0) - Index;

            //Skip Version
            Index++;

            //Check codec
            PRtp.Codec = (uint)PacketData[Index] & 0x7F;
            PRtp.marker = (PacketData[Index] & 0xff & 0x80) == 0x80;

            Index++;

            PRtp.SequenceNumber = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
            PRtp.TimeStamp = Function.Get4Bytes(PacketData, ref Index, Const.NORMAL);
            PRtp.SynchronisationSourceIdentifier = Function.Get4Bytes(PacketData, ref Index, Const.NORMAL);

            //if (clsGetAppConfigSIPRec.EnableDifferentCodecLog && PRtp.marker)
            //    NSLogger.Logger.WriteLog("Marker packet arrived, Codec is = " + PRtp.Codec + ", Sequence Number = " + PRtp.SequenceNumber + ", TimeStamp = " + PRtp.TimeStamp + ", SSRC = " + PRtp.SynchronisationSourceIdentifier, NSLogger.LogLevel.COMMSLOG);

            PRtp.Contents = new byte[Size - RTPHEADERLENGTH];

            for (i = 0; i < Size - RTPHEADERLENGTH; i++)
                PRtp.Contents[i] = PacketData[Index++];
            return PRtp;
        }
        # endregion PACKET_RTP  Parser
    }
}
