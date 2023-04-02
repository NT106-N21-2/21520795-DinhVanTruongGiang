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
    public partial class FormBai01 : Form
    {
        public FormBai01()
        {
            InitializeComponent();
        }

        private void FormBai01_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Kiểm tra textbox
            string inputstring = textBox1.Text.Trim();
            if (inputstring == "-" || inputstring.Length == 0) return;
            int num;
            if (!int.TryParse(inputstring, out num))
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                textBox1.Text = string.Empty;
                return;
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Kiểm tra input
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                return;
            }
            int num1, num2;
            long sum = 0;
            num1 = int.Parse(textBox1.Text.Trim());
            num2 = int.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Kiểm tra textbox
            string inputstring = textBox2.Text.Trim();
            if (inputstring == "-" || inputstring.Length == 0) return;
            int num;
            if (!int.TryParse(inputstring, out num))
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                textBox1.Text = string.Empty;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty;
            textBox2.Text= string.Empty;
            textBox3.Text= string.Empty;
        }
    }
}
