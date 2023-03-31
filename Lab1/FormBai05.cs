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
    public partial class FormBai05 : Form
    {
        public FormBai05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty || textBox4.Text == string.Empty) 
            {
                MessageBox.Show("Yêu cầu chọn loại xe!");
                return;
            }
            double dungtich = double.Parse(textBox2.Text);
            double tigia = double.Parse(textBox4.Text);
            int thanhtien = (int)Math.Round(dungtich * tigia);
            textBox3.Text = thanhtien.ToString();
            double quangduong = Math.Round(dungtich / double.Parse(textBox5.Text) * 100, 2);
            textBox1.Text = quangduong.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strings1 = { "RON 95-III", "RON 92-II" };
            string[] strings2 = { "RON 95-III" };
            string[] strings3 = { "DO 005S-II" };
            double[] DungTich = { 3.7, 3.8, 5.2, 6, 4.5, 4.4, 70 };
            double[] HaoPhiNhienLieu = { 1.6, 1.99, 1.87, 2.02, 1.7, 2.17, 13 };
            textBox2.Text = DungTich[comboBox1.SelectedIndex].ToString();
            textBox5.Text = HaoPhiNhienLieu[comboBox1.SelectedIndex].ToString();
            comboBox2.Items.Clear();
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                    comboBox2.Items.AddRange(strings1);
                    break;
                case 3:
                case 4:
                case 5:
                    comboBox2.Items.AddRange(strings2);
                    break;
                case 6:
                    comboBox2.Items.AddRange(strings3);
                    break;
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            string st = comboBox2.SelectedItem.ToString();
            if (st == "RON 95-III") textBox4.Text = "26,830";
            if (st == "RON 92-II") textBox4.Text = "26,070";
            if (st == "DO 005S-II") textBox4.Text = "21,310";
        }
    }
}
