using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FitnesStudioClientApp.Communication
{
    public class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;
        public CommunicationClient(Socket socket)
        {
            receiver = new Receiver(socket);
            sender = new Sender(socket);
        }

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException ex)
            {
                throw new System.Runtime.Remoting.ServerException(ex.Message);
            }
            catch (SocketException ex)
            {

                throw new System.Runtime.Remoting.ServerException(ex.Message);
            }
        }
        public object GetResponseResult()
        {
            Response response = (Response)receiver.Receive();
            Debug.WriteLine(">>>> GetResponseResult error");
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else
            {
                // throw new SystemOperationException(response.Error); // TODO create your own exceptions

                throw new Exception(response.Error);
            }
        }
    }
}
