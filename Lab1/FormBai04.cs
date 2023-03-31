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
    public partial class FormBai04 : Form
    {
        public FormBai04()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    if (textBox1.Text.Length > 12) MessageBox.Show("Chỉ nhập số có tối đa 12 chữ số!");
                    else
                    {
                        long num = long.Parse(textBox1.Text.Trim());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai yêu cầu!");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void FormBai04_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Yêu cầu nhập số nguyên!");
                return;
            }
            long num = long.Parse(textBox1.Text.Trim());
            if (num == 0)
            {
                textBox2.Text = "Không";
                return;
            }
            string[] DonVi = { "", "nghìn ", "triệu ", "tỷ " };
            string[] HangDonVi = { "", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín " };
            byte i = 0;
            string KetQua = "", GroupText;
            while (num > 0)
            {
                GroupText = "";
                int group = (int)(num % 1000);
                num /= 1000;
                int tram = group / 100;
                int chuc = (group % 100) / 10;
                int donvi = group % 10;
                if (tram == 0)
                {
                    if (num > 0 && (chuc > 0 || donvi > 0)) GroupText = "không trăm ";
                }
                else
                    GroupText = HangDonVi[tram] + "trăm ";

                if (chuc == 0)
                {
                    if (num > 0 && donvi > 0) GroupText = GroupText + "lẻ ";
                    if (num == 0 && tram > 0 && donvi > 0) GroupText = GroupText + "lẻ ";
                    GroupText += HangDonVi[donvi];
                }
                else
                    if (chuc == 1)
                    if (donvi == 5) GroupText += "mười lăm";
                    else GroupText += " mười " + HangDonVi[donvi];
                else
                {
                    GroupText += HangDonVi[chuc] + "mươi ";
                    if (donvi == 1) GroupText += "mốt";
                    else
                        if (donvi == 5) GroupText += "lăm";
                    else GroupText += HangDonVi[donvi];
                }
                if (GroupText != "") KetQua = GroupText + DonVi[i] + KetQua;
                i++;
            }
            textBox2.Text = KetQua;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
