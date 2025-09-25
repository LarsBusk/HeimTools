using System;
using OpcUaServer;
using OpcUaServer.OpcNodes;
using System.Security.Cryptography.X509Certificates;

namespace DexterOpcUaTestServer
{
    public class OpcUaHelper
    {
        #region Public properties

        public OpcUaNodes Nodes => OpcUaServer.Nodes;
        public OpcUaServer.OpcUaServer OpcUaServer;

        #endregion

        #region Private fields

        private static uint serverWatchdog = 1;
        private readonly X509Certificate2 certificate;
        private readonly string userName;
        private readonly string password;
        private readonly bool enableAnonymous;
        private readonly bool enableUserAndPassword;
        private readonly bool enableCertificate;

        #endregion

        #region Public methods

        public OpcUaHelper(string serverName, string homeFolder, bool enableAnonymous, bool enableUserAndPassword,
            bool enableCertificate, string userName, string password, X509Certificate2 certificate)
        {
            // Add null checks
            if (string.IsNullOrEmpty(serverName))
                throw new ArgumentException("Server name cannot be null or empty", nameof(serverName));
            if (string.IsNullOrEmpty(homeFolder))
                throw new ArgumentException("Home folder cannot be null or empty", nameof(homeFolder));

            this.enableUserAndPassword = enableUserAndPassword;
            this.enableAnonymous = enableAnonymous;
            this.enableCertificate = enableCertificate;
            this.userName = userName;
            this.password = password;
            this.certificate = certificate;

            try
            {
                OpcUaServer = new OpcUaServer.OpcUaServer(
                    serverName,
                    homeFolder,
                    Properties.Settings.Default.OpcNameSpace,
                    Properties.Settings.Default.NodeSeparator,
                    Instrument.Dexter);
                //OpcUaServer.Server.CertificateStores.AutoCreateCertificate = true;
                SetAuthentication();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to initialize OpcUaServer: {ex.Message}", ex);
            }
        }

        public void StartServer()
        {
            if (OpcUaServer == null)
                throw new InvalidOperationException("OpcUaServer is not initialized. Call the constructor first.");

            // Ensure certificate stores are created before starting the server
            if (OpcUaServer.Server?.CertificateStores != null)
            {
                OpcUaServer.Server.CertificateStores.AutoCreateCertificate = true;
            }

            OpcUaServer.StartServer();
        }

        public void StopServer()
        {
            OpcUaServer.StopServer();
        }

        public void StartMeasuring(string product)
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodes.ProductCode, product);
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesDexter.StartMeasuring, true);
        }

        public void StartMeasuring()
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesDexter.StartMeasuring, true);
        }

        public void StopMeasuring()
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodesDexter.StartMeasuring, false);
        }

        public void ChangeProduct(string newProduct)
        {
            OpcUaServer.SetNodeValue(Nodes.ControllerNodes.ProductCode, newProduct);
        }

        public void SetRecipe(string recipeCode)
        {
            if (uint.TryParse(recipeCode, out uint recipeCodeN))
            {
                OpcUaServer.SetNodeValue(Nodes.ControllerNodesDexter.RecipeCodeN, recipeCodeN);
            }
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
