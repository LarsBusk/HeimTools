using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace NoraOpcUaTestServer
{
    public partial class CertForm : Form
    {
        public X509Certificate2 Cert;
        public CertForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK )
            {
                var certFile = dialog.FileName;
                Cert = new X509Certificate2();
                Cert.Import(certFile);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Cert = new X509Certificate2(Convert.FromBase64String(certTextBox.Text));
        }
    }
}
