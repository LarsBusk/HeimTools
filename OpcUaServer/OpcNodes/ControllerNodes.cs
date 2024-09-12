using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class ControllerNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<string> ProductCode;
        public OpcDataVariableNode<uint> ProductCodeN;
        public OpcDataVariableNode<uint> WatchdogCounter;

        private readonly OpcFolderNode controllerFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();

        public ControllerNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "Controller";
            controllerFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            ProductCode = CreateOpcUaNode<string>(controllerFolder, "ProductCode", nodes);
            ProductCodeN = CreateOpcUaNode<uint>(controllerFolder, "ProductCodeN", nodes);
            WatchdogCounter = CreateOpcUaNode<uint>(controllerFolder, "WatchdogCounter", nodes);
        }
    }
}
