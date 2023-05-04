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

        private void button1_Click(object sender, EventArgs e)
        {
            Ex1_DashBoard ex1_DashBoard = new Ex1_DashBoard();
            ex1_DashBoard.ShowDialog();
        }
    }
}
