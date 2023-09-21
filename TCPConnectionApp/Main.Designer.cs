namespace TCPConnectionApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            txtIP = new TextBox();
            txtPort = new TextBox();
            btnConnect = new Button();
            btnDisconnect = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rtbData = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItemClear = new ToolStripMenuItem();
            lastMessagesToolStripMenuItem = new ToolStripMenuItem();
            rtbSendData = new RichTextBox();
            btnSend = new Button();
            cbMLLP = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 32);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 0;
            label2.Text = "Port";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 748);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(42, 3);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(227, 39);
            txtIP.TabIndex = 3;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(337, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(97, 39);
            txtPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(440, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(325, 39);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(771, 3);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(187, 39);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtIP);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtPort);
            flowLayoutPanel1.Controls.Add(btnConnect);
            flowLayoutPanel1.Controls.Add(btnDisconnect);
            flowLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(962, 48);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // rtbData
            // 
            rtbData.ContextMenuStrip = contextMenuStrip1;
            rtbData.Location = new Point(12, 66);
            rtbData.Name = "rtbData";
            rtbData.ReadOnly = true;
            rtbData.Size = new Size(962, 510);
            rtbData.TabIndex = 8;
            rtbData.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemClear, lastMessagesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(199, 68);
            // 
            // toolStripMenuItemClear
            // 
            toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            toolStripMenuItemClear.Size = new Size(198, 32);
            toolStripMenuItemClear.Text = "Clear";
            toolStripMenuItemClear.Click += toolStripMenuItemClear_Click;
            // 
            // lastMessagesToolStripMenuItem
            // 
            lastMessagesToolStripMenuItem.Name = "lastMessagesToolStripMenuItem";
            lastMessagesToolStripMenuItem.Size = new Size(198, 32);
            lastMessagesToolStripMenuItem.Text = "Last Messages";
            // 
            // rtbSendData
            // 
            rtbSendData.ContextMenuStrip = contextMenuStrip1;
            rtbSendData.Location = new Point(10, 582);
            rtbSendData.Name = "rtbSendData";
            rtbSendData.Size = new Size(820, 163);
            rtbSendData.TabIndex = 9;
            rtbSendData.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(836, 582);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(148, 134);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cbMLLP
            // 
            cbMLLP.AutoSize = true;
            cbMLLP.Location = new Point(856, 716);
            cbMLLP.Name = "cbMLLP";
            cbMLLP.Size = new Size(114, 29);
            cbMLLP.TabIndex = 11;
            cbMLLP.Text = "Use MLLP";
            cbMLLP.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 770);
            Controls.Add(cbMLLP);
            Controls.Add(btnSend);
            Controls.Add(rtbSendData);
            Controls.Add(rtbData);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "TCP Connect";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private StatusStrip statusStrip1;
        private TextBox txtIP;
        private TextBox txtPort;
        private Button btnConnect;
        private Button btnDisconnect;
        private FlowLayoutPanel flowLayoutPanel1;
        private RichTextBox rtbData;
        private RichTextBox rtbSendData;
        private Button btnSend;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemClear;
        private CheckBox cbMLLP;
        private ToolStripMenuItem lastMessagesToolStripMenuItem;
    }
}