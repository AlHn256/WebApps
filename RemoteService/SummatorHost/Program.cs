using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace SummatorHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new TcpChannel(55211);
            ChannelServices.RegisterChannel(channel,false);
            var service = new RemoteService.SummatorRemoteService();
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteService.SummatorRemoteService),"Summator",WellKnownObjectMode.SingleCall);
            Console.WriteLine("Service Started!");
            Console.ReadLine();
        }
    }
}
