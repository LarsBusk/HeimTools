using Opc.UaFx;
using System.Collections.Generic;

namespace DexterOpcUaTestServer.OpcNodes
{
    public class DexterNodes
    {
        #region Public nodegroups

        public InstrumentNodes InstrumentNodes;
        public ControllerNodes ControllerNodes;
        public SampleNodes SampleNodes;
        public EventNodes EventNodes;
        public AlarmNodes AlarmNodes;
        public BatchNodes BatchNodes;
        public RejectorNodes RejectorNodes;

        #endregion


        public List<IOpcNode> Nodes => this.nodes;

        private readonly List<IOpcNode> nodes;
        private readonly OpcFolderNode homeFolder;

        public DexterNodes(string homeFolderName)
        {
            nodes = new List<IOpcNode>();
            homeFolder = new OpcFolderNode(homeFolderName);
            GetNodes();
        }

        private void GetNodes()
        {
            InstrumentNodes = new InstrumentNodes(homeFolder);
            nodes.AddRange(InstrumentNodes.Nodes);
            ControllerNodes = new ControllerNodes(homeFolder);
            nodes.AddRange(ControllerNodes.Nodes);
            SampleNodes = new SampleNodes(homeFolder);
            nodes.AddRange(SampleNodes.Nodes);
            EventNodes = new EventNodes(homeFolder);
            nodes.AddRange(EventNodes.Nodes);
            AlarmNodes = new AlarmNodes(homeFolder);
            nodes.AddRange(AlarmNodes.Nodes);
            BatchNodes = new BatchNodes(homeFolder);
            nodes.AddRange(BatchNodes.Nodes);
            RejectorNodes = new RejectorNodes(homeFolder);
            nodes.AddRange(RejectorNodes.Nodes);
        }
    }
}
