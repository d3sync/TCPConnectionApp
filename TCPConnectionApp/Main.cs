using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using SuperSimpleTcp;
using TCPConnectionApp.Properties;

namespace TCPConnectionApp
{
    public partial class Main : Form
    {
        private SimpleTcpClient tcpClient;
        private Server _serverForm = new Server();
        const char Vt = '\v';       // Vertical Tab (VT)
        const char Fs = '\u001C';   // File Separator (FS)
        const char Cr = '\r';       // Carriage Return (CR)
        private string[]? sentMessages = new string[10];
        private int _pos = 0;
        public Main()
        {
            InitializeComponent();
            try
            {
                IPAddress ipAddress = GetLocalIPAddress();
                AppendWithNewLine($"*** Detected local IP Address: {ipAddress}");
                txtIP.Text = ipAddress.ToString();
                txtPort.Text = "6667";
            }
            catch (Exception ex)
            {
                AppendWithNewLine(ex.Message);
            }
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.SourceControl is RichTextBox rtb)
            {
                rtb.Clear();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIP.Text) || string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("Please input IP & Port",
                    "Missing Parameters",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var isIpValid = IPAddress.TryParse(txtIP.Text, out var ip);
                var isPortValid = int.TryParse(txtPort.Text, out var port);
                if (!isIpValid && !isPortValid)
                {
                    MessageBox.Show("Please input valid IP & Port",
                        "Invalid IP or Port",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    tcpClient = new SimpleTcpClient(ip, port);
                    tcpClient.Events.Connected += Events_Connected;
                    tcpClient.Events.DataReceived += Events_DataReceived;
                    tcpClient.Events.DataSent += Events_DataSent;
                    tcpClient.Events.Disconnected += Events_Disconnected;
                    try
                    {
                        tcpClient.ConnectWithRetries(10000);
                    }
                    catch
                    {
                        AppendWithNewLine("*** Failed to connect! Connection timeout... Try again.");
                    }
                }
            }
        }

        private void AppendWithNewLine(string text)
        {
            try
            {
                if (rtbData.InvokeRequired) // Check if we're on a different thread than the control's
                {
                    rtbData.Invoke(new Action<string>(AppendWithNewLine),
                        text); // Invoke the same method on the main thread
                }
                else
                {
                    rtbData.AppendText(
                        $"{text}{Environment.NewLine}"); // Directly update the control since we're on the main thread
                }
                ScrollToEnd();
            }
            catch
            {

            }
        }

        private void ScrollToEnd()
        {
            rtbData.SelectionStart = rtbData.Text.Length;
            rtbData.ScrollToCaret();
        }
        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            rtbData.BeginInvoke(new Action<string>(AppendWithNewLine), $"*** Server {e.IpPort} disconnected!");
            SetControlsStateAsync(true, btnConnect);
        }

        private void SetControlsStateAsync(bool state, params Control[] controls)
        {
            this.BeginInvoke(new Action(() =>
            {
                foreach (Control control in controls)
                {
                    control.Enabled = state;
                }
            }));
        }

        private void Events_DataSent(object? sender, DataSentEventArgs e)
        {
            //AppendWithNewLine($"[{DateTime.Now}]:{e.BytesSent}");
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            var data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
            var ip = data.Split(" ")[0];
            var text = data.Split(" ")[1];
            if (Properties.Settings.Default.Encrypt)
            {
                data = Decrypt(text);
            }
            AppendWithNewLine($"[{DateTime.Now}]:{ip}{data}");
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            AppendWithNewLine($"*** Server {e.IpPort} connected!");
            SetControlsState(false, btnConnect);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (tcpClient is not null)
                tcpClient.Disconnect();
        }

        private string Encrypt(string input)
        {
            return Encryption.Encrypt(input, Properties.Settings.Default.EncKey,Properties.Settings.Default.EncKey2);
        }
        private string Decrypt(string input)
        {
            return Encryption.Decrypt(input, Properties.Settings.Default.EncKey,Properties.Settings.Default.EncKey2);
        }
        private void PopulateLastMessagesMenu()
        {
            // Clear existing items from the submenu
            lastMessagesToolStripMenuItem.DropDownItems.Clear();

            foreach (string message in sentMessages)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    // Truncate the message for display
                    string truncatedMessage = message.Length > 20 ? message.Substring(0, 20) + "..." : message;

                    // Create the submenu item
                    ToolStripMenuItem item = new ToolStripMenuItem(truncatedMessage);
                    item.Click += (sender, e) =>
                    {
                        rtbSendData.Text = message; // Copy full message to richTextBox
                    };

                    // Add the submenu item to lastMessagesToolStripMenuItem
                    lastMessagesToolStripMenuItem.DropDownItems.Add(item);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient is not { IsConnected: true })
                {
                    AppendWithNewLine($"*** Not connected! Unable to send data.");
                }
                else
                {
                    var data = rtbSendData.Text;
                    if (Properties.Settings.Default.Encrypt)
                    {
                        data = Encrypt(data);
                    }
                    if (rtbSendData.Text.Contains(@"\r"))
                        data = data.Replace(@"\r", Cr.ToString());
                    if (rtbSendData.Text.Contains(@"\n"))
                        data = data.Replace(@"\n", Environment.NewLine);
                    if (cbMLLP.Checked)
                    {
                        tcpClient.Send($"{Vt}{data}{Fs}{Cr}");
                        if (_pos == 10)
                            _pos = 0;
                        sentMessages[_pos] = rtbSendData.Text;
                    }
                    else
                    {
                        tcpClient.Send($"{data}");
                        if (_pos == 10)
                            _pos = 0;
                        sentMessages[_pos] = rtbSendData.Text;
                    }
                    _pos++;
                    //AppendWithNewLine(">>>>>>>>" + DateTime.Now + " Transmission Started!");
                    AppendWithNewLine(Environment.NewLine + ">>>" + rtbSendData.Text);
                    ScrollToEnd();
                    //AppendWithNewLine(">>>>>>>> EOT");
                    rtbSendData.Clear();
                    PopulateLastMessagesMenu();
                }
            }
            catch (Exception ex)
            {
                AppendWithNewLine(ex.Message);
            }
        }
        private void SetControlsState(bool state, params Control[] controls)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetControlsState(state, controls)));
            }
            else
            {
                foreach (var control in controls)
                {
                    control.Enabled = state;
                }
            }
        }
        private static IPAddress GetLocalIPAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (!ni.Description.ToLowerInvariant().Contains("virtual") &&
                    !ni.Description.ToLowerInvariant().Contains("pseudo") &&
                    !ni.Description.ToLowerInvariant().Contains("vmware") &&
                    !ni.Description.ToLowerInvariant().Contains("hyper-v"))
                {
                    // Filter for Ethernet and WLAN network interfaces
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                        ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        if (ni.OperationalStatus == OperationalStatus.Up)
                        {
                            foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                            {
                                // We're filtering for IPv4 addresses here. If you want IPv6, then adjust accordingly.
                                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    return ip.Address;
                                }
                            }
                        }
                    }
                }
            }

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serverForm is null)
            {
                _serverForm = new Server();
            }
            _serverForm.Show();
        }
    }
}