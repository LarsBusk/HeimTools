using Opc.UaFx;
using System;
using System.Drawing;
using System.Windows.Forms;
using NiceLittleLogger;

namespace DexterOpcUaTestServer
{
    public partial class AlarmsForm : Form
    {
        private OpcUaHelper helper;
        private Logger logger;
        private delegate void UpdateLabelTextCallback(Label label, Color colour);

        public AlarmsForm(OpcUaHelper helper)
        {
            InitializeComponent();
            logger = new Logger("Logs","Alarm.log");
            this.helper = helper;
            GetCurrentAlarms();
            
            helper.Nodes.AlarmNodesDexter.ReferenceMeasurementNeeded.AfterApplyChanges += AlarmHasChanged;
            helper.Nodes.AlarmNodes.SystemAlarms.AfterApplyChanges += AlarmHasChanged;
        }

        private void GetCurrentAlarms()
        {
            UpdateLabelColour(ZeroSettingIncompleteLabel, helper.Nodes.AlarmNodesDexter.ReferenceMeasurementNeeded.Value ? Color.Red : Color.Black);
            UpdateLabelColour(SystemAlarmsLabel, helper.Nodes.AlarmNodes.SystemAlarms.Value ? Color.Red : Color.Black);
        }

        private void AlarmHasChanged(object sender, OpcNodeChangesEventArgs e)
        {
            var alarm = (OpcDataVariableNode<bool>)sender;
            var colour = alarm.Value ? Color.Red : Color.Black;
            var nodeName = alarm.DisplayName.ToString();
            Label label = UninterruptibleModeLabel;

            switch (nodeName)
            {
                case "SystemAlarms":
                    label = SystemAlarmsLabel;
                    break;
                case "ZeroSettingIncomplete":
                    label = ZeroSettingIncompleteLabel;
                    break;
            }

            logger.LogInfo($"{nodeName}: {alarm.Value}, {alarm.Timestamp}");
            UpdateLabelColour(label, colour);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateLabelColour(Label label, Color colour)
        {
            if (label.InvokeRequired)
            {
                UpdateLabelTextCallback d = new UpdateLabelTextCallback(UpdateLabelColour);
                this.Invoke(d, new object[] { label, colour });
                return;
            }

            label.ForeColor = colour;
        }
    }
}
