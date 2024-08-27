
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

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
        public string WhereCondition => "";
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
                result.Add(new Clanstvo
                {
                    Grupa = new Grupa
                    {
                        Id = (int)reader[1],
                    },
                    Clan = new Clan
                    {
                        Id = (int)reader[6],
                        ClanId = (int)reader[2],
                        Ime = (string)reader[8],
                        Prezime = (string)reader[9],
                        DatumRodjenja = Convert.ToDateTime(reader[10]),
                        Zanimanje = (string)reader[11],
                        Telefon = (string)reader[12],
                    },
                    DatumUclanjenja = Convert.ToDateTime(reader[3]),
                    NeizmirenaDugovanja = (int)reader[4],
                    DatumPoslednjegPlacanja = Convert.ToDateTime(reader[5])

                });
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Clanstvo c)
            {
                return c.Clan?.ClanId == Clan?.ClanId && c.Grupa?.Id == Grupa?.Id;
            }
            return false;
        }
    }
}
