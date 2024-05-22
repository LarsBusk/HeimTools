using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;

namespace OpcUaTestClient
{
    internal class OpcUaClient
    {
        public OpcClient Client { get; set; }

        private Timer watchdogTimer;
        private int watchdog = 0;

        public OpcUaClient()
        {
            Client = new OpcClient("opc.tcp://172.20.20.54:4840/NoraTestServer");
            watchdogTimer = new Timer
            {
                Interval = 1000,
                Enabled = true
            };
            watchdogTimer.Tick += WatchdogTimer_Tick;
            watchdogTimer.Start();
            Client.Connect();
        }

        private void WatchdogTimer_Tick(object sender, EventArgs e)
        {
            Client.WriteNode("ns=2;s=Foss.Nora.Instrument.WatchdogCounter", watchdog);
            watchdog++;
        }
    }
}
