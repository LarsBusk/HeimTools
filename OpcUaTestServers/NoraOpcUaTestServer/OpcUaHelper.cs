using OpcUaServer;
using OpcUaServer.OpcNodes;
using System;
using System.Security.Cryptography.X509Certificates;

namespace NoraOpcUaTestServer
{
    public class OpcUaHelper
    {
        #region Public properties

        public OpcUaNodes Nodes => OpcUaServer.Nodes;
        public OpcUaServer.OpcUaServer OpcUaServer;

        #endregion

        #region Private fields

        private static uint serverWatchdog = 1;
        private readonly string userName;
        private readonly string password;
        private readonly bool enableAnonymous;
        private readonly bool enableUserAndPassword;
        private readonly bool enableCertificate;
        private readonly X509Certificate2 certificate;

        #endregion

        #region Public methods

        public OpcUaHelper(string serverName, string homeFolder, bool enableAnonymous, bool enableUserAndPassword,
            bool enableCertificate, string userName, string password, X509Certificate2 certificate)
        {
            this.enableUserAndPassword = enableUserAndPassword;
            this.enableAnonymous = enableAnonymous;
            this.enableCertificate = enableCertificate;
            this.userName = userName;
            this.password = password;
            this.certificate = certificate;

            OpcUaServer = new OpcUaServer.OpcUaServer(
                serverName, 
                homeFolder, 
                Properties.Settings.Default.OpcNameSpace,
                Properties.Settings.Default.NodeSeparator,
                Instrument.Nora);
            SetAuthentication();
        }

        public void StartServer()
        {
            OpcUaServer.StartServer();
        }

        public void StopServer()
        {
            OpcUaServer.StopServer();
        }

        public void StartMeasuring(string product)
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodes.ProductCode, product);
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesNora.ModeN, 1);
        }

        public void StartMeasuring()
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesNora.ModeN, 1);
        }

        public void StopMeasuring()
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesNora.ModeN, 0);
        }

        public void SetCip()
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesNora.ModeN, 2);
        }

        public void ChangeProduct(string newProduct)
        {
            OpcUaServer.SetNodeValue<string>(Nodes.ControllerNodes.ProductCode, newProduct);
        }

        public void EnqueueZero()
        {
            OpcUaServer.ToggleNode(Nodes.ControllerNodesNora.ZeroToQueue, TimeSpan.FromMilliseconds(500));
        }

        public void EnqueueClean()
        {
            OpcUaServer.ToggleNode(Nodes.ControllerNodesNora.CleanToQueue, TimeSpan.FromMilliseconds(500));
        }

        public void SetSampleRegistration(string registration)
        {
            OpcUaServer.SetNodeValue<string>(Nodes.ControllerNodesNora.SampleRegistration, registration);
        }

        public void SetNoDelayedResults(bool state)
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesNora.NoDelayedResults, state);
        }

        public void UpdateServerWatchdog()
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodes.WatchdogCounter, serverWatchdog);
            serverWatchdog++;
        }

        #endregion

        #region Private methods

        private void SetAuthentication()
        {
            if (enableUserAndPassword) EnableUserPassword();
            if (enableCertificate) EnableCert();
            SetAnonymous();
        }

        private void EnableUserPassword()
        {
            OpcUaServer.EnableUserPassword(userName, password);
        }

        private void EnableCert()
        {
            OpcUaServer.EnableCert(certificate);
        }

        private void SetAnonymous()
        {
            OpcUaServer.SetAnonymous(enableAnonymous);
        }

        #endregion
    }
}
