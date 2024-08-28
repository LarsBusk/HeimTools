using OpcUaServer.OpcNodes;
using OpcUaServer;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DexterOpcUaTestServer
{
    public class OpcUaHelper
    {
        #region Public properties

        public OpcUaNodes Nodes => Server.Nodes;
        public OpcUaServer.OpcUaServer Server;
        public string RawDataString;


        #endregion

        #region Private fields

        private static uint serverWatchdog = 1;
        private readonly string serverName;
        private readonly string homeFolder;
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
            this.enableUserAndPassword = enableUserAndPassword;
            this.enableAnonymous = enableAnonymous;
            this.enableCertificate = enableCertificate;
            this.userName = userName;
            this.password = password;
            this.certificate = certificate;

            Server = new OpcUaServer.OpcUaServer(
                serverName,
                homeFolder,
                Properties.Settings.Default.OpcNameSpace,
                Properties.Settings.Default.NodeSeparator,
                Instrument.Dexter);
            SetAuthentication();
        }

        public void StartServer()
        {
            Server.StartServer();
        }

        public void StopServer()
        {
            Server.StopServer();
        }

        public void StartMeasuring(string product)
        {
            Server.SetNodeValue(Nodes.ControllerNodes.ProductCode, product);
            Server.SetNodeValue(Nodes.ControllerNodesDexter.StartMeasuring, true);
        }

        public void StartMeasuring()
        {
            Server.SetNodeValue(Nodes.ControllerNodesDexter.StartMeasuring, true);
        }

        public void StopMeasuring()
        {
            Server.SetNodeValue(Nodes.ControllerNodesDexter.StartMeasuring, false);
        }

        public void ChangeProduct(string newProduct)
        {
            Server.SetNodeValue(Nodes.ControllerNodes.ProductCode, newProduct);
        }

        public void SetRecipe(string recipeCode)
        {
            if (uint.TryParse(recipeCode, out uint recipeCodeN))
            {
                Server.SetNodeValue(Nodes.ControllerNodesDexter.RecipeCodeN, recipeCodeN);
            }
        }

        public void UpdateServerWatchdog()
        {
            Server.SetNodeValue(Nodes.ControllerNodes.WatchdogCounter, serverWatchdog);
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
            Server.EnableUserPassword(userName, password);
        }

        private void EnableCert()
        {
            Server.EnableCert(certificate);
        }

        private void SetAnonymous()
        {
            Server.SetAnonymous(enableAnonymous);
        }

        #endregion
    }
}
