using Common;
using Controller;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerApp
{
    public class ClientHandler
    {
        private Socket clientSocket;
        private readonly BindingList<Trener> treneri;
        private Trener logedInTrener;

        //  private Receiver receiver;
        //  private Sender sender;
        /*private readonly BindingList<Trener> treneri;
        private Trener ulogovanTrener;
*/
        // public EventHandler OdjavljenKlijent;

        internal void Stop()
        {
            clientSocket.Close();
        }

        public ClientHandler(Socket clientSocket, BindingList<Trener> treneri)
        {
            this.clientSocket = clientSocket;
            this.treneri = treneri;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(clientSocket);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response
                        {
                            IsSuccessful = false,
                            Error = ex.Message
                        };
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                treneri.Remove(logedInTrener);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                treneri.Remove(logedInTrener);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
          
            switch (request.Operation)
            {
                case Operation.Login:
                    Trener trener = Controller.Controller.Instance.Login((Trener)request.RequestObject);
                    if (trener != null)
                    {
                        foreach (Trener t in treneri)
                        {
                            if (t.KorisnickoIme == trener.KorisnickoIme && t.Sifra == trener.Sifra)
                            {
                                trener.VecUlogovan = true;
                                break;
                                
                            }
                        }
                        if (!trener.VecUlogovan)
                        {
                            logedInTrener = trener;
                            treneri.Add(logedInTrener);
                        }
                    }

                    response.Result = trener;
                    break;
                case Operation.LogOut:
                    Trener logOutTrener = (Trener)request.RequestObject;
                    if (logOutTrener != null)
                    {
                        treneri.Remove(logedInTrener);
                    }
                    break;
                case Operation.Register:
                    response.Result = Controller.Controller.Instance.Register((Trener)request.RequestObject);
                    break;
                case Operation.SacuvajClana:
                    Controller.Controller.Instance.SacuvajClana((Clan)request.RequestObject);
                    break;
                case Operation.VratiSveClanove:
                    response.Result = Controller.Controller.Instance.VratiSveClanove((Clan)request.RequestObject);
                    break;
                case Operation.VratiTreningPrograme:
                    response.Result = Controller.Controller.Instance.VratiTreningPrograme((TreningProgram)request.RequestObject);
                    break;
                case Operation.SacuvajGrupu:
                    Controller.Controller.Instance.SacuvajGrupu((Grupa)request.RequestObject);
                    break;
                case Operation.NadjiClanove:
                    response.Result = Controller.Controller.Instance.PretraziClanove((Clan)request.RequestObject);
                    break;
                case Operation.IzmeniClana:
                    Controller.Controller.Instance.IzmeniClana((Clan)request.RequestObject);
                    break;
                case Operation.VratiSveGrupe:
                    response.Result = Controller.Controller.Instance.VratiSveGrupe((Grupa)request.RequestObject);
                    break;
                case Operation.NadjiGrupe:
                    response.Result = Controller.Controller.Instance.PretraziGrupe((Grupa)request.RequestObject);
                    break;
                default:
                    break;
            }

            return response;
        }
    }
}
