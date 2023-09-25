namespace TCPConnectionApp
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnStartServer = new Button();
            btnStop = new Button();
            txtPort = new TextBox();
            txtKey = new TextBox();
            txtKey2 = new TextBox();
            rtbServerData = new RichTextBox();
            lbClients = new ListBox();
            btnSave = new Button();
            chkEncrypt = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Server Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 40);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Encryption Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 69);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Encryption Key 2";
            // 
            // btnStartServer
            // 
            btnStartServer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartServer.Location = new Point(12, 91);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(439, 31);
            btnStartServer.TabIndex = 3;
            btnStartServer.Text = "Start Server";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStop.Location = new Point(12, 128);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(439, 32);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop Server";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(157, 8);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(294, 23);
            txtPort.TabIndex = 5;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(157, 37);
            txtKey.MaxLength = 16;
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(294, 23);
            txtKey.TabIndex = 6;
            // 
            // txtKey2
            // 
            txtKey2.Location = new Point(157, 66);
            txtKey2.MaxLength = 16;
            txtKey2.Name = "txtKey2";
            txtKey2.Size = new Size(294, 23);
            txtKey2.TabIndex = 7;
            // 
            // rtbServerData
            // 
            rtbServerData.Location = new Point(3, 166);
            rtbServerData.Name = "rtbServerData";
            rtbServerData.ReadOnly = true;
            rtbServerData.Size = new Size(578, 272);
            rtbServerData.TabIndex = 8;
            rtbServerData.Text = "";
            // 
            // lbClients
            // 
            lbClients.FormattingEnabled = true;
            lbClients.ItemHeight = 15;
            lbClients.Location = new Point(587, 1);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(201, 439);
            lbClients.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(457, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 88);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkEncrypt
            // 
            chkEncrypt.AutoSize = true;
            chkEncrypt.Location = new Point(457, 141);
            chkEncrypt.Name = "chkEncrypt";
            chkEncrypt.Size = new Size(85, 19);
            chkEncrypt.TabIndex = 11;
            chkEncrypt.Text = "Encrypt On";
            chkEncrypt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(457, 95);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 12;
            button1.Text = "Generate Keys";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(chkEncrypt);
            Controls.Add(btnSave);
            Controls.Add(lbClients);
            Controls.Add(rtbServerData);
            Controls.Add(txtKey2);
            Controls.Add(txtKey);
            Controls.Add(txtPort);
            Controls.Add(btnStop);
            Controls.Add(btnStartServer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Server";
            Text = "Server";
            FormClosing += Server_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnStartServer;
        private Button btnStop;
        private TextBox txtPort;
        private TextBox txtKey;
        private TextBox txtKey2;
        private RichTextBox rtbServerData;
        private ListBox lbClients;
        private Button btnSave;
        private CheckBox chkEncrypt;
        private Button button1;
    }
}