using Opc.UaFx;
using System.Collections.Generic;

namespace NoraOpcUaTestServer.OpcNodes
{
    public class SampleNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public ParametersNodes ParametersNodes;
        public TimeStampNodes TimeStampNodes;
        public SampleEventNodes EventNodes;
        public OpcDataVariableNode<string> SampleNumber;
        public OpcDataVariableNode<int> SampleNumberN;
        public OpcDataVariableNode<string> ProductCode;
        public OpcDataVariableNode<int> ProductCodeN;
        public OpcDataVariableNode<string> ProductName;
        public OpcDataVariableNode<int> Quality;
        public OpcDataVariableNode<string> SampleRegistrationValue;
        public OpcDataVariableNode<bool> MovingAverageCalculated;


        private readonly OpcFolderNode sampleFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();

        public SampleNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "Sample";
            sampleFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            SampleNumber = CreateOpcUaNode<string>(sampleFolder, "Number", nodes);
            SampleNumberN = CreateOpcUaNode<int>(sampleFolder, "NumberN", nodes);
            ProductCode = CreateOpcUaNode<string>(sampleFolder, "ProductCode", nodes);
            ProductCodeN = CreateOpcUaNode<int>(sampleFolder, "ProductCodeN", nodes);
            ProductName = CreateOpcUaNode<string>(sampleFolder, "ProductName", nodes);
            Quality = CreateOpcUaNode<int>(sampleFolder, "Quality", nodes);
            SampleRegistrationValue = CreateOpcUaNode<string>(sampleFolder, $"Registration{NodeSeparator}Value", nodes);
            MovingAverageCalculated = CreateOpcUaNode<bool>(sampleFolder, "MovingAverageCalculated", nodes);

            ParametersNodes = new ParametersNodes(sampleFolder);
            nodes.AddRange(ParametersNodes.Nodes);
            TimeStampNodes = new TimeStampNodes(sampleFolder);
            nodes.AddRange(TimeStampNodes.Nodes);
            EventNodes = new SampleEventNodes(sampleFolder);
            nodes.AddRange(EventNodes.Nodes);
        }
    }
}

