using Domain;
using Storage;
using Storage.Implementation;
using System;
using System.Diagnostics;
using SystemOperations.TrenerSO;


namespace Controller
{
    public class Controller
    {
        private IGenericRepository Repository;
        public Trener Trener { get; set; }
        private static Controller instance;

        private static object _lock = new object();

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
            Repository = new GenericRepository();
        }




        //TRENER
        public Trener Login(Trener trener)
        {
            LogInTreneraSO so = new LogInTreneraSO();
            so.ExecuteTemplate(trener);
            return so.Result;
        }

        public Trener Register(Trener trener)
        {
            RegisterTreneraSO so = new RegisterTreneraSO();
            so.ExecuteTemplate(trener);
            return trener;
        }

        public void SacuvajClana(Clan clan)
        {
            SacuvajClanaSO so = new SacuvajClanaSO();
            so.ExecuteTemplate(clan);
        }

        /*
       //Grupa za treniranje

       public object VratiSveSale(SalaZaTrening salaZaTrening)
       {
           VratiSveSaleSO so = new VratiSveSaleSO();
           so.ExecuteTemplate(salaZaTrening);
           return so.Result;
       }

       public void SacuvajGrupu(GrupaZaTreniranje grupa)
       {
           SacuvajNovuGrupuSO so = new SacuvajNovuGrupuSO();
           so.ExecuteTemplate(grupa);

       }

       public List<GrupaZaTreniranje> VratiSveGrupe(GrupaZaTreniranje grupaZaTreniranje)
       {
           VratiSveGrupeSO so = new VratiSveGrupeSO();
           so.ExecuteTemplate(grupaZaTreniranje);
           return so.Result;
       }

       public void SacuvajClana(ClanKluba clanKluba)
       {
           SacuvajNovogClanaSO so = new SacuvajNovogClanaSO();
           so.ExecuteTemplate(clanKluba);
       }

       public List<ClanKluba> PretraziClana(ClanKluba clanKluba)
       {
           PretraziClanaSO so = new PretraziClanaSO();
           so.ExecuteTemplate(clanKluba);
           return so.Result;
       }

       public void EvidentirajPlacanjeClanarine(Clanarina clanarina)
       {
           EvidentirajPlacanjeClanarineSO so = new EvidentirajPlacanjeClanarineSO();
           so.ExecuteTemplate(clanarina);
       }

       public List<Trening> PretraziTreninge(Trening trening)
       {
           PretraziTreningeSO so = new PretraziTreningeSO();
           so.ExecuteTemplate(trening);
           return so.Result;
       }

       public void SacuvajPrisustva(List<Prisustvo> listaPrisustva)
       {
           SacuvajPrisustvaSO so = new SacuvajPrisustvaSO
           {
               listaPrisustva = listaPrisustva
           };
           so.ExecuteTemplate(new Prisustvo());
       }

       public void SacuvajIzmeneClana(ClanKluba requestObject)
       {
           SacuvajIzmeneClanaSO so = new SacuvajIzmeneClanaSO();
           so.ExecuteTemplate(requestObject);
       }

       public Trening UcitajTrening(Trening requestObject)
       {
           UcitajTreningSO so = new UcitajTreningSO();
           so.ExecuteTemplate(requestObject);
           return so.Result;
       }

       public void SacuvajIzmeneTreninga(Trening requestObject)
       {
           SacuvajIzmeneTreningaSO so = new SacuvajIzmeneTreningaSO();
           so.ExecuteTemplate(requestObject);
       }

       public ClanKluba UcitajClanaaKluba(ClanKluba requestObject)
       {
           UcitajClanaKlubaSO so = new UcitajClanaKlubaSO();
           so.ExecuteTemplate(requestObject);
           return so.Result;
       }

       public object VratiPrisustva(Prisustvo requestObject)
       {
           VratiPrisustvaSO so = new VratiPrisustvaSO();
           so.ExecuteTemplate(requestObject);
           return so.Result;
       }

       public List<Clanarina> UcitajClanarinu(Clanarina requestObject)
       {
           VratiClanarineSO so = new VratiClanarineSO();
           so.ExecuteTemplate(requestObject);
           return so.Result;
       }

       public List<GrupaZaTreniranje> PretraziGrupu(GrupaZaTreniranje requestObject)
       {
           PretraziGrupeSO so = new PretraziGrupeSO();
           so.ExecuteTemplate(requestObject);
           return so.Result;
       }

       public GrupaZaTreniranje UcitajGrupu(GrupaZaTreniranje requestObject)
       {
           UcitajGrupuSO so = new UcitajGrupuSO();
           so.ExecuteTemplate(requestObject);
           return so.Result;
       }*/
    }
}
