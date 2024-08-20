using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Trener : IEntity
    {
        public int Id { get; set; }

        public string KorisnickoIme { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Sifra { get; set; }

        public bool VecUlogovan { get; set; }


        [Browsable(false)]
        public string TableName => "Trener";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdName => "TrenerID";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "*";

        public string WhereCondition => throw new NotImplementedException();

        public string GetUpdateValues => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Trener
                {
                    Id = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    KorisnickoIme = (string)reader[3],
                    Sifra = (string)reader[4]
                });
            }
            return result;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
