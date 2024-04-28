using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_22521190_ToCongQuan
{
    public partial class flab : Form
    {
        public flab()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab1 f = new flab1();
            f.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            flab3 flab3 = new flab3();
            this.Hide();
            flab3.Show();   
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab2 f = new flab2();
            f.Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab4 flab4 = new flab4();
            flab4.Show();
        }
    }
}
