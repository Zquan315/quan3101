using Lab1;

namespace Lab1_Bai1 
{
    public partial class flab : Form
    {
        public flab()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab1 f1 = new flab1();
            f1.ShowDialog();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab2 f2 = new flab2();
            f2.ShowDialog();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab3 f3 = new flab3();
            f3.ShowDialog();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab4 f4 = new flab4();
            f4.ShowDialog();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab5 f5 = new flab5();
            f5.ShowDialog();
        }
    }
}
