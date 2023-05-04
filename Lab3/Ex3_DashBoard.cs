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
    public partial class Ex3_DashBoard : Form
    {
        public Ex3_DashBoard()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            Ex3_Server server = new Ex3_Server();
            server.Show();
            btn_Server.Enabled = false;
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Ex3_Client client = new Ex3_Client();
            client.Show();
            btn_Client.Enabled = false;
        }
    }
}
