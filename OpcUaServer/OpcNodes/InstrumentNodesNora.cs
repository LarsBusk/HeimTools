using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class InstrumentNodesNora : NodeBase
    {
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
        public OpcDataVariableNode<int> ModeN;

        public List<IOpcNode> Nodes => nodes;

        private readonly OpcFolderNode instrumentFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();


        public InstrumentNodesNora(OpcFolderNode parentFolder)
        {
            this.FolderName = "Instrument";
            instrumentFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
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
            ModeN = CreateOpcUaNode<int>(instrumentFolder, "ModeN", nodes);
        }
    }
}
