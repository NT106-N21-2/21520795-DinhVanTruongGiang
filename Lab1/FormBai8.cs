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
    public partial class FormBai8 : Form
    {
        public FormBai8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xóa thông tin cũ
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            //Kiểm tra chuỗi vừa nhập
            if (textBox3.Text.IndexOf(",") == -1)
            {
                MessageBox.Show("Hãy nhập đúng định dạng!");
                return;
            }
            int nofsubjects = 0;
            double[] subjects = { };
            string[] ds = textBox3.Text.Split(',');
            //Kiếm tra chuỗi ds[0]
            foreach (char c in ds[0])
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Nhập sai họ tên!");
                    return;
                }
            //Kiểm tra danh sách điểm
            for (nofsubjects = 1; nofsubjects < ds.Length; nofsubjects++)
            {
                double i;
                if (!double.TryParse(ds[nofsubjects].Trim(), out i))
                {
                    MessageBox.Show("Nhập sai điểm!");
                    return;
                }
                if (i < 0 || i > 10)
                {
                    MessageBox.Show("Nhập sai điểm!");
                    return;
                }
                //thêm điểm vào mảng
                Array.Resize(ref subjects, nofsubjects);
                subjects[nofsubjects - 1] = i;
            }
            nofsubjects--;
            //Thông báo thành công
            MessageBox.Show("Nhập thành công!");

            //In họ tên
            textBox2.AppendText("Họ tên: " + ds[0] + Environment.NewLine + Environment.NewLine);
            //In điểm
            for (int i = 0; i < nofsubjects; i++)
            {
                textBox2.AppendText("Môn " + (i + 1).ToString() + ": " + subjects[i].ToString());
                //Tạo danh sách điểm gồm 4 cột
                if ((i + 1) % 4 == 0)
                    textBox2.AppendText(Environment.NewLine);
                else
                    textBox2.AppendText("\t\t");
            }
            //tính điểm cao nhất, thấp nhất, DTB, số môn đậu
            int min = 0, max = 0, pass = 0;
            double TB = 0;
            for (int i = 0; i < nofsubjects; i++)
            {
                TB += subjects[i];
                if (subjects[i] < subjects[min]) min = i;
                if (subjects[i] > subjects[max]) max = i;
                if (subjects[i] >= 5) pass++;
            }
            TB /= nofsubjects;
            //In thông tin trên
            textBox4.Text = "Môn " + max.ToString() + ": " + subjects[max].ToString();
            textBox5.Text = "Môn " + min.ToString() + ": " + subjects[min].ToString();
            textBox6.Text = pass.ToString(); textBox7.Text = (nofsubjects - pass).ToString();
            textBox8.Text = Math.Round(TB, 2).ToString();
            //Tính xếp loại
            if (TB > 8 && subjects[min] >= 6.5) textBox1.Text = "Giỏi";
            else
                if (TB >= 6.5 && subjects[min] >= 5) textBox1.Text = "Khá";
            else
                if (TB >= 5 && subjects[min] >= 3.5) textBox1.Text = "TB";
            else
                if (TB >= 3.5 && subjects[min] >= 2) textBox1.Text = "Yếu";
            else textBox1.Text = "Kém";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
