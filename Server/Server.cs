using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ServerApp
{
    public class Server
    {
        private readonly Socket serverSocket;
        private readonly List<ClientHandler> clients = new List<ClientHandler>();
        private BindingList<Trener> treneri = new BindingList<Trener>();

        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
                serverSocket.Bind(endpoint);
                Debug.WriteLine(">>>> Serrver is running...");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>> Start server error: " + ex.Message);
                return false;
            }
        }

        public void Listen()
        {
            serverSocket.Listen(100);
            try
            {
                while (true)
                {
                    Debug.WriteLine(">>> Server is listening... ");
                    Socket clientSocket = serverSocket.Accept();
                    ClientHandler client = new ClientHandler(clientSocket, treneri);
                    clients.Add(client);
                    Thread clientHandlerThread = new Thread(client.StartHandler);
                    clientHandlerThread.IsBackground = false;
                    clientHandlerThread.Start();
                }
            }
            catch (SocketException)
            {
                Debug.WriteLine(">>> Server stoped... ");
            }
        }

        public void Stop()
        {
            serverSocket.Close();
            foreach (ClientHandler c in clients)
            {
                c.Stop();
            }
            clients.Clear();
        }
    }
}
