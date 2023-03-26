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
    public partial class FormBai03 : Form
    {
        public FormBai03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                int num = int.Parse(textBox1.Text.Trim());
                if (num < 0 || num > 9) MessageBox.Show("Nhập sai yêu cầu!");
        }
    }
}
