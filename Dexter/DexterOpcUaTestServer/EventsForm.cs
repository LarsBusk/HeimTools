using System;
using System.Windows.Forms;

namespace DexterOpcUaTestServer
{
    public partial class EventsForm : Form
    {
        private OpcUaHelper _helper;

        public EventsForm(OpcUaHelper helper)
        {
            InitializeComponent();
            this._helper = helper;
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            InitialiseGrid();
            RefreshGrid();
        }

        private void InitialiseGrid()
        {
            EventsDataGridView.ColumnCount = 5;
            EventsDataGridView.Columns[0].Name = "Severity";
            EventsDataGridView.Columns[1].Name = "Source";
            EventsDataGridView.Columns[2].Name = "Code";
            EventsDataGridView.Columns[3].Name = "Message";
            EventsDataGridView.Columns[4].Name = "Hint";
        }

        private void RefreshGrid()
        {
            const int eventsCount = 16;
            var eventCodes = _helper.Nodes.EventNodes.EventCodes.Value;
            var eventMessages = _helper.Nodes.EventNodes.EventMessages.Value;
            var eventSources = _helper.Nodes.EventNodes.EventSources.Value ?? new string[eventsCount];
            var eventHints = _helper.Nodes.EventNodes.EventHints.Value;
            var eventSeverities = _helper.Nodes.EventNodes.EventSeverity.Value;

            EventsDataGridView.Rows.Clear();

            for (int i = 0; i < eventsCount; i++)
            {
                object[] row =
                {
                    eventSeverities[i] == 1 ? "Warning" : "Error",
                    eventSources[i],
                    eventCodes[i],
                    eventMessages[i],
                    eventHints[i]
                };

                EventsDataGridView.Rows.Add(row);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
