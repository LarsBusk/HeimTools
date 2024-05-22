using Opc.UaFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterOpcUaTestServer.OpcNodes
{
    public class BatchNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<int> BatchNumber;
        //public OpcDataVariableNode<int> BatchNumberN;
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
            //BatchNumberN = CreateOpcUaNode<int>(batchFolder, "BatchNumberN", nodes);
            Timestamp = CreateOpcUaNode<DateTime>(batchFolder, "Timestamp.DateTime", nodes);
            ParameterNodes = new BatchParametersNodes(batchFolder);
            nodes.AddRange(ParameterNodes.Nodes);
        }
    }
}
