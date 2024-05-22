using System;
using System.Windows.Forms;

namespace NoraJitterTool
{
    public partial class AddTestSystemForm : Form
    {
        private DataHelper helper;
        public AddTestSystemForm(DataHelper helper)
        {
            InitializeComponent();
            this.helper = helper;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var type = SimulatorRadioButton.Checked ? "Simulator" : "Instrument";
            helper.AddTestSystem(SnTextBox.Text, long.Parse(ChassisTextBox.Text), type, NameTextBox.Text);
        }
    }
}
