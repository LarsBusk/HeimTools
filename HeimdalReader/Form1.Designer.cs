namespace HeimdalReader
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incidentsBtn = new System.Windows.Forms.Button();
            this.conditionsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.fromSimCb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 149);
            this.dataGridView1.TabIndex = 1;
            // 
            // incidentsBtn
            // 
            this.incidentsBtn.Location = new System.Drawing.Point(805, 360);
            this.incidentsBtn.Name = "incidentsBtn";
            this.incidentsBtn.Size = new System.Drawing.Size(75, 23);
            this.incidentsBtn.TabIndex = 2;
            this.incidentsBtn.Text = "Incidents";
            this.incidentsBtn.UseVisualStyleBackColor = true;
            this.incidentsBtn.Click += new System.EventHandler(this.incidentsBtn_Click);
            // 
            // conditionsBtn
            // 
            this.conditionsBtn.Location = new System.Drawing.Point(805, 398);
            this.conditionsBtn.Name = "conditionsBtn";
            this.conditionsBtn.Size = new System.Drawing.Size(75, 23);
            this.conditionsBtn.TabIndex = 3;
            this.conditionsBtn.Text = "Conditions";
            this.conditionsBtn.UseVisualStyleBackColor = true;
            this.conditionsBtn.Click += new System.EventHandler(this.conditionsBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(805, 322);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(75, 23);
            this.productsBtn.TabIndex = 5;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 198);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(399, 223);
            this.treeView1.TabIndex = 6;
            // 
            // fromSimCb
            // 
            this.fromSimCb.AutoSize = true;
            this.fromSimCb.Location = new System.Drawing.Point(671, 211);
            this.fromSimCb.Name = "fromSimCb";
            this.fromSimCb.Size = new System.Drawing.Size(93, 17);
            this.fromSimCb.TabIndex = 7;
            this.fromSimCb.Text = "From simulator";
            this.fromSimCb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.fromSimCb);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conditionsBtn);
            this.Controls.Add(this.incidentsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Heimdal reader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button incidentsBtn;
        private System.Windows.Forms.Button conditionsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox fromSimCb;
    }
}

