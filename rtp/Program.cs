using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
namespace rtp
{
    class Program
    {
        #region code
        //  static readonly string rootFolder = @"C:\Users\shahzaib.hassan\Downloads";
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
        static readonly string textFile = @"C:\Users\shahzaib.hassan\Downloads\SIPREC Video.pcapng";

       
            public static void Main(string[] args)
            {
                PcapDeviceList getNetConnections = SharpPcap.GetAllDevices();
                // network connection 1 (change as required)
                NetworkDevice netConn = (NetworkDevice)getNetConnections[1];
                PcapDevice device = netConn;
                // Define packet handler
                device.PcapOnPacketArrival +=
                new SharpPcap.PacketArrivalEvent(device_PcapOnPacketArrival);
                device.PcapOpen(true, 1000);
                Console.WriteLine("Network connection: {0}", device.PcapDescription);
                //Start the capturing process
                device.PcapStartCapture();
                Console.WriteLine("Press any <RETURN> to exit");
                Console.Read();
                device.PcapStopCapture();
                device.PcapClose();
            }
            private static void device_PcapOnPacketArrival(object sender, Packet packet)
            {
                if (packet is ARPPacket)
                {
                    byte[] b = packet.Header;
                    int type = b[1] + (b[0] << 8);
                    int protocol = b[3] + (b[2] << 8);
                    int opcode = b[7] + (b[6] << 8);
                    Console.WriteLine("ARP: Hardware type {0}, protocol {1}, op-code: {2}",
                    type, protocol, opcode);
                }
            }
        }
        //CaptureFileReaderDevice k = new CaptureFileReaderDevice();



        //if (File.Exists(textFile))
        //{
        //    // Read entire text file content in one string    
        //    string text = File.ReadAllText(textFile);
        //    Console.WriteLine(text);
        //}

        //if (File.Exists(textFile))
        //{
        //    // Read a text file line by line.  
        //    string[] lines = File.ReadAllLines(textFile);
        //    foreach (string line in lines)
        //        Console.WriteLine(line);
        //}

        //if (File.Exists(textFile))

        //        // Read file using StreamReader. Reads file line by line  
        //        using (StreamReader file = new StreamReader(textFile))
        //        {
        //            int counter = 0;
        //            string ln;

        //            while ((ln = file.ReadLine()) != null)
        //            {
        //                Console.WriteLine(ln);
        //                counter++;
        //            }
        //            file.Close();
        //            Console.WriteLine($"File has {counter} lines.");
        //        }
        //    }
        //}

    }
    