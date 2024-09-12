using Opc.UaFx;
using System;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class BatchNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<int> BatchNumber;
        public OpcDataVariableNode<DateTime> Timestamp;
        public BatchParametersNodes ParameterNodes;

        private readonly List<IOpcNode> nodes = new List<IOpcNode>();
        private readonly OpcFolderNode batchFolder;

        public BatchNodes(OpcFolderNode parrentFolder)
        {
            this.FolderName = "Batch";
            batchFolder = new OpcFolderNode(parrentFolder, FolderName);
            SetNodeTree(parrentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            BatchNumber = CreateOpcUaNode<int>(batchFolder, "BatchNumber", nodes);
            Timestamp = CreateOpcUaNode<DateTime>(batchFolder, "Timestamp.DateTime", nodes);
            ParameterNodes = new BatchParametersNodes(batchFolder);
            nodes.AddRange(ParameterNodes.Nodes);
        }
    }
}
