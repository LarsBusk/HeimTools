using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class InstrumentNodes : NodeBase
    {


        public OpcDataVariableNode<uint> WatchdogCounter;
        public OpcDataVariableNode<string> Mode;
        public OpcDataVariableNode<uint> SampleCounter;
        public OpcDataVariableNode<string> ProductName;
        public OpcDataVariableNode<string> ProductCode;
        public OpcDataVariableNode<int> ProductCodeN;
        public OpcDataVariableNode<string> SerialNumber;
        public OpcDataVariableNode<bool> CleanInQueue;

        public List<IOpcNode> Nodes => nodes;

        private readonly OpcFolderNode instrumentFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();


        public InstrumentNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "Instrument";
            instrumentFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            WatchdogCounter = CreateOpcUaNode<uint>(instrumentFolder, "WatchdogCounter", nodes);
            SampleCounter = CreateOpcUaNode<uint>(instrumentFolder, "SampleCounter", nodes);
            ProductCode = CreateOpcUaNode<string>(instrumentFolder, "ProductCode", nodes);
            ProductCodeN = CreateOpcUaNode<int>(instrumentFolder, "ProductCodeN", nodes);
            ProductName = CreateOpcUaNode<string>(instrumentFolder, "ProductName", nodes);
            Mode = CreateOpcUaNode<string>(instrumentFolder, "Mode", "Disconnected");
            nodes.Add(Mode);
            SerialNumber = CreateOpcUaNode<string>(instrumentFolder, "SerialNumber", nodes);
            CleanInQueue = CreateOpcUaNode<bool>(instrumentFolder, "CleanInQueue", nodes);
        }
    }
}
