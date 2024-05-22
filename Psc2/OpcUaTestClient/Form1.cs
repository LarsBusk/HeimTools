using Opc.UaFx.Client;
using System;
using System.Text;
using System.Windows.Forms;

namespace OpcUaTestClient
{
    public partial class Form1 : Form
    {
        public OpcClient Client { get; set; }

        private Timer watchdogTimer;
        private uint watchdog = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Initialise();
            Client.Connect();
            watchdogTimer.Enabled = true;
            watchdogTimer.Start();
        }

        private void Initialise()
        {
            Client = new OpcClient("opc.tcp://172.20.20.54:4840/NoraTestServer");
            //var importedCert = new X509Certificate2("FOSStestLicense.cer", "SLU1234");
            //var certArray = importedCert.GetRawCertData();
            //var cert = new X509Certificate2(certArray);
            //var newCert = OpcCertificateManager.CreateCertificate(Client);
            //var cert = new X509Certificate2(newCert.RawData);
            //Client.CertificateStores.ApplicationStore.Add(cert);
            
            //Client.Security.UseOnlySecureEndpoints = true;
            //Client.Security.UserIdentity = new OpcCertificateIdentity(Client.CertificateStores.ApplicationStore.GetCertificate(cert.Thumbprint).Certificate);
            //Client.Security.AutoAcceptUntrustedCertificates = true;
            watchdogTimer = new Timer
            {
                Interval = 1000,
                Enabled = false
            };
            watchdogTimer.Tick += WatchdogTimer_Tick;
        }

        private void WatchdogTimer_Tick(object sender, EventArgs e)
        {
            var res = Client.WriteNode("ns=2;s=Foss.Nora.Instrument.WatchdogCounter", watchdog);
            label1.Text = $"Writing {watchdog} result: {res.IsGood}";
            watchdog++;
        }

        private byte[] ConvertHex(string hexString)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < hexString.Length; i += 2)
            {
                var hs = hexString.Substring(i, 2);
                uint decval = System.Convert.ToUInt32(hs, 16);
                char character = System.Convert.ToChar(decval);
                sb.Append(character);
            }
            var ascii = sb.ToString();
            var bytes = Encoding.ASCII.GetBytes(ascii);
            return bytes;
        }
    }
}
