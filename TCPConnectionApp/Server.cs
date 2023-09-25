using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPConnectionApp
{
    public partial class Server : Form
    {
        private SimpleTcpServer _server;
        private int _port => Properties.Settings.Default.ServerPort;
        public Server()
        {
            InitializeComponent();
            txtPort.Text = Properties.Settings.Default.ServerPort.ToString();
            txtKey.Text = Properties.Settings.Default.EncKey;
            txtKey2.Text = Properties.Settings.Default.EncKey2;
            chkEncrypt.Checked = Properties.Settings.Default.Encrypt;
            txtPort.KeyPress += TextBox_KeyPress;
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPort = int.Parse(txtPort.Text);
            Properties.Settings.Default.EncKey = txtKey.Text;
            Properties.Settings.Default.EncKey2 = txtKey2.Text;
            Properties.Settings.Default.Encrypt = chkEncrypt.Checked;
            Properties.Settings.Default.Save();
        }
        public async Task<SimpleTcpServer> StarTcpServer(string port)
        {
            _server = new SimpleTcpServer($"0.0.0.0:{port}");
            _server.Settings.NoDelay = true;
            _server.Keepalive.EnableTcpKeepAlives = true;
            try
            {
                _server.Start();
                if (_server.IsListening)
                {
                    PrintToRtb($"*** Server is listening on {_port}.");
                }
                //_logger.Information("[ {status} ] TCP Server started listening on {port}.", "OK", port);
            }
            catch (Exception ex)
            {
                PrintToRtb($"*** Server unable to start on {_port}. Error: {ex.Message}");
                //_logger.Error("[ {status} ] TCP Server failed to start listening on {port}. Issue: {error}", "OK", port, ex.Message);
            }
            _server.Events.ClientConnected += EventsOnClientConnected;
            _server.Events.ClientDisconnected += Events_ClientDisconnected;
            _server.Events.DataReceived += Events_DataReceived;
            return _server;
        }

        public void Stop()
        {
            _server.Stop();
        }

        //private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        //{
        //    var ip = e.IpPort;
        //    var data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
        //    data = $"[{ip}] {data}";
        //    byte[] byteArray = Encoding.UTF8.GetBytes(data);
        //    ArraySegment<byte> arraySegment = new ArraySegment<byte>(byteArray);

        //    var d = (SimpleTcpServer)sender;
        //    foreach (var client in d.GetClients())
        //    {
        //        _server.Send(client, arraySegment.Array);
        //    }
        //    PrintToRtb($"*** Broadcasted: {data}");
        //}
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            var ip = e.IpPort;
            var data = $"[{ip}] {Encoding.UTF8.GetString(e.Data.Array, e.Data.Offset, e.Data.Count)}";

            var d = (SimpleTcpServer)sender;

            // Send the data directly as an ArraySegment<byte> to all clients
            foreach (var client in d.GetClients())
            {
                _server.Send(client, data);
            }

            PrintToRtb($"*** Broadcasted: {data}");
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            //Console.WriteLine("*** [" + e.IpPort + "] client connected");
            PrintToRtb("*** [" + e.IpPort + "] client connected");
            PopulateLb();
        }

        private void EventsOnClientConnected(object? sender, ConnectionEventArgs e)
        {
            //Console.WriteLine("*** [" + e.IpPort + "] client connected");
            PrintToRtb("*** [" + e.IpPort + "] client connected");
            PopulateLb();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Task.Run(() => StarTcpServer(_port.ToString()));
        }

        private void PrintToRtb(string text)
        {
            var dt = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                if (rtbServerData.InvokeRequired) // Check if we're on a different thread than the control's
                {
                    rtbServerData.Invoke(new Action<string>(PrintToRtb),
                        text);
                }
                else
                {
                    rtbServerData.AppendText($"[{dt}]" + text + Environment.NewLine); // Directly update the control since we're on the main thread
                }
                ScrollToEnd();
            }
            catch
            {

            }
        }

        private void PopulateLb()
        {
            if (lbClients.InvokeRequired)
            {
                lbClients.Invoke(new Action(() => PopulateLb()));
            }
            else
            {
                lbClients.Items.Clear();
                foreach (var client in _server.GetClients())
                {
                    lbClients.Items.Add(client);
                }
            }
        }
        private void ScrollToEnd()
        {
            rtbServerData.SelectionStart = rtbServerData.Text.Length;
            rtbServerData.ScrollToCaret();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
            PrintToRtb("*** Stopped the server.");
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // For AES-128, use a 128-bit key (16 bytes) and a 128-bit IV (16 bytes)
            byte[] aesKey = new byte[16];
            byte[] aesIV = new byte[16];

// Generate random bytes for the key and IV
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(aesKey);
                rngCsp.GetBytes(aesIV);
            }
            PrintToRtb("Key:" + aesKey);
            PrintToRtb("IV:" + aesIV);
        }
    }
}
