using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;

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

        [Browsable(false)]
        public string TableName => "Clan";
        [Browsable(false)]
        public string InsertValues => $"{ClanId}, '{Ime}', '{Prezime}', '{DatumRodjenja}', '{Zanimanje}', '{Telefon}'";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "C";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"Id={Id}";
        [Browsable(false)]
        public string GetUpdateValues => $"Ime='{Ime}', Prezime='{Prezime}', DatumRodjenja='{DatumRodjenja:d.M.yyyy. HH:mm:ss}', Zanimanje='{Zanimanje}', Telefon='{Telefon}'";
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
                    ClanId= (int)reader[1],
                    Ime = (string)reader[2],
                    Prezime = (string)reader[3],
                    //DatumRodjenja = Convert.ToDateTime(reader[4]),
                    DatumRodjenja = DateTime.ParseExact(reader[4].ToString(), "d.M.yyyy. HH:mm:ss", CultureInfo.InvariantCulture),
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

        public override bool Equals(object clan)
        {
            if (clan is Clan c)
            {
                return c.Id == Id;
            }
            return false;
        }
    }
}
