using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Lab3_22521190_ToCongQuan
{
   
    public partial class TCP_Client : Form
    {
        
        public TCP_Client()
        {
            InitializeComponent();
        }

        TcpClient tcp_Client ;
        NetworkStream ns;
        bool isConnected = false;
        
        private void btSend_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                MessageBox.Show("Please connect with server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Byte[] data= System.Text.Encoding.UTF8.GetBytes(rtbMess.Text + '\n');
            ns.Write(data, 0, data.Length);
            rtbMess.Text = "";
             
        }
        
        private void btConnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                tcp_Client = new TcpClient();
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                IPEndPoint iPEndPoint = new IPEndPoint(ip, 8080);
                
                tcp_Client.Connect(iPEndPoint);
                ns = tcp_Client.GetStream();
                isConnected = true;
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
                    Byte[] data = System.Text.Encoding.UTF8.GetBytes("00110001000000010010000000000100\n");
                    ns.Write(data, 0, data.Length);
                    ns.Close();
                    ns = null;
                    tcp_Client.Close();
                    tcp_Client=null;
                    isConnected = false;
                   
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disconnecting from server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_Close(object sender, FormClosedEventArgs e)
        {     
            if(isConnected == true)
            {
                Byte[] data = System.Text.Encoding.UTF8.GetBytes("00110001000000010010000000000100\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                ns = null;
                tcp_Client.Close();
                tcp_Client = null;
                isConnected = false;
            }    
                
        }
    }


}
