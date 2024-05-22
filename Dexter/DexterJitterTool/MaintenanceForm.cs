using System;
using System.Windows.Forms;

namespace DexterJitterTool
{
    public partial class MaintenanceForm : Form
    {
        private DataHelper _helper;
        public MaintenanceForm(DataHelper helper)
        {
            InitializeComponent();
            _helper = helper;
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
            var items = _helper.TestSetups();

            foreach (var item in items)
            {
                SetupCombo.Items.Add(item);
                SetupCombo2.Items.Add(item);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _helper.RemoveTestSetup(((TestSetupComboItems)SetupCombo.SelectedItem).TestSetupId);
        }

        private void SetupCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = _helper.Delays(((TestSetupComboItems)SetupCombo2.SelectedItem).TestSetupId);

            foreach (var item in items)
            {
                DelayCombo.Items.Add(item);
            }
        }

        private void RemoveDelayButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DelayIDTb.Text, out var delayID) )
            {
                delayID = ((DelayComboItem)DelayCombo.SelectedItem).DelayId;
            }

            _helper.RemoveDelay(delayID);
        }
    }
}
