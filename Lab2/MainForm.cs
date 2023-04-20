using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 nf = new Bai1();
            nf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 nf = new Bai2();
            nf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 nf = new Bai3();
            nf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 nf = new Bai4();
            nf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 nf = new Bai5();
            nf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai6 nf = new Bai6();
            nf.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
