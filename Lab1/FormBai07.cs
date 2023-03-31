using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormBai07 : Form
    {        
        public FormBai07()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int SoSubnet;
            if (!int.TryParse(textBox3.Text, out SoSubnet))
            {
                MessageBox.Show("Mời bạn nhập số!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                byte Prefix = 0;
                string[] input = textBox1.Text.Split('/');
                IPAddress ipAddress;

                if (!IPAddress.TryParse(input[0], out ipAddress))
                {
                    MessageBox.Show("Địa chỉ IP không hợp lệ");
                    return;
                }
                if (!byte.TryParse(input[1], out Prefix)||Prefix > 30 || Prefix < 0)
                {
                    MessageBox.Show("Số prefix không hợp lệ");
                    return;
                }
                textBox2.Text = Math.Pow(2, 30 - Prefix).ToString();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            //if (textBox3.Text == string.Empty)
            //{
            //    MessageBox.Show("Mời nhập địa chỉ IP!");
            //    return;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Số subnet
            int SoSubnet = int.Parse(textBox3.Text);
            //Tạo mảng IPaddress
            string[] input = textBox1.Text.Split('/');
            string[] ip = input[0].Split('.');
            int k = 0;
            int[] IPAdd = new int[4];
            foreach (string s in ip)
            {
                IPAdd[k++] = int.Parse(s);
            }
            //Tạo số prefix
            byte Prefix = byte.Parse(input[1]);
            //Tạo bảng
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Địa chỉ mạng", typeof(string));
            table.Columns.Add("Địa chỉ đầu", typeof(string));
            table.Columns.Add("Địa chỉ cuối", typeof(string));
            table.Columns.Add("Địa chỉ broadcast", typeof(string));
            //tính số bit mượn
            byte SoBitMuon = 0;
            for (SoBitMuon = 0; Math.Pow(2, SoBitMuon) < SoSubnet; SoBitMuon++) ;

            //Buoc nhay tren mot octect = 2^(8-so bit muon tren octect đó)
            int[] BuocNhay = { 0, 0, 0, 0 };
            BuocNhay[(int)((Prefix + SoBitMuon) / 8)] += (int)(Math.Pow(2, 8 - (Prefix + SoBitMuon) % 8));
            for (int i = (int)((Prefix + SoBitMuon) / 8) + 1; i < 4; i++) BuocNhay[i] = 256;
            string net = "";
            string firstIP = "";
            string lastIP = "";
            string broadcast = "";
            for (int i = 1; i <= Math.Pow(2, SoBitMuon); i++)
            {
                //Tính các giá trị
                net = IPAdd[0].ToString() + '.' + IPAdd[1].ToString() + '.' + IPAdd[2].ToString() + '.' + IPAdd[3].ToString() + '/' + (SoBitMuon + Prefix).ToString();
                firstIP = IPAdd[0].ToString() + '.' + IPAdd[1].ToString() + '.' + IPAdd[2].ToString() + '.' + (IPAdd[3] + 1).ToString();
                IPAdd[3] += BuocNhay[3] - 2;
                IPAdd[2] += (int)((Prefix + SoBitMuon) / 8) <= 2 ? BuocNhay[2] - 1 : 0;
                IPAdd[1] += (int)((Prefix + SoBitMuon) / 8) <= 1 ? BuocNhay[1] - 1 : 0;
                IPAdd[0] += (int)((Prefix + SoBitMuon) / 8) <= 0 ? BuocNhay[0] - 1 : 0;
                lastIP = IPAdd[0].ToString() + '.' + IPAdd[1].ToString() + '.' + IPAdd[2].ToString() + '.' + IPAdd[3].ToString();
                broadcast = IPAdd[0].ToString() + '.' + IPAdd[1].ToString() + '.' + IPAdd[2].ToString() + '.' + (IPAdd[3] + 1).ToString();
                //add giá trị vào table
                table.Rows.Add(i, net, firstIP, lastIP, broadcast);

                //Cập nhật giá trị
                int flag = (int)((IPAdd[3] + 2) / 256);
                IPAdd[3] = (IPAdd[3] + 2) % 256;
                
                IPAdd[2] += flag;//(int)((Prefix + SoBitMuon) / 8) <= 2 ? 1 : 0;
                flag = (int)(IPAdd[2] / 256);
                IPAdd[2] = IPAdd[2] % 256;
                
                IPAdd[1] += flag;// (int)((Prefix + SoBitMuon) / 8) <= 1 ? 1 : 0;
                flag = (int)(IPAdd[1] / 256);
                IPAdd[1] = IPAdd[1] % 256;
                
                IPAdd[0] += flag; //(int)((Prefix + SoBitMuon) / 8) <= 0 ? 1 : 0;
                IPAdd[0] = IPAdd[0] % 256;
            }
            dataGridView1.DataSource = table;
        }
    }
}
