namespace Caspar_CG_OSC_Monitor
{
    partial class formMain
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
            this.splitContainerToolbarLogs = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartStopServer = new System.Windows.Forms.Button();
            this.numericUpDownOSCPort = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewIncomingMessages = new System.Windows.Forms.DataGridView();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarLogs)).BeginInit();
            this.splitContainerToolbarLogs.Panel1.SuspendLayout();
            this.splitContainerToolbarLogs.Panel2.SuspendLayout();
            this.splitContainerToolbarLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSCPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerToolbarLogs
            // 
            this.splitContainerToolbarLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerToolbarLogs.IsSplitterFixed = true;
            this.splitContainerToolbarLogs.Location = new System.Drawing.Point(0, 0);
            this.splitContainerToolbarLogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerToolbarLogs.Name = "splitContainerToolbarLogs";
            this.splitContainerToolbarLogs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerToolbarLogs.Panel1
            // 
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.clearBtn);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.filterBox);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.label1);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.buttonStartStopServer);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.numericUpDownOSCPort);
            // 
            // splitContainerToolbarLogs.Panel2
            // 
            this.splitContainerToolbarLogs.Panel2.Controls.Add(this.dataGridViewIncomingMessages);
            this.splitContainerToolbarLogs.Size = new System.Drawing.Size(803, 305);
            this.splitContainerToolbarLogs.SplitterDistance = 45;
            this.splitContainerToolbarLogs.SplitterWidth = 3;
            this.splitContainerToolbarLogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monitor Port:";
            // 
            // buttonStartStopServer
            // 
            this.buttonStartStopServer.Location = new System.Drawing.Point(196, 10);
            this.buttonStartStopServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartStopServer.Name = "buttonStartStopServer";
            this.buttonStartStopServer.Size = new System.Drawing.Size(85, 27);
            this.buttonStartStopServer.TabIndex = 1;
            this.buttonStartStopServer.Text = "Start Server";
            this.buttonStartStopServer.UseVisualStyleBackColor = true;
            this.buttonStartStopServer.Click += new System.EventHandler(this.buttonStartStopServer_Click);
            // 
            // numericUpDownOSCPort
            // 
            this.numericUpDownOSCPort.Location = new System.Drawing.Point(92, 16);
            this.numericUpDownOSCPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownOSCPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownOSCPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOSCPort.Name = "numericUpDownOSCPort";
            this.numericUpDownOSCPort.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownOSCPort.TabIndex = 0;
            this.numericUpDownOSCPort.Value = new decimal(new int[] {
            6250,
            0,
            0,
            0});
            // 
            // dataGridViewIncomingMessages
            // 
            this.dataGridViewIncomingMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomingMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIncomingMessages.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIncomingMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewIncomingMessages.Name = "dataGridViewIncomingMessages";
            this.dataGridViewIncomingMessages.RowHeadersVisible = false;
            this.dataGridViewIncomingMessages.RowTemplate.Height = 28;
            this.dataGridViewIncomingMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewIncomingMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIncomingMessages.Size = new System.Drawing.Size(803, 257);
            this.dataGridViewIncomingMessages.TabIndex = 0;
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(338, 14);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(268, 20);
            this.filterBox.TabIndex = 3;
            this.filterBox.TextChanged += filterChanged;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(655, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 305);
            this.Controls.Add(this.splitContainerToolbarLogs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMain";
            this.Text = "Caspar CG OSC Monitor";
            this.splitContainerToolbarLogs.Panel1.ResumeLayout(false);
            this.splitContainerToolbarLogs.Panel1.PerformLayout();
            this.splitContainerToolbarLogs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarLogs)).EndInit();
            this.splitContainerToolbarLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSCPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerToolbarLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartStopServer;
        private System.Windows.Forms.NumericUpDown numericUpDownOSCPort;
        private System.Windows.Forms.DataGridView dataGridViewIncomingMessages;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button clearBtn;
    }
}

