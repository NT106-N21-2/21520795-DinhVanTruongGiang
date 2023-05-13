namespace Lab4
{
    public partial class Lab4_MainForm : Form
    {
        public Lab4_MainForm()
        {
            InitializeComponent();
        }

        private void btn_Ex2_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.ShowDialog();
        }

        private void btn_Ex5_Click(object sender, EventArgs e)
        {
            Ex5 ex5 = new Ex5();
            ex5.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}