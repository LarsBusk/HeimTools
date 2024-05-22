namespace DexterJitterTool
{
    partial class AddTestSystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTestSystemForm));
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SnTextBox = new System.Windows.Forms.TextBox();
            this.ChassisTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SimulatorRadioButton = new System.Windows.Forms.RadioButton();
            this.InstrumentRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(530, 369);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 35);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test system name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chassis number";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(56, 78);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(454, 26);
            this.NameTextBox.TabIndex = 5;
            // 
            // SnTextBox
            // 
            this.SnTextBox.Location = new System.Drawing.Point(56, 157);
            this.SnTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SnTextBox.Name = "SnTextBox";
            this.SnTextBox.Size = new System.Drawing.Size(454, 26);
            this.SnTextBox.TabIndex = 6;
            // 
            // ChassisTextBox
            // 
            this.ChassisTextBox.Location = new System.Drawing.Point(56, 245);
            this.ChassisTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChassisTextBox.Name = "ChassisTextBox";
            this.ChassisTextBox.Size = new System.Drawing.Size(454, 26);
            this.ChassisTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SimulatorRadioButton);
            this.groupBox1.Controls.Add(this.InstrumentRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(56, 285);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(231, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // SimulatorRadioButton
            // 
            this.SimulatorRadioButton.AutoSize = true;
            this.SimulatorRadioButton.Location = new System.Drawing.Point(26, 68);
            this.SimulatorRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SimulatorRadioButton.Name = "SimulatorRadioButton";
            this.SimulatorRadioButton.Size = new System.Drawing.Size(94, 24);
            this.SimulatorRadioButton.TabIndex = 1;
            this.SimulatorRadioButton.TabStop = true;
            this.SimulatorRadioButton.Text = "Simulator";
            this.SimulatorRadioButton.UseVisualStyleBackColor = true;
            // 
            // InstrumentRadioButton
            // 
            this.InstrumentRadioButton.AutoSize = true;
            this.InstrumentRadioButton.Checked = true;
            this.InstrumentRadioButton.Location = new System.Drawing.Point(26, 32);
            this.InstrumentRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InstrumentRadioButton.Name = "InstrumentRadioButton";
            this.InstrumentRadioButton.Size = new System.Drawing.Size(104, 24);
            this.InstrumentRadioButton.TabIndex = 0;
            this.InstrumentRadioButton.TabStop = true;
            this.InstrumentRadioButton.Text = "Instrument";
            this.InstrumentRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddTestSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChassisTextBox);
            this.Controls.Add(this.SnTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTestSystemForm";
            this.Text = "Add test system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SnTextBox;
        private System.Windows.Forms.TextBox ChassisTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SimulatorRadioButton;
        private System.Windows.Forms.RadioButton InstrumentRadioButton;
    }
}