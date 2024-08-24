using Domen;
using System;
using System.Collections.Generic;
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

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public object SelectValues => throw new NotImplementedException();

        public string WhereCondition => throw new NotImplementedException();

        public string GetUpdateValues => throw new NotImplementedException();

        public string GeneralCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
