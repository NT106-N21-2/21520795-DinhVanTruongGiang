using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Ex3_Client : Form
    {
        //các biến dùng để kết nối mạng và quản lý các luồng đọc/ghi message
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isConnectedToServer = false;
        private string userName;
        //private string attachmentFilePath = null;
        //private ConcurrentDictionary<string, byte[]> files = new ConcurrentDictionary<string, byte[]>();
        private bool isLogin;
        private bool allIsDisposed;
        private string serPubKey;
        public Ex3_Client()
        {
            InitializeComponent();
        }
        private void CreateNewKeys()
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
            //how to get the private key
            RSAParameters privKey = csp.ExportParameters(true);
            string privKeyString;
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
                tb_publicKey.Text = pubKeyString;
            }
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, privKey);
                //get the string from the stream
                privKeyString = sw.ToString();
                tb_privateKey.Text = privKeyString;
            }
        }
        public string Encryption(string strText)
        {
            //Import Key from Server
            string publicKey = serPubKey;
            var textData = Encoding.UTF8.GetBytes(strText);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // client encrypting data with public key issued by server                    
                    rsa.FromXmlString(serPubKey.ToString());
                    var encryptedData = rsa.Encrypt(textData, true);
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

            var privateKey = tb_privateKey.Text;
            var testData = Encoding.UTF8.GetBytes(strText);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = strText;
                    rsa.FromXmlString(privateKey);
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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (bt_Connect.Text == "Connect")
            {
                //Kiểm tra địa chỉ IP
                IPAddress ip;
                string IPadd = serIP.Text.Trim();
                if (!IPAddress.TryParse(IPadd, out ip))
                {
                    MessageBox.Show("Wrong IP address!");
                    return;
                }
                if (!string.IsNullOrEmpty(tb_userName.Text))
                {
                    try
                    {
                        //Tạo kết nối tới server
                        client = new TcpClient(IPadd, 8080);
                        //dùng để ghi và đọc dữ liệu từ kết nối
                        stream = client.GetStream();
                        //Tạo luồng
                        //Sử dụng ReceiveMessage để có thể đọc message được gửi từ server và hiển thị
                        receiveThread = new Thread(ReceiveMessages);
                        //Thực thi luồng
                        receiveThread.Start();
                        // Thiết lập trạng thái kết nối
                        isConnectedToServer = true;
                        // lấy tên người dùng ra và gửi tới Server
                        userName = tb_userName.Text;
                        tb_userName.Font = new Font(tb_userName.Font, FontStyle.Bold);
                        // Gửi tên người dùng tới server
                        SendMessage($"{userName}");
                        CreateNewKeys();
                        SendMessage(tb_publicKey.Text);

                        serIP.ReadOnly = true;
                        tb_userName.ReadOnly = true;
                        bt_Connect.Text = "Disconnect";
                    }
                    catch (Exception ex)
                    {
                        AppendMessage("[ERROR] " + ex.Message);
                        // Đưa ra thông báo không tìm thấy máy chủ trên RichTextBox
                        AppendMessage("SERVER NOT FOUND");
                        isConnectedToServer = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a username.");
                }
                isLogin = true;
            }
            else btn_Logout_Click(sender, e);
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            isConnectedToServer = false;
            isLogin = false;
            serIP.ReadOnly = false;
            tb_userName.ReadOnly=false;
            Task.Run(() =>
            {
                SendMessage($"{tb_userName.Text} is disconected");
                /*if (stream != null && stream.CanRead)
                {
                    ReadMessage(stream);
                }*/
                /*if (client != null && client.Connected)
                {
                    client.Close();
                }*/
                if (stream != null)
                {
                    stream.Close();
                }
            });
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msgTB.Text)) // Kiểm tra nội dung tin nhắn có rỗng hay không
            {
                MessageBox.Show("Please enter a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            userName = tb_userName.Text;
            tb_userName.Font = new Font(tb_userName.Font, FontStyle.Bold);

            string message = Encryption(userName + ": " + msgTB.Text);
            if (msgTB.Text != "" && msgTB.Enabled)
            {
                SendMessage($"{message}");
            }
            ////hiển thị khung chat
            //AppendMessage(userName + ": " + msgTB.Text);
            ////hiển thị tin nhắn vừa mã hóa
            //latestMsg_Update(message);
            //Xoá sau khi gửi
            msgTB.Clear();
        }
        private void SendMessage(string message)
        {
            if (client != null && client.Connected)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }
        private void ReceiveMessages()
        {
            if (!isConnectedToServer)
            {
                // Đưa ra thông báo không tìm thấy máy chủ trên RichTextBox
                AppendMessage("SERVER NOT FOUND");
                return;
            }
            //lặp với điều kiện có kết nối tới Server rồi
            while (client.Connected)
            {
                string receivedData = ReadMessage(stream);
                if (receivedData != null)
                {
                    if (receivedData.Contains("<?xml")) serPubKey = receivedData;
                    else
                    {
                        latestMsg_Update(receivedData);
                        AppendMessage(Decryption(receivedData));
                    }
                }
            }
        }
        private string ReadMessage(NetworkStream stream)
        {
            if (!stream.CanRead || !client.Connected)
            {
                return null;
            }

            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            try
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
            }
            catch (IOException)
            {
                // Xử lý ngoại lệ IOException khi kết nối bị đóng
                return null;
            }

            if (bytesRead > 0)
            {
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            else
            {
                return null;
            }
        }
        private void latestMsg_Update(string message)
        {
            if (!allIsDisposed)
            {
                //check coi đúng luồng không, nếu ở luồng khác, sử dụng Invoke để gọi lại AppendMessage trên luồng chính
                if (encryptedMessage.InvokeRequired)
                {
                    encryptedMessage.Invoke(new Action<string>(latestMsg_Update), message);
                }
                else
                {
                    encryptedMessage.AppendText(message + "\n");
                }
            }
        }
        private void AppendMessage(string message)
        {
            if (!allIsDisposed)
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
                        Font boldFont = new Font(rtb_Client.Font, FontStyle.Bold);
                        rtb_Client.SelectionFont = boldFont;
                        rtb_Client.AppendText(messageParts[0]);

                        Font ItalicFont = new Font(rtb_Client.Font, FontStyle.Italic);
                        rtb_Client.SelectionFont = ItalicFont;
                        rtb_Client.AppendText($": ({DateTime.Now})");

                        rtb_Client.SelectionFont = rtb_Client.Font; // Đặt lại font gốc
                        rtb_Client.AppendText(": " + messageParts[1] + "\n");
                    }

                    else
                    {
                        rtb_Client.AppendText(message + "\n");
                    }
                }
            }
        }
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin)
            {
                MessageBox.Show("Please log out before closing the form!");
                e.Cancel = true;
            }
            else
            {
                if (client != null && client.Connected)
                {
                    client.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            allIsDisposed = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
