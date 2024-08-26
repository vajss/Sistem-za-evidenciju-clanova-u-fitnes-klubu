using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Termin : IEntity
    {

        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Trajanje { get; set; }
        public Grupa Grupa { get; set; }

        [Browsable(false)]
        public string TableName => "Termin";
        [Browsable(false)]
        public string InsertValues => $"'{Datum}', '{Trajanje}', {Grupa.Id}";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "ON (TE.GrupaId = G.Id)";
        [Browsable(false)]
        public string JoinTable => "JOIN Grupa G";
        [Browsable(false)]
        public string TableAlias => "TE";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"TE.Id={Id}";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => $"{GCondition}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Clan
                {
                    Id = (int)reader[0],
                    ClanId = (int)reader[1],
                    Ime = (string)reader[2],
                    Prezime = (string)reader[3],
                    DatumRodjenja = Convert.ToDateTime(reader[4]),
                    Zanimanje = (string)reader[5],
                    Telefon = (string)reader[6]
                });
            }
            return result;
        }
    }
}
