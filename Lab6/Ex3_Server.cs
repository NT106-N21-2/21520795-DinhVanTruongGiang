using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Lab6
{
    public partial class Ex3_Server : Form
    {
        private TcpListener server;
        private Thread listenThread;
        private List<TcpClient> connectedClients = new List<TcpClient>();

        //Danh sách lưu tên người dùng với mỗi client được kết nối
        private ConcurrentDictionary<TcpClient, string> userNames = new ConcurrentDictionary<TcpClient, string>();
        private ConcurrentDictionary<TcpClient, string> pubKeys = new ConcurrentDictionary<TcpClient, string>();
        //Dùng để kiểm tra xem Server có đang chạy hay không
        private bool isServerRunning;
        public Ex3_Server()
        {
            InitializeComponent();
        }
        private void CreateNewKeys()
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
            //how to get the private key
            RSAParameters privKey = csp.ExportParameters(true);
            //and the public key ...
            RSAParameters pubKey = csp.ExportParameters(false);
            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();
                publicKey.Text = pubKeyString;
            }
            string privKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, privKey);
                //get the string from the stream
                privKeyString = sw.ToString();
                privateKey.Text = privKeyString;
            }
        }
        public string Encryption(string strText, string pubKey)
        {
            var testData = Encoding.UTF8.GetBytes(strText);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // client encrypting data with public key issued by server                    
                    rsa.FromXmlString(pubKey.ToString());
                    var encryptedData = rsa.Encrypt(testData, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        public string Decryption(string strText)
        {

            var testData = Encoding.UTF8.GetBytes(strText);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = strText;
                    // server decrypting data with private key                    
                    rsa.FromXmlString(privateKey.Text.ToString());
                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        private void Log(string message)
        {
            if (rtb_main.InvokeRequired)
            {
                rtb_main.Invoke(new Action<string>(Log), message);
            }
            else
            {
                //serverTextBox.AppendText(message); 
                string[] messageParts = message.Split(':');
                if (messageParts.Length == 2)
                {
                    Font boldFont = new Font(rtb_main.Font, FontStyle.Bold);
                    rtb_main.SelectionFont = boldFont;
                    rtb_main.AppendText(messageParts[0]);

                    Font ItalicFont = new Font(rtb_main.Font, FontStyle.Italic);
                    rtb_main.SelectionFont = ItalicFont;
                    rtb_main.AppendText($": ({DateTime.Now})");

                    rtb_main.SelectionFont = rtb_main.Font; // Đặt lại font gốc
                    rtb_main.AppendText(": " + messageParts[1] + "\n");
                }
                else
                {
                    rtb_main.AppendText(message + "\n");
                }
            }
        }
        private void latestMsg_Update(string message)
        {
            if (latestMsg.InvokeRequired)
            {
                latestMsg.Invoke(new Action<string>(latestMsg_Update), message);
            }
            else
            {
                latestMsg.AppendText(message + "\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            if (bt_Listen.Text == "Listen")
            {
                int port = 8080;
                server = new TcpListener(IPAddress.Any, port);
                //Server bắt đầu lắng nghe
                server.Start();
                isServerRunning = true;

                //Lấy địa chỉ ip hiện tại của pc để làm máy chủ
                string ipAddress = NetworkInterface
                .GetAllNetworkInterfaces()
                .FirstOrDefault(n => n.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && n.OperationalStatus == OperationalStatus.Up)
                ?.GetIPProperties()
                .UnicastAddresses
                .FirstOrDefault(a => a.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                ?.Address
                ?.ToString();
                Log($"Server started on {ipAddress}:{port}\n");

                //Tạo thread để chấp nhận kết nối từ các Client
                listenThread = new Thread(AcceptClients);
                listenThread.Start();

                //Tạo key.
                CreateNewKeys();

                //Ẩn/hiện các button
                bt_Listen.Text = "Stop Listening";
            }
            else StopListen_Click(sender, e);
        }
        private void AcceptClients()
        {
            while (isServerRunning)
            {
                try
                {
                    //Chấp nhận kết nối từ Client
                    TcpClient client = server.AcceptTcpClient();

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
                    //Thêm client vào CurentDictionary
                    userNames[client] = userName;

                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string pubKey = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    pubKeys[client] = pubKey;
                    Log($"[NEW USER] - {userNames[client]} connected from: {client.Client.RemoteEndPoint}.");
                    //Mã hóa
                    string message = "[NEW USER] - " + userName + " is connected.";
                    //Gửi key
                    string sendKey = publicKey.Text.ToString();
                    SendMessageToAllClients(client, sendKey);
                    SendMessageToAllClients(client, message);

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
        private void ReceiveMessages(TcpClient client)
        {
            //Tạo 1 stream để đọc và ghi tin nhắn gửi từ Client
            using (NetworkStream stream = client.GetStream())
            {
                //Mảng này để đọc dữ liệu từ stream đó
                byte[] buffer = new byte[1024];

                //Nếu vẫn còn kết nối thì vẫn nhận tin nhắn
                while (client.Connected && client != null && stream != null)
                {
                    if (isServerRunning == false)
                    {
                        break;
                    }
                    if (stream.DataAvailable)
                    {
                        //Đọc dữ liệu từ stream vào mảng byte
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }

                        //Chuyển dữ liệu đọc thành chuỗi
                        string userName = userNames[client];
                        string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        //Giải mã
                        string message = Decryption(receivedData);
                        //In ra màn hình
                        latestMsg_Update(receivedData);
                        Log($"{message}");

                        //Gửi tới các client khác nữa
                        SendMessageToAllClients(client, message);
                    }
                }
            }
        }
        private async Task SendMessageToAllClients(TcpClient senderClient, string message)
        {
            //Duyệt qua tất cả các Client trong list để gửi tin nhắn
            foreach (TcpClient client in connectedClients)
            {
                if (message.Contains("<?xml")) { }
                else message = Encryption(message, pubKeys[client]);
                //Chuyển tin nhắn thành mảng byte
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }
        private void StopListen_Click(object sender, EventArgs e)
        {
            bt_Listen.Text = "Listen";

            isServerRunning = false;
            //Dừng máy chủ
            server.Stop();
            //Xoá danh sách các Clients đang kết nối
            if (connectedClients.Count > 0)
            {
                lock (connectedClients)
                {
                    List<TcpClient> clientsCopy = new List<TcpClient>(connectedClients);
                    // Duyệt qua danh sách các client và ngắt kết nối với mỗi client
                    foreach (TcpClient client in connectedClients)
                    {
                        client.Close();
                    }
                }
            }
            connectedClients.Clear();
            Log("Server stopped\n");
        }
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị cảnh báo yes/no
            DialogResult result = MessageBox.Show("Are you sure you want to close the server?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                if (isServerRunning)
                {
                    MessageBox.Show("Please stop listening before closing the server!");
                    e.Cancel = true;
                }
            }
            else
            {
                // Hủy đóng form
                e.Cancel = true;
            }
        }
    }
}
