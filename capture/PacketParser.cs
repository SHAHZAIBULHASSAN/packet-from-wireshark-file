using NSLogger;
using SharpPcap;
using SharpPcap.LibPcap;
using SIPRECLoadTestCallGeneratorTool.Enums;
using SIPRECLoadTestCallGeneratorTool.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPRECLoadTestCallGeneratorTool.ParsePacket
{
    public class PacketParser
    {
        public static List<byte[]> h264VideoPackets = new List<byte[]>();
        public static CaptureFileReaderDevice captureFileReader = null;
        public static int index = 0;

        private PACKET_ETHERNET PEthernet;
        private PACKET_INTERNET PInternet;
        private PACKET_UDP PUdp;
        private PACKET_RTP PRtp;
        public void SavePackets()
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings.Get("FilePath");
            captureFileReader = new CaptureFileReaderDevice(filePath);
            captureFileReader.OnPacketArrival += SavePacketsHandler;
            captureFileReader.Capture();
        }
        private void SavePacketsHandler(object sender, CaptureEventArgs e)
        {
            byte[] packet = e.Packet.Data;
            if (packet != null)
            {
                try
                {
                    byte[] rtpPackets = ParsePacket(packet);
                    if (rtpPackets == null)
                        return;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private byte[] ParsePacket(byte[] PacketData)
        {
            try
            {
                index = 0;

                PEthernet = PacketETHERNET.Parser(PacketData, ref index);

                if (PEthernet.Error)
                    return null;

                if (PEthernet.Type != Const.ETHERTYPE_IP && PEthernet.Type != Const.ETHERTYPE_8021Q)
                    return null;

                if (PEthernet.Type == Const.ETHERTYPE_8021Q)
                    index = index + 4;


                PInternet = PacketINTERNET.Parser(PacketData, ref index);


                if (PInternet.Error)
                    return null;

                if (PInternet.Protocol != Const.IPPROTO_UDP)
                    return null;


                PUdp = PacketUDP.Parser(PacketData, ref index);
                int IntrudeIndex = index;
                byte[] IntrudePacketData = PacketData;

                if (PUdp.Error)
                    return null;

                if (PUdp.DestinationPort != Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPAUDIOLOGGERPORT1")) && PUdp.DestinationPort != Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPAUDIOLOGGERPORT2")) && PUdp.DestinationPort != Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPVIDEOLOGGERPORT1")) && PUdp.DestinationPort != Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPVIDEOLOGGERPORT2")))
                    return null;

                // get the valid rtp
                if (CheckValidRTP(PacketData, ref index))
                {
                    byte[] IntrudePackets = new byte[IntrudePacketData.Length - IntrudeIndex];
                    Buffer.BlockCopy(IntrudePacketData, IntrudeIndex, IntrudePackets, 0, IntrudePacketData.Length - IntrudeIndex);
                    //tuqeer 28-04-2021 for SRTP packets check
                    int acceptedpacketlength = 214;
                    if (Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings.Get("IsSrtpPackets")) == true)
                    {
                        acceptedpacketlength = 224;
                    }
                    //tuqeer 28-04-2021 for SRTP packets check

                    if (PUdp.DestinationPort == Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPAUDIOLOGGERPORT1")) && PacketData.Length == acceptedpacketlength)
                        SIPRECCallGenerator.inAudioPacketsByteArray.Add(IntrudePackets);
                    if (PUdp.DestinationPort == Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPAUDIOLOGGERPORT2")) && PacketData.Length == acceptedpacketlength)
                        SIPRECCallGenerator.outAudioPacketsByteArray.Add(IntrudePackets);

                    return IntrudePackets;
                }
                else if (CheckValidH263_H264(PacketData, ref index))
                {
                    PRtp = PacketRTP.Parser(PacketData, ref index);
                    //File.WriteAllBytes(Path.GetDirectoryName(Application.ExecutablePath) + "\\Files\\In.txt", PRtp.Contents);
                    h264VideoPackets.Add(PRtp.Contents);

                    byte[] IntrudePackets = new byte[IntrudePacketData.Length - IntrudeIndex];
                    Buffer.BlockCopy(IntrudePacketData, IntrudeIndex, IntrudePackets, 0, IntrudePacketData.Length - IntrudeIndex);

                    if (PUdp.DestinationPort == Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPVIDEOLOGGERPORT1")))
                        SIPRECCallGenerator.inVideoPacketsByteArray.Add(IntrudePackets);

                    if (PUdp.DestinationPort == Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("RTPVIDEOLOGGERPORT2")))
                        SIPRECCallGenerator.outVideoPacketsByteArray.Add(IntrudePackets);
                }
                return null;
            }
            catch (Exception ex)
            {
                Logger.WriteException(ex);
            }
            return null;
        }
        private bool CheckValidRTP(byte[] PacketData, ref int Index)
        {
            int tmpIndex = Index;
            bool retval = false;

            uint temp = (uint)PacketData[Index] & 0x80;
            if (temp == 0x80)
                retval = true;
            else
                return false;


            Index++;
            int Codec = PacketData[Index] & 0x7F;

            if (Codec == (int)PayLoadTypeEnum.EnumPayloadType.G711ULaw || Codec == (int)PayLoadTypeEnum.EnumPayloadType.G711ALaw ||
                Codec == (int)PayLoadTypeEnum.EnumPayloadType.G729 || Codec == (int)PayLoadTypeEnum.EnumPayloadType.G723)
            {
                retval = true;
            }
            else
            {
                Index--;
                return false;
            }

            //Skip Sequence Number and Timestamp
            Index += 7;

            uint SyncID = Function.Get4Bytes(PacketData, ref Index, Const.NORMAL);

            //Set the Index back
            Index = tmpIndex;

            return retval;
        }
        public static bool CheckValidH263_H264(byte[] PacketData, ref int Index)
        {
            int tmpIndex = Index;
            //PayLoad = PayLoadTypeEnum.EnumPayloadType.H263;
            bool retval = false;
            //			if( (PacketData.GetLength(0) - Index ) >= 172)
            //				retval = true;
            //			else
            //				return false;

            //Check version
            uint temp = (uint)PacketData[Index] & 0x80;
            if (temp == 0x80)
                //This is version 2
                retval = true;
            else
                return false;

            //Check codec
            Index++;
            int Codec = PacketData[Index] & 0x7F;

            if (Codec == (int)PayLoadTypeEnum.EnumPayloadType.H263)
            {
                //PayLoad = PayLoadTypeEnum.EnumPayloadType.H263;
                retval = true;
            }
            else if (Codec == (int)PayLoadTypeEnum.EnumPayloadType.H264)
            {
                //PayLoad = PayLoadTypeEnum.EnumPayloadType.H264;
                retval = true;
            }
            else
            {
                Index--;
                return false;
            }

            //Skip Sequence Number and Timestamp
            Index += 7;

            //Set the Index back
            Index = tmpIndex;
            return retval;
        }
    }
}
