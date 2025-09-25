using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;

namespace OpcUaServer.OpcNodes
{
    public class SampleRegistrationNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<string> Value;
        public OpcDataVariableNode<int> ValueN;

        private readonly OpcFolderNode sampleRegistrationFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();
        public SampleRegistrationNodes(OpcFolderNode parentFolder, int number)
        {
            this.FolderName = $"SampleRegistration{number}";
            sampleRegistrationFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            Value = CreateOpcUaNode<string>(sampleRegistrationFolder, "Value", nodes);
            ValueN = CreateOpcUaNode<int>(sampleRegistrationFolder, "ValueN", nodes);
        }
    }
}
