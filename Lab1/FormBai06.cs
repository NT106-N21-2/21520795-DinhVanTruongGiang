using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormBai06 : Form
    {
        public FormBai06()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Length > 0)
                {
                    int num = int.Parse(textBox2.Text.Trim());
                    if (num < 0 || num > 9)
                    {
                        MessageBox.Show("Chỉ nhập số từ 0 - 9!");
                        textBox2.Text = string.Empty;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai yêu cầu!");
                textBox2.Text = string.Empty;
                return;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    int num = int.Parse(textBox1.Text.Trim());
                    if (num < 0 || num > 9)
                    {
                        MessageBox.Show("Chỉ nhập số từ 0 - 9!");
                        textBox1.Text = string.Empty;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai yêu cầu!");
                textBox1.Text = string.Empty;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty; textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox2.Text.Trim());
            int B = int.Parse(textBox1.Text.Trim());
            long AGiaithua = 1, BGiaithua = 1, ALuyThua = 1, S3 = 0;
            int S1 = 0, S2 = 0; 
            for(int i = 1; i <= A; i++)
            {
                AGiaithua *= i;
                S1 += i;
            }
            for(int i = 1;i <= B; i++)
            {
                BGiaithua *= i;
                S2 += i;     
                ALuyThua *= A;
                S3 += ALuyThua;
            }
            //Xuat
            textBox3.AppendText(Environment.NewLine + "A! = " + AGiaithua.ToString() + "\t" +  "B! = " + BGiaithua.ToString() + Environment.NewLine);
            textBox3.AppendText("S1 = 1 + 2 + 3 + ... + A = " + S1.ToString() + Environment.NewLine);
            textBox3.AppendText("S2 = 1 + 2 + 3 + ... + B = " + S2.ToString() + Environment.NewLine);
            textBox3.AppendText("S3 = A^1 + A^2 + A^3 + ... + A^B = " + S3.ToString() + Environment.NewLine);
        }
    }
}
