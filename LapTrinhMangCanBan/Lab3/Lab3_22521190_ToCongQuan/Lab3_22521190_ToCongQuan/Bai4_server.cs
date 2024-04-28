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
using System.Xml.Linq;

namespace Lab3_22521190_ToCongQuan
{
    public partial class Bai4_server : Form
    {
        private delegate void SafeCallDelegate(string text);
        
        public Bai4_server()
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
        int flag = 0;
        private List<Thread> clientThreads = new List<Thread>();
        private List<NetworkStream> clientStreams = new List<NetworkStream>();
        NetworkStream clientStream;
        public void StartUnsafeThread()
        {
            try
            {
                Socket listenerSocket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                );
                IPEndPoint ipE = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipE);
                listenerSocket.Listen(-1);

                while (true)
                {
                    Socket clientSocket = listenerSocket.Accept(); 

                    if (clientSocket != null)
                    {
                        lvMess.Items.Add(new ListViewItem("New client connected from: " + clientSocket.RemoteEndPoint.ToString() + "\n"));
                        clientStream = new NetworkStream(clientSocket);
                        clientStreams.Add(clientStream);
                        Thread clientThread = new Thread(() => HandleClient(clientSocket)); 
                        clientThreads.Add(clientThread);
                        flag++;
                        clientThread.IsBackground = true;
                        clientThread.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in server thread: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void HandleClient(Socket clientSocket)
        {
            try
            {
                while (clientSocket.Connected)
                {
                    int ByteReceive = 0;
                    byte[] rec = new byte[1];
                    string mess = "";
                    do
                    {
                        ByteReceive = clientSocket.Receive(rec);
                        mess += Encoding.UTF8.GetString(rec);
                    } while (mess[mess.Length - 1] != '\n');

                    

                    if (mess == "#!)!@))$\n" || mess == "@@%@!!()\n" || mess == "#!!%%\n")
                    {
                        lvMess.Items.Add(new ListViewItem("A Client is disconnected!\n"));
                        flag--;
                    }
                    else
                    {
                        lvMess.Items.Add(new ListViewItem(mess));
                        byte[] data = Encoding.UTF8.GetBytes(mess);
                        List<NetworkStream> connectedStreams = new List<NetworkStream>();
                        foreach (NetworkStream stream in clientStreams)
                        {
                            if (stream.CanWrite)
                            {
                                connectedStreams.Add(stream);
                            }
                        }

                        foreach (NetworkStream stream in connectedStreams)
                        {
                            stream.Write(data, 0, data.Length);
                            stream.Flush();
                        }

                    }    
                        
                    if (flag == 0)
                    {
                        lvMess.Items.Add(new ListViewItem("All Clients are disconnected!\n"));
                        
                        break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
               
               //MessageBox.Show("Error handling client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clientSocket.Close();
                clientStreams.Remove(clientStream);
            }
        }
    }
}
