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
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            settingsToolStripMenuItem = new ToolStripMenuItem();
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
            statusStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 0;
            label2.Text = "Port";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 432);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 10, 0);
            statusStrip1.Size = new Size(689, 30);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(37, 28);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(29, 2);
            txtIP.Margin = new Padding(2);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(160, 29);
            txtIP.TabIndex = 3;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(235, 2);
            txtPort.Margin = new Padding(2);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(69, 29);
            txtPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(308, 2);
            btnConnect.Margin = new Padding(2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(228, 29);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(540, 2);
            btnDisconnect.Margin = new Padding(2);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(131, 29);
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
            flowLayoutPanel1.Location = new Point(8, 7);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(673, 39);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // rtbData
            // 
            rtbData.ContextMenuStrip = contextMenuStrip1;
            rtbData.Location = new Point(8, 42);
            rtbData.Margin = new Padding(2);
            rtbData.Name = "rtbData";
            rtbData.ReadOnly = true;
            rtbData.Size = new Size(675, 352);
            rtbData.TabIndex = 8;
            rtbData.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemClear, lastMessagesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(150, 48);
            // 
            // toolStripMenuItemClear
            // 
            toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            toolStripMenuItemClear.Size = new Size(149, 22);
            toolStripMenuItemClear.Text = "Clear";
            toolStripMenuItemClear.Click += toolStripMenuItemClear_Click;
            // 
            // lastMessagesToolStripMenuItem
            // 
            lastMessagesToolStripMenuItem.Name = "lastMessagesToolStripMenuItem";
            lastMessagesToolStripMenuItem.Size = new Size(149, 22);
            lastMessagesToolStripMenuItem.Text = "Last Messages";
            // 
            // rtbSendData
            // 
            rtbSendData.ContextMenuStrip = contextMenuStrip1;
            rtbSendData.Location = new Point(7, 398);
            rtbSendData.Margin = new Padding(2);
            rtbSendData.Multiline = false;
            rtbSendData.Name = "rtbSendData";
            rtbSendData.Size = new Size(575, 29);
            rtbSendData.TabIndex = 9;
            rtbSendData.Text = "";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(585, 398);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(98, 29);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cbMLLP
            // 
            cbMLLP.AutoSize = true;
            cbMLLP.Enabled = false;
            cbMLLP.Location = new Point(599, 430);
            cbMLLP.Margin = new Padding(2);
            cbMLLP.Name = "cbMLLP";
            cbMLLP.Size = new Size(78, 19);
            cbMLLP.TabIndex = 11;
            cbMLLP.Text = "Use MLLP";
            cbMLLP.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 462);
            Controls.Add(cbMLLP);
            Controls.Add(btnSend);
            Controls.Add(rtbSendData);
            Controls.Add(rtbData);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Main";
            Text = "TCP Connect";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}