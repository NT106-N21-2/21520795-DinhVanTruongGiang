using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    [Serializable]
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public float c1 { get; set; }
        public float c2 { get; set; }
        public float c3 { get; set; }
        public float Avg { get; set; }

        public Student(string[] info)
        {
            Id = long.Parse(info[1]);
            Name = info[0];
            PhoneNum = info[2];
            c1 = float.Parse(info[3]);
            c2 = float.Parse(info[4]);
            c3 = float.Parse(info[5]);
            Avg = float.Parse(info[6]);
        }
    }
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input4.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            Student[] list = new Student[50];
            int i = 0;
            string[] studentInfo = textBox1.Text.Split("\r\n\r\n");
            foreach(string s  in studentInfo)
            {
                if (s != "")
                {
                    string[] studentprop = s.Split("\r\n");
                    list[i] = new Student(studentprop);
                    i++;
                }
            }
            bf.Serialize(fs, list);
            fs.Close();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            //Tên
            foreach (char c in textBox2.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Wrong Name Format!");
                    return;
                }
            }
            //ID
            long i;
            if (!long.TryParse(textBox3.Text, out i))
            {
                MessageBox.Show("Wrong ID!");
                return;
            }
            if (i < 9999999 || i > 99999999)
            {
                MessageBox.Show("Wrong ID");
                return;
            }
            //SDT
            if (textBox4.Text.Length != 10) { MessageBox.Show("Wrong Phone Number Format!"); return; }
            if (textBox4.Text[0] != '0') { MessageBox.Show("Wrong Phone Number Format!"); return; }
            foreach (char c in textBox4.Text)
                if (!char.IsDigit(c)) { MessageBox.Show("Wrong Phone Number Format!"); return; }
            //Diem 3 mon
            float n1, n2, n3;
            if (!float.TryParse(textBox5.Text, out n1) || !float.TryParse(textBox6.Text, out n2) || !float.TryParse(textBox7.Text, out n3))
            {
                MessageBox.Show("Wrong Score Format!");
                return;
            }
            if (n1 < 0 || n2 < 0 || n3 < 0 || n1 > 10 || n2 > 10 || n3 > 10)
            {
                MessageBox.Show("Wrong Score Format!");
                return;
            }
            //Hiển thị
            textBox1.AppendText(textBox2.Text + "\r\n");
            textBox1.AppendText(textBox3.Text + "\r\n");
            textBox1.AppendText(textBox4.Text + "\r\n");
            textBox1.AppendText(textBox5.Text + "\r\n");
            textBox1.AppendText(textBox6.Text + "\r\n");
            textBox1.AppendText(textBox7.Text + "\r\n");
            textBox1.AppendText(textBox8.Text + "\r\n\r\n");
            //textBox1.Text = string.Empty;
            //textBox2.Text = string.Empty;
            //textBox3.Text = string.Empty;
            //textBox4.Text = string.Empty;
            //textBox5.Text = string.Empty;
            //textBox6.Text = string.Empty;
            //textBox7.Text = string.Empty;
            //textBox8.Text = string.Empty;
        }
    }
}
