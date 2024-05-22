using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DexterJitterTool
{
    public partial class MainForm : Form
    {
        private DataHelper helper;
        private List<DelayInfo> delayInfos;
        private string csvFileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(timeCorrTextbox.Text, out var timeCorrection))
            {
                var setupId = helper.AddNewTestSetup(
                    ((TestSystemComboItem)TestSystemCombo.SelectedItem).ChassisId,
                    NoraVersionCombo.Text,
                    DateTime.Now,
                    PlatformVersionCombo.Text,
                    CommentTextBox.Text,
                    csvFileName,
                    realPCCheckBox.Checked,
                    timeCorrection,
                    int.Parse(conveyorSpeedCombo.Text),
                    rejectionModeCombo.Text,
                    elementOnBeltCombo.Text,
                    int.Parse(delayTb.Text),
                    int.Parse(durationTb.Text),
                    int.Parse(distanceTb.Text),
                    MosaicSyncCheck.Checked,
                    autoExportCheck.Checked,
                    ticketPrintCheck.Checked,
                    reposCleanCheck.Checked);
                helper.AddDelays(setupId, delayInfos);
                helper.AddStatistics(setupId);
            }
            else
            {
                MessageBox.Show("The time correction must be an integer", "Time correction");
            }
        }

        private void SelectCsvButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (!dialog.ShowDialog().Equals(DialogResult.OK)) return;

            csvFileName = dialog.FileName;
            var reader = new CsvReader(csvFileName);
            delayInfos = reader.GetRecords();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            helper = new DataHelper();
            FillTestSystemCombo();

            NoraVersionCombo.Items.AddRange(helper.NoraVersions());
            PlatformVersionCombo.Items.AddRange(helper.PlatformVersions());
            elementOnBeltCombo.SelectedIndex = 0;
            conveyorSpeedCombo.SelectedIndex = 2;
            rejectionModeCombo.SelectedIndex = 0;
        }

        private void AddTestSystemButton_Click(object sender, EventArgs e)
        {
            var form = new AddTestSystemForm(helper);
            form.ShowDialog();
            FillTestSystemCombo();
        }

        private void FillTestSystemCombo()
        {
            var items = helper.TestSystems();
            TestSystemCombo.Items.Clear();

            foreach (var item in items)
            {
                TestSystemCombo.Items.Add(item);
            }
        }

        private void CleanupButton_Click(object sender, EventArgs e)
        {
            var form = new MaintenanceForm(helper);
            form.ShowDialog();
        }

        private void VerifyInputIsInt(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!int.TryParse(textBox.Text, out var outInt))
            {
                MessageBox.Show("The input must be an integer", "Wrong input");
            }

            textBox.Text = outInt.ToString();
        }

        private void rejectionModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            switch (box.SelectedIndex)
            {
                case 0:
                    delayTb.Enabled = false;
                    delayTb.Text = "0";
                    durationTb.Enabled = false;
                    durationTb.Text = "0";
                    distanceTb.Enabled = false;
                    distanceTb.Text = "0";
                    break;
                case 1:
                    delayTb.Enabled = false;
                    delayTb.Text = "0";
                    durationTb.Enabled = false;
                    durationTb.Text = "0";
                    distanceTb.Enabled = true;
                    break;
                case 2:
                    delayTb.Enabled = true;
                    durationTb.Enabled = true;
                    distanceTb.Enabled = false;
                    distanceTb.Text = "0";
                    break;
            }
        }
    }
}
