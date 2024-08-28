using Opc.UaFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcUaServer.OpcNodes
{
    public class AlarmNodesNora : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<bool> UninterruptibleMode;
        public OpcDataVariableNode<bool> CabinetDoorOpen;
        public OpcDataVariableNode<bool> ZeroSettingIncomplete;
        private readonly OpcFolderNode alarmsFolder;
        private List<IOpcNode> nodes = new List<IOpcNode>();

        public AlarmNodesNora(OpcFolderNode parentFolder)
        {
            this.FolderName = "Alarms";
            alarmsFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        public void GetNodes()
        {
            UninterruptibleMode = CreateOpcUaNode<bool>(alarmsFolder, "UninterruptibleMode", nodes);
            CabinetDoorOpen = CreateOpcUaNode<bool>(alarmsFolder, "CabinetDoorOpen", nodes);
            ZeroSettingIncomplete = CreateOpcUaNode<bool>(alarmsFolder, "ZeroSettingIncomplete", nodes);
        }
    }
}
