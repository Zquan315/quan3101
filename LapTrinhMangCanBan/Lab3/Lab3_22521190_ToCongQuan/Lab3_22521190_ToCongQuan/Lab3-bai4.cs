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
    public partial class flab4 : Form
    {
        public flab4()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.Show();
        }

        private void btServer_Click(object sender, EventArgs e)
        {
            Bai4_server sv = new Bai4_server();
            sv.Show();

            Thread th = new Thread(hienthibai4);
            th.IsBackground = true;
            th.Start();
        }

        void hienthibai4()
        {
            flab4 flab4 = new flab4();
            flab4.Show();
        }

        private void btCl1_Click(object sender, EventArgs e)
        {
            Client1 cl1 = new Client1();
            cl1.Show();

            Thread th = new Thread(hienthibai4);
            th.IsBackground = true;
            th.Start();
        }

        private void btCl2_Click(object sender, EventArgs e)
        {
            Client2 cl2 = new Client2();
            cl2.Show();

            Thread th = new Thread(hienthibai4);
            th.IsBackground = true;
            th.Start();
        }

        private void btCl3_Click(object sender, EventArgs e)
        {
            Client3 cl3 = new Client3();
            cl3.Show();

            Thread th = new Thread(hienthibai4);
            th.IsBackground = true;
            th.Start();
        }
    }
}
