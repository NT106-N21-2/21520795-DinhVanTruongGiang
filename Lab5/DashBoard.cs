using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btn_Ex2_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();    
            ex2.ShowDialog();
        }
    }
}
