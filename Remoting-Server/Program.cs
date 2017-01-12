using Controller;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Remoting_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel hc = new HttpChannel(10200);

            ChannelServices.RegisterChannel(hc, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(UserController), "USERSERVICE", WellKnownObjectMode.Singleton);

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("- Established Remoting Server Connection ...");
            Console.WriteLine("-----------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
