using System;
using System.Windows.Forms;

namespace NoraOpcUaTestServer
{
    public partial class NodesForm : Form
    {
        private OpcUaHelper helper;
        public NodesForm(OpcUaHelper helper)
        {
            InitializeComponent();
            this.helper = helper;
            ShowNodes();
        }

        private void ShowNodes()
        {
            var nodes = helper.OpcUaServer.Server.DefaultNodeManager.Nodes;
            nodesRtb.Clear();
            foreach (var node in nodes)
            {
                var nodeType = node.GetType().ToString();
                nodeType = nodeType.Substring(nodeType.LastIndexOf('.') + 1);
                nodesRtb.AppendText($"{node.Id} [{nodeType}\n");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
