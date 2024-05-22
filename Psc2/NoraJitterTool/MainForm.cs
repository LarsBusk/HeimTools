using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace NoraJitterTool
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
            if (int.TryParse(cyclesTextBox.Text, out var numberOfCycles))
            {
                var setupId = helper.AddNewTestSetup(
                    ((TestSystemComboItem)TestSystemCombo.SelectedItem).ChassisId,
                    NoraVersionCombo.Text,
                    DateTime.Now,
                    PlatformVersionCombo.Text,
                    CommentTextBox.Text,
                    csvFileName,
                    NoDelayedResultsCb.Checked,
                    realPCCheckBox.Checked,
                    numberOfCycles);
                helper.AddDelays(setupId, delayInfos);
                helper.AddStatistics(setupId);
            }
            else
            {
                MessageBox.Show("The number of cycles must be an integer", "Number of cycles");
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
    }
}
