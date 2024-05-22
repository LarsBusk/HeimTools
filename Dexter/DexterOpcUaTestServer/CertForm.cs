using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexterOpcUaTestServer
{
    public partial class CertForm : Form
    {
        public string CertString;
        public CertForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CertString = certTextBox.Text;
            this.Close();
        }
    }
}
