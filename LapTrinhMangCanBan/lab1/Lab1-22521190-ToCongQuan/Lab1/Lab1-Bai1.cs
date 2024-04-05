namespace Lab1
{
    public partial class flab1 : Form
    {
        public flab1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsum_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (!int.TryParse(n1.Text, out num) && !int.TryParse(n2.Text, out num))
            {
                MessageBox.Show("Vui lòng nhập hai số là số nguyên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(n1.Text, out num))
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất là số nguyên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(n2.Text, out num))
            {
                MessageBox.Show("Vui lòng nhập số thứ hai là số nguyên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int kqua = Convert.ToInt32(n1.Text) + Convert.ToInt32(n2.Text);
                kq.Text = kqua.ToString();
            }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            n1.Text = n2.Text = kq.Text = "";
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
