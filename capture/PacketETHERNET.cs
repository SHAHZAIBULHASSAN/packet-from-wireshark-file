using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRECLoadTestCallGeneratorTool.Helpers
{
    # region struct PACKET_ETHERNET
    public struct PACKET_ETHERNET
    {
        public string Destination;
        public string Source;
        public ushort Type;
        public Boolean Error;
        public String ErrorDescription;
    }
    # endregion struct PACKET_ETHERNET

    public class PacketETHERNET
    {

        public static PACKET_ETHERNET PEthernet;

        # region PacketETHERNET
        public PacketETHERNET()
        {
        }
        # endregion PacketETHERNET

        # region PACKET_ETHERNET  Parser
        public static PACKET_ETHERNET Parser(byte[] PacketData, ref int Index)
        {
            string Tmp = "";

            if ((Index + Const.LENGTH_OF_ETHERNET) > PacketData.Length)
            {
                Tmp = "[ Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";

                PEthernet.Error = true;
                PEthernet.ErrorDescription = Tmp;

                return PEthernet;
            }
            try
            {

                PEthernet.Destination = Function.GetMACAddress(PacketData, ref Index);
                PEthernet.Source = Function.GetMACAddress(PacketData, ref Index);

                PEthernet.Type = Function.Get2Bytes(PacketData, ref Index, Const.NORMAL);

            }
            catch (Exception Ex)
            {
                Tmp = "[ Error: Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";
                Tmp = "[ Exception raised is <" + Ex.GetType().ToString() + "> at packet index <" + Index.ToString() + "> ]";
                PEthernet.Error = true;
                PEthernet.ErrorDescription = Tmp;

                return PEthernet;
            }

            PEthernet.Error = false;

            return PEthernet;

        }
        # endregion PACKET_ETHERNET  Parser

    }
}
