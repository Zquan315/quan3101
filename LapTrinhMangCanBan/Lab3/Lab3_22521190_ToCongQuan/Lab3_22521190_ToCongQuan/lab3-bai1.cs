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
    public partial class flab1 : Form
    {
        public flab1()
        {
            InitializeComponent();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            Thread st = new Thread(hienthiBai1);
            st.IsBackground = true;
            st.Start();
            UDP_Client_bai1 uDP_Client_Bai1 = new UDP_Client_bai1();
            uDP_Client_Bai1.Show();
        }
        public void hienthiBai1()
        {
            flab1 f1 = new flab1();
            f1.Show();
        }

        private void btServer_Click(object sender, EventArgs e)
        {
            Thread st = new Thread(hienthiBai1);
            st.IsBackground = true;
            st.Start();
            UDP_Server_bai1 uDP_ = new UDP_Server_bai1();
            uDP_.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.Show();
        }
    }
}
