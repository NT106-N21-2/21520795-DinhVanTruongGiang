using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Ex3_Dashboard : Form
    {
        public Ex3_Dashboard()
        {
            InitializeComponent();
            TCPClient.Enabled = false;
        }
        private void TCPServer_Click(object sender, EventArgs e)
        {
            Ex3_Server ex3_Server = new Ex3_Server();
            TCPClient.Enabled = true;
            ex3_Server.Show();
        }

        private void TCPClient_Click(object sender, EventArgs e)
        {
            Ex3_Client ex3_Client = new Ex3_Client();
            ex3_Client.Show();
        }
        private void Ex3_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
