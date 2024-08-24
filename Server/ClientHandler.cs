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

        private bool kraj = false;

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
                        Debug.WriteLine(">>>>>>StartHandler: ", ex.Message);
                        // System.Windows.Forms.MessageBox.Show(ex.Message);
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                        Debug.WriteLine("response" + response.ToString());
                        Debug.WriteLine(">>>>>> PRE IZLASKA IZ CATCHA)");

                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan // TODO
                treneri.Remove(logedInTrener);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan // TODO
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
                case Operation.Register:
                    response.Result = Controller.Controller.Instance.Register((Trener)request.RequestObject);
                    break;
                case Operation.SacuvajClana:
                    Controller.Controller.Instance.SacuvajClana((Clan)request.RequestObject);
                    break;
                case Operation.VratiClanove:
                    response.Result = Controller.Controller.Instance.VratiClanove((Clan)request.RequestObject);
                    break;

                /*      case Operation.VratiSale:
                        List<SalaZaTrening> rez = (List<SalaZaTrening>)Controller.Controller.Instance.VratiSveSale(new SalaZaTrening());
                        response.Result = rez;
                        break;
                    case Operation.SacuvajGrupu:
                        Controller.Controller.Instance.SacuvajGrupu((GrupaZaTreniranje)request.RequestObject);
                        break;
                    case Operation.VratiGrupe:
                        response.Result = (List<GrupaZaTreniranje>)Controller.Controller.Instance.VratiSveGrupe(new GrupaZaTreniranje());
                        break;
                    case Operation.SacuvajClana:
                        Controller.Controller.Instance.SacuvajClana((ClanKluba)request.RequestObject);
                        break;
                    case Operation.PretraziClana:
                        response.Result = (List<ClanKluba>)Controller.Controller.Instance.PretraziClana((ClanKluba)request.RequestObject);
                        break;
                    case Operation.EvidentirajPlacanjeClanarine:
                        Controller.Controller.Instance.EvidentirajPlacanjeClanarine((Clanarina)request.RequestObject);
                        break;
                    case Operation.PretraziTreninge:
                        response.Result = (List<Trening>)Controller.Controller.Instance.PretraziTreninge((Trening)request.RequestObject);
                        break;
                    case Operation.SacuvajPrisustva:
                        Controller.Controller.Instance.SacuvajPrisustva(new List<Prisustvo>((BindingList<Prisustvo>)request.RequestObject));
                        break;
                    case Operation.SacuvajIzmeneClana:
                        Controller.Controller.Instance.SacuvajIzmeneClana((ClanKluba)request.RequestObject);
                        break;
                    case Operation.UcitajTrening:
                        response.Result = (Trening)Controller.Controller.Instance.UcitajTrening((Trening)request.RequestObject);
                        break;
                    case Operation.SacuvajIzmeneTreninga:
                        Controller.Controller.Instance.SacuvajIzmeneTreninga((Trening)request.RequestObject);
                        break;
                    case Operation.UcitajClanaKluba:
                        response.Result = (ClanKluba)Controller.Controller.Instance.UcitajClanaaKluba((ClanKluba)request.RequestObject);
                        break;
                    case Operation.VratiPrisustva:
                        response.Result = Controller.Controller.Instance.VratiPrisustva((Prisustvo)request.RequestObject);
                        break;
                    case Operation.VratiClanarine:
                        response.Result = Controller.Controller.Instance.UcitajClanarinu((Clanarina)request.RequestObject);
                        break;
                    case Operation.PretraziGrupe:
                        response.Result = Controller.Controller.Instance.PretraziGrupu((GrupaZaTreniranje)request.RequestObject);
                        break;
                    case Operation.UcitajGrupu:
                        response.Result = Controller.Controller.Instance.UcitajGrupu((GrupaZaTreniranje)request.RequestObject);
                        break;*/
                default:
                    break;
            }

            return response;
        }
    }
}
