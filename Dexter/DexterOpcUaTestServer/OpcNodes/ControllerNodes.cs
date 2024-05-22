using Opc.UaFx;
using System.Collections.Generic;

namespace DexterOpcUaTestServer.OpcNodes
{
    public class ControllerNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<string> ProductCode;
        public OpcDataVariableNode<int> ProductCodeN;
        public OpcDataVariableNode<string> RecipeCode;
        public OpcDataVariableNode<uint> RecipeCodeN;
        public OpcDataVariableNode<bool> StartMeasuring;
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
            ProductCodeN = CreateOpcUaNode<int>(controllerFolder, "ProductCodeN", nodes);
            RecipeCode = CreateOpcUaNode<string>(controllerFolder, "RecipeCode", nodes);
            RecipeCodeN = CreateOpcUaNode<uint>(controllerFolder, "RecipeCodeN", nodes);
            StartMeasuring = CreateOpcUaNode<bool>(controllerFolder, "StartMeasuring", nodes);
            WatchdogCounter = CreateOpcUaNode<uint>(controllerFolder, "WatchdogCounter", nodes);
        }
    }
}
