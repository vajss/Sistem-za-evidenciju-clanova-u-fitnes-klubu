using Domain;
using Storage;
using Storage.Implementation;
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
            PrijaviTreneraSO so = new PrijaviTreneraSO();
            so.ExecuteTemplate(trener);
            return so.Result;
        }
/*
        //Grupa za treniranje

    }
}
