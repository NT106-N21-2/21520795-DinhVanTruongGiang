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
    public partial class Ex5_Client : Form
    {
        //các biến dùng để kết nối mạng và quản lý các luồng đọc/ghi message
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private string userName;
        public Ex5_Client()
        {
            InitializeComponent();
            try
            {
                //Tạo kết nối tới server
                client = new TcpClient("127.0.0.1", 8080);
                //dùng để ghi và đọc dữ liệu từ kết nối
                stream = client.GetStream();
                //Tạo luồng
                //Sử dụng ReceiveMessage để có thể đọc message được gửi từ server và hiển thị
                receiveThread = new Thread(ReceiveMessages);
                //Thực thi luồng
                receiveThread.Start();
                // lấy tên người dùng ra và gửi tới Server
                userName = tb_Name.Text;
                SendMessage(userName);

                AppendMessage("Connected to server.");
            }
            catch (Exception ex)
            {
                AppendMessage("[ERROR] " + ex.Message);
            }
        }

        //Phương thức dùng để đọc các message được gửi từ server
        private void ReceiveMessages()
        {
            //lặp với điều kiện có kết nối tới Server rồi
            while (client.Connected)
            {
                string message = ReadMessage(stream);
                if (message != null)
                {
                    AppendMessage(message);
                }
                else
                {
                    AppendMessage("Server disconnected.");
                    break;
                }
            }
        }

        //Dùng để lấy tên của client và message để gửi tới server
        private void btn_Send_Click(object sender, EventArgs e)
        {
            userName = tb_Name.Text;
            string message = tb_Message.Text;
            SendMessage($"{client.Client.RemoteEndPoint}: {userName}: {message}");
        }

        //Phương thức dùng để gửi message tới Server
        private void SendMessage(string message)
        {
            if (client != null && client.Connected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message + "\n");
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        //Phương thức dùng để đọc các message từ luồng mạng
        private string ReadMessage(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            if (bytesRead > 0)
            {
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            else
            {
                return null;
            }
        }

        //Phương thức dùng để hiển thị message lên giao diện
        private void AppendMessage(string message)
        {
            //check coi đúng luồng không, nếu ở luồng khác, sử dụng Invoke để gọi lại AppendMessage trên luồng chính
            if (rtb_Client.InvokeRequired)
            {
                rtb_Client.Invoke(new Action<string>(AppendMessage), message);
            }
            else
            {
                string[] messageParts = message.Split(':');
                if (messageParts.Length == 2)
                {
                    rtb_Client.AppendText(messageParts[0] + ": " + messageParts[1] + Environment.NewLine);
                }
                else
                {
                    rtb_Client.AppendText(message + Environment.NewLine);
                }
            }
        }

        //Đóng kết nối mạng, thoát ứng dụng
        private void Ex5_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
            if (stream != null)
            {
                stream.Close();
            }
            Application.Exit();
        }
    }
}
