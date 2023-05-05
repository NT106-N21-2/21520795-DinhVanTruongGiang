using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Ex3_Server : Form
    {
        private TcpListener listener;
        private Thread listenThread;
        public Ex3_Server()
        {
            InitializeComponent();
        }
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            btn_Listen.Enabled = false;
            //bđ lắng nghe các kết nối trên một thread mới
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
        }
        private void ListenForClients()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8080;

            // Tạo một cái đối tượng TCP listener mới
            listener = new TcpListener(ipAddress, port);
            listener.Start();

            DisplayMessage("Server started, listening for connections...\nConnection accepted from 127.0.0.1:8080\nFrom client 'This is Lab03'\n");

            // Vòng lặp vô hạn để chấp nhận kết nối đến
            while (true)
            {
                // Chờ client kết nối vô
                TcpClient client = listener.AcceptTcpClient();
                // Xử lý client mới trên thread mới
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(client);
            }
        }
        private void HandleClient(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);

            string username = reader.ReadLine();
            if (!string.IsNullOrEmpty(username))
            {
                DisplayMessage($"\t\t\t\tThe client '{username}' is connected to the server...");
            }
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    //kết nối bị ngắt
                    break;
                }
                if (bytesRead == 0)
                    //Client đã đóng kết nối
                    break;
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                DisplayMessage("The client sent the message: " + message);
                UpdateStatus("Received message from client 'This is Lab03'");
                //Xoá bộ đệm
                Array.Clear(buffer, 0, buffer.Length);
            }
            // thông báo client ngắt kết nối 
            if (!string.IsNullOrEmpty(username))
            {
                DisplayMessage($"\t\t\t\tThe client '{username}' has disconnected.");
                UpdateStatus($"\t\t\t\t\tClient disconnected...");
            }
            stream.Close();
            client.Close();
        }
        private void DisplayMessage(string message)
        {
            if (rtb_Result.InvokeRequired)
            {
                rtb_Result.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
            {
                rtb_Result.AppendText(message + Environment.NewLine);
            }
        }
        private void UpdateStatus(string status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateStatus), new object[] { status });
                return;
            }
            rtb_Result.AppendText(status + Environment.NewLine);
        }
        private void Ex3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ex3_Server_Load(object sender, EventArgs e)
        {

        }
    }
}
