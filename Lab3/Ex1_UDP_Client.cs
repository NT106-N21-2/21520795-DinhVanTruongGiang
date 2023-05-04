using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab3
{
    public partial class Ex1_UDP_Client : Form
    {
        public Ex1_UDP_Client()
        {
            InitializeComponent();
            textBox1.Text = "127.0.0.1";
        }

        private void Ex1_UDP_Client_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check ip address
            IPAddress ip;
            string IPadd = textBox1.Text;
            if (!IPAddress.TryParse(IPadd, out ip))
            {
                MessageBox.Show("Wrong IP address!");
                return;
            }
            //Check port number
            int port;
            if(!int.TryParse(textBox2.Text,out port))
            {
                MessageBox.Show("Please enter Port number!");
                return;
            }
            //check message
            if (string.IsNullOrEmpty(textBox1.Text)) { MessageBox.Show("Please enter a message!"); return; }
            UdpClient udpClient = new UdpClient();
            //send message
            byte[] msg = System.Text.Encoding.UTF8.GetBytes(textBox3.Text);
            udpClient.Send(msg, msg.Length, IPadd, int.Parse(textBox2.Text));
        }
    }
}