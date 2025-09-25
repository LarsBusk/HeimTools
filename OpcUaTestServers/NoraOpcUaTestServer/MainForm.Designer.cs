
namespace NoraOpcUaTestServer
{
  partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverStateLabel = new System.Windows.Forms.Label();
            this.watchdogLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nodesButton = new System.Windows.Forms.Button();
            this.sampleCounterLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noDelayedResCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.cipButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.simulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateLabel = new System.Windows.Forms.Label();
            this.alarmsButton = new System.Windows.Forms.Button();
            this.sampleRegButton = new System.Windows.Forms.Button();
            this.sampleregTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.forceMeasureCheckBox = new System.Windows.Forms.CheckBox();
            this.eventsButton = new System.Windows.Forms.Button();
            this.updateWdCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverStateLabel);
            this.groupBox1.Controls.Add(this.watchdogLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(43, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(161, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPC Server";
            // 
            // serverStateLabel
            // 
            this.serverStateLabel.AutoSize = true;
            this.serverStateLabel.Location = new System.Drawing.Point(19, 22);
            this.serverStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverStateLabel.Name = "serverStateLabel";
            this.serverStateLabel.Size = new System.Drawing.Size(59, 16);
            this.serverStateLabel.TabIndex = 5;
            this.serverStateLabel.Text = "Stopped";
            // 
            // watchdogLabel
            // 
            this.watchdogLabel.AutoSize = true;
            this.watchdogLabel.Location = new System.Drawing.Point(17, 151);
            this.watchdogLabel.Name = "watchdogLabel";
            this.watchdogLabel.Size = new System.Drawing.Size(0, 16);
            this.watchdogLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Watchdog";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(20, 86);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(85, 33);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(20, 48);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 33);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(397, 54);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 283);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // nodesButton
            // 
            this.nodesButton.Location = new System.Drawing.Point(513, 354);
            this.nodesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nodesButton.Name = "nodesButton";
            this.nodesButton.Size = new System.Drawing.Size(107, 33);
            this.nodesButton.TabIndex = 2;
            this.nodesButton.Text = "Get nodes";
            this.nodesButton.UseVisualStyleBackColor = true;
            this.nodesButton.Click += new System.EventHandler(this.nodesButton_Click);
            // 
            // sampleCounterLabel
            // 
            this.sampleCounterLabel.AutoSize = true;
            this.sampleCounterLabel.Location = new System.Drawing.Point(59, 69);
            this.sampleCounterLabel.Name = "sampleCounterLabel";
            this.sampleCounterLabel.Size = new System.Drawing.Size(103, 16);
            this.sampleCounterLabel.TabIndex = 3;
            this.sampleCounterLabel.Text = "SampleCounter:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noDelayedResCb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cleanButton);
            this.groupBox2.Controls.Add(this.zeroButton);
            this.groupBox2.Controls.Add(this.cipButton);
            this.groupBox2.Controls.Add(this.startStopButton);
            this.groupBox2.Controls.Add(this.productTextBox);
            this.groupBox2.Location = new System.Drawing.Point(211, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(168, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nora Control";
            // 
            // noDelayedResCb
            // 
            this.noDelayedResCb.AutoSize = true;
            this.noDelayedResCb.Location = new System.Drawing.Point(5, 250);
            this.noDelayedResCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noDelayedResCb.Name = "noDelayedResCb";
            this.noDelayedResCb.Size = new System.Drawing.Size(139, 20);
            this.noDelayedResCb.TabIndex = 12;
            this.noDelayedResCb.Text = "No delayed results";
            this.noDelayedResCb.UseVisualStyleBackColor = true;
            this.noDelayedResCb.CheckedChanged += new System.EventHandler(this.noDelayedResCb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(5, 201);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(120, 36);
            this.cleanButton.TabIndex = 4;
            this.cleanButton.Text = "Clean to queue";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(5, 161);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(120, 34);
            this.zeroButton.TabIndex = 3;
            this.zeroButton.Text = "Zero to queue";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // cipButton
            // 
            this.cipButton.Location = new System.Drawing.Point(5, 122);
            this.cipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cipButton.Name = "cipButton";
            this.cipButton.Size = new System.Drawing.Size(120, 33);
            this.cipButton.TabIndex = 2;
            this.cipButton.Text = "CIP";
            this.cipButton.UseVisualStyleBackColor = true;
            this.cipButton.Click += new System.EventHandler(this.cipButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(5, 82);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(120, 33);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(5, 49);
            this.productTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(97, 22);
            this.productTextBox.TabIndex = 0;
            this.productTextBox.TextChanged += new System.EventHandler(this.productTextBox_TextChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(59, 43);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(56, 16);
            this.productLabel.TabIndex = 6;
            this.productLabel.Text = "Product:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.simulateToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.settingsToolStripMenuItem.Text = "Opc server";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // simulateToolStripMenuItem
            // 
            this.simulateToolStripMenuItem.Name = "simulateToolStripMenuItem";
            this.simulateToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.simulateToolStripMenuItem.Text = "Simulate";
            this.simulateToolStripMenuItem.Click += new System.EventHandler(this.simulateToolStripMenuItem_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(59, 96);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 16);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State:";
            // 
            // alarmsButton
            // 
            this.alarmsButton.Location = new System.Drawing.Point(397, 354);
            this.alarmsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alarmsButton.Name = "alarmsButton";
            this.alarmsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alarmsButton.Size = new System.Drawing.Size(109, 33);
            this.alarmsButton.TabIndex = 9;
            this.alarmsButton.Text = "Alarms";
            this.alarmsButton.UseVisualStyleBackColor = true;
            this.alarmsButton.Click += new System.EventHandler(this.alarmsButton_Click);
            // 
            // sampleRegButton
            // 
            this.sampleRegButton.Location = new System.Drawing.Point(17, 21);
            this.sampleRegButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sampleRegButton.Name = "sampleRegButton";
            this.sampleRegButton.Size = new System.Drawing.Size(119, 32);
            this.sampleRegButton.TabIndex = 6;
            this.sampleRegButton.Text = "Sample reg";
            this.sampleRegButton.UseVisualStyleBackColor = true;
            this.sampleRegButton.Click += new System.EventHandler(this.sampleRegButton_Click);
            // 
            // sampleregTextbox
            // 
            this.sampleregTextbox.Location = new System.Drawing.Point(157, 26);
            this.sampleregTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sampleregTextbox.Name = "sampleregTextbox";
            this.sampleregTextbox.Size = new System.Drawing.Size(225, 22);
            this.sampleregTextbox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sampleRegButton);
            this.groupBox3.Controls.Add(this.sampleregTextbox);
            this.groupBox3.Location = new System.Drawing.Point(43, 415);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(399, 60);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sample registration";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.forceMeasureCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(40, 117);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(164, 96);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulate";
            // 
            // forceMeasureCheckBox
            // 
            this.forceMeasureCheckBox.AutoSize = true;
            this.forceMeasureCheckBox.Location = new System.Drawing.Point(13, 27);
            this.forceMeasureCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forceMeasureCheckBox.Name = "forceMeasureCheckBox";
            this.forceMeasureCheckBox.Size = new System.Drawing.Size(117, 20);
            this.forceMeasureCheckBox.TabIndex = 0;
            this.forceMeasureCheckBox.Text = "Force Measure";
            this.forceMeasureCheckBox.UseVisualStyleBackColor = true;
            this.forceMeasureCheckBox.CheckedChanged += new System.EventHandler(this.forceMeasureCheckBox_CheckedChanged);
            // 
            // eventsButton
            // 
            this.eventsButton.Location = new System.Drawing.Point(627, 354);
            this.eventsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(100, 33);
            this.eventsButton.TabIndex = 13;
            this.eventsButton.Text = "Events";
            this.eventsButton.UseVisualStyleBackColor = true;
            this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
            // 
            // updateWdCheckBox
            // 
            this.updateWdCheckBox.AutoSize = true;
            this.updateWdCheckBox.Location = new System.Drawing.Point(465, 443);
            this.updateWdCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateWdCheckBox.Name = "updateWdCheckBox";
            this.updateWdCheckBox.Size = new System.Drawing.Size(132, 20);
            this.updateWdCheckBox.TabIndex = 14;
            this.updateWdCheckBox.Text = "Update watchdog";
            this.updateWdCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 487);
            this.Controls.Add(this.updateWdCheckBox);
            this.Controls.Add(this.eventsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.alarmsButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sampleCounterLabel);
            this.Controls.Add(this.nodesButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Nora Opc UA Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button stopButton;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button nodesButton;
    private System.Windows.Forms.Label watchdogLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label sampleCounterLabel;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button startStopButton;
    private System.Windows.Forms.TextBox productTextBox;
    private System.Windows.Forms.Label productLabel;
    private System.Windows.Forms.Button cipButton;
    private System.Windows.Forms.Button zeroButton;
    private System.Windows.Forms.Button cleanButton;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
    private System.Windows.Forms.Label serverStateLabel;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label stateLabel;
    private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button alarmsButton;
        private System.Windows.Forms.Button sampleRegButton;
        private System.Windows.Forms.TextBox sampleregTextbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox noDelayedResCb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox forceMeasureCheckBox;
        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.ToolStripMenuItem simulateToolStripMenuItem;
        private System.Windows.Forms.CheckBox updateWdCheckBox;
    }
}

