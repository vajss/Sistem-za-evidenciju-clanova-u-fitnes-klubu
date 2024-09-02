
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Domain
{
    [Serializable]
    public class Clanstvo : IEntity
    {
        public Clan Clan { get; set; }
        public DateTime DatumUclanjenja { get; set; }
        public DateTime DatumPoslednjegPlacanja { get; set; }
        public int NeizmirenaDugovanja { get; set; }
        public Grupa Grupa { get; set; }
        [Browsable(false)]
        public string TableName => "Clanstvo";
        [Browsable(false)]
        public string InsertValues => $"{Grupa.Id}, {Clan.Id}, '{DatumUclanjenja}', '{NeizmirenaDugovanja}' ,'{DatumPoslednjegPlacanja}' ";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "ON (CL.ClanId= C.Id)";
        [Browsable(false)]
        public string JoinTable => "JOIN Clan C";
        [Browsable(false)]
        public string TableAlias => "CL";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => $"ClanId = {Clan.Id} AND GrupaId = {Grupa.Id}";
        [Browsable(false)]
        public string GetUpdateValues => $"DatumUclanjenja='{DatumUclanjenja:d.M.yyyy. HH:mm:ss}', DatumPoslednjegPlacanja='{DatumPoslednjegPlacanja:d.M.yyyy. HH:mm:ss}', NeizmirenaDugovanja={NeizmirenaDugovanja}";
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => $"{GCondition}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Clanstvo
                {
                    Grupa = new Grupa
                    {
                        Id = (int)reader[1],
                    },
                    Clan = new Clan
                    {
                        Id = (int)reader[6],
                        ClanId = (int)reader[7],
                        Ime = (string)reader[8],
                        Prezime = (string)reader[9],
                        //DatumRodjenja = Convert.ToDateTime(reader[10]),
                        DatumRodjenja = DateTime.ParseExact(reader[10].ToString(), "d.M.yyyy. HH:mm:s", CultureInfo.InvariantCulture),
                        Zanimanje = (string)reader[11],
                        Telefon = (string)reader[12],
                    },
                    //DatumUclanjenja = Convert.ToDateTime(reader[3]),
                    DatumUclanjenja = DateTime.ParseExact(reader[3].ToString(), "d.M.yyyy. HH:mm:ss", CultureInfo.InvariantCulture),
                    NeizmirenaDugovanja = (int)reader[4],
                    //DatumPoslednjegPlacanja = Convert.ToDateTime(reader[5])
                    DatumPoslednjegPlacanja = DateTime.ParseExact(reader[5].ToString(), "d.M.yyyy. HH:mm:ss", CultureInfo.InvariantCulture),
                });
            }
            return result;
        }

        public override bool Equals(object clanstvo)
        {
            if (clanstvo is Clanstvo c)
            {
                return c.Clan?.ClanId == Clan?.ClanId;
            }
            return false;
        }
    }
}
