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
    }
}
