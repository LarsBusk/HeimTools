using Opc.UaFx;
using Opc.UaFx.Server;
using OpcUaServer.OpcNodes;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace OpcUaServer
{
    public class OpcUaServer
    {
        public OpcServer Server;
        public OpcUaNodes Nodes => opcUaNodes;
        public event EventHandler<ServerStateEventArgs> ServerStateChanged;
        

        private OpcUaNodes opcUaNodes;
        private readonly string serverName;
        private readonly string homeFolder;
        private readonly Instrument instrument;

        public OpcUaServer(string serverName, string homeFolder, string opcNamespace, string nodeSeparator, Instrument instrument)
        {
            this.serverName = serverName;
            this.homeFolder = homeFolder;
            NodeBase.NodeSeparator = nodeSeparator;
            NodeBase.OpcNameSpace = opcNamespace;
            this.instrument = instrument;   
            Server = CreateServer();
            Server.StateChanged += OnServerStateChanged;
        }

        public void StartServer()
        {
            Server.Start();
        }

        public void StopServer()
        {
            Server.Stop();
        }

        protected virtual void OnServerStateChanged(object sender, OpcServerStateChangedEventArgs e)
        {

            var args = new ServerStateEventArgs(e.NewState.ToString(), DateTime.Now);
            ServerStateChanged?.Invoke(this, args);
        }

        public void SetAnonymous(bool enableAnonymous)
        {
            Server.Security.AnonymousAcl.IsEnabled = enableAnonymous;
        }

        public void EnableUserPassword(string userName, string password)
        {
            var acl = Server.Security.UserNameAcl;
            acl.AddEntry(userName, password);
            acl.IsEnabled = true;
        }

        public void EnableCert(X509Certificate2 certificate)
        {
            Server.CertificateStores.AutoCreateCertificate = false;
            var acl = Server.Security.CertificateAcl;
            acl.AddEntry(certificate);
            acl.IsEnabled = true;
        }

        public void SetNodeValue<T>(OpcDataVariableNode<T> node, object value)
        {
            node.Value = (T)value;
            node.ApplyChanges(Server.SystemContext);
        }

        public void ToggleNode(OpcDataVariableNode<bool> node, TimeSpan onTime)
        {
            SetNodeValue(node, true);
            Thread.Sleep(onTime);
            SetNodeValue(node, false);
        }

        private OpcServer CreateServer()
        {
            opcUaNodes = new OpcUaNodes(homeFolder, instrument);

            Opc.UaFx.Licenser.LicenseKey = Keys.Version3Key;

            return new OpcServer(
                serverName,
                opcUaNodes.Nodes
                );
        }
    }

    public enum Instrument
    {
        Nora,
        Dexter
    }
}
