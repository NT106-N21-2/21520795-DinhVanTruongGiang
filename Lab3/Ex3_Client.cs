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
    public partial class Ex3_Client : Form
    {
        private TcpClient client;
        public Ex3_Client()
        {
            InitializeComponent();
            btn_Disconnect.Enabled = false;
        }
        private bool IsServerRunning()
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient("127.0.0.1", 8080)) { }
                return true;
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    return false;
                }
                throw;
            }
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //check coi có mở server chưa
            if (!IsServerRunning())
            {
                MessageBox.Show("Server is not running!\nPlease start the server first.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btn_Disconnect.Enabled = true;
            string ipAddress = "127.0.0.1";
            int port = 8080;

            // Tạo TCP client mới và connect với server
            client = new TcpClient(ipAddress, port);
            //MessageBox.Show("Connected to server: " + ipAddress + ":" + port);
            rtb_Input.AppendText("\t\t\t\tConnected to server...\nEnter the message to send to the server:\n");
            //thể hiện kết nối thành công tới server
            string username = "This is Lab03";
            StreamWriter writer = new StreamWriter(client.GetStream());
            writer.WriteLine(username);
            writer.Flush();
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            // check kết nối giữa client với server
            if (client == null || !client.Connected)
            {
                MessageBox.Show("Not connected to server yet.", "Sending Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtb_Input.Clear();
                return;
            }
            // lấy thông điệp vừa nhập vô từ rtb_Input xong gửi tới server
            //Lấy dòng mới nhập vào
            string[] lines = rtb_Input.Lines;
            string message = lines[lines.Length - 1];
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            client.GetStream().Write(buffer, 0, buffer.Length);

            DisplayMessage("\nSent message: " + message);
            rtb_Input.AppendText("Enter the message to send to the server: ");
            rtb_Input.SelectionStart = rtb_Input.TextLength;
            rtb_Input.ScrollToCaret();
        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            // Đóng kết nối
            if (client != null)
            {
                client.Close();
                client = null;
            }
            DisplayMessage("\n\t\t\t\tDisconnected from server...");
            btn_Disconnect.Enabled = false;
        }
        private void DisplayMessage(string message)
        {
            if (rtb_Input.InvokeRequired)
            {
                rtb_Input.Invoke(new Action<string>(DisplayMessage), new object[] { message });
            }
            else
            {
                rtb_Input.AppendText(message + Environment.NewLine);
            }
        }
        private void rtb_Input_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.IsInputKey = true;
                btn_Send_Click(sender, e);
            }
        }

        private void rtb_Input_MouseDown(object sender, MouseEventArgs e)
        {
            MoveCaretToEnd();
        }

        private void rtb_Input_MouseUp(object sender, MouseEventArgs e)
        {
            MoveCaretToEnd();
        }

        private void rtb_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                MoveCaretToEnd();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void MoveCaretToEnd()
        {
            rtb_Input.SelectionStart = rtb_Input.TextLength;
            rtb_Input.ScrollToCaret();
        }

        private void Ex3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
