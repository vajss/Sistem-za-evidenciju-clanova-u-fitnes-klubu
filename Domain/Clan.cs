using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient; 

namespace Domain
{
    [Serializable]
    public class Clan : IEntity
    {
        public int Id { get; set; }

        public int ClanId { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public string Zanimanje { get; set; }

        public string Telefon { get; set; }

        public string TableName => "Clan";

        public string InsertValues => $"{ClanId}, '{Ime}', '{Prezime}', '{DatumRodjenja}', '{Zanimanje}', '{Telefon}'";

        public string IdName => "Id";
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
                result.Add(new Clan
                {
                    Id = (int)reader[0],
                    ClanId= (int)reader[1],
                    Ime = (string)reader[2],
                    Prezime = (string)reader[3],
                    DatumRodjenja = Convert.ToDateTime(reader[4]),
                    Zanimanje = (string)reader[5],
                    Telefon = (string)reader[6]
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
