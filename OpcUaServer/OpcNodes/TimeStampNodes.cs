using Opc.UaFx;
using System;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class TimeStampNodes : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<DateTime> SampleDateTime;
        public OpcDataVariableNode<uint> Year;
        public OpcDataVariableNode<uint> Month;
        public OpcDataVariableNode<uint> Day;
        public OpcDataVariableNode<uint> Hour;
        public OpcDataVariableNode<uint> Minute;
        public OpcDataVariableNode<uint> Second;
        public OpcDataVariableNode<uint> MilliSecond;

        private readonly List<IOpcNode> nodes = new List<IOpcNode>();
        private OpcFolderNode timeStampFolder;
        

        public TimeStampNodes(OpcFolderNode parentFolder)
        {
            this.FolderName = "TimeStamp";
            timeStampFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            SampleDateTime = CreateOpcUaNode<DateTime>(timeStampFolder, "DateTime", nodes);
            Year = CreateOpcUaNode<uint>(timeStampFolder, "Year", nodes);
            Month = CreateOpcUaNode<uint>(timeStampFolder, "Month", nodes);
            Day = CreateOpcUaNode<uint>(timeStampFolder, "Day", nodes);
            Hour = CreateOpcUaNode<uint>(timeStampFolder, "Hour", nodes);
            Minute = CreateOpcUaNode<uint>(timeStampFolder, "Minute", nodes);
            Second = CreateOpcUaNode<uint>(timeStampFolder, "Second", nodes);
            MilliSecond = CreateOpcUaNode<uint>(timeStampFolder, "Msec", nodes);
        }
    }
}
