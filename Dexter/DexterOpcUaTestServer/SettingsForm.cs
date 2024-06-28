using DexterOpcUaTestServer.OpcNodes;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace DexterOpcUaTestServer
{
    public partial class SettingsForm : Form
    {
        public static LogOptions LogOptions;

        private X509Certificate2 cert;
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
            MainForm.Certificate = cert;
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
                cert = certForm.Cert;
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
