using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace NetworkToolOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PingService pingService = new PingService();
            pingService.SendPing();
            Console.WriteLine(pingService);

        }
    }
}