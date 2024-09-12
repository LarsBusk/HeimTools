namespace DexterJitterTool
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
            elementOnBeltCombo = new System.Windows.Forms.ComboBox();
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
            groupBox3 = new System.Windows.Forms.GroupBox();
            reposCleanCheck = new System.Windows.Forms.CheckBox();
            MosaicSyncCheck = new System.Windows.Forms.CheckBox();
            ticketPrintCheck = new System.Windows.Forms.CheckBox();
            autoExportCheck = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            distanceTb = new System.Windows.Forms.TextBox();
            durationTb = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            delayTb = new System.Windows.Forms.TextBox();
            rejectionModeCombo = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            conveyorSpeedCombo = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            timeCorrTextbox = new System.Windows.Forms.TextBox();
            realPCCheckBox = new System.Windows.Forms.CheckBox();
            AddTestSystemButton = new System.Windows.Forms.Button();
            CleanupButton = new System.Windows.Forms.Button();
            singleResultCheck = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // elementOnBeltCombo
            // 
            elementOnBeltCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            elementOnBeltCombo.FormattingEnabled = true;
            elementOnBeltCombo.Items.AddRange(new object[] { "Meat", "FO" });
            elementOnBeltCombo.Location = new System.Drawing.Point(8, 234);
            elementOnBeltCombo.MaxDropDownItems = 2;
            elementOnBeltCombo.Name = "elementOnBeltCombo";
            elementOnBeltCombo.Size = new System.Drawing.Size(121, 23);
            elementOnBeltCombo.TabIndex = 16;
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
            label2.Size = new System.Drawing.Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Dexter sw version";
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
            SelectCsvButton.Location = new System.Drawing.Point(576, 400);
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
            AddDataButton.Location = new System.Drawing.Point(576, 433);
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
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(elementOnBeltCombo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(conveyorSpeedCombo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(timeCorrTextbox);
            groupBox1.Controls.Add(realPCCheckBox);
            groupBox1.Controls.Add(NoraVersionCombo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CommentTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PlatformVersionCombo);
            groupBox1.Location = new System.Drawing.Point(46, 87);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(514, 379);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Test setup";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(singleResultCheck);
            groupBox3.Controls.Add(reposCleanCheck);
            groupBox3.Controls.Add(MosaicSyncCheck);
            groupBox3.Controls.Add(ticketPrintCheck);
            groupBox3.Controls.Add(autoExportCheck);
            groupBox3.Location = new System.Drawing.Point(336, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(167, 210);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Instrument configuration";
            // 
            // reposCleanCheck
            // 
            reposCleanCheck.AutoSize = true;
            reposCleanCheck.Location = new System.Drawing.Point(6, 85);
            reposCleanCheck.Name = "reposCleanCheck";
            reposCleanCheck.Size = new System.Drawing.Size(127, 19);
            reposCleanCheck.TabIndex = 24;
            reposCleanCheck.Text = "Repository cleanup";
            reposCleanCheck.UseVisualStyleBackColor = true;
            // 
            // MosaicSyncCheck
            // 
            MosaicSyncCheck.AutoSize = true;
            MosaicSyncCheck.Location = new System.Drawing.Point(6, 18);
            MosaicSyncCheck.Name = "MosaicSyncCheck";
            MosaicSyncCheck.Size = new System.Drawing.Size(144, 19);
            MosaicSyncCheck.TabIndex = 21;
            MosaicSyncCheck.Text = "Mosaic syncronisation";
            MosaicSyncCheck.UseVisualStyleBackColor = true;
            // 
            // ticketPrintCheck
            // 
            ticketPrintCheck.AutoSize = true;
            ticketPrintCheck.Location = new System.Drawing.Point(6, 62);
            ticketPrintCheck.Name = "ticketPrintCheck";
            ticketPrintCheck.Size = new System.Drawing.Size(95, 19);
            ticketPrintCheck.TabIndex = 23;
            ticketPrintCheck.Text = "Ticket printer";
            ticketPrintCheck.UseVisualStyleBackColor = true;
            // 
            // autoExportCheck
            // 
            autoExportCheck.AutoSize = true;
            autoExportCheck.Location = new System.Drawing.Point(6, 39);
            autoExportCheck.Name = "autoExportCheck";
            autoExportCheck.Size = new System.Drawing.Size(119, 19);
            autoExportCheck.TabIndex = 22;
            autoExportCheck.Text = "Automatic export";
            autoExportCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(distanceTb);
            groupBox2.Controls.Add(durationTb);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(delayTb);
            groupBox2.Controls.Add(rejectionModeCombo);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new System.Drawing.Point(168, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(157, 210);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rejector configuration";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(16, 153);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(110, 15);
            label11.TabIndex = 25;
            label11.Text = "Distance from edge";
            // 
            // distanceTb
            // 
            distanceTb.Location = new System.Drawing.Point(15, 173);
            distanceTb.Name = "distanceTb";
            distanceTb.Size = new System.Drawing.Size(100, 23);
            distanceTb.TabIndex = 24;
            distanceTb.Text = "0";
            distanceTb.TextChanged += VerifyInputIsInt;
            // 
            // durationTb
            // 
            durationTb.Location = new System.Drawing.Point(15, 129);
            durationTb.Name = "durationTb";
            durationTb.Size = new System.Drawing.Size(100, 23);
            durationTb.TabIndex = 23;
            durationTb.Text = "0";
            durationTb.TextChanged += VerifyInputIsInt;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(15, 111);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(53, 15);
            label10.TabIndex = 22;
            label10.Text = "Duration";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(15, 67);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(36, 15);
            label9.TabIndex = 21;
            label9.Text = "Delay";
            // 
            // delayTb
            // 
            delayTb.Location = new System.Drawing.Point(15, 85);
            delayTb.Name = "delayTb";
            delayTb.Size = new System.Drawing.Size(100, 23);
            delayTb.TabIndex = 20;
            delayTb.Text = "0";
            delayTb.TextChanged += VerifyInputIsInt;
            // 
            // rejectionModeCombo
            // 
            rejectionModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            rejectionModeCombo.FormattingEnabled = true;
            rejectionModeCombo.Items.AddRange(new object[] { "Manual", "Auto On Conv", "Auto Off Conv" });
            rejectionModeCombo.Location = new System.Drawing.Point(15, 41);
            rejectionModeCombo.MaxDropDownItems = 3;
            rejectionModeCombo.Name = "rejectionModeCombo";
            rejectionModeCombo.Size = new System.Drawing.Size(121, 23);
            rejectionModeCombo.TabIndex = 18;
            rejectionModeCombo.SelectedIndexChanged += rejectionModeCombo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(15, 23);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 15);
            label8.TabIndex = 19;
            label8.Text = "Rejection mode";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 216);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 15);
            label7.TabIndex = 17;
            label7.Text = "Element on belt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 260);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 15);
            label5.TabIndex = 15;
            label5.Text = "Conveyor speed";
            // 
            // conveyorSpeedCombo
            // 
            conveyorSpeedCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            conveyorSpeedCombo.FormattingEnabled = true;
            conveyorSpeedCombo.Items.AddRange(new object[] { "100", "200", "300" });
            conveyorSpeedCombo.Location = new System.Drawing.Point(8, 278);
            conveyorSpeedCombo.MaxDropDownItems = 3;
            conveyorSpeedCombo.Name = "conveyorSpeedCombo";
            conveyorSpeedCombo.Size = new System.Drawing.Size(121, 23);
            conveyorSpeedCombo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 163);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 15);
            label6.TabIndex = 13;
            label6.Text = "Time correction [ms]";
            // 
            // timeCorrTextbox
            // 
            timeCorrTextbox.Location = new System.Drawing.Point(8, 184);
            timeCorrTextbox.Name = "timeCorrTextbox";
            timeCorrTextbox.Size = new System.Drawing.Size(100, 23);
            timeCorrTextbox.TabIndex = 12;
            timeCorrTextbox.Text = "0";
            timeCorrTextbox.TextChanged += VerifyInputIsInt;
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
            // AddTestSystemButton
            // 
            AddTestSystemButton.Location = new System.Drawing.Point(556, 22);
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
            CleanupButton.Location = new System.Drawing.Point(556, 55);
            CleanupButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CleanupButton.Name = "CleanupButton";
            CleanupButton.Size = new System.Drawing.Size(108, 27);
            CleanupButton.TabIndex = 12;
            CleanupButton.Text = "Cleanup";
            CleanupButton.UseVisualStyleBackColor = true;
            CleanupButton.Click += CleanupButton_Click;
            // 
            // singleResultCheck
            // 
            singleResultCheck.AutoSize = true;
            singleResultCheck.Location = new System.Drawing.Point(6, 110);
            singleResultCheck.Name = "singleResultCheck";
            singleResultCheck.Size = new System.Drawing.Size(124, 19);
            singleResultCheck.TabIndex = 25;
            singleResultCheck.Text = "Single result mode";
            singleResultCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(681, 478);
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
            Text = "Dexter Jitter Tool";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private System.Windows.Forms.CheckBox realPCCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeCorrTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox elementOnBeltCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox conveyorSpeedCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rejectionModeCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox distanceTb;
        private System.Windows.Forms.TextBox durationTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox delayTb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox MosaicSyncCheck;
        private System.Windows.Forms.CheckBox ticketPrintCheck;
        private System.Windows.Forms.CheckBox autoExportCheck;
        private System.Windows.Forms.CheckBox reposCleanCheck;
        private System.Windows.Forms.CheckBox singleResultCheck;
    }
}

