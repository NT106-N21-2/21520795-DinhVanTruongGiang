using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Ex4_TCP_BackupServer : Form
    {
        private TcpListener bListener;
        private Thread bthread;
        public Ex4_TCP_BackupServer()
        {
            InitializeComponent();
        }

        private void Ex4_TCP_BackupServer_Load(object sender, EventArgs e)
        {
            bthread = new Thread(new ThreadStart(Listening));
            bthread.Start();
        }
        private void Listening()
        {
            IPEndPoint ServerIPEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8081);
            bListener = new TcpListener(ServerIPEP);
            bListener.Start();

            DisplayMessage("Server2 started, listening for connections ...");

            while (true)
            {
                try
                {
                    TcpClient tcpClient = bListener.AcceptTcpClient();

                    Thread clientThread = new Thread(() => HandleClient(tcpClient));
                    clientThread.Start();
                }
                catch
                {
                    break;
                }
            }
        }
        private void HandleClient(object clientObject)
        {
            TcpClient client = (TcpClient)clientObject;
            NetworkStream stream = client.GetStream();
            StreamReader streamReader = new StreamReader(stream);

            string username = streamReader.ReadLine();
            if (!String.IsNullOrEmpty(username))
            {
                DisplayMessage($"Client '{username}' is connected!");
            }
            byte[] buffer = new byte[1024];
            int byteRead = 0;
            while (true)
            {
                try
                {
                    byteRead = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    break;
                }
                if (byteRead == 0) break;

                string msg = Encoding.UTF8.GetString(buffer, 0, byteRead);
                DisplayMessage($"'{username}': " + msg);
                Array.Clear(buffer, 0, buffer.Length);
            }

            if (!string.IsNullOrEmpty(username))
            {
                DisplayMessage($"'{username}' is disconnected");
            }
            stream.Close();
            streamReader.Close();
            client.Close();
        }
        private void DisplayMessage(string message)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
            {
                richTextBox1.AppendText(message + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bListener.Stop();
            DisplayMessage("Server2 stopped");
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            bthread = new Thread(new ThreadStart(Listening));
            bthread.Start();
        }
    }
}
