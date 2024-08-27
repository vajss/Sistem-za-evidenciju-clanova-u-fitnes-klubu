
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
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "CL";
        [Browsable(false)]
        public object SelectValues => "";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GCondition { get; set; }
        [Browsable(false)]
        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException("GetEntities not implemented in Clanstva.");
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
