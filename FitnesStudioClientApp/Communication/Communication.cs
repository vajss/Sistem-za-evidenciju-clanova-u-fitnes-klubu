using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;

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
        }

        public void Disconnect()
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

        internal Trener LogOut(Trener t)
        {
            Request request = new Request
            {
                Operation = Operation.LogOut,
                RequestObject = t
            };
            client.SendRequest(request);
            return t;
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

        internal Clan DodajClana(Clan clan)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajClana,
                RequestObject = clan
            };
            client.SendRequest(request);
            return (Clan)client.GetResponseResult();
        }

        internal Clan IzmeniClana(Clan clan)
        {
            Request request = new Request
            {
                Operation = Operation.IzmeniClana,
                RequestObject = clan
            };
            client.SendRequest(request);
            return (Clan)client.GetResponseResult();
        }

        internal List<Clan> VratiSveClanove()
        {
            Request request = new Request
            {
                Operation = Operation.VratiSveClanove,
            };
            client.SendRequest(request);
            return (List<Clan>)client.GetResponseResult();
        }

        internal List<TreningProgram> VratiTrerningPrograme()
        {
            Request request = new Request
            {
                Operation = Operation.VratiTreningPrograme,
            };
            client.SendRequest(request);
            return (List<TreningProgram>)client.GetResponseResult();
        }

        internal Grupa SacuvajGrupu(Grupa grupa)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajGrupu,
                RequestObject = grupa
            };
            client.SendRequest(request);
            return (Grupa)client.GetResponseResult();
        }

        internal List<Clan> PretraziClanove(Clan clan)
        {
            Request request = new Request
            {
                Operation = Operation.NadjiClanove,
                RequestObject = clan
            };
            client.SendRequest(request);
            return (List<Clan>)client.GetResponseResult();
        }

        internal List<Grupa> VratiSveGrupe()
        {
            Request request = new Request
            {
                Operation = Operation.VratiSveGrupe
            };
            client.SendRequest(request);
            return (List<Grupa>)client.GetResponseResult();
        }

        internal List<Grupa> PretraziGrupe(Grupa grupa)
        {
            Request request = new Request
            {
                Operation = Operation.NadjiGrupe,
                RequestObject = grupa
            };
            client.SendRequest(request);
            return (List<Grupa>)client.GetResponseResult();
        }

        internal Termin DodajTermin(Termin termin)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajTermin,
                RequestObject = termin
            };
            client.SendRequest(request);
            return (Termin)client.GetResponseResult();
        }

        internal List<Termin> PretraziTermine(Termin termin)
        {
            Request request = new Request
            {
                Operation = Operation.NadjiTermine,
                RequestObject = termin
            };
            client.SendRequest(request);
            return (List<Termin>)client.GetResponseResult();
        }

        internal Grupa IzmeniGrupu(Grupa g)
        {
            throw new NotImplementedException();
        }
    }
}
