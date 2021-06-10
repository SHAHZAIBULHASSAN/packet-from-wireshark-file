using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capture
{
    class Program
    {
       


            public static void Main(string[] args)
            {
            var dev = new CaptureFileReaderDevice(@"C:\Users\shahzaib.hassan\Downloads\SIPREC Video.pcapng");
            dev.Open();

            string ver = SharpPcap.Version.VersionString;

                /* Print SharpPcap version */
                Console.WriteLine("SharpPcap {0}, ReadingCaptureFile", ver);
                Console.WriteLine();

                Console.WriteLine();

                // read the file from stdin or from the command line arguments
                string capFile;
                if (args.Length == 0)
                {
                    Console.Write("-- Please enter an input capture file name: ");
                    capFile = Console.ReadLine();
                }
                else
                {
                    // use the first argument as the filename
                    capFile = args[0];
                }

                Console.WriteLine("opening '{0}'", capFile);

                ICaptureDevice device;

                try
                {
                    // Get an offline device
                    device = new CaptureFileReaderDevice(capFile);

                    // Open the device
                    device.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Caught exception when opening file" + e.ToString());
                    return;
                }

                // Register our handler function to the 'packet arrival' event
                device.OnPacketArrival +=
                   SavePacketsHandler;
            captureFileReader.Capture();

                Console.WriteLine();
                Console.WriteLine
                    ("-- Capturing from '{0}', hit 'Ctrl-C' to exit...",
                    capFile);

                // Start capture 'INFINTE' number of packets
                // This method will return when EOF reached.
                device.Capture();

                // Close the pcap device
                device.Close();
                Console.WriteLine("-- End of file reached.");
                Console.Write("Hit 'Enter' to exit...");
                Console.ReadLine();
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

        private byte[] ParsePacket(byte[] packet)
        {
           
        }
    }

    
}

