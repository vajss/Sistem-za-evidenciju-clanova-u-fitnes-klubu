using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FitnesStudioClientApp.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;

        private Communication()
        {

        }
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            client = new CommunicationClient(socket);

            Debug.WriteLine(">>>>>>>> JEL DODJE DOVDE");
        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        internal Trener Login(Trener trener)
        {
            Request request = new Request
            {
                Operation = Operation.Login,
                RequestObject = trener
            };
            client.SendRequest(request);
            return (Trener)client.GetResponseResult();
        }

        internal Trener Register(Trener trener)
        {
            Request request = new Request
            {
                Operation = Operation.Register,
                RequestObject = trener
            };
            client.SendRequest(request);
            return (Trener)client.GetResponseResult();
        }
    }
}
