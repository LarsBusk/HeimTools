using Opc.UaFx;
using System.Collections.Generic;

namespace OpcUaServer.OpcNodes
{
    public class OpcUaNodes
    {
        #region Public nodegroups

        public InstrumentNodes InstrumentNodes;
        public InstrumentNodesDexter InstrumentNodesDexter;
        public InstrumentNodesNora InstrumentNodesNora;
        public ControllerNodes ControllerNodes;
        public ControllerNodesDexter ControllerNodesDexter;
        public ControllerNodesNora ControllerNodesNora;
        public SampleNodes SampleNodes;
        public EventNodes EventNodes;
        public AlarmNodes AlarmNodes;
        public AlarmNodesNora AlarmNodesNora;
        public AlarmNodesDexter AlarmNodesDexter;
        public BatchNodes BatchNodes;
        public RejectorNodes RejectorNodes;
        public ResultNodes ResultNodes;

        #endregion


        public List<IOpcNode> Nodes => this.nodes;

        private readonly List<IOpcNode> nodes;
        private readonly OpcFolderNode homeFolder;

        public OpcUaNodes(string homeFolderName, Instrument instrument)//, string opcNameSpace, string nodeSeparator)
        {
            nodes = new List<IOpcNode>();
            homeFolder = new OpcFolderNode(homeFolderName);
            GetNodes(instrument);
        }

        private void GetNodes(Instrument instrument)
        {
            InstrumentNodes = new InstrumentNodes(homeFolder);
            nodes.AddRange(InstrumentNodes.Nodes);
            ControllerNodes = new ControllerNodes(homeFolder);
            nodes.AddRange(ControllerNodes.Nodes);
            SampleNodes = new SampleNodes(homeFolder, instrument);
            nodes.AddRange(SampleNodes.Nodes);
            EventNodes = new EventNodes(homeFolder);
            nodes.AddRange(EventNodes.Nodes);
            AlarmNodes = new AlarmNodes(homeFolder);
            nodes.AddRange(AlarmNodes.Nodes);
            switch (instrument)
            {
                case Instrument.Nora:
                    AlarmNodesNora = new AlarmNodesNora(homeFolder);
                    nodes.AddRange(AlarmNodesNora.Nodes);
                    ControllerNodesNora = new ControllerNodesNora(homeFolder);
                    nodes.AddRange(ControllerNodesNora.Nodes);
                    InstrumentNodesNora = new InstrumentNodesNora(homeFolder);
                    nodes.AddRange(InstrumentNodesNora.Nodes);
                    break;
                case Instrument.Dexter:
                    AlarmNodesDexter = new AlarmNodesDexter(homeFolder);
                    nodes.AddRange(AlarmNodesDexter.Nodes);
                    ControllerNodesDexter = new ControllerNodesDexter(homeFolder);
                    nodes.AddRange(ControllerNodesDexter.Nodes);
                    InstrumentNodesDexter = new InstrumentNodesDexter(homeFolder);
                    nodes.AddRange(InstrumentNodesDexter.Nodes);
                    BatchNodes = new BatchNodes(homeFolder);
                    nodes.AddRange(BatchNodes.Nodes);
                    RejectorNodes = new RejectorNodes(homeFolder); 
                    nodes.AddRange(RejectorNodes.Nodes);
                    ResultNodes = new ResultNodes(homeFolder, instrument);
                    nodes.AddRange(ResultNodes.Nodes);
                    break;
            }

        }
    }
}
