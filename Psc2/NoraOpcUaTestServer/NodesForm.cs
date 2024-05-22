using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var nodes = helper.Server.DefaultNodeManager.Nodes;
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
