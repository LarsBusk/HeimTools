using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class ParametersNodesDexter : NodeBase
    {
        public OpcDataVariableNode<float> FatValue;
        public OpcDataVariableNode<string> FatUnit;
        public OpcDataVariableNode<float> WeightValue;
        public OpcDataVariableNode<string> WeightUnit;
        public OpcDataVariableNode<float> BoneValue;
        public OpcDataVariableNode<string> BoneUnit;
        public OpcDataVariableNode<float> MetalValue;
        public OpcDataVariableNode<string> MetalUnit;
        public List<IOpcNode> Nodes => nodes;
        
        private readonly OpcFolderNode parametersFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();
        private readonly string[] parameters = { "Fat", "Weight", "Bone", "Metal"};


        public ParametersNodesDexter(OpcFolderNode parentFolderNode)
        {
            this.FolderName = "Parameters";
            parametersFolder = new OpcFolderNode(parentFolderNode, FolderName);
            SetNodeTree(parentFolderNode, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            foreach (var parameter in parameters)
            {
                nodes.AddRange(ResultFolderNodes(parameter));
            }
        }

        private List<IOpcNode> ResultFolderNodes(string parameterName)
        {
            var nodes = new List<IOpcNode>();
            var parameterFolder = new OpcFolderNode(parametersFolder, parameterName);
            var valueNode = CreateOpcUaNode<float>(parameterFolder, $"{parameterName}{NodeSeparator}Result");
            var unitNode = CreateOpcUaNode<string>(parameterFolder, $"{parameterName}{NodeSeparator}Unit");

            switch (parameterName)
            {
                case "Fat":
                    FatValue = valueNode;
                    FatUnit = unitNode;
                    break;
                case "Weight":
                    WeightValue = valueNode;
                    WeightUnit = unitNode;
                    break;
                case "Bone":
                    BoneValue = valueNode;
                    BoneUnit = unitNode;
                    break;
                case "Metal":
                    MetalValue = valueNode;
                    MetalUnit = unitNode;
                    break;
            }

            nodes.Add(valueNode);
            nodes.Add(unitNode);

            return nodes;
        }
    }
}
