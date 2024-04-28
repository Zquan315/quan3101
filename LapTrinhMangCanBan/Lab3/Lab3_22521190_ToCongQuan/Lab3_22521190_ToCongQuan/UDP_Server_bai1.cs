using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security;

namespace Lab3_22521190_ToCongQuan
{
    public partial class UDP_Server_bai1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        public UDP_Server_bai1()
        {
            InitializeComponent();
        }

        private void UDP_Server_bai1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thrUDP = new Thread(serverThread);
            thrUDP.Start();
        }
        public void serverThread()
        {
            
            UdpClient udpClient = new UdpClient(int.Parse(tbPort.Text));
            while (true) 
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, int.Parse(tbPort.Text));
                Byte[] reveiveBytes = udpClient.Receive(ref remoteIPEndPoint);
                string returnData = Encoding.UTF8.GetString(reveiveBytes);
                string mess = remoteIPEndPoint.ToString() + ": " + returnData.ToString() ;

                infoMessage(mess);
            }
        }

        public void infoMessage(string message) 
        {
            if(lvReceive.InvokeRequired)
            {
                var d = new SafeCallDelegate(infoMessage);
                lvReceive.Invoke(d, new object[] { message });

            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = message;
                lvReceive.Items.Add(item);
            }
        }

        private void btListen_Click(object sender, EventArgs e)
        {

        }
    }
}
