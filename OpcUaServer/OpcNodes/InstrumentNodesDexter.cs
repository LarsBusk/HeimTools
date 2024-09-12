using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class InstrumentNodesDexter : NodeBase
    {
        public OpcDataVariableNode<bool> AutomaticReferenceRunning;
        public OpcDataVariableNode<bool> ReadyToReceiveSample;
        public OpcDataVariableNode<bool> UpdateSession;
        public OpcDataVariableNode<float> ConveyorSpeed;
        public OpcDataVariableNode<string> RecipeCode;
        public OpcDataVariableNode<uint> RecipeCodeN;
        public OpcDataVariableNode<string> RecipeName;
        public OpcDataVariableNode<uint> BatchCounter;
        public OpcDataVariableNode<uint> ResultCounter;
        public OpcDataVariableNode<uint> ModeN;
        public SampleRegistrationNodes SampleRegistrationNodes0;
        public SampleRegistrationNodes SampleRegistrationNodes1;

        public List<IOpcNode> Nodes => nodes;

        private readonly OpcFolderNode instrumentFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();


        public InstrumentNodesDexter(OpcFolderNode parentFolder)
        {
            this.FolderName = "Instrument";
            instrumentFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            AutomaticReferenceRunning = CreateOpcUaNode<bool>(instrumentFolder, "AutomaticReferenceRunning", nodes);
            ReadyToReceiveSample = CreateOpcUaNode<bool>(instrumentFolder, "ReadyToReceiveSample", nodes);
            UpdateSession = CreateOpcUaNode<bool>(instrumentFolder, "UpdateSession", nodes);
            RecipeCode = CreateOpcUaNode<string>(instrumentFolder, "RecipeCode", nodes);
            RecipeCodeN = CreateOpcUaNode<uint>(instrumentFolder, "RecipeCodeN", nodes);
            RecipeName = CreateOpcUaNode<string>(instrumentFolder, "RecipeName", nodes);
            ConveyorSpeed = CreateOpcUaNode<float>(instrumentFolder, "ConveyorSpeed", nodes);
            BatchCounter = CreateOpcUaNode<uint>(instrumentFolder, "BatchCounter", nodes);
            ResultCounter = CreateOpcUaNode<uint>(instrumentFolder, "ResultCounter", nodes);
            ModeN = CreateOpcUaNode<uint>(instrumentFolder, "ModeN", nodes);
            SampleRegistrationNodes0 = new SampleRegistrationNodes(instrumentFolder, 0);
            SampleRegistrationNodes1 = new SampleRegistrationNodes(instrumentFolder, 1);
            nodes.AddRange(SampleRegistrationNodes1.Nodes);
            nodes.AddRange(SampleRegistrationNodes0.Nodes);
        }
    }
}
