using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Ex4_TCP_Client : Form
    {
        public Ex4_TCP_Client()
        {
            InitializeComponent();
        }
        private TcpClient tcpClient;
        private bool IsServer1Running()
        {
            try
            {
                using (TcpClient Client = new TcpClient("127.0.0.1", 8080)) { };
                return true;
            }
            catch (Exception ex)
            {
                if (ex is SocketException)
                {
                    return false;
                }
                throw;
            }
        }
        private bool IsBackupServerRunning()
        {
            try
            {
                using (TcpClient Client = new TcpClient("127.0.0.1", 8081)) { };
                return true;
            }
            catch (Exception ex)
            {
                if (ex is SocketException)
                {
                    return false;
                }
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IPAddress = "127.0.0.1";
            int port;
            if (!IsServer1Running())
            {
                DisplayMessage("Can't connect to Server1. Try connect to BackupServer ...");
                if (!IsBackupServerRunning())
                {
                    MessageBox.Show("Can't connect to any Server!", "Please start the server!");
                    return;
                }
                else
                {
                    port = 8081;
                }
            }
            else port = 8080;
            
            tcpClient = new TcpClient(IPAddress, port);
            DisplayMessage("Connected\n");

            string username = "I'm Client";
            StreamWriter sw = new StreamWriter(tcpClient.GetStream());
            sw.WriteLine(username);
            sw.Flush();

            button2.Enabled = false;
            button3.Enabled = true;
        }
        private void DisplayMessage(string message)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
                richTextBox1.AppendText(message + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check message box is empty or not
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a message!");
                return;
            }
            //check connection
            if (!tcpClient.Connected)
            {
                string IPAddress = "127.0.0.1";
                int port;
                if (!IsServer1Running())
                {
                    DisplayMessage("Can't connect to Server1. Try connect to BackupServer ...");
                    if (!IsBackupServerRunning())
                    {
                        MessageBox.Show("Can't connect to any Server!", "Please start the server!");
                        return;
                    }
                    else
                    {
                        port = 8081;
                    }
                }
                else port = 8080;
                tcpClient = new TcpClient(IPAddress, port);
                string username = "I'm Client";
                StreamWriter sw = new StreamWriter(tcpClient.GetStream());
                sw.WriteLine(username);
                sw.Flush();
            }
            string msg = textBox1.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            tcpClient.GetStream().Write(buffer, 0, buffer.Length);

            DisplayMessage("Me: " + msg);
            textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
                //tcpClient = null;
            }
            DisplayMessage("Disconnected");
            button3.Enabled = false;
            button2.Enabled = true;
        }
    }
}
