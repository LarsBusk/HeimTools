namespace NoraJitterTool
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
            TestSystemCombo = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            NoraVersionCombo = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            PlatformVersionCombo = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SelectCsvButton = new System.Windows.Forms.Button();
            AddDataButton = new System.Windows.Forms.Button();
            CommentTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            realPCCheckBox = new System.Windows.Forms.CheckBox();
            NoDelayedResultsCb = new System.Windows.Forms.CheckBox();
            AddTestSystemButton = new System.Windows.Forms.Button();
            CleanupButton = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cyclesTextBox = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TestSystemCombo
            // 
            TestSystemCombo.FormattingEnabled = true;
            TestSystemCombo.Location = new System.Drawing.Point(49, 40);
            TestSystemCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TestSystemCombo.Name = "TestSystemCombo";
            TestSystemCombo.Size = new System.Drawing.Size(186, 23);
            TestSystemCombo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Test system";
            // 
            // NoraVersionCombo
            // 
            NoraVersionCombo.FormattingEnabled = true;
            NoraVersionCombo.Location = new System.Drawing.Point(7, 39);
            NoraVersionCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NoraVersionCombo.Name = "NoraVersionCombo";
            NoraVersionCombo.Size = new System.Drawing.Size(140, 23);
            NoraVersionCombo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 21);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Nora sw version";
            // 
            // PlatformVersionCombo
            // 
            PlatformVersionCombo.FormattingEnabled = true;
            PlatformVersionCombo.Location = new System.Drawing.Point(7, 85);
            PlatformVersionCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PlatformVersionCombo.Name = "PlatformVersionCombo";
            PlatformVersionCombo.Size = new System.Drawing.Size(140, 23);
            PlatformVersionCombo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 67);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 15);
            label3.TabIndex = 5;
            label3.Text = "Platform version";
            // 
            // SelectCsvButton
            // 
            SelectCsvButton.Location = new System.Drawing.Point(500, 238);
            SelectCsvButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SelectCsvButton.Name = "SelectCsvButton";
            SelectCsvButton.Size = new System.Drawing.Size(88, 27);
            SelectCsvButton.TabIndex = 6;
            SelectCsvButton.Text = "Select Csv";
            SelectCsvButton.UseVisualStyleBackColor = true;
            SelectCsvButton.Click += SelectCsvButton_Click;
            // 
            // AddDataButton
            // 
            AddDataButton.Location = new System.Drawing.Point(500, 271);
            AddDataButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddDataButton.Name = "AddDataButton";
            AddDataButton.Size = new System.Drawing.Size(88, 27);
            AddDataButton.TabIndex = 7;
            AddDataButton.Text = "Add data";
            AddDataButton.UseVisualStyleBackColor = true;
            AddDataButton.Click += AddDataButton_Click;
            // 
            // CommentTextBox
            // 
            CommentTextBox.Location = new System.Drawing.Point(8, 129);
            CommentTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CommentTextBox.Name = "CommentTextBox";
            CommentTextBox.Size = new System.Drawing.Size(377, 23);
            CommentTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 111);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Comment";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cyclesTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(realPCCheckBox);
            groupBox1.Controls.Add(NoDelayedResultsCb);
            groupBox1.Controls.Add(NoraVersionCombo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CommentTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PlatformVersionCombo);
            groupBox1.Location = new System.Drawing.Point(49, 87);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(405, 223);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Test setup";
            // 
            // realPCCheckBox
            // 
            realPCCheckBox.AutoSize = true;
            realPCCheckBox.Location = new System.Drawing.Point(178, 67);
            realPCCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            realPCCheckBox.Name = "realPCCheckBox";
            realPCCheckBox.Size = new System.Drawing.Size(87, 19);
            realPCCheckBox.TabIndex = 11;
            realPCCheckBox.Text = "Physical PC";
            realPCCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoDelayedResultsCb
            // 
            NoDelayedResultsCb.AutoSize = true;
            NoDelayedResultsCb.Location = new System.Drawing.Point(178, 39);
            NoDelayedResultsCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NoDelayedResultsCb.Name = "NoDelayedResultsCb";
            NoDelayedResultsCb.Size = new System.Drawing.Size(123, 19);
            NoDelayedResultsCb.TabIndex = 10;
            NoDelayedResultsCb.Text = "No delayed results";
            NoDelayedResultsCb.UseVisualStyleBackColor = true;
            // 
            // AddTestSystemButton
            // 
            AddTestSystemButton.Location = new System.Drawing.Point(490, 22);
            AddTestSystemButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddTestSystemButton.Name = "AddTestSystemButton";
            AddTestSystemButton.Size = new System.Drawing.Size(108, 27);
            AddTestSystemButton.TabIndex = 11;
            AddTestSystemButton.Text = "Add test system";
            AddTestSystemButton.UseVisualStyleBackColor = true;
            AddTestSystemButton.Click += AddTestSystemButton_Click;
            // 
            // CleanupButton
            // 
            CleanupButton.Location = new System.Drawing.Point(490, 55);
            CleanupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CleanupButton.Name = "CleanupButton";
            CleanupButton.Size = new System.Drawing.Size(108, 27);
            CleanupButton.TabIndex = 12;
            CleanupButton.Text = "Cleanup";
            CleanupButton.UseVisualStyleBackColor = true;
            CleanupButton.Click += CleanupButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(499, 162);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 157);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 15);
            label6.TabIndex = 12;
            label6.Text = "Number of cycles";
            // 
            // cyclesTextBox
            // 
            cyclesTextBox.Location = new System.Drawing.Point(7, 175);
            cyclesTextBox.Name = "cyclesTextBox";
            cyclesTextBox.Size = new System.Drawing.Size(120, 23);
            cyclesTextBox.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(612, 322);
            Controls.Add(label5);
            Controls.Add(CleanupButton);
            Controls.Add(AddTestSystemButton);
            Controls.Add(groupBox1);
            Controls.Add(AddDataButton);
            Controls.Add(SelectCsvButton);
            Controls.Add(label1);
            Controls.Add(TestSystemCombo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Nora Jitter Tool";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox TestSystemCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NoraVersionCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PlatformVersionCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectCsvButton;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddTestSystemButton;
        private System.Windows.Forms.Button CleanupButton;
        private System.Windows.Forms.CheckBox NoDelayedResultsCb;
        private System.Windows.Forms.CheckBox realPCCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cyclesTextBox;
        private System.Windows.Forms.Label label6;
    }
}

