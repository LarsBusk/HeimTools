using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class ControllerNodesNora : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;

        public OpcDataVariableNode<int> ModeN;
        public OpcDataVariableNode<int> PipetteProductCodeN;
        public OpcDataVariableNode<bool> ZeroToQueue;
        public OpcDataVariableNode<bool> CleanToQueue;
        public OpcDataVariableNode<bool> NoDelayedResults;
        public OpcDataVariableNode<string> SampleRegistration;
        public OpcDataVariableNode<string> PipetteProductCode;

        private readonly OpcFolderNode controllerFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();

        public ControllerNodesNora(OpcFolderNode parentFolder)
        {
            this.FolderName = "Controller";
            controllerFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            ModeN = CreateOpcUaNode<int>(controllerFolder, "ModeN", nodes);
            ZeroToQueue = CreateOpcUaNode<bool>(controllerFolder, "ZeroToQueue", nodes);
            CleanToQueue = CreateOpcUaNode<bool>(controllerFolder, "CleanToQueue", nodes);
            NoDelayedResults = CreateOpcUaNode<bool>(controllerFolder, "NoDelayedResults", nodes);
            //SampleRegistration node in in 2 subfolders.
            SampleRegistration = CreateOpcUaNode<string>(controllerFolder,
                $"SampleRegistration{NodeSeparator}PreRegistration{NodeSeparator}Value", nodes);
            PipetteProductCode = CreateOpcUaNode<string>(controllerFolder, "PipetteProductCode", nodes);
            PipetteProductCodeN = CreateOpcUaNode<int>(controllerFolder, "PipetteProductCodeN", nodes);
        }
    }
}
