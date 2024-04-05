using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class flab : Form
    {
        public flab()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            this.Hide();    
            flab1 f1 = new flab1(); 
            f1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab2 f2 = new flab2();
            f2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab3 flab3 = new flab3();  
            flab3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab4  f4 = new flab4();
            f4.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab5 f = new flab5();
            f.Show();
        }
    }
}
