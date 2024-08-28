using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class AlarmNodes : NodeBase  
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<uint> Count;
        public OpcDataVariableNode<bool> SystemAlarms;
        private readonly OpcFolderNode alarmsFolder;
        private List<IOpcNode> nodes = new List<IOpcNode>();

        public AlarmNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "Alarms";
            alarmsFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        public void GetNodes()
        {
            Count = CreateOpcUaNode<uint>(alarmsFolder, "Count", nodes);
            SystemAlarms = CreateOpcUaNode<bool>(alarmsFolder, "SystemAlarms", nodes);
        }
    }
}
