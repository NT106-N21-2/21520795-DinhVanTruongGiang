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
    public partial class Ex5_DashBoard : Form
    {
        public Ex5_DashBoard()
        {
            InitializeComponent();
        }

        private void TCPServer_Click(object sender, EventArgs e)
        {
            Ex5_Server ex5_Server = new Ex5_Server();
            ex5_Server.ShowDialog();
        }
    }
}
