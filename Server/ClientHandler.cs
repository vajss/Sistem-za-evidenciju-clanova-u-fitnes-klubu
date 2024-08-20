using Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private Receiver receiver;
        private Sender sender;

        public EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);

        }

        private bool kraj = false;
        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Request request = (Request)receiver.Receive();
                    Response response = CreateResponse(request);
                    sender.Send(response);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }


        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    /*case Operation.Login:
                        response.Result = Controller.Instance.Login((User)request.RequestObject);
                        if (response.Result == null)
                        {
                            response.IsSuccessful = false;
                            response.Message = "Korisnik ne postoji!";
                        }
                        break;
                    case Operation.GetAllProducts:
                        response.Result = Controller.Instance.GetAllProducts();
                        break;
                    case Operation.End:
                        kraj = true;
                        break;
                        */
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }
        private readonly object lockobject = new object();
        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
