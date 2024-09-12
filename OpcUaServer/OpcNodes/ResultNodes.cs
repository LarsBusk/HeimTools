using Opc.UaFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcUaServer.OpcNodes
{
    public class ResultNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public ParametersNodesDexter ParametersNodesDexter;
        public TimeStampNodes TimeStampNodes;

        private readonly OpcFolderNode resultFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();
        private readonly Instrument instrument;

        public ResultNodes(OpcFolderNode parentFolder, Instrument instrument)
        {
            this.FolderName = "Result";
            resultFolder = new OpcFolderNode(parentFolder, FolderName);
            this.instrument = instrument;
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            ParametersNodesDexter = new ParametersNodesDexter(resultFolder);
            nodes.AddRange(ParametersNodesDexter.Nodes);
            TimeStampNodes = new TimeStampNodes(resultFolder);
            nodes.AddRange(TimeStampNodes.Nodes);
        }
    }
}
