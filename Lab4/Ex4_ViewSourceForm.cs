using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Ex4_ViewSourceForm : Form
    {
        public Ex4_ViewSourceForm(string html)
        {
            InitializeComponent();
            textBox1.Text = html;
        }

    }
}
