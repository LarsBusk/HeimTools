using DexterOpcUaTestServer.OpcNodes;
using System;
using System.Windows.Forms;

namespace DexterOpcUaTestServer
{
    public partial class SettingsForm : Form
    {
        public static LogOptions LogOptions;

        private string certString;
        private bool userPasswordEnabled;
        private bool certEnabled;
        private bool anonomousEnabled;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            serverTextBox.Text = MainForm.ServerName;
            rootFolderTextBox.Text = MainForm.RootFolderName;
            nodeSeparatorTextBox.Text = NodeBase.NodeSeparator;
            opcNamespaceTextBox.Text = NodeBase.OpcNameSpace;
            anonymousCheckBox.Checked = MainForm.EnableAnonymous;
            userPasswordCheckbox.Checked = MainForm.EnableUserPassword;
            certificateCheckBox.Checked = MainForm.EnableCertificate;
            certString = MainForm.CertString;
            userTextBox.Text = MainForm.User;
            passwordTextBox.Text = MainForm.Password;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MainForm.RootFolderName = rootFolderTextBox.Text;
            NodeBase.NodeSeparator = nodeSeparatorTextBox.Text;
            NodeBase.OpcNameSpace = opcNamespaceTextBox.Text;
            MainForm.ServerName = serverTextBox.Text;
            MainForm.EnableUserPassword = userPasswordCheckbox.Checked;
            MainForm.EnableAnonymous = anonymousCheckBox.Checked;
            MainForm.EnableCertificate = certificateCheckBox.Checked;
            MainForm.Password = passwordTextBox.Text;
            MainForm.User = userTextBox.Text;
            MainForm.CertString = certString;
            LogOptions.LogJitter = jitterCheckBox.Checked;
            LogOptions.LogMeasuredValues = measuredValuesCheckBox.Checked;
            LogOptions.LogNodeValues = nodeValuesCheckBox.Checked;
            LogOptions.LogStates = statesCheckBox.Checked;
            this.Close();
        }

        private void userPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            userTextBox.Enabled = userPasswordCheckbox.Checked;
            passwordTextBox.Enabled = userPasswordCheckbox.Checked;
            userPasswordEnabled = userPasswordCheckbox.Checked;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            var certForm = new CertForm();
            if (certForm.ShowDialog() == DialogResult.OK)
            {
                certString = certForm.CertString;
            }
        }

        private void anonomousCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            anonomousEnabled = anonymousCheckBox.Checked;
        }
    }

    public struct LogOptions
    {
        public bool LogJitter;
        public bool LogMeasuredValues;
        public bool LogStates;
        public bool LogNodeValues;
    }
}
