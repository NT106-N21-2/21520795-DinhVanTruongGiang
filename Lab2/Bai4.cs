using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


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
        public string GetInfo()
        {
            string line = this.Name + "\r\n" + this.Id + "\r\n" + this.PhoneNum 
                + "\r\n" + this.c1 + "\r\n" + this.c2 + "\r\n" + this.c3 + "\r\n" + this.Avg + "\r\n\r\n";
            return line;
        }
        public void AvgCal()
        {
            this.Avg = (this.c1 + this.c2 + this.c3) / 3;
        }
    }
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        static Student[] dssv = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Please Enter Information!");
                    return;
                }
                FileStream fs = new FileStream("input4.txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                List<Student> list = new List<Student>();
                int i = 0;
                string[] studentInfo = textBox1.Text.Split("\r\n\r\n");
                foreach (string s in studentInfo)
                {
                    if (s != "")
                    {
                        string[] studentprop = s.Split("\r\n");
                        Student student = new Student(studentprop);
                        list.Add(student);
                        i++;
                    }
                }
                dssv = new Student[list.Count];
                dssv = list.ToArray();
                bf.Serialize(fs, dssv);
                fs.Close();
                MessageBox.Show("Write successfully!");
                textBox1.Text = string.Empty;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBox16.Text) - 1;
            ShowInfo(dssv[index - 1]);
            textBox16.Text = index.ToString();
            if (index == 1) button3.Enabled = false;
            button4.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBox16.Text) - 1;
            ShowInfo(dssv[index + 1]);
            textBox16.Text = (index + 2).ToString();
            if (index+2>=dssv.Length) button4.Enabled = false;
            button3.Enabled = true;
        }
        public void ShowInfo(Student s)
        {
            textBox9.Text = s.Name;
            textBox10.Text = s.Id.ToString();
            textBox11.Text = s.PhoneNum;
            textBox12.Text = s.c1.ToString();
            textBox13.Text = s.c2.ToString();
            textBox14.Text = s.c3.ToString();
            textBox15.Text = s.Avg.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream inputfs = new FileStream("input4.txt", FileMode.Open, FileAccess.Read);
                FileStream outputfs = new FileStream("output4.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                StreamWriter sw = new StreamWriter(outputfs);
                dssv = (Student[])bf.Deserialize(inputfs);
                //Xuat DSSV
                textBox1.Text = string.Empty;
                for (int i = 0; i < dssv.Length; i++)
                {
                    if (dssv[i] != null)
                    {
                        dssv[i].AvgCal();
                        string s = dssv[i].GetInfo();
                        textBox1.AppendText(s);
                        sw.Write(s);
                    }
                }
                sw.Close();
                inputfs.Close();
                outputfs.Close();

                //thong tin chi tiet tung sinh vien
                ShowInfo(dssv[0]);
                textBox16.Text = "1";
                button3.Enabled = false;
                if (dssv[int.Parse(textBox16.Text)] == null) { button4.Enabled = false; }
                else { button4.Enabled = true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open \"input4.txt\"!");
                return;
            }
        }
        
    }
}
