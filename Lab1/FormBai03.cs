using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormBai03 : Form
    {
        public FormBai03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    int num = int.Parse(textBox1.Text.Trim());
                    if (num < 0 || num > 9) MessageBox.Show("Nhập sai yêu cầu!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai yêu cầu!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==string.Empty)
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                return;
            }
            int num = int.Parse(textBox1.Text.Trim());
            string s = string.Empty;
            switch (num)
            {
                case 0:
                    s = "Không";
                    break;
                case 1:
                    s = "Một";
                    break;
                case 2:
                    s = "Hai";
                    break;
                case 3:
                    s = "Ba";
                    break;
                case 4:
                    s = "Bốn";
                    break;
                case 5:
                    s = "Năm";
                    break;
                case 6:
                    s = "Sáu";
                    break;
                case 7:
                    s = "Bảy";
                    break;
                case 8:
                    s = "Tám";
                    break;
                case 9:
                    s = "Chín";
                    break;
            }
            textBox2.Text = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
