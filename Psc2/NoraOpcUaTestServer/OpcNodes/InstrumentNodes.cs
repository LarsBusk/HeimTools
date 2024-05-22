using Opc.UaFx;
using System.Collections.Generic;

namespace NoraOpcUaTestServer.OpcNodes
{
    public class InstrumentNodes : NodeBase
    {


        public OpcDataVariableNode<uint> WatchdogCounter;
        public OpcDataVariableNode<string> Mode;
        public OpcDataVariableNode<int> ModeN;
        public OpcDataVariableNode<uint> SampleCounter;
        public OpcDataVariableNode<string> ProductName;
        public OpcDataVariableNode<string> ProductCode;
        public OpcDataVariableNode<int> ProductCodeN;
        public OpcDataVariableNode<string> SerialNumber;
        public OpcDataVariableNode<bool> CleanInQueue;
        public OpcDataVariableNode<bool> CleanToQueue;
        public OpcDataVariableNode<bool> ZeroInQueue;
        public OpcDataVariableNode<bool> ZeroToQueue;
        public OpcDataVariableNode<bool> NoDelayedResults;
        public OpcDataVariableNode<string> PipetteProductCode;
        public OpcDataVariableNode<int> PipetteProductCodeN;
        public OpcDataVariableNode<string> PipetteProductName;
        public OpcDataVariableNode<int> TimeUntilProcessClean;
        public OpcDataVariableNode<bool> PipetteProductIsCheckSampleDefinition;

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
            ModeN = CreateOpcUaNode<int>(instrumentFolder, "ModeN", nodes);
            SampleCounter = CreateOpcUaNode<uint>(instrumentFolder, "SampleCounter", nodes);
            ProductCode = CreateOpcUaNode<string>(instrumentFolder, "ProductCode", nodes);
            ProductCodeN = CreateOpcUaNode<int>(instrumentFolder, "ProductCodeN", nodes);
            ProductName = CreateOpcUaNode<string>(instrumentFolder, "ProductName", nodes);
            Mode = CreateOpcUaNode<string>(instrumentFolder, "Mode", "Disconnected");
            nodes.Add(Mode);
            SerialNumber = CreateOpcUaNode<string>(instrumentFolder, "SerialNumber", nodes);
            CleanInQueue = CreateOpcUaNode<bool>(instrumentFolder, "CleanInQueue", nodes);
            CleanToQueue = CreateOpcUaNode<bool>(instrumentFolder, "CleanToQueue", nodes);
            ZeroToQueue = CreateOpcUaNode<bool>(instrumentFolder, "ZeroToQueue", nodes);
            ZeroInQueue = CreateOpcUaNode<bool>(instrumentFolder, "ZeroInQueue", nodes);
            NoDelayedResults = CreateOpcUaNode<bool>(instrumentFolder, "NoDelayedResults", nodes);
            PipetteProductCode = CreateOpcUaNode<string>(instrumentFolder, "PipetteProductCode", nodes);
            PipetteProductCodeN = CreateOpcUaNode<int>(instrumentFolder, "PipetteProductCodeN", nodes);
            PipetteProductName = CreateOpcUaNode<string>(instrumentFolder, "PipetteProductName", nodes);
            TimeUntilProcessClean = CreateOpcUaNode<int>(instrumentFolder, "TimeUntilProcessClean", nodes);
            PipetteProductIsCheckSampleDefinition =
                CreateOpcUaNode<bool>(instrumentFolder, "PipetteProductIsCheckSampleDefinition", nodes);
        }
    }
}
