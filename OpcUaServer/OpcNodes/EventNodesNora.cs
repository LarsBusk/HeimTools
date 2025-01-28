using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class EventNodesNora : NodeBase
    {
        public List<IOpcNode> Nodes => nodes;
        public OpcDataVariableNode<string> Hint01;
        public OpcDataVariableNode<string> Hint02;
        public OpcDataVariableNode<string> Hint03;
        public OpcDataVariableNode<string> Hint04;
        public OpcDataVariableNode<string> Hint05;
        public OpcDataVariableNode<string> Hint06;
        public OpcDataVariableNode<string> Hint07;
        public OpcDataVariableNode<string> Hint08;
        public OpcDataVariableNode<string> Hint09;
        public OpcDataVariableNode<string> Hint10;
        public OpcDataVariableNode<string> Hint11;
        public OpcDataVariableNode<string> Hint12;
        public OpcDataVariableNode<string> Hint13;
        public OpcDataVariableNode<string> Hint14;
        public OpcDataVariableNode<string> Hint15;
        public OpcDataVariableNode<string> Hint16;

        public OpcDataVariableNode<string> Message01;
        public OpcDataVariableNode<string> Message02;
        public OpcDataVariableNode<string> Message03;
        public OpcDataVariableNode<string> Message04;
        public OpcDataVariableNode<string> Message05;
        public OpcDataVariableNode<string> Message06;
        public OpcDataVariableNode<string> Message07;
        public OpcDataVariableNode<string> Message08;
        public OpcDataVariableNode<string> Message09;
        public OpcDataVariableNode<string> Message10;
        public OpcDataVariableNode<string> Message11;
        public OpcDataVariableNode<string> Message12;
        public OpcDataVariableNode<string> Message13;
        public OpcDataVariableNode<string> Message14;
        public OpcDataVariableNode<string> Message15;
        public OpcDataVariableNode<string> Message16;

        public OpcDataVariableNode<string> Source01;
        public OpcDataVariableNode<string> Source02;
        public OpcDataVariableNode<string> Source03;
        public OpcDataVariableNode<string> Source04;
        public OpcDataVariableNode<string> Source05;
        public OpcDataVariableNode<string> Source06;
        public OpcDataVariableNode<string> Source07;
        public OpcDataVariableNode<string> Source08;
        public OpcDataVariableNode<string> Source09;
        public OpcDataVariableNode<string> Source10;
        public OpcDataVariableNode<string> Source11;
        public OpcDataVariableNode<string> Source12;
        public OpcDataVariableNode<string> Source13;
        public OpcDataVariableNode<string> Source14;
        public OpcDataVariableNode<string> Source15;
        public OpcDataVariableNode<string> Source16;


        public OpcDataVariableNode<uint> ID01;
        public OpcDataVariableNode<uint> ID02;
        public OpcDataVariableNode<uint> ID03;
        public OpcDataVariableNode<uint> ID04;
        public OpcDataVariableNode<uint> ID05;
        public OpcDataVariableNode<uint> ID06;
        public OpcDataVariableNode<uint> ID07;
        public OpcDataVariableNode<uint> ID08;
        public OpcDataVariableNode<uint> ID09;
        public OpcDataVariableNode<uint> ID10;
        public OpcDataVariableNode<uint> ID11;
        public OpcDataVariableNode<uint> ID12;
        public OpcDataVariableNode<uint> ID13;
        public OpcDataVariableNode<uint> ID14;
        public OpcDataVariableNode<uint> ID15;
        public OpcDataVariableNode<uint> ID16;

        public OpcDataVariableNode<ushort> Severity01;
        public OpcDataVariableNode<ushort> Severity02;
        public OpcDataVariableNode<ushort> Severity03;
        public OpcDataVariableNode<ushort> Severity04;
        public OpcDataVariableNode<ushort> Severity05;
        public OpcDataVariableNode<ushort> Severity06;
        public OpcDataVariableNode<ushort> Severity07;
        public OpcDataVariableNode<ushort> Severity08;
        public OpcDataVariableNode<ushort> Severity09;
        public OpcDataVariableNode<ushort> Severity10;
        public OpcDataVariableNode<ushort> Severity11;
        public OpcDataVariableNode<ushort> Severity12;
        public OpcDataVariableNode<ushort> Severity13;
        public OpcDataVariableNode<ushort> Severity14;
        public OpcDataVariableNode<ushort> Severity15;
        public OpcDataVariableNode<ushort> Severity16;

        private readonly OpcFolderNode eventsFolder;
        private readonly List<IOpcNode> nodes = new List<IOpcNode>();

        public EventNodesNora(OpcFolderNode parentFolder)
        {
            this.FolderName = "Events";
            eventsFolder = new OpcFolderNode(parentFolder, FolderName);
            SetNodeTree(parentFolder, FolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            Hint01 = CreateOpcUaNode<string>(eventsFolder, "Hint01", nodes);
            Hint02 = CreateOpcUaNode<string>(eventsFolder, "Hint02", nodes);
            Hint03 = CreateOpcUaNode<string>(eventsFolder, "Hint03", nodes);
            Hint04 = CreateOpcUaNode<string>(eventsFolder, "Hint04", nodes);
            Hint05 = CreateOpcUaNode<string>(eventsFolder, "Hint05", nodes);
            Hint06 = CreateOpcUaNode<string>(eventsFolder, "Hint06", nodes);
            Hint07 = CreateOpcUaNode<string>(eventsFolder, "Hint07", nodes);
            Hint08 = CreateOpcUaNode<string>(eventsFolder, "Hint08", nodes);
            Hint09 = CreateOpcUaNode<string>(eventsFolder, "Hint09", nodes);
            Hint10 = CreateOpcUaNode<string>(eventsFolder, "Hint10", nodes);
            Hint11 = CreateOpcUaNode<string>(eventsFolder, "Hint11", nodes);
            Hint12 = CreateOpcUaNode<string>(eventsFolder, "Hint12", nodes);
            Hint13 = CreateOpcUaNode<string>(eventsFolder, "Hint13", nodes);
            Hint14 = CreateOpcUaNode<string>(eventsFolder, "Hint14", nodes);
            Hint15 = CreateOpcUaNode<string>(eventsFolder, "Hint15", nodes);
            Hint16 = CreateOpcUaNode<string>(eventsFolder, "Hint16", nodes);

            Message01 = CreateOpcUaNode<string>(eventsFolder, "Message01", nodes);
            Message02 = CreateOpcUaNode<string>(eventsFolder, "Message02", nodes);
            Message03 = CreateOpcUaNode<string>(eventsFolder, "Message03", nodes);
            Message04 = CreateOpcUaNode<string>(eventsFolder, "Message04", nodes);
            Message05 = CreateOpcUaNode<string>(eventsFolder, "Message05", nodes);
            Message06 = CreateOpcUaNode<string>(eventsFolder, "Message06", nodes);
            Message07 = CreateOpcUaNode<string>(eventsFolder, "Message07", nodes);
            Message08 = CreateOpcUaNode<string>(eventsFolder, "Message08", nodes);
            Message09 = CreateOpcUaNode<string>(eventsFolder, "Message09", nodes);
            Message10 = CreateOpcUaNode<string>(eventsFolder, "Message10", nodes);
            Message11 = CreateOpcUaNode<string>(eventsFolder, "Message11", nodes);
            Message12 = CreateOpcUaNode<string>(eventsFolder, "Message12", nodes);
            Message13 = CreateOpcUaNode<string>(eventsFolder, "Message13", nodes);
            Message14 = CreateOpcUaNode<string>(eventsFolder, "Message14", nodes);
            Message15 = CreateOpcUaNode<string>(eventsFolder, "Message15", nodes);
            Message16 = CreateOpcUaNode<string>(eventsFolder, "Message16", nodes);

            ID01 = CreateOpcUaNode<uint>(eventsFolder, "ID01", nodes);
            ID02 = CreateOpcUaNode<uint>(eventsFolder, "ID02", nodes);
            ID03 = CreateOpcUaNode<uint>(eventsFolder, "ID03", nodes);
            ID04 = CreateOpcUaNode<uint>(eventsFolder, "ID04", nodes);
            ID05 = CreateOpcUaNode<uint>(eventsFolder, "ID05", nodes);
            ID06 = CreateOpcUaNode<uint>(eventsFolder, "ID06", nodes);
            ID07 = CreateOpcUaNode<uint>(eventsFolder, "ID07", nodes);
            ID08 = CreateOpcUaNode<uint>(eventsFolder, "ID08", nodes);
            ID09 = CreateOpcUaNode<uint>(eventsFolder, "ID09", nodes);
            ID10 = CreateOpcUaNode<uint>(eventsFolder, "ID10", nodes);
            ID11 = CreateOpcUaNode<uint>(eventsFolder, "ID11", nodes);
            ID12 = CreateOpcUaNode<uint>(eventsFolder, "ID12", nodes);
            ID13 = CreateOpcUaNode<uint>(eventsFolder, "ID13", nodes);
            ID14 = CreateOpcUaNode<uint>(eventsFolder, "ID14", nodes);
            ID15 = CreateOpcUaNode<uint>(eventsFolder, "ID15", nodes);
            ID16 = CreateOpcUaNode<uint>(eventsFolder, "ID16", nodes);

            Severity01 = CreateOpcUaNode<ushort>(eventsFolder, "Severity01", nodes);
            Severity02 = CreateOpcUaNode<ushort>(eventsFolder, "Severity02", nodes);
            Severity03 = CreateOpcUaNode<ushort>(eventsFolder, "Severity03", nodes);
            Severity04 = CreateOpcUaNode<ushort>(eventsFolder, "Severity04", nodes);
            Severity05 = CreateOpcUaNode<ushort>(eventsFolder, "Severity05", nodes);
            Severity06 = CreateOpcUaNode<ushort>(eventsFolder, "Severity06", nodes);
            Severity07 = CreateOpcUaNode<ushort>(eventsFolder, "Severity07", nodes);
            Severity08 = CreateOpcUaNode<ushort>(eventsFolder, "Severity08", nodes);
            Severity09 = CreateOpcUaNode<ushort>(eventsFolder, "Severity09", nodes);
            Severity10 = CreateOpcUaNode<ushort>(eventsFolder, "Severity10", nodes);
            Severity11 = CreateOpcUaNode<ushort>(eventsFolder, "Severity11", nodes);
            Severity12 = CreateOpcUaNode<ushort>(eventsFolder, "Severity12", nodes);
            Severity13 = CreateOpcUaNode<ushort>(eventsFolder, "Severity13", nodes);
            Severity14 = CreateOpcUaNode<ushort>(eventsFolder, "Severity14", nodes);
            Severity15 = CreateOpcUaNode<ushort>(eventsFolder, "Severity15", nodes);
            Severity16 = CreateOpcUaNode<ushort>(eventsFolder, "Severity16", nodes);

            Source01 = CreateOpcUaNode<string>(eventsFolder, "Source01", nodes);
            Source02 = CreateOpcUaNode<string>(eventsFolder, "Source02", nodes);
            Source03 = CreateOpcUaNode<string>(eventsFolder, "Source03", nodes);
            Source04 = CreateOpcUaNode<string>(eventsFolder, "Source04", nodes);
            Source05 = CreateOpcUaNode<string>(eventsFolder, "Source05", nodes);
            Source06 = CreateOpcUaNode<string>(eventsFolder, "Source06", nodes);
            Source07 = CreateOpcUaNode<string>(eventsFolder, "Source07", nodes);
            Source08 = CreateOpcUaNode<string>(eventsFolder, "Source08", nodes);
            Source09 = CreateOpcUaNode<string>(eventsFolder, "Source09", nodes);
            Source10 = CreateOpcUaNode<string>(eventsFolder, "Source10", nodes);
            Source11 = CreateOpcUaNode<string>(eventsFolder, "Source11", nodes);
            Source12 = CreateOpcUaNode<string>(eventsFolder, "Source12", nodes);
            Source13 = CreateOpcUaNode<string>(eventsFolder, "Source13", nodes);
            Source14 = CreateOpcUaNode<string>(eventsFolder, "Source14", nodes);
            Source15 = CreateOpcUaNode<string>(eventsFolder, "Source15", nodes);
            Source16 = CreateOpcUaNode<string>(eventsFolder, "Source16", nodes);
        }
    }
}
