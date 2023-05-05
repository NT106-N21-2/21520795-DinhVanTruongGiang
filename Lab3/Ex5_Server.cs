using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Ex5_Server : Form
    {
        private TcpListener server;
        private Thread listenThread;
        private List<TcpClient> connectedClients = new List<TcpClient>();

        //Cái này để lưu tên người dùng với mỗi client được kết nối
        private Dictionary<TcpClient, string> userNames = new Dictionary<TcpClient, string>();

        //Dùng để kiểm tra xem Server có đang chạy hay không
        private bool isServerRunning;

        public Ex5_Server()
        {
            InitializeComponent();
        }
        private void Log(string message)
        {
            if (serverTextBox.InvokeRequired)
            {
                serverTextBox.Invoke(new Action<string>(Log), message);
            }
            else
            {
                serverTextBox.AppendText(message);
            }
        }
        private void Listen_Click(object sender, EventArgs e)
        {
            int port = 8080;
            server = new TcpListener(IPAddress.Any, port);
            //Server bắt đầu lắng nghe
            server.Start();
            isServerRunning = true;

            Log($"Server started on 127.0.0.1:{port}\n");

            //Tạo thread để chấp nhận kết nối từ các Client
            listenThread = new Thread(AcceptClients);
            listenThread.Start();

            //Ẩn/hiện các button
            Listen.Enabled = false;
            StopListen.Enabled = true;
        }

        private void AcceptClients()
        {
            while (isServerRunning)
            {
                try
                {
                    //Chấp nhận kết nối từ Client
                    TcpClient client = server.AcceptTcpClient();
                    Log($"New client connected from: {client.Client.RemoteEndPoint}\n");

                    // Thêm client vào danh sách
                    lock (connectedClients)
                    {
                        connectedClients.Add(client);
                    }
                    //Đọc tên người dùng
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string userName = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    userNames[client] = userName;

                    //Tạo thread mới để nhận tin nhắn từ Client vừa kết nối
                    Thread receiveMessagesThread = new Thread(() => ReceiveMessages(client));
                    receiveMessagesThread.Start();
                }
                catch (Exception ex)
                {
                    if (!isServerRunning)
                    {
                        break;
                    }
                    Log($"Error accepting client: {ex.Message}");
                    continue;
                }
            }
        }
        //Hàm này để nhận tin nhắn
        private void ReceiveMessages(TcpClient client)
        {
            //Tạo 1 stream để đọc và ghi tin nhắn gửi từ Client
            NetworkStream stream = client.GetStream();
            //Mảng này để đọc dữ liệu từ stream đó
            byte[] buffer = new byte[1024];

            //Nếu vẫn còn kết nối thì vẫn nhận tin nhắn
            while (client.Connected)
            {
                //Đọc dữ liệu từ stream vào mảng byte
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }

                //Chuyển dữ liệu đọc thành chuỗi
                string userName = userNames[client];
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                //In ra màn hình
                Log($"{userName}: {message}\n");
                //Gửi tới các client khác nữa
                SendMessageToAllClients(client, $"{userName}: {message}");
            }

            //Xoá Client khỏi ds
            lock (connectedClients)
            {
                connectedClients.Remove(client);
            }

            Log($"Client disconnected: {client.Client.RemoteEndPoint}\n");
            stream.Close();
        }
        private void SendMessageToAllClients(TcpClient senderClient, string message)
        {
            //Chuyển tin nhắn thành mảng byte
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            //Duyệt qua tất cả các Client trong list để gửi tin nhắn
            foreach (TcpClient client in userNames.Keys)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        private void StopListen_Click(object sender, EventArgs e)
        {
            Listen.Enabled = true;
            StopListen.Enabled = false;

            isServerRunning = false;
            //Dừng máy chủ
            server.Stop();
            //Xoá danh sách các Clients đang kết nối
            connectedClients.Clear();
            Log("Server stopped\n");
        }

        //private void Ex5_Server_Load(object sender, EventArgs e)
        //{

        //}
    }
}
