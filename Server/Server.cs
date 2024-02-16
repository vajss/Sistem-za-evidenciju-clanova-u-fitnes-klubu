using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {
        private readonly Socket socket;
        private readonly List<ClientHandler> clients = new List<ClientHandler>();

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endpoint);
                socket.Listen(100);
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
            try
            {
                while (true)
                {
                    Debug.WriteLine(">>> Server is listening... ");
                    Socket klijentskiSocket = socket.Accept();
                    ClientHandler client = new ClientHandler(klijentskiSocket);
                    clients.Add(client);
                    client.OdjavljenKlijent += Handler_OdjavljenKlijent;
                    Thread clientHandlerThread = new Thread(client.HandleRequests);
                    clientHandlerThread.IsBackground = false;
                    clientHandlerThread.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>> Server listening interupted: " + ex.Message);
            }
        }

        public void Handler_OdjavljenKlijent(object sender, EventArgs args)
        {
            clients.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket.Close();
            foreach (ClientHandler handler in clients.ToList())
            {
                handler.CloseSocket();
            }
        }
    }
}
