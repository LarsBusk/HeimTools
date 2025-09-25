namespace NoraOpcUaTestServer
{
    partial class SimulateForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MeasureTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CipTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StopTb = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(36, 197);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Measure";
            // 
            // MeasureTb
            // 
            this.MeasureTb.Location = new System.Drawing.Point(36, 38);
            this.MeasureTb.Name = "MeasureTb";
            this.MeasureTb.Size = new System.Drawing.Size(100, 20);
            this.MeasureTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CIP";
            // 
            // CipTb
            // 
            this.CipTb.Location = new System.Drawing.Point(36, 85);
            this.CipTb.Name = "CipTb";
            this.CipTb.Size = new System.Drawing.Size(100, 20);
            this.CipTb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stop";
            // 
            // StopTb
            // 
            this.StopTb.Location = new System.Drawing.Point(36, 134);
            this.StopTb.Name = "StopTb";
            this.StopTb.Size = new System.Drawing.Size(100, 20);
            this.StopTb.TabIndex = 6;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(138, 197);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SimulateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 239);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StopTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CipTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MeasureTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulateForm";
            this.Text = "Simulate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulateForm_FormClosing);
            this.Load += new System.EventHandler(this.SimulateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MeasureTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CipTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StopTb;
        private System.Windows.Forms.Button CloseButton;
    }
}