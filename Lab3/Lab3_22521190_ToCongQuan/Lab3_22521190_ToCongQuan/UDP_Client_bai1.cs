using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_22521190_ToCongQuan
{
    public partial class UDP_Client_bai1 : Form
    {
        public UDP_Client_bai1()
        {
            InitializeComponent();
        }
        

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            UDP_Server_bai1 u = new UDP_Server_bai1();
            u.Hide();
            flab1 f = new flab1();
            f.Show();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if(tbIP.Text != "127.0.0.1" )
            {
                MessageBox.Show("Vui lòng nhập IP: 127.0.0.1!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbPort.Text != "8080")
            {
                MessageBox.Show("Vui lòng nhập Port: 8080!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            UdpClient udpClient = new UdpClient();
            IPAddress ip = IPAddress.Parse(tbIP.Text);
            IPEndPoint cl = new IPEndPoint(ip, int.Parse(tbPort.Text));
            Byte[] sendBytes = Encoding.UTF8.GetBytes(rtbMess.Text);
            udpClient.Send(sendBytes, sendBytes.Length, cl);
            rtbMess.Text = "";
        }
    }
}
