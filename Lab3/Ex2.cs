using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }
        bool isListen = true;
        bool isListening;
        private Socket listenerSocket, clientSocket;
        private void Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();

            isListen = false;
            Listen.Enabled = isListen;
            StopListen.Enabled = !isListen;
        }
        private bool IsPortInUse(int port)
        {
            bool isInUse = false;

            //Lấy thông tin giao thức IP trên hệ thông
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            //Lấy danh sách các IP và port (IPEndPoint) của các máy nghe TCP đang hoạt động
            IPEndPoint[] activeTcpListeners = ipGlobalProperties.GetActiveTcpListeners();

            //Duyệt qua tất cả để xem Port cần kiểm tra có bị trùng hay không 
            foreach (IPEndPoint endPoint in activeTcpListeners)
            {
                if (endPoint.Port == port)
                {
                    isInUse = true;
                    break;
                }
            }

            return isInUse;
        }

        void StartUnsafeThread()
        {
            int port = 8080;

            if (IsPortInUse(port))
            {
                MessageBox.Show($"The port {port} is in use. Please close the application that is using this port.");
                isListen = true;
                Listen.Enabled = isListen;
                StopListen.Enabled = !isListen;
            }
            else
            {
                int bytesReceived = 0;
                byte[] recv = new byte[1];
                listenerSocket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );
                IPEndPoint iperServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                listenerSocket.Bind(iperServer);
                listenerSocket.Listen(-1);

                isListening = true;
                while (isListening)
                {
                    try
                    {
                        clientSocket = listenerSocket.Accept();
                        ListViewCommand.Items.Add(new ListViewItem("New client connected"));
                        while (clientSocket.Connected)
                        {
                            string text = "";
                            do
                            {
                                bytesReceived = clientSocket.Receive(recv);
                                text += Encoding.ASCII.GetString(recv);
                            }
                            while (text[text.Length - 1] != '\n');
                            ListViewCommand.Items.Add(new ListViewItem(text));
                        }
                    }
                    catch
                    {
                        if (isListening)
                        {
                            MessageBox.Show("Error accepting a new connection.");
                        }
                        else break;
                    }
                }
                listenerSocket.Close();
            }
        }

        private void StopListen_Click(object sender, EventArgs e)
        {
            isListen = true;
            Listen.Enabled = isListen;
            StopListen.Enabled = !isListen;

            isListening = false;
            if (listenerSocket != null)
            {
                try
                {
                    listenerSocket.Close();
                    ListViewCommand.Items.Add(new ListViewItem("Listener stopped."));
                }
                catch
                {
                    MessageBox.Show("Error stopping listener: ");
                }
            }
            if (clientSocket != null)
            {
                try
                {
                    clientSocket.Close();
                    ListViewCommand.Items.Add(new ListViewItem("Client connection closed."));
                }
                catch
                {
                    MessageBox.Show("Error closing client connection: ");
                }
            }
        }

        private void Ex2_Load(object sender, EventArgs e)
        {

        }
    }
}
