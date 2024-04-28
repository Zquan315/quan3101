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
using System.Timers;

namespace Lab3_22521190_ToCongQuan
{
    public partial class TCP_Server : Form
    {
        private delegate void SafeCallDelegate(string text);
        public TCP_Server()
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
                        lvReceive.Items.Add(new ListViewItem("Hello quan315\n"));
                    else
                    {
                        MessageBox.Show("Don't acccept to connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    while (clientSocket.Connected)
                    {
                        string mess = "";
                        do
                        {
                            ByteReceive = clientSocket.Receive(rec);
                            mess += Encoding.UTF8.GetString(rec);

                        } while (mess[mess.Length - 1] != '\n');

                        if (mess == "00110001000000010010000000000100\n")
                        {
                            lvReceive.Items.Add(new ListViewItem("quan315 Disconnected!\n"));
                            break;
                        }
                        else
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
    }
}
