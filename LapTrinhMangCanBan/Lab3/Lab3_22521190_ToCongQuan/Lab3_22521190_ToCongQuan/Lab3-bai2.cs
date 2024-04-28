using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3_22521190_ToCongQuan
{
    public partial class flab2 : Form
    {
       
        Socket listenerSocket;
        public flab2()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread serverThread = new Thread(StartUnsafeThread);
                serverThread.IsBackground = true;
                serverThread.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting server... " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        public void StartUnsafeThread()
        {
            
            
            try
            {
                while (true)
                {
                    int ByteReceive = 0;
                    byte[] rec = new byte[1];
                    Socket clientSocket;

                    Socket listenerSocket = new Socket(
                        AddressFamily.InterNetwork,
                        SocketType.Stream,
                        ProtocolType.Tcp
                    );
                    IPEndPoint ipE = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                    listenerSocket.Bind(ipE);
                    listenerSocket.Listen(-1);

                    clientSocket = listenerSocket.Accept();
                    
                    if (clientSocket != null)
                    {
                        lvReceive.Items.Add(new ListViewItem("Telnet is running on 127.0.0.1:8080"));
                        
                    }    
                        
                    else
                    {
                        MessageBox.Show("Don't acccept to connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    while (clientSocket.Connected)
                    {
                        if (!clientSocket.Connected)//dieu kien dung
                        {
                            lvReceive.Items.Add(new ListViewItem("Telnet is disconnected!\n"));
                            break;
                        }
                        string mess = "";
                       do
                       {
                          ByteReceive = clientSocket.Receive(rec);
                          mess += Encoding.UTF8.GetString(rec);

                       }while (mess[mess.Length - 1] != '\n');
                       
                       lvReceive.Items.Add(new ListViewItem(mess));
                    }
                    
                    listenerSocket.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in server thread: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.Show();
        }

        private void flab2_Load(object sender, EventArgs e)
        {

        }

        private void bai2_close(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
