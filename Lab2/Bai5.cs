using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter data!");
                return;
            }
            //luu trữ dữ liệu trên file tạm
            try
            {
                string data = textBox1.Text;
                File.WriteAllText("input5.txt", data);
                //nén thành file zip
                using (FileStream fs = new FileStream("input5.zip", FileMode.OpenOrCreate))
                {
                    using (ZipArchive zip = new ZipArchive(fs, ZipArchiveMode.Create))
                    {
                        ZipArchiveEntry entry = zip.CreateEntry("input5.txt");
                        using (StreamWriter sw = new StreamWriter(entry.Open()))
                        {
                            sw.Write(data);
                        }
                    }
                }
                //Xóa file tạm
                File.Delete("input5.txt");
                //hiển thị đường dẫn
                FileInfo fi = new FileInfo("input5.zip");
                textBox3.Text = fi.DirectoryName + "\\input5.zip";
                MessageBox.Show("Archive successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archive unsuccessfully!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Giải nén và lưu
                using (FileStream fs = new FileStream("input5.zip", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (ZipArchive zip = new ZipArchive(fs, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry entry = zip.GetEntry("input5.txt");
                        using (StreamReader sr = new StreamReader(entry.Open()))
                        {
                            string data = sr.ReadToEnd();
                            File.WriteAllText("output5.txt", data);
                        }
                    }
                }
                //hiển thị đường dẫn
                FileInfo fi = new FileInfo("output5.txt");
                textBox4.Text = fi.DirectoryName + "\\output5.txt";
                MessageBox.Show("Extract successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Extract unsuccessfully!");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ouputdata = File.ReadAllText("output5.txt");
            textBox2.Text = ouputdata;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
