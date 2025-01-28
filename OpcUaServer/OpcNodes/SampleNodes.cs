using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class SampleNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public ParametersNodesNora ParametersNodesNora;
        public ParametersNodesDexter ParametersNodesDexter;
        public TimeStampNodes TimeStampNodes;
        public SampleEventNodes EventNodes;
        public SampleEventNodesNora SampleEventNodesNora;
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
        private readonly Instrument instrument;

        public SampleNodes(OpcFolderNode parentFolder, Instrument instrument)
        {
            this.FolderName = "Sample";
            sampleFolder = new OpcFolderNode(parentFolder, FolderName);
            this.instrument = instrument;
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
            MovingAverageCalculated = CreateOpcUaNode<bool>(sampleFolder, "MovingAverageReported", nodes);
            TimeStampNodes = new TimeStampNodes(sampleFolder);
            nodes.AddRange(TimeStampNodes.Nodes);
            EventNodes = new SampleEventNodes(sampleFolder);
            nodes.AddRange(EventNodes.Nodes);

            switch (instrument)
            {
                case Instrument.Nora:
                    ParametersNodesNora = new ParametersNodesNora(sampleFolder);
                    nodes.AddRange(ParametersNodesNora.Nodes);
                    SampleEventNodesNora = new SampleEventNodesNora(sampleFolder);
                    nodes.AddRange(SampleEventNodesNora.Nodes);
                    break;
                case Instrument.Dexter:
                    ParametersNodesDexter = new ParametersNodesDexter(sampleFolder);
                    nodes.AddRange(ParametersNodesDexter.Nodes);
                    break;
            }
        }
    }
}

