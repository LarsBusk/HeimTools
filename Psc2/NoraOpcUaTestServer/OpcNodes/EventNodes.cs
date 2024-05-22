using Opc.UaFx;
using System.Collections.Generic;

namespace NoraOpcUaTestServer.OpcNodes
{
    public class EventNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<uint> EventsCount;
        public OpcDataVariableNode<string[]> EventMessages;
        public OpcDataVariableNode<string[]> EventHints;
        public OpcDataVariableNode<string[]> EventSources;
        public OpcDataVariableNode<uint[]> EventCodes;
        public OpcDataVariableNode<ushort[]> EventSeverity;

        private readonly OpcFolderNode eventsFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();

        public EventNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "Events";
            eventsFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            EventsCount = CreateOpcUaNode<uint>(eventsFolder, "Count", nodes);
            EventMessages = CreateOpcUaNode<string[]>(eventsFolder, "Message", nodes);
            EventCodes = CreateOpcUaNode<uint[]>(eventsFolder, "ID", nodes);
            EventHints = CreateOpcUaNode<string[]>(eventsFolder, "Hint", nodes);
            EventSeverity = CreateOpcUaNode<ushort[]>(eventsFolder, "Severity", nodes);
            EventSources = CreateOpcUaNode<string[]>(eventsFolder, "Source", nodes);
        }
    }
}
