namespace NoraOpcUaTestServer
{
    partial class EventsForm
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
            this.EventsDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EventsDataGridView
            // 
            this.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGridView.Location = new System.Drawing.Point(53, 38);
            this.EventsDataGridView.Name = "EventsDataGridView";
            this.EventsDataGridView.Size = new System.Drawing.Size(725, 559);
            this.EventsDataGridView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(703, 612);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.EventsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EventsDataGridView;
        private System.Windows.Forms.Button refreshButton;
    }
}