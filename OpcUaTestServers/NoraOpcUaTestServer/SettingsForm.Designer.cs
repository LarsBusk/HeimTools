
namespace NoraOpcUaTestServer
{
  partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nodeSeparatorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rootFolderTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.opcNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nodeValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.statesCheckBox = new System.Windows.Forms.CheckBox();
            this.measuredValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.jitterCheckBox = new System.Windows.Forms.CheckBox();
            this.userPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.certLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.certificateCheckBox = new System.Windows.Forms.CheckBox();
            this.anonymousCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // serverTextBox
            // 
            resources.ApplyResources(this.serverTextBox, "serverTextBox");
            this.serverTextBox.Name = "serverTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // nodeSeparatorTextBox
            // 
            resources.ApplyResources(this.nodeSeparatorTextBox, "nodeSeparatorTextBox");
            this.nodeSeparatorTextBox.Name = "nodeSeparatorTextBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rootFolderTextBox
            // 
            resources.ApplyResources(this.rootFolderTextBox, "rootFolderTextBox");
            this.rootFolderTextBox.Name = "rootFolderTextBox";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // opcNamespaceTextBox
            // 
            resources.ApplyResources(this.opcNamespaceTextBox, "opcNamespaceTextBox");
            this.opcNamespaceTextBox.Name = "opcNamespaceTextBox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nodeValuesCheckBox);
            this.groupBox1.Controls.Add(this.statesCheckBox);
            this.groupBox1.Controls.Add(this.measuredValuesCheckBox);
            this.groupBox1.Controls.Add(this.jitterCheckBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // nodeValuesCheckBox
            // 
            resources.ApplyResources(this.nodeValuesCheckBox, "nodeValuesCheckBox");
            this.nodeValuesCheckBox.Checked = true;
            this.nodeValuesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nodeValuesCheckBox.Name = "nodeValuesCheckBox";
            this.nodeValuesCheckBox.UseVisualStyleBackColor = true;
            // 
            // statesCheckBox
            // 
            resources.ApplyResources(this.statesCheckBox, "statesCheckBox");
            this.statesCheckBox.Checked = true;
            this.statesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statesCheckBox.Name = "statesCheckBox";
            this.statesCheckBox.UseVisualStyleBackColor = true;
            // 
            // measuredValuesCheckBox
            // 
            resources.ApplyResources(this.measuredValuesCheckBox, "measuredValuesCheckBox");
            this.measuredValuesCheckBox.Checked = true;
            this.measuredValuesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.measuredValuesCheckBox.Name = "measuredValuesCheckBox";
            this.measuredValuesCheckBox.UseVisualStyleBackColor = true;
            // 
            // jitterCheckBox
            // 
            resources.ApplyResources(this.jitterCheckBox, "jitterCheckBox");
            this.jitterCheckBox.Checked = true;
            this.jitterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jitterCheckBox.Name = "jitterCheckBox";
            this.jitterCheckBox.UseVisualStyleBackColor = true;
            // 
            // userPasswordCheckbox
            // 
            resources.ApplyResources(this.userPasswordCheckbox, "userPasswordCheckbox");
            this.userPasswordCheckbox.Name = "userPasswordCheckbox";
            this.userPasswordCheckbox.UseVisualStyleBackColor = true;
            this.userPasswordCheckbox.CheckedChanged += new System.EventHandler(this.userPasswordCheckbox_CheckedChanged);
            // 
            // userTextBox
            // 
            resources.ApplyResources(this.userTextBox, "userTextBox");
            this.userTextBox.Name = "userTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.certLabel);
            this.groupBox2.Controls.Add(this.selectButton);
            this.groupBox2.Controls.Add(this.certificateCheckBox);
            this.groupBox2.Controls.Add(this.anonymousCheckBox);
            this.groupBox2.Controls.Add(this.userTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.userPasswordCheckbox);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // certLabel
            // 
            resources.ApplyResources(this.certLabel, "certLabel");
            this.certLabel.Name = "certLabel";
            // 
            // selectButton
            // 
            resources.ApplyResources(this.selectButton, "selectButton");
            this.selectButton.Name = "selectButton";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // certificateCheckBox
            // 
            resources.ApplyResources(this.certificateCheckBox, "certificateCheckBox");
            this.certificateCheckBox.Name = "certificateCheckBox";
            this.certificateCheckBox.UseVisualStyleBackColor = true;
            // 
            // anonymousCheckBox
            // 
            resources.ApplyResources(this.anonymousCheckBox, "anonymousCheckBox");
            this.anonymousCheckBox.Checked = true;
            this.anonymousCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.anonymousCheckBox.Name = "anonymousCheckBox";
            this.anonymousCheckBox.UseVisualStyleBackColor = true;
            this.anonymousCheckBox.CheckedChanged += new System.EventHandler(this.anonomousCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.opcNamespaceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rootFolderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nodeSeparatorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox serverTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox nodeSeparatorTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox rootFolderTextBox;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox opcNamespaceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox nodeValuesCheckBox;
        private System.Windows.Forms.CheckBox statesCheckBox;
        private System.Windows.Forms.CheckBox measuredValuesCheckBox;
        private System.Windows.Forms.CheckBox jitterCheckBox;
        private System.Windows.Forms.CheckBox userPasswordCheckbox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox certificateCheckBox;
        private System.Windows.Forms.CheckBox anonymousCheckBox;
        private System.Windows.Forms.Label certLabel;
        private System.Windows.Forms.Button selectButton;
    }
}