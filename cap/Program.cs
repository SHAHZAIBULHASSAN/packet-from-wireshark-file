using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cap
{
    class Program
    {  static ICaptureDevice device;

        [Obsolete]
        static void Main(string[] args)
        {

            // read the file from stdin or from the command line arguments
            
            if (args.Length == 0)
            {
                Console.Write("-- Please enter an input capture file name: ");
                device = new CaptureFileReaderDevice(@"C:\Users\shahzaib.hassan\Downloads\SIPREC Video.pcapng");
                Console.ReadLine();
            }

           
            Console.WriteLine("opening of the file");

           

            try
            {
                // Get an offline device
               

                // Open the device
                device.Open();
               
                Console.WriteLine($"file is open");
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception when opening file" + e.ToString());
                return;
            }

            // Register our handler function to the 'packet arrival' event
            device.OnPacketArrival += SavePacketsHandler;
            // device.OnPacketArrival += PacketHandler;
            device.Capture();

            Console.WriteLine();
            

            // Start capture 'INFINTE' number of packets
            // This method will return when EOF reached.
            device.Capture();

            // Close the pcap device
            device.Close();
            Console.WriteLine("-- End of file reached.");
            Console.Write("Hit 'Enter' to exit...");
            Console.ReadLine();
        }

        [Obsolete]
        private static void SavePacketsHandler(object sender, CaptureEventArgs e)
        {
            Packet packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            var tcpPacket = ARPPacket.GetEncapsulated(packet); // what this method us used for ? i use it to find arppacket

            var ipPacket = IpPacket.GetEncapsulated(packet);
            try
            {
                if (ipPacket != null)

                {
                    #region instruction
                    // if i use above two methods then it is not entering this if block... hence it is not printing the info
                    // would we use the below statments in above block in order to print the info

                    // everything i get is in hexadecimal from which i cannot understand it. kindly make to decimal so that end user can understand easilt. moreover 
                    // always use try catch and resolcve this exception
                    //okay i will use decimal instead of hex  so where i use this convert

                    #endregion
                    //byte[] bb= e.Packet.Data;
                    //byte[] b = packet.Header;
                    //int type = b[1] + (b[0] << 8);
                    //int protocol = b[3] + (b[2] << 8);
                    //int opcode = b[7] + (b[6] << 8);
                    //Console.WriteLine("ARP: Hardware type {0}, protocol {1}, op-code: {2}",
                    //type, protocol, opcode);
                    //DateTime time = e.Packet.Timeval.Date;
                    //int len = e.Packet.Data.Length;


                    var srcIp = ipPacket.SourceAddress.ToString();
                    //   int ipindex = Convert.ToInt32(srcIp, 16);
                    //      Console.WriteLine(ipindex);
                    srcIp = srcIp.Replace("::", ":");
                    Console.WriteLine(srcIp);
                    string ip = srcIp;
                    // var srcPort = tcpPacket.SourcePort.ToString();

                    var dstPort = srcIp.ToString();

                    

                    string data = Encoding.ASCII.GetString(raw);
                    Console.WriteLine(data);
                    string[] values = ip.Split(':');
                   


                    for (int i = 0; i < values.Length; i++)
                    {

                        var part = new IPAddress(long.Parse(values[i], NumberStyles.AllowHexSpecifier));

                      
                        Console.WriteLine(part);
                    }
                    

                    //var ipPart1 = int.Parse(srcIp.Substring(0, 2), NumberStyles.HexNumber);
                    //    var ipPart2 = int.Parse(srcIp.Substring(2, 2), NumberStyles.HexNumber);
                    //    var ipPart3 = int.Parse(srcIp.Substring(4, 2), NumberStyles.HexNumber);
                    //   //      var ipPart4 = int.Parse(srcIp.Substring(6, 2), NumberStyles.HexNumber);

                    //    Console.WriteLine($" and {ipPart1}");




                    #region instruction
                    ////String ip = "";

                    ////for (int j = 0; j < srcIp.Length; j += 2)
                    ////{
                    ////    String sub = srcIp.Substring(j, j + 2);
                    ////    int num = Convert.ToInt32(sub, 16);
                    ////    int num = int.Parse(sub, 16);
                    ////    ip += num + ".";
                    ////    Console.WriteLine(ip);
                    ////}

                    //ip = ip.Substring(0, ip.Length - 1);
                    //Console.WriteLine(ip);

                    ////double w;
                    ////NumberStyles style = System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowCurrencySymbol;
                    ////CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
                    ////Double.TryParse(srcIp, style, culture, out w);
                    ////Console.WriteLine(w.ToString());
                    ////var iip = new IPAddress(long.Parse(srcIp, NumberStyles.HexNumber));


                    //  here src make it normal ip e.g 172.20.22.65 like this 
                    // currently, it is in hex , 
                    // i will convert into hex to normal ip address 
                    // did you say, right?
                    // yes and rest of the properties as well
                    //okay
                    // thank to you give me your precious time 
                    // i will check you after some time..
                    //
                    #endregion

                    var dstIp = ipPacket.DestinationAddress.ToString();
                    Console.WriteLine(dstIp);
                    string ip2 = dstIp;
                    string[] values2 = ip2.Split(':');



                    for (int i = 0; i < values.Length; i++)
                    {

                        var part = new IPAddress(long.Parse(values2[i], NumberStyles.AllowHexSpecifier));


                        Console.WriteLine(part);
                    }

                   
                    var header = ipPacket.Header.ToString();
                    var version = ipPacket.Version.ToString();
                    var typepackt = ipPacket.HeaderLength.ToString();
                    var protocol = ipPacket.Protocol.ToString();
                    Console.WriteLine($" protocol={protocol} , header=={header} , version={version}, " +
                        $"header length={typepackt} and ");


                    //var srcPort = tcpPacket.SourcePort.ToString();

                    //var dstPort = tcpPacket.DestinationPort.ToString();

                    //var hex = BitConverter.ToString(tcpPacket.PayloadData);

                    //hex = hex.Replace("-", "");
                    //byte[] raw = new byte[hex.Length / 2];
                    //for (int i = 0; i < raw.Length; i++)
                    //{
                    //    raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                    //}

                  //  string data = Encoding.ASCII.GetString(raw);

                 //   Console.WriteLine("{0}:{1}:{2} and payolad data=={3}", srcIp, dstIp, data);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToUpper());
            }




            #region code
            //byte[] packet = e.Packet.Data;


            //var rawPacket = e.GetPacket();
            //captureFileWriter.Write(rawPacket);
            //Console.WriteLine("Packet dumped to file.");

            //if (rawPacket.LinkLayerType == PacketDotNet.LinkLayers.Ethernet)
            //{
            //    var packet = PacketDotNet.Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);
            //    var ethernetPacket = (EthernetPacket)packet;

            //    Console.WriteLine("{0} At: {1}:{2}: MAC:{3} -> MAC:{4}",
            //                      packetIndex,
            //                      rawPacket.Timeval.Date.ToString(),
            //                      rawPacket.Timeval.Date.Millisecond,
            //                      ethernetPacket.SourceHardwareAddress,
            //                      ethernetPacket.DestinationHardwareAddress);
            //    packetIndex++;
            //}
            #endregion










        }

        //public static string Fun(var srcIp)
        //{
        //    String ip = "";

        //    for (int j = 0; j < srcIp.Count(); j += 2)
        //    {
        //        String sub = srcIp.Substring(j, j + 2);
        //        int num = Convert.ToInt32(sub, 16);
        //        // int num = int.Parse(sub, 16);
        //        ip += num + ".";
        //    }

        //    ip = ip.Substring(0, ip.Count() - 1);
        //    return ip;
        //}
    }

    //public static string Fun(String hex)
    //{

}       //       
    
