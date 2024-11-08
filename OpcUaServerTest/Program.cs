using Opc.UaFx;
using OpcUaServer;
using OpcUaServer.OpcNodes;
using System;

namespace OpcUaServerTest
{
    internal class Program
    {
        private static OpcUaHelper helper;

        static void Main(string[] args)
        {
            helper = new OpcUaHelper(
                "opc.tcp://localhost:4850",
                "Foss.Opc",
                true,
                false,
                false         );

            helper.StartServer();
            helper.Nodes.InstrumentNodes.WatchdogCounter.AfterApplyChanges += WatchdogCounter_AfterApplyChanges;
            Console.Read();
        }


        private static void WatchdogCounter_AfterApplyChanges(object sender, Opc.UaFx.OpcNodeChangesEventArgs e)
        {
            Console.Clear();
            var node = (OpcDataVariableNode<uint>)sender;
            var watchdog = node.Value.ToString();
            Console.WriteLine($"Watchdog: {watchdog}");
        }
    }
}
