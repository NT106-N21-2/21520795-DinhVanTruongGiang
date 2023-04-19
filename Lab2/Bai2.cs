using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mở hộp thoại để chọn File
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(ofd.FileName);
                textBox2.Text = fi.Name;
                textBox4.Text = fi.Length.ToString();
                textBox3.Text = fi.Directory.ToString() + "\\" + fi.Name;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string s;
                int line = 0, word = 0, ch = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    textBox1.AppendText(s + "\r\n");
                    line++;
                    word += s.Split(' ').Length;
                    ch += s.Length;
                }
                textBox5.Text = line.ToString();
                textBox6.Text = word.ToString();
                textBox7.Text = ch.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
