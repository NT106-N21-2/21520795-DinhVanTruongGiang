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
            Ex1_DashBoard ex1_DashBoard = new Ex1_DashBoard();
            ex1_DashBoard.ShowDialog();
        }

        private void btn_Ex2_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.ShowDialog();
        }

        private void btn_Ex3_Click(object sender, EventArgs e)
        {
            Ex3_DashBoard ex3 = new Ex3_DashBoard();
            ex3.Show();
        }

        private void btn_Ex5_Click(object sender, EventArgs e)
        {
            Ex5_DashBoard ex5_DashBoard = new Ex5_DashBoard();
            ex5_DashBoard.ShowDialog();
        }
    }
}
