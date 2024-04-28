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
    public partial class Client2 : Form
    {
        private delegate void SafeCallDelegate(string text);
        TcpClient tcp_Client;
        NetworkStream ns;
        bool isConnected = false;
        public Client2()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                MessageBox.Show("Please connect with server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(rtbMess.Text != "")
            {
                Byte[] data = System.Text.Encoding.UTF8.GetBytes(tbName.Text + ": " + rtbMess.Text + '\n');
                ns.Write(data, 0, data.Length);
                rtbMess.Text = "";
            }    
            
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected == false)
                {
                    tcp_Client = new TcpClient();
                    IPAddress ip = IPAddress.Parse("127.0.0.1");
                    IPEndPoint iPEndPoint = new IPEndPoint(ip, 8080);

                    tcp_Client.Connect(iPEndPoint);
                    ns = tcp_Client.GetStream();
                    isConnected = true;
                    Task.Run(() => ReceiveMessageFromServer());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected == true)
                {
                    Byte[] data = System.Text.Encoding.UTF8.GetBytes("@@%@!!()\n");
                    ns.Write(data, 0, data.Length);
                    ns.Close();
                    ns = null;
                    tcp_Client.Close();
                    tcp_Client = null;
                    isConnected = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disconnecting from server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cl2_close(object sender, FormClosedEventArgs e)
        {
            if (isConnected == true)
            {
                Byte[] data = System.Text.Encoding.UTF8.GetBytes("@@%@!!()\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                ns = null;
                tcp_Client.Close();
                tcp_Client = null;
                isConnected = false;
            }
        }
        private void ReceiveMessageFromServer()
        {
            Task.Run(() =>
            {
                try
                {
                    while (isConnected == true)
                    {


                        try
                        {
                            byte[] data = new byte[4096];
                            int bytesRead = ns.Read(data, 0, data.Length);

                            if (bytesRead > 0)
                            {
                                string message = Encoding.UTF8.GetString(data, 0, bytesRead);
                                AddMessageToListView(message);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error receiving message from server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        private void AddMessageToListView(string message)
        {
            if (lvMess.InvokeRequired)
            {
                var d = new SafeCallDelegate(AddMessageToListView);
                lvMess.Invoke(d, new object[] { message });

            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = message;
                lvMess.Items.Add(item);
            }
        }
    }
}
