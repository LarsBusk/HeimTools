namespace NoraOpcUaTestServer
{
    partial class AlarmsForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZeroSettingIncompleteLabel = new System.Windows.Forms.Label();
            this.SystemAlarmsLabel = new System.Windows.Forms.Label();
            this.UninterruptibleModeLabel = new System.Windows.Forms.Label();
            this.cabinetDoorOpenLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(379, 252);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cabinetDoorOpenLabel);
            this.groupBox1.Controls.Add(this.ZeroSettingIncompleteLabel);
            this.groupBox1.Controls.Add(this.SystemAlarmsLabel);
            this.groupBox1.Controls.Add(this.UninterruptibleModeLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active conditions";
            // 
            // ZeroSettingIncompleteLabel
            // 
            this.ZeroSettingIncompleteLabel.AutoSize = true;
            this.ZeroSettingIncompleteLabel.Location = new System.Drawing.Point(9, 92);
            this.ZeroSettingIncompleteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZeroSettingIncompleteLabel.Name = "ZeroSettingIncompleteLabel";
            this.ZeroSettingIncompleteLabel.Size = new System.Drawing.Size(142, 16);
            this.ZeroSettingIncompleteLabel.TabIndex = 2;
            this.ZeroSettingIncompleteLabel.Text = "ZeroSettingIncomplete";
            // 
            // SystemAlarmsLabel
            // 
            this.SystemAlarmsLabel.AutoSize = true;
            this.SystemAlarmsLabel.Location = new System.Drawing.Point(8, 60);
            this.SystemAlarmsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemAlarmsLabel.Name = "SystemAlarmsLabel";
            this.SystemAlarmsLabel.Size = new System.Drawing.Size(94, 16);
            this.SystemAlarmsLabel.TabIndex = 1;
            this.SystemAlarmsLabel.Text = "SystemAlarms";
            // 
            // UninterruptibleModeLabel
            // 
            this.UninterruptibleModeLabel.AutoSize = true;
            this.UninterruptibleModeLabel.Location = new System.Drawing.Point(8, 33);
            this.UninterruptibleModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UninterruptibleModeLabel.Name = "UninterruptibleModeLabel";
            this.UninterruptibleModeLabel.Size = new System.Drawing.Size(128, 16);
            this.UninterruptibleModeLabel.TabIndex = 0;
            this.UninterruptibleModeLabel.Text = "UninterruptibleMode";
            // 
            // cabinetDoorOpenLabel
            // 
            this.cabinetDoorOpenLabel.AutoSize = true;
            this.cabinetDoorOpenLabel.Location = new System.Drawing.Point(9, 119);
            this.cabinetDoorOpenLabel.Name = "cabinetDoorOpenLabel";
            this.cabinetDoorOpenLabel.Size = new System.Drawing.Size(116, 16);
            this.cabinetDoorOpenLabel.TabIndex = 3;
            this.cabinetDoorOpenLabel.Text = "CabinetDoorOpen";
            // 
            // AlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmsForm";
            this.Text = "AlarmsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ZeroSettingIncompleteLabel;
        private System.Windows.Forms.Label SystemAlarmsLabel;
        private System.Windows.Forms.Label UninterruptibleModeLabel;
        private System.Windows.Forms.Label cabinetDoorOpenLabel;
    }
}