using Opc.UaFx;
using System.Collections.Generic;

namespace DexterOpcUaTestServer.OpcNodes
{
    public class InstrumentNodes : NodeBase
    {


        public OpcDataVariableNode<uint> WatchdogCounter;
        public OpcDataVariableNode<string> Mode;
        public OpcDataVariableNode<uint> ModeN;
        public OpcDataVariableNode<uint> SampleCounter;
        public OpcDataVariableNode<uint> BatchCounter;
        public OpcDataVariableNode<string> ProductName;
        public OpcDataVariableNode<string> ProductCode;
        public OpcDataVariableNode<int> ProductCodeN;
        public OpcDataVariableNode<string> SerialNumber;
        public OpcDataVariableNode<bool> AutomaticReferenceRunning;
        public OpcDataVariableNode<bool> ReadyToReceiveSample;
        public OpcDataVariableNode<float> ConveyorSpeed;
        public OpcDataVariableNode<string> RecipeCode;
        public OpcDataVariableNode<uint> RecipeCodeN;
        public OpcDataVariableNode<string> RecipeName;

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
            ModeN = CreateOpcUaNode<uint>(instrumentFolder, "ModeN", nodes);
            SampleCounter = CreateOpcUaNode<uint>(instrumentFolder, "SampleCounter", nodes);
            BatchCounter = CreateOpcUaNode<uint>(instrumentFolder, "BatchCounter", nodes);
            ProductCode = CreateOpcUaNode<string>(instrumentFolder, "ProductCode", nodes);
            ProductCodeN = CreateOpcUaNode<int>(instrumentFolder, "ProductCodeN", nodes);
            ProductName = CreateOpcUaNode<string>(instrumentFolder, "ProductName", nodes);
            Mode = CreateOpcUaNode<string>(instrumentFolder, "Mode", "Disconnected");
            nodes.Add(Mode);
            SerialNumber = CreateOpcUaNode<string>(instrumentFolder, "SerialNumber", nodes);
            AutomaticReferenceRunning = CreateOpcUaNode<bool>(instrumentFolder, "AutomaticReferenceRunning", nodes);
            ReadyToReceiveSample = CreateOpcUaNode<bool>(instrumentFolder, "ReadyToReceiveSample", nodes);
            RecipeCode = CreateOpcUaNode<string>(instrumentFolder, "RecipeCode", nodes);
            RecipeCodeN = CreateOpcUaNode<uint>(instrumentFolder, "RecipeCodeN", nodes);
            RecipeName = CreateOpcUaNode<string>(instrumentFolder, "RecipeName", nodes);
            ConveyorSpeed = CreateOpcUaNode<float>(instrumentFolder, "ConveyorSpeed", nodes);
        }
    }
}
