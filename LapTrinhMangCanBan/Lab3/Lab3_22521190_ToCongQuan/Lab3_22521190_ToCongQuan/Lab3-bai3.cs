using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_22521190_ToCongQuan
{
    public partial class flab3 : Form
    {
        public flab3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.Show();
        }

        private void bt_SV_Click(object sender, EventArgs e)
        {

            Thread thr = new Thread(bai3);
            thr.IsBackground = true;
            thr.Start();
            TCP_Server tCP_Server = new TCP_Server();
            tCP_Server.Show();

        }
        public void bai3()
        {
            flab3 flab3 = new flab3();
            flab3.Show();
        }

        private void bt_CL_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(bai3);
            th.IsBackground = true;
            th.Start();
            TCP_Client cl = new TCP_Client();
            cl.Show();
        }
         }
}
