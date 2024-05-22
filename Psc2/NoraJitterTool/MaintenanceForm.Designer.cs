namespace NoraJitterTool
{
    partial class MaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SetupCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveDelayButton = new System.Windows.Forms.Button();
            this.DelayIDTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DelayCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetupCombo2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.SetupCombo);
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove testsetup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test setup";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(9, 109);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 35);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SetupCombo
            // 
            this.SetupCombo.FormattingEnabled = true;
            this.SetupCombo.Location = new System.Drawing.Point(9, 52);
            this.SetupCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetupCombo.Name = "SetupCombo";
            this.SetupCombo.Size = new System.Drawing.Size(180, 28);
            this.SetupCombo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveDelayButton);
            this.groupBox2.Controls.Add(this.DelayIDTb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DelayCombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SetupCombo2);
            this.groupBox2.Location = new System.Drawing.Point(356, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove delay";
            // 
            // RemoveDelayButton
            // 
            this.RemoveDelayButton.Location = new System.Drawing.Point(9, 292);
            this.RemoveDelayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveDelayButton.Name = "RemoveDelayButton";
            this.RemoveDelayButton.Size = new System.Drawing.Size(112, 35);
            this.RemoveDelayButton.TabIndex = 7;
            this.RemoveDelayButton.Text = "Remove";
            this.RemoveDelayButton.UseVisualStyleBackColor = true;
            this.RemoveDelayButton.Click += new System.EventHandler(this.RemoveDelayButton_Click);
            // 
            // DelayIDTb
            // 
            this.DelayIDTb.Location = new System.Drawing.Point(9, 217);
            this.DelayIDTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelayIDTb.Name = "DelayIDTb";
            this.DelayIDTb.Size = new System.Drawing.Size(248, 26);
            this.DelayIDTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "DelayID";
            // 
            // DelayCombo
            // 
            this.DelayCombo.FormattingEnabled = true;
            this.DelayCombo.Location = new System.Drawing.Point(9, 134);
            this.DelayCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelayCombo.Name = "DelayCombo";
            this.DelayCombo.Size = new System.Drawing.Size(248, 28);
            this.DelayCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sample Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test setup";
            // 
            // SetupCombo2
            // 
            this.SetupCombo2.FormattingEnabled = true;
            this.SetupCombo2.Location = new System.Drawing.Point(9, 52);
            this.SetupCombo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetupCombo2.Name = "SetupCombo2";
            this.SetupCombo2.Size = new System.Drawing.Size(248, 28);
            this.SetupCombo2.TabIndex = 0;
            this.SetupCombo2.SelectedIndexChanged += new System.EventHandler(this.SetupCombo2_SelectedIndexChanged);
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MaintenanceForm";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox SetupCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RemoveDelayButton;
        private System.Windows.Forms.TextBox DelayIDTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DelayCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SetupCombo2;
    }
}