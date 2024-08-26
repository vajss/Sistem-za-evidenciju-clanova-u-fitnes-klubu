using Domain;
using Storage;
using Storage.Implementation;
using System.Collections.Generic;
using SystemOperations.ClanSO;
using SystemOperations.GrupaSO;
using SystemOperations.TerminSO;
using SystemOperations.TrenerSO;
using SystemOperations.TreningProgramSO;


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

        // CLAN
        public void SacuvajClana(Clan clan)
        {
            SacuvajClanaSO so = new SacuvajClanaSO();
            so.ExecuteTemplate(clan);
        }

        public void IzmeniClana(Clan clan)
        {
            IzmeniClanaSO so = new IzmeniClanaSO();
            so.ExecuteTemplate(clan);
        }

        public List<Clan> VratiSveClanove(Clan clan)
        {
            VratiSveClanoveSO so = new VratiSveClanoveSO();
            so.ExecuteTemplate(clan);
            return so.Result;
        }

        public List<Clan> PretraziClanove(Clan clan)
        {
            PretragaClanovaSO so = new PretragaClanovaSO();
            so.ExecuteTemplate(clan);
            return so.Result;
        }

        // TRENING PROGRAM
        public List<TreningProgram> VratiTreningPrograme(TreningProgram treningProgram)
        {
            VratiTreningProgrameSO so = new VratiTreningProgrameSO();
            so.ExecuteTemplate(treningProgram);
            return so.Result;
        }

        // GRUPA
        public void SacuvajGrupu(Grupa grupa)
        {
            SacuvajGrupuSO so = new SacuvajGrupuSO();
            so.ExecuteTemplate(grupa);
        }

        public List<Grupa> VratiSveGrupe(Grupa grupa)
        {
            VratiSveGrupeSO so = new VratiSveGrupeSO();
            so.ExecuteTemplate(grupa);
            return so.Result;
        }

        public List<Grupa> PretraziGrupe(Grupa grupa)
        {
            PretraziGrupeSO so = new PretraziGrupeSO();
            so.ExecuteTemplate(grupa);
            return so.Result;
        }

        // TERMIN
        public void SacuvajTermin(Termin termin)
        {
            SacuvajTerminSO so = new SacuvajTerminSO();
            so.ExecuteTemplate(termin);
        }
    }
}
