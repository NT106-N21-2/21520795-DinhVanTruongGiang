using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

namespace Lab3
{
    public partial class Ex1_UDP_Server : Form
    {
        public Ex1_UDP_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port;
            if(!int.TryParse(textBox1.Text, out port))
            {
                MessageBox.Show("Please enter port number!");
                return;
            }
            Thread serverThread = new Thread(new ThreadStart(ServerThread));
            serverThread.Start();
            serverThread.IsBackground = true;
        }
        private void ServerThread()
        {
            UdpClient udpClient = new UdpClient(int.Parse(textBox1.Text));
            while (true)
            {
                IPEndPoint RemoteIPEP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] recvdBytes = udpClient.Receive(ref RemoteIPEP);
                string RecvdData = Encoding.UTF8.GetString(recvdBytes);
                string msg = RemoteIPEP.Address.ToString() + ": "+ RecvdData.ToString() + "\n";
                textBox2.Text += msg;
            }
        }
    }
}
