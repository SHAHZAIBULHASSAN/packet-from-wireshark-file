using SIPRECLoadTestCallGeneratorTool.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRECLoadTestCallGeneratorTool
{

    #region struct PACKET_INTERNET
    public struct PACKET_INTERNET
    {
        public byte Version;
        public byte HeaderLength;
        public byte DifferentiatedServicesField;
        public ushort Length;
        public ushort Identification;
        public byte Flags;
        public ushort FragmentOffset;
        public ushort TimeToLive;
        public byte Protocol;
        public ushort HeaderChecksum;
        public string Source;
        public string Destination;

        public Boolean Error;
        public String ErrorDescription;
    }
    #endregion struct PACKET_INTERNET

    public class PacketINTERNET
    {

        private static PACKET_INTERNET PInternet;

        public PacketINTERNET()
        {

        }

        # region PACKET_INTERNET  Parser
        public static PACKET_INTERNET Parser(byte[] PacketData, ref int Index)
        {
            string Tmp = "";


            if ((Index + Const.LENGTH_OF_INTERNET) > PacketData.Length)
            {
                Tmp = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";

                PInternet.Error = true;
                PInternet.ErrorDescription = Tmp;

                return PInternet;
            }

            try
            {

                PInternet.Version = PacketData[Index++];
                PInternet.HeaderLength = (byte)((PInternet.Version & 0x0f) * 4);
                PInternet.Version = (byte)((int)PInternet.Version >> 4);
                PInternet.DifferentiatedServicesField = PacketData[Index++];
                PInternet.Length = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PInternet.Identification = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PInternet.FragmentOffset = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PInternet.Flags = (byte)((int)PInternet.FragmentOffset >> 12);
                PInternet.FragmentOffset = (ushort)(PInternet.FragmentOffset & 0x0f);
                PInternet.TimeToLive = PacketData[Index++];
                PInternet.Protocol = PacketData[Index++];
                PInternet.HeaderChecksum = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);
                PInternet.Source = Function.GetIpAddress(PacketData, ref Index);
                PInternet.Destination = Function.GetIpAddress(PacketData, ref Index);

            }
            catch
            {
                PInternet.Error = true;
                PInternet.ErrorDescription = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";
                return PInternet;
            }

            PInternet.Error = false;
            return PInternet;

        }
        # endregion PACKET_INTERNET  Parser
    }
}
