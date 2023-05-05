using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Ex4_DashBoard : Form
    {
        public Ex4_DashBoard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex4_TCP_BackupServer ex4_TCP_BackupServer = new Ex4_TCP_BackupServer();
            ex4_TCP_BackupServer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ex4_TCP_Server ex4_TCP_Server = new Ex4_TCP_Server();
            ex4_TCP_Server.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex4_TCP_Client ex4_TCP_Client = new Ex4_TCP_Client();
            ex4_TCP_Client.Show();
        }
    }
}
