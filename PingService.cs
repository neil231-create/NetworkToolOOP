using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using NetworkToolOOP;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkToolOOP
{
    public class PingService
    {
        // state
        public int Data { get; set; }
        public byte[] buffer { get; set; }
        public int timeout { get; set; }
        public string address { get; set; }
        public Ping pingSender { get; set; }
        public PingOptions options { get; set; }

        // constructor

        public PingService() 
        {
            timeout = 120;
            address = "4.2.2.2";
            buffer = Encoding.ASCII.GetBytes("Learn to Code");
            pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;

        }
        // methods
        public bool SendPing()
        {
            PingReply reply = pingSender.Send(address, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine($"Response: {reply.Status}");
                Console.WriteLine($"Roundtrip: {reply.RoundtripTime}");
                Console.WriteLine($"Time to live: {reply.Options.Ttl}");
                Console.WriteLine($"Buffer size: {reply.Buffer.Length}");
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
