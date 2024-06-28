using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexterOpcUaTestServer
{
    public partial class CertForm : Form
    {
        public string CertString;
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

        private void importBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var certFile = dialog.FileName;
                Cert = new X509Certificate2();//X509Certificate2.CreateFromCertFile(certFile));
                Cert.Import(certFile);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Cert = new X509Certificate2(Convert.FromBase64String(certTextBox.Text));
        }
    }
}
