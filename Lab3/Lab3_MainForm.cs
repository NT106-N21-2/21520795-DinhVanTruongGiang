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
    public partial class Lab3_MainForm : Form
    {
        public Lab3_MainForm()
        {
            InitializeComponent();
        }
        private void btn_Ex1_Click(object sender, EventArgs e)
        {
            Ex1_DashBoard nf = new Ex1_DashBoard();
            nf.ShowDialog();
        }

        private void btn_Ex2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ex3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ex4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ex5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
