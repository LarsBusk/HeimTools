using Opc.UaFx;
using System;
using System.Data;
using System.Linq;
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
            ShowNodesInGrid();
        }

        private void ShowNodesInGrid()
        {
            var columnNames = new[] { "Node Id", "DataType", "Value" };
            var dt = new DataTable();
            dt.Columns.AddRange(columnNames.Select(c => new DataColumn(c)).ToArray());
            var nodes = helper.OpcUaServer.Server.DefaultNodeManager.Nodes;
            var readableNodes = helper.Nodes;
            foreach (var node in nodes)
            {
                var nodeType = node.GetType().ToString();
                var variableNode = (OpcDataVariableNode)(readableNodes.Nodes.First(n => n.Id.Equals(node.Id)));
                dt.Rows.Add(
                    node.Id, 
                    nodeType.Substring(nodeType.LastIndexOf('.') + 1).Replace("]",""), 
                    variableNode.Value);
            }



            nodesGridView.DataSource = dt;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ShowNodesInGrid();
        }
    }
}
