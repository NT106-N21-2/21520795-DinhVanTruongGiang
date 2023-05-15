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

        private void btn_Ex3_Click(object sender, EventArgs e)
        {
            Ex3 ex3 = new Ex3();
            ex3.ShowDialog();
        }

        private void btn_Ex4_Click(object sender, EventArgs e)
        {
            Ex4 ex4 = new Ex4();
            ex4.ShowDialog();
        }
    }
}