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
    public partial class FormBai02 : Form
    {
        public FormBai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            num1 = float.Parse(textBox1.Text.Trim());
            num2 = float.Parse(textBox2.Text.Trim());
            num3 = float.Parse(textBox3.Text.Trim());
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    textBox4.Text = num1.ToString();
                    if (num2 < num3) textBox5.Text = num3.ToString();
                    else textBox5.Text = num2.ToString();
                }
                else
                {
                    textBox4.Text = num3.ToString();
                    textBox5.Text = num2.ToString();
                }
            }
            else
            {
                if (num2 < num3)
                {
                    textBox4.Text = num2.ToString();
                    if (num1 < num3) textBox5.Text = num3.ToString();
                    else textBox5.Text = num1.ToString();
                }
                else
                {
                    textBox4.Text = num3.ToString();
                    textBox5.Text = num1.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
