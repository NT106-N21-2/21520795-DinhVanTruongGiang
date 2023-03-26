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
            try
            {
                string inputstring = textBox1.Text.Trim();
                if (inputstring.Length == 1 && inputstring[0] == '-') { }
                    else
                    {
                        int num = int.Parse(inputstring);
                    }
            }
            catch
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                return;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = int.Parse(textBox1.Text.Trim());
            num2 = int.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string inputstring = textBox2.Text.Trim();
                if (inputstring.Length == 1 && inputstring[0] == '-') { }
                else
                {
                    int num = int.Parse(inputstring);
                }
            }
            catch
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                return;
            }
        }
    }
}
