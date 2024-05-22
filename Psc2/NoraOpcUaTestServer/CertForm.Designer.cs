namespace NoraOpcUaTestServer
{
    partial class CertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.certTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // certTextBox
            // 
            this.certTextBox.Location = new System.Drawing.Point(12, 12);
            this.certTextBox.Multiline = true;
            this.certTextBox.Name = "certTextBox";
            this.certTextBox.Size = new System.Drawing.Size(781, 544);
            this.certTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(718, 578);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 613);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.certTextBox);
            this.Name = "CertForm";
            this.Text = "CertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox certTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}