using Opc.UaFx;
using System.Collections.Generic;

namespace DexterOpcUaTestServer.OpcNodes
{
    public class BatchParametersNodes : NodeBase
    {
        public OpcDataVariableNode<float> FatValue;
        public OpcDataVariableNode<float> FatTarget;
        public OpcDataVariableNode<string> FatUnit;
        public OpcDataVariableNode<float> WeightValue;
        public OpcDataVariableNode<float> WeightTarget;
        public OpcDataVariableNode<string> WeightUnit;
        public OpcDataVariableNode<float> BoneValue;
        public OpcDataVariableNode<float> BoneTarget;
        public OpcDataVariableNode<string> BoneUnit;
        public OpcDataVariableNode<float> MetalValue;
        public OpcDataVariableNode<float> MetalTarget;
        public OpcDataVariableNode<string> MetalUnit;
        public List<IOpcNode> Nodes => nodes;
        
        private readonly OpcFolderNode parametersFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();
        private readonly string[] parameters = { "Fat", "Weight", "Bone", "Metal"};


        public BatchParametersNodes(OpcFolderNode parentFolderNode)
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
            var targetNode = CreateOpcUaNode<float>(parameterFolder, $"{parameterName}{NodeSeparator}Target");
            var unitNode = CreateOpcUaNode<string>(parameterFolder, $"{parameterName}{NodeSeparator}Unit");

            switch (parameterName)
            {
                case "Fat":
                    FatValue = valueNode;
                    FatTarget = targetNode;
                    FatUnit = unitNode;
                    break;
                case "Weight":
                    WeightValue = valueNode;
                    WeightTarget = targetNode;
                    WeightUnit = unitNode;
                    break;
                case "Bone":
                    BoneValue = valueNode;
                    BoneTarget = targetNode;
                    BoneUnit = unitNode;
                    break;
                case "Metal":
                    MetalValue = valueNode;
                    MetalTarget = targetNode;
                    MetalUnit = unitNode;
                    break;
            }

            nodes.Add(valueNode);
            nodes.Add(targetNode);
            nodes.Add(unitNode);

            return nodes;
        }
    }
}
