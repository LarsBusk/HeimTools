using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class ControllerNodesDexter : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<string> RecipeCode;
        public OpcDataVariableNode<uint> RecipeCodeN;
        public OpcDataVariableNode<bool> StartMeasuring;
        public SampleRegistrationNodes SampleRegistrationNodes0;
        public SampleRegistrationNodes SampleRegistrationNodes1;

        private readonly OpcFolderNode controllerFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();

        public ControllerNodesDexter(OpcFolderNode parentFolder)
        {
            this.FolderName = "Controller";
            controllerFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            RecipeCode = CreateOpcUaNode<string>(controllerFolder, "RecipeCode", nodes);
            RecipeCodeN = CreateOpcUaNode<uint>(controllerFolder, "RecipeCodeN", nodes);
            StartMeasuring = CreateOpcUaNode<bool>(controllerFolder, "StartMeasuring", nodes);
            SampleRegistrationNodes0 = new SampleRegistrationNodes(controllerFolder, 0);
            SampleRegistrationNodes1 = new SampleRegistrationNodes(controllerFolder, 1);
            nodes.AddRange(SampleRegistrationNodes1.Nodes);
            nodes.AddRange(SampleRegistrationNodes0.Nodes);
        }
    }
}
